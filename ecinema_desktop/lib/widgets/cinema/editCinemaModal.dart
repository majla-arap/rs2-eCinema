import 'dart:convert';
import 'dart:io';
import 'package:ecinema_desktop/models/cinema.dart';
import 'package:ecinema_desktop/utils/utils.dart';
import 'package:file_picker/file_picker.dart';
import 'package:flutter/material.dart';

String patternUrl =
    r'^(https?:\/\/)?([\da-z\.-]+)\.([a-z\.]{2,6})([\/\w \.-]*)*\/?$';
String patternEmail = r'^[\w-]+(\.[\w-]+)*@([\w-]+\.)+[a-zA-Z]{2,7}$';
String patternPhone = r'^\d{3}-\d{3}-\d{3}$';

class EditCinemaModal extends StatefulWidget {
  final Cinema cinema;
  final Function handleEdit;
  const EditCinemaModal({
    Key? key,
    required this.cinema,
    required this.handleEdit,
  }) : super(key: key);

  @override
  State<EditCinemaModal> createState() => _EditPozoristeModalState();
}

class _EditPozoristeModalState extends State<EditCinemaModal> {
  GlobalKey<FormState> formKey = GlobalKey<FormState>();

  late TextEditingController nazivController;
  late TextEditingController adresaController;
  late TextEditingController webStranicaController;
  late TextEditingController emailController;
  late TextEditingController brojTelefonaController;
  bool? isAktivan;
  String? _selectedImage;

  @override
  void initState() {
    super.initState();
    nazivController = TextEditingController(text: widget.cinema.naziv);
    adresaController = TextEditingController(text: widget.cinema.adresa);
    webStranicaController =
        TextEditingController(text: widget.cinema.webstranica);
    emailController = TextEditingController(text: widget.cinema.email);
    brojTelefonaController =
        TextEditingController(text: widget.cinema.brTelefona);
    _selectedImage = widget.cinema.logo;
    isAktivan = widget.cinema.aktivan;
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
      title: const Text('Izmjeni kina'),
      content: Form(
          key: formKey,
          child: Row(
            children: [
              Expanded(
                child: Column(
                  children: [
                    TextFormField(
                      controller: nazivController,
                      decoration: const InputDecoration(
                        labelText: 'Naziv',
                        hintText: 'Unesite naziv kina',
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
                      controller: adresaController,
                      decoration: const InputDecoration(
                        labelText: 'Adresa',
                        hintText: 'Unesite adresu kina',
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
                      controller: webStranicaController,
                      decoration: const InputDecoration(
                          labelText: 'Web stranica',
                          hintText: 'Unesite web stranicu kina'),
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
                      controller: emailController,
                      decoration: const InputDecoration(
                          labelText: 'Email', hintText: 'Unesite email kina'),
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
                    TextFormField(
                      controller: brojTelefonaController,
                      decoration: const InputDecoration(
                          labelText: 'Broj broj telefona kina', hintText: ''),
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
                'naziv': nazivController.text,
                'adresa': adresaController.text,
                'webstranica': webStranicaController.text,
                'logo': _selectedImage,
                'email': emailController.text,
                'brTelefona': brojTelefonaController.text,
                'aktivan': isAktivan,
              };

              widget.handleEdit(widget.cinema.cinemaId, request);
            }
          },
          child: const Text('Izmjeni'),
        ),
      ],
    );
  }
}
