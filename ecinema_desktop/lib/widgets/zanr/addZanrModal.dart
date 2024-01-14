import 'package:flutter/material.dart';

class AddZanrModal extends StatefulWidget {
  final Function handleAdd;
  const AddZanrModal({
    super.key,
    required this.handleAdd,
  });

  @override
  State<AddZanrModal> createState() => _AddZanrModalState();
}

class _AddZanrModalState extends State<AddZanrModal> {
  GlobalKey<FormState> formKey = GlobalKey<FormState>();
  String? naziv;
  @override
  Widget build(BuildContext context) {
    return AlertDialog(
      title: const Text('Dodaj vrstu filma'),
      content: Form(
        key: formKey,
        child: Column(
          mainAxisSize: MainAxisSize.min,
          children: [
            TextFormField(
              decoration: const InputDecoration(
                labelText: 'Naziv zanra',
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
              widget.handleAdd(naziv!);
            }
          },
          child: const Text('Dodaj'),
        ),
      ],
    );
  }
}
