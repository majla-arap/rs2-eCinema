import 'package:ecinema_desktop/models/zanr.dart';
import 'package:flutter/material.dart';

class EditZanrModal extends StatefulWidget {
  final Zanr vf;
  final Function handleEdit;
  const EditZanrModal({
    Key? key,
    required this.vf,
    required this.handleEdit,
  }) : super(key: key);

  @override
  State<EditZanrModal> createState() => _EditZanrModalState();
}

class _EditZanrModalState extends State<EditZanrModal> {
  final _formKey = GlobalKey<FormState>();
  late TextEditingController _nazivController;

  @override
  void initState() {
    super.initState();
    _nazivController = TextEditingController(text: widget.vf.naziv);
  }

  @override
  void dispose() {
    _nazivController.dispose();
    super.dispose();
  }

  @override
  Widget build(BuildContext context) {
    return AlertDialog(
      title: const Text('Uredi vrstu filma'),
      content: Form(
        key: _formKey,
        child: Column(
          mainAxisSize: MainAxisSize.min,
          children: [
            TextFormField(
              controller: _nazivController,
              decoration: const InputDecoration(
                labelText: 'Naziv zanra',
                hintText: 'Naziv',
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
            if (_formKey.currentState!.validate()) {
              widget.handleEdit(
                widget.vf.zanrId,
                _nazivController.text,
              );
            }
          },
          child: const Text('Izmjeni'),
        ),
      ],
    );
  }
}
