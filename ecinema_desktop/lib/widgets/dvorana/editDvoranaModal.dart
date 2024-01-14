import 'package:ecinema_desktop/models/dvorana.dart';
import 'package:flutter/material.dart';

class EditDvoranaModal extends StatefulWidget {
  final Dvorana dvorana;
  final Function handleEdit;
  const EditDvoranaModal({
    Key? key,
    required this.dvorana,
    required this.handleEdit,
  }) : super(key: key);

  @override
  State<EditDvoranaModal> createState() => _EditDvoranaModalState();
}

class _EditDvoranaModalState extends State<EditDvoranaModal> {
  final _formKey = GlobalKey<FormState>();
  late TextEditingController _nazivController;
  late TextEditingController _brojRedovaController;
  late TextEditingController _brojSjedistaPoReduController;
  late TextEditingController _ukupanBrojSjedistaController;

  @override
  void initState() {
    super.initState();
    _nazivController = TextEditingController(text: widget.dvorana.naziv);
    _brojRedovaController =
        TextEditingController(text: widget.dvorana.brRedova.toString());
    _brojSjedistaPoReduController =
        TextEditingController(text: widget.dvorana.brSjedistaPoRedu.toString());
    _ukupanBrojSjedistaController =
        TextEditingController(text: widget.dvorana.brSjedista.toString());
  }

  @override
  void dispose() {
    _nazivController.dispose();
    _brojRedovaController.dispose();
    _brojSjedistaPoReduController.dispose();
    _ukupanBrojSjedistaController.dispose();
    super.dispose();
  }

  @override
  Widget build(BuildContext context) {
    return AlertDialog(
      title: const Text('Uredi dvoranu'),
      content: Form(
        key: _formKey,
        child: Column(
          mainAxisSize: MainAxisSize.min,
          children: [
            TextFormField(
              controller: _nazivController,
              decoration: const InputDecoration(
                labelText: 'Naziv ',
                hintText: 'Unesite naziv dvorane',
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
              dynamic request = {'naziv': _nazivController.text};
              widget.handleEdit(widget.dvorana.dvoranaId, request);
            }
          },
          child: const Text('Izmjeni'),
        ),
      ],
    );
  }
}
