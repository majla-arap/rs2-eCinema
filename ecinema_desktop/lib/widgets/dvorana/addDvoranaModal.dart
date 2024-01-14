import 'package:flutter/material.dart';
import 'package:flutter/services.dart';

class AddDvoranaModal extends StatefulWidget {
  final Function handleAdd;
  const AddDvoranaModal({
    super.key,
    required this.handleAdd,
  });

  @override
  State<AddDvoranaModal> createState() => _AddDvoranaModalState();
}

class _AddDvoranaModalState extends State<AddDvoranaModal> {
  final ukupanBrojSjedistaController = TextEditingController();
  GlobalKey<FormState> formKey = GlobalKey<FormState>();
  String? naziv;
  int brojRedova = 10;
  int brojSjedistaPoRedu = 10;
  int? brojSjedista;
  @override
  void initState() {
    super.initState();
    ukupanBrojSjedistaController.text = '100';
  }

  @override
  Widget build(BuildContext context) {
    return AlertDialog(
      title: const Text('Dodaj dvoranu'),
      content: Form(
        key: formKey,
        child: Column(
          mainAxisSize: MainAxisSize.min,
          children: [
            TextFormField(
              decoration: const InputDecoration(
                labelText: 'Naziv dvorane',
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
              initialValue: '10',
              keyboardType: TextInputType.number,
              inputFormatters: [FilteringTextInputFormatter.digitsOnly],
              decoration: const InputDecoration(
                labelText: 'Broj redova',
              ),
              onChanged: (String value) {
                if (value.isEmpty) return;
                brojRedova = int.parse(value);
                setState(() {
                  brojRedova = int.parse(value);
                });
                ukupanBrojSjedistaController.text =
                    (brojRedova * brojSjedistaPoRedu).toString();
              },
              validator: (value) {
                if (value == null || value.isEmpty) {
                  return 'Ovo polje je obavezno';
                }
                return null;
              },
            ),
            TextFormField(
              initialValue: '10',
              keyboardType: TextInputType.number,
              inputFormatters: [FilteringTextInputFormatter.digitsOnly],
              decoration: const InputDecoration(
                labelText: 'Broj sjedista po redu',
              ),
              onChanged: (String value) {
                if (value.isEmpty) return;
                setState(() {
                  brojSjedistaPoRedu = int.parse(value);
                });

                ukupanBrojSjedistaController.text =
                    (brojRedova * brojSjedistaPoRedu).toString();
              },
              validator: (value) {
                if (value == null || value.isEmpty) {
                  return 'Ovo polje je obavezno';
                }
                return null;
              },
            ),
            TextFormField(
              controller: ukupanBrojSjedistaController,
              keyboardType: TextInputType.number,
              enabled: false,
              decoration: const InputDecoration(
                labelText: 'Ukupan broj sjedista',
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
      actions: [
        TextButton(
          onPressed: () {
            Navigator.pop(context);
          },
          child: const Text('Poništi'),
        ),
        ElevatedButton(
          onPressed: () {
            if (formKey.currentState!.validate()) {
              dynamic request = {
                'naziv': naziv,
                'brRedova': brojRedova,
                'brSjedistaPoRedu': brojSjedistaPoRedu
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
