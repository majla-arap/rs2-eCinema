import 'package:ecinema_desktop/models/glumac.dart';
import 'package:ecinema_desktop/providers/filmGlumacProvider.dart';
import 'package:ecinema_desktop/providers/glumciProvider.dart';
import 'package:flutter/material.dart';
import 'package:provider/provider.dart';

class AddFilmGlumacModal extends StatefulWidget {
  final int filmId;
  final String nazivFilma;
  const AddFilmGlumacModal({
    super.key,
    required this.nazivFilma,
    required this.filmId,
  });

  @override
  State<AddFilmGlumacModal> createState() => _AddFilmGlumacModalState();
}

class _AddFilmGlumacModalState extends State<AddFilmGlumacModal> {
  GlobalKey<FormState> formKey = GlobalKey<FormState>();
  FilmGlumacProvider? _filmGlumacProvider;
  GlumacProvider? _glumacProvider;
  List<Glumac> _glumci = [];

  late TextEditingController nazivController;
  String? uloga;
  Glumac? _selectedGlumac;

  @override
  void initState() {
    super.initState();
    _filmGlumacProvider = context.read<FilmGlumacProvider>();
    _glumacProvider = context.read<GlumacProvider>();
    nazivController = TextEditingController(text: widget.nazivFilma);
    loadGlumci();
  }

  void loadGlumci() async {
    var data = await _glumacProvider!.get();
    setState(() {
      _glumci = data;
    });
  }

  void handleAdd() async {
    dynamic request = {
      "nazivUloge": uloga,
      "glumacId": _selectedGlumac!.glumacId,
      "predstavaId": widget.filmId,
    };
    await _filmGlumacProvider!.insert(request);
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
      title: const Text('Dodaj glumca'),
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
            TextFormField(
              decoration: const InputDecoration(
                labelText: 'Naziv uloge',
              ),
              onChanged: (value) {
                uloga = value;
              },
              validator: (value) {
                if (value == null || value.isEmpty) {
                  return 'Ovo polje je obavezno';
                }
                return null;
              },
            ),
            SizedBox(
              width: double.infinity,
              child: DropdownButtonFormField<Glumac>(
                decoration: InputDecoration(
                  labelText: 'Glumac',
                  labelStyle: TextStyle(color: Theme.of(context).primaryColor),
                  enabledBorder: UnderlineInputBorder(
                    borderSide:
                        BorderSide(color: Theme.of(context).primaryColor),
                  ),
                ),
                value: _selectedGlumac,
                onChanged: (Glumac? g) {
                  setState(() {
                    _selectedGlumac = g!;
                  });
                },
                items: _glumci.map<DropdownMenuItem<Glumac>>((Glumac g) {
                  return DropdownMenuItem<Glumac>(
                    value: g,
                    child: Text("${g.ime} ${g.prezime}"),
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
