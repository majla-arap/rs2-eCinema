import 'dart:convert';
import 'dart:io';
import 'package:ecinema_desktop/models/film.dart';
import 'package:ecinema_desktop/utils/utils.dart';
import 'package:file_picker/file_picker.dart';
import 'package:flutter/material.dart';
import 'package:flutter/services.dart';

class EditFilmModal extends StatefulWidget {
  final Film film;
  final Function handleEdit;
  const EditFilmModal({
    Key? key,
    required this.film,
    required this.handleEdit,
  }) : super(key: key);

  @override
  State<EditFilmModal> createState() => _EditFilmModalState();
}

class _EditFilmModalState extends State<EditFilmModal> {
  GlobalKey<FormState> formKey = GlobalKey<FormState>();

  late TextEditingController nazivController;
  late TextEditingController sadrzajController;
  late TextEditingController vrijemeTrajanjeController;
  late TextEditingController redateljController;
  late TextEditingController godinaController;
  late DateTime pocPRikazivanjaController;
  bool slikaError = false;

  String? _selectedImage;
  @override
  void initState() {
    super.initState();
    nazivController = TextEditingController(text: widget.film.naziv);
    sadrzajController = TextEditingController(text: widget.film.sadrzaj);
    vrijemeTrajanjeController =
        TextEditingController(text: widget.film.vrijemeTrajanje.toString());
    redateljController = TextEditingController(text: widget.film.redatelj);
    godinaController = TextEditingController(text: widget.film.godina);
    pocPRikazivanjaController = widget.film.pocetakPrikazivanja;
    _selectedImage = widget.film.slika;
  }

  void selectImage() async {
    FilePickerResult? result =
        await FilePicker.platform.pickFiles(type: FileType.image);

    if (result != null) {
      final file = File(result.files.single.path!);
      final bytes = await file!.readAsBytes();
      final image = base64Encode(bytes);
      setState(() {
        _selectedImage = image;
        slikaError = false;
      });
    }
  }

  Future<void> handleSelectDate(BuildContext context) async {
    final DateTime? picked = await showDatePicker(
      context: context,
      initialDate: pocPRikazivanjaController,
      firstDate: DateTime(2000),
      lastDate: DateTime(2100),
    );
    if (picked != null && picked != pocPRikazivanjaController) {
      setState(() {
        pocPRikazivanjaController = picked;
      });
    }
  }

  @override
  Widget build(BuildContext context) {
    return AlertDialog(
      title: const Text('Izmjeni predstavu'),
      content: Form(
          key: formKey,
          child: Row(
            children: [
              SizedBox(
                width: 220,
                child: Column(
                  children: [
                    TextFormField(
                      controller: nazivController,
                      decoration: const InputDecoration(
                        labelText: 'Naziv',
                        hintText: 'Unesite naziv Film',
                      ),
                      validator: (value) {
                        if (value == null || value.isEmpty) {
                          return 'Ovo polje je obavezno';
                        }
                        return null;
                      },
                    ),
                    TextFormField(
                      controller: sadrzajController,
                      maxLines: 6,
                      decoration: const InputDecoration(
                          labelText: 'Sadrzaj',
                          hintText: 'Unesite sadrzaj Film'),
                      validator: (value) {
                        if (value == null || value.isEmpty) {
                          return 'Ovo polje je obavezno';
                        }
                        return null;
                      },
                    ),
                    const SizedBox(height: 16),
                    TextFormField(
                      controller: vrijemeTrajanjeController,
                      keyboardType: TextInputType.number,
                      inputFormatters: [FilteringTextInputFormatter.digitsOnly],
                      decoration: const InputDecoration(
                        labelText: 'Vrijeme trajanja(min)',
                        hintText: '45',
                      ),
                      validator: (value) {
                        if (value == null || value.isEmpty) {
                          return 'Ovo polje je obavezno';
                        }
                        return null;
                      },
                    ),
                    const SizedBox(height: 16),
                    TextFormField(
                      controller: redateljController,
                      decoration: const InputDecoration(
                        labelText: 'Redatelj',
                        hintText: 'Unesite redatelja',
                      ),
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
                                          color: Theme.of(context).primaryColor,
                                        ),
                                        const SizedBox(height: 8),
                                        Text(
                                          'Odaberite sliku',
                                          style: TextStyle(
                                            color:
                                                Theme.of(context).primaryColor,
                                          ),
                                        ),
                                      ],
                                    ),
                                  )
                                : imageFromBase64String(
                                    _selectedImage!,
                                    200,
                                    200,
                                  ),
                          ),
                        ),
                        if (slikaError)
                          const Text(
                            'Slika je obavezna!',
                            style: TextStyle(color: Colors.red),
                          )
                      ],
                    ),
                    const SizedBox(height: 16),
                    TextFormField(
                      controller: godinaController,
                      decoration: const InputDecoration(
                        labelText: 'Godina izdanja',
                        hintText: 'Unesite godinu',
                      ),
                      validator: (value) {
                        if (value == null || value.isEmpty) {
                          return 'Ovo polje je obavezno';
                        }
                        return null;
                      },
                    ),
                    const SizedBox(height: 16),
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
                            formatDateTime(pocPRikazivanjaController),
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
              dynamic request = {
                'naziv': nazivController.text,
                'sadrzaj': sadrzajController.text,
                'slika': _selectedImage,
                'vrijemeTrajanje': int.parse(vrijemeTrajanjeController.text),
                'redatelj': redateljController.text,
                'godina': godinaController.text,
                'pocetakPrikazivanja':
                    pocPRikazivanjaController.toIso8601String(),
              };
              widget.handleEdit(widget.film.filmId, request);
            }
          },
          child: const Text('Uredi'),
        ),
      ],
    );
  }
}
