import 'dart:convert';
import 'dart:io';
import 'package:ecinema_desktop/utils/utils.dart';
import 'package:flutter/material.dart';
import 'package:flutter/services.dart';
import 'package:file_picker/file_picker.dart';

class AddFilmModal extends StatefulWidget {
  final Function handleAdd;
  const AddFilmModal({
    super.key,
    required this.handleAdd,
  });

  @override
  State<AddFilmModal> createState() => _AddFilmModalState();
}

class _AddFilmModalState extends State<AddFilmModal> {
  GlobalKey<FormState> formKey = GlobalKey<FormState>();
  String? naziv;
  String? sadrzaj;
  String? vrijemeTrajanja;
  String? redatelj;
  String? godina;
  DateTime pocetakPrikazivanja = DateTime.now();
  bool slikaError = false;
  File? _selectedImage;

  @override
  void initState() {
    super.initState();
  }

  void selectImage() async {
    FilePickerResult? result =
        await FilePicker.platform.pickFiles(type: FileType.image);

    if (result != null) {
      setState(() {
        _selectedImage = File(result.files.single.path!);
        slikaError = false;
      });
    } else {
      // User canceled the picker
    }
  }

  Future<void> handleSelectDate(BuildContext context) async {
    final DateTime? picked = await showDatePicker(
      context: context,
      initialDate: pocetakPrikazivanja,
      firstDate: DateTime(2000),
      lastDate: DateTime(2100),
    );
    if (picked != null && picked != pocetakPrikazivanja) {
      setState(() {
        pocetakPrikazivanja = picked;
      });
    }
  }

  @override
  Widget build(BuildContext context) {
    return AlertDialog(
      title: const Text('Dodaj film'),
      content: SingleChildScrollView(
        child: Form(
            key: formKey,
            child: Row(
              children: [
                SizedBox(
                  width: 220,
                  child: Column(
                    children: [
                      TextFormField(
                        decoration: const InputDecoration(
                          labelText: 'Naziv',
                          hintText: 'Unesite naziv filma',
                        ),
                        onChanged: (value) {
                          naziv = value;
                        },
                        validator: (value) {
                          if (value == null || value.isEmpty) {
                            return 'Ovo polje je obavezno';
                          }
                          return null;
                        },
                      ),
                      TextFormField(
                        maxLines: 6,
                        decoration: const InputDecoration(
                            labelText: 'Sadrzaj',
                            hintText: 'Unesite sadrzaj filmu'),
                        onChanged: (value) {
                          sadrzaj = value;
                        },
                        validator: (value) {
                          if (value == null || value.isEmpty) {
                            return 'Ovo polje je obavezno';
                          }
                          return null;
                        },
                      ),
                      const SizedBox(height: 16),
                      TextFormField(
                        keyboardType: TextInputType.number,
                        inputFormatters: [
                          FilteringTextInputFormatter.digitsOnly
                        ],
                        decoration: const InputDecoration(
                          labelText: 'Vrijeme trajanja(min)',
                          hintText: '45',
                        ),
                        onChanged: (value) {
                          vrijemeTrajanja = value;
                        },
                        validator: (value) {
                          if (value == null || value.isEmpty) {
                            return 'Ovo polje je obavezno';
                          }
                          return null;
                        },
                      ),
                      const SizedBox(height: 16),
                      TextFormField(
                        decoration: const InputDecoration(
                          labelText: 'Redatelj',
                          hintText: 'Unesite redatelja',
                        ),
                        onChanged: (value) {
                          redatelj = value;
                        },
                        validator: (value) {
                          if (value == null || value.isEmpty) {
                            return 'Ovo polje je obavezno';
                          }
                          return null;
                        },
                      ),
                    ],
                  ),
                ),
                const SizedBox(width: 40),
                SizedBox(
                  width: 220,
                  child: Column(
                    children: [
                      Column(
                        children: [
                          Container(
                              height: 200,
                              width: 200,
                              decoration: BoxDecoration(
                                border: Border.all(
                                  color: Theme.of(context).primaryColor,
                                  style: _selectedImage == null
                                      ? BorderStyle.solid
                                      : BorderStyle.none,
                                ),
                                borderRadius: BorderRadius.circular(8),
                              ),
                              child: InkWell(
                                onTap: selectImage,
                                child: _selectedImage == null
                                    ? SizedBox(
                                        width: double.infinity,
                                        child: Column(
                                          mainAxisAlignment:
                                              MainAxisAlignment.center,
                                          children: [
                                            Icon(
                                              Icons.cloud_upload,
                                              size: 48,
                                              color: Theme.of(context)
                                                  .primaryColor,
                                            ),
                                            const SizedBox(height: 8),
                                            Text(
                                              'Odaberite sliku',
                                              style: TextStyle(
                                                color: Theme.of(context)
                                                    .primaryColor,
                                              ),
                                            ),
                                          ],
                                        ),
                                      )
                                    : Image.file(
                                        _selectedImage!,
                                        height: 200,
                                        width: 200,
                                        fit: BoxFit.contain,
                                      ),
                              )),
                          if (slikaError)
                            const Text(
                              'Slika je obavezna!',
                              style: TextStyle(color: Colors.red),
                            )
                        ],
                      ),
                      const SizedBox(height: 16),
                      TextFormField(
                        decoration: const InputDecoration(
                          labelText: 'Godina',
                          hintText: 'Unesite godinu izdanja',
                        ),
                        onChanged: (value) {
                          godina = value;
                        },
                        validator: (value) {
                          if (value == null || value.isEmpty) {
                            return 'Ovo polje je obavezno';
                          }
                          return null;
                        },
                      ),
                      const SizedBox(height: 16),
                      const Text('Pocetak prikazivanja'),
                      Container(
                        decoration: BoxDecoration(
                          borderRadius: BorderRadius.circular(4),
                          border: Border.all(color: Colors.black, width: 1),
                        ),
                        child: Padding(
                          padding: const EdgeInsets.all(8.0),
                          child: InkWell(
                            onTap: () => handleSelectDate(context),
                            child: Text(
                              formatDateTime(pocetakPrikazivanja),
                              style: const TextStyle(fontSize: 16),
                            ),
                          ),
                        ),
                      ),
                    ],
                  ),
                )
              ],
            )),
      ),
      actions: [
        TextButton(
          onPressed: () {
            Navigator.pop(context);
          },
          child: const Text('Poništi'),
        ),
        ElevatedButton(
          onPressed: () async {
            setState(() {
              slikaError = false;
            });
            if (formKey.currentState!.validate()) {
              if (_selectedImage == null) {
                setState(() {
                  slikaError = true;
                });
                return;
              }
              final bytes = await _selectedImage!.readAsBytes();
              final image = base64Encode(bytes);
              dynamic request = {
                'naziv': naziv,
                'sadrzaj': sadrzaj,
                'slika': image,
                'vrijemeTrajanje': int.parse(vrijemeTrajanja!),
                'redatelj': redatelj,
                'godina': godina,
                'pocetakPrikazivanja': pocetakPrikazivanja.toIso8601String(),
              };
              widget.handleAdd(request);
            }
          },
          child: const Text('Dodaj'),
        ),
      ],
    );
  }
}
