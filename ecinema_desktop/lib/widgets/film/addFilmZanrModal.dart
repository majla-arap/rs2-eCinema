import 'package:ecinema_desktop/models/models.dart';
import 'package:ecinema_desktop/providers/filmZanrProvider.dart';
import 'package:ecinema_desktop/providers/zanrProvider.dart';
import 'package:flutter/material.dart';
import 'package:provider/provider.dart';

class AddFilmZanrModal extends StatefulWidget {
  final int filmId;
  final String nazivFilma;
  const AddFilmZanrModal({
    super.key,
    required this.nazivFilma,
    required this.filmId,
  });

  @override
  State<AddFilmZanrModal> createState() => _AddFilmZanrModalState();
}

class _AddFilmZanrModalState extends State<AddFilmZanrModal> {
  GlobalKey<FormState> formKey = GlobalKey<FormState>();
  FilmZanrProvider? _filmZanrProvider;
  ZanrProvider? _zanrProvider;
  List<Zanr> _zanrovi = [];

  late TextEditingController nazivController;
  Zanr? _selectedZanr;

  @override
  void initState() {
    super.initState();
    _filmZanrProvider = context.read<FilmZanrProvider>();
    _zanrProvider = context.read<ZanrProvider>();
    nazivController = TextEditingController(text: widget.nazivFilma);
    loadZanrovi();
  }

  void loadZanrovi() async {
    var data = await _zanrProvider!.get();
    setState(() {
      _zanrovi = data;
    });
  }

  void handleAdd() async {
    dynamic request = {
      "zanrId": _selectedZanr!.zanrId,
      "filmId": widget.filmId,
    };
    await _filmZanrProvider!.insert(request);
    if (context.mounted) {
      Navigator.pop(context);
    }
  }

  @override
  void dispose() {
    nazivController.dispose();
    super.dispose();
  }

  @override
  Widget build(BuildContext context) {
    return AlertDialog(
      title: const Text('Dodaj žanr'),
      content: Form(
        key: formKey,
        child: Column(
          mainAxisSize: MainAxisSize.min,
          children: [
            TextFormField(
              enabled: false,
              controller: nazivController,
              decoration: const InputDecoration(
                labelText: 'Naziv filma',
              ),
              validator: (value) {
                if (value == null || value.isEmpty) {
                  return 'Ovo polje je obavezno';
                }
                return null;
              },
            ),
            SizedBox(
              width: double.infinity,
              child: DropdownButtonFormField<Zanr>(
                decoration: InputDecoration(
                  labelText: 'Žanr',
                  labelStyle: TextStyle(color: Theme.of(context).primaryColor),
                  enabledBorder: UnderlineInputBorder(
                    borderSide:
                        BorderSide(color: Theme.of(context).primaryColor),
                  ),
                ),
                value: _selectedZanr,
                onChanged: (Zanr? z) {
                  setState(() {
                    _selectedZanr = z!;
                  });
                },
                items: _zanrovi.map<DropdownMenuItem<Zanr>>((Zanr z) {
                  return DropdownMenuItem<Zanr>(
                    value: z,
                    child: Text(z.naziv),
                  );
                }).toList(),
              ),
            )
          ],
        ),
      ),
      actions: [
        ElevatedButton(
          onPressed: () {
            if (formKey.currentState!.validate()) {
              handleAdd();
            }
          },
          child: const Text('Add'),
        ),
      ],
    );
  }
}
