import 'dart:convert';
import 'dart:io';
import 'package:ecinema_desktop/utils/utils.dart';
import 'package:flutter/material.dart';
import 'package:file_picker/file_picker.dart';

String patternUrl =
    r'^(https?:\/\/)?([\da-z\.-]+)\.([a-z\.]{2,6})([\/\w \.-]*)*\/?$';
String patternEmail = r'^[\w-]+(\.[\w-]+)*@([\w-]+\.)+[a-zA-Z]{2,7}$';
String patternPhone = r'^\d{3}-\d{3}-\d{3}$';

class AddCinemaModal extends StatefulWidget {
  final Function handleAdd;
  const AddCinemaModal({
    super.key,
    required this.handleAdd,
  });

  @override
  State<AddCinemaModal> createState() => _AddCinemaModalState();
}

class _AddCinemaModalState extends State<AddCinemaModal> {
  GlobalKey<FormState> formKey = GlobalKey<FormState>();
  String? naziv;
  String? adresa;
  String? webStranica;
  String? email;
  String? brojTelefona;
  String? _selectedImage;
  bool isAktivan = false;
  @override
  void initState() {
    super.initState();
  }

  void selectImage() async {
    FilePickerResult? result =
        await FilePicker.platform.pickFiles(type: FileType.image);

    if (result != null) {
      final imageFile = File(result.files.single.path!);
      final bytes = await imageFile!.readAsBytes();
      final image = base64Encode(bytes);
      setState(() {
        _selectedImage = image;
      });
    } else {
      // User canceled the picker
    }
  }

  @override
  Widget build(BuildContext context) {
    return AlertDialog(
      title: const Text('Dodaj kino'),
      content: Form(
          key: formKey,
          child: Row(
            children: [
              Expanded(
                child: Column(
                  children: [
                    TextFormField(
                      decoration: const InputDecoration(
                        labelText: 'Naziv',
                        hintText: 'Unesite naziv kina',
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
                    const SizedBox(height: 16),
                    TextFormField(
                      decoration: const InputDecoration(
                        labelText: 'Adresa',
                        hintText: 'Unesite adresu kina',
                      ),
                      onChanged: (value) {
                        adresa = value;
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
                          labelText: 'Web stranica',
                          hintText: 'Unesite web stranicu kina'),
                      onChanged: (value) {
                        webStranica = value;
                      },
                      validator: (value) {
                        if (value == null || value.isEmpty) {
                          return 'Ovo polje je obavezno';
                        } else if (!RegExp(patternUrl).hasMatch(value)) {
                          return 'Unesite validan url(https://stranica.com)';
                        }
                        return null;
                      },
                    ),
                    const SizedBox(height: 16),
                    TextFormField(
                      decoration: const InputDecoration(
                          labelText: 'Email',
                          hintText: 'Unesite email pozorista'),
                      onChanged: (value) {
                        email = value;
                      },
                      validator: (value) {
                        if (value == null || value.isEmpty) {
                          return 'Ovo polje je obavezno';
                        } else if (!RegExp(patternEmail).hasMatch(value)) {
                          return 'Unesite validan email';
                        }
                        return null;
                      },
                    ),
                    const SizedBox(height: 16),
                  ],
                ),
              ),
              const SizedBox(width: 40),
              Expanded(
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
                      ],
                    ),
                    TextFormField(
                      decoration: const InputDecoration(
                          labelText: 'Broj broj telefona kina', hintText: ''),
                      onChanged: (value) {
                        brojTelefona = value;
                      },
                      validator: (value) {
                        if (value == null || value.isEmpty) {
                          return 'Ovo polje je obavezno';
                        } else if (!RegExp(patternPhone).hasMatch(value)) {
                          return 'Format telefona mora biti XXX-XXX-XXX';
                        }
                        return null;
                      },
                    ),
                    const SizedBox(height: 16),
                    Row(
                      children: [
                        Checkbox(
                          value: isAktivan,
                          onChanged: (bool? s) {
                            setState(() {
                              isAktivan = s!;
                            });
                          },
                          activeColor: Theme.of(context).primaryColor,
                        ),
                        const Text('Aktivan')
                      ],
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
            if (formKey.currentState!.validate()) {
              dynamic request = {
                'naziv': naziv,
                'adresa': adresa,
                'webstranica': webStranica,
                'logo': _selectedImage,
                'email': email,
                'brTelefona': brojTelefona,
                'aktivan': isAktivan,
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
