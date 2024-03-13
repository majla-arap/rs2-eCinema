import 'package:ecinema_desktop/models/film.dart';
import 'package:ecinema_desktop/models/termin.dart';
import 'package:ecinema_desktop/providers/filmProvider.dart';
import 'package:ecinema_desktop/providers/terminiProvider.dart';
import 'package:ecinema_desktop/utils/utils.dart';
import 'package:flutter/material.dart';
import 'package:flutter/services.dart';
import 'package:provider/provider.dart';

class EditTerminModal extends StatefulWidget {
  final Termin termin;
  final Function handleEdit;
  const EditTerminModal({
    Key? key,
    required this.termin,
    required this.handleEdit,
  }) : super(key: key);

  @override
  State<EditTerminModal> createState() => _EditPozoristeModalState();
}

class _EditPozoristeModalState extends State<EditTerminModal> {
  TerminProvider? _terminProvider;
  FilmProvider? _FilmProvider;
  List<Film> _film = [];
  GlobalKey<FormState> formKey = GlobalKey<FormState>();
  Film? _selectedFilm;
  bool displayError = false;

  late TextEditingController cijenaKarteController;
  late TextEditingController vrijemeOdrzavanjaController;

  late DateTime datumOdrzavanja;
  late bool isPremijera;
  late bool isPredPremijera;

  @override
  void initState() {
    super.initState();
    _terminProvider = context.read<TerminProvider>();
    _FilmProvider = context.read<FilmProvider>();
    cijenaKarteController =
        TextEditingController(text: widget.termin.cijenaKarte.toString());
    vrijemeOdrzavanjaController =
        TextEditingController(text: widget.termin.vrijemeOdrzavanja);

    isPremijera = widget.termin.premijera;
    isPredPremijera = widget.termin.predpremijera;
    datumOdrzavanja = widget.termin.datumOdrzavanja;
    loadFilm();
  }

  loadFilm() async {
    var data = await _FilmProvider!.get();
    _film = data;
    int index =
        data.indexWhere((element) => element.filmId == widget.termin.filmId);

    setState(() {
      _film = data;
      _selectedFilm = data[index];
    });
  }

  @override
  void dispose() {
    cijenaKarteController.dispose();
    vrijemeOdrzavanjaController.dispose();
    super.dispose();
  }

  void handleEdit(int id, dynamic request) async {
    try {
      await _terminProvider!.update(id, request);
      if (context.mounted) {
        Navigator.pop(context);
        widget.handleEdit();
      }
    } catch (e) {
      if (context.mounted) {
        setState(() {
          displayError = true;
        });
      }
    }
  }

  Future<void> handleSelectDate(BuildContext context) async {
    final DateTime? picked = await showDatePicker(
      context: context,
      initialDate: datumOdrzavanja,
      firstDate: DateTime(2000),
      lastDate: DateTime(2100),
    );
    if (picked != null && picked != datumOdrzavanja) {
      setState(() {
        datumOdrzavanja = picked;
      });
    }
  }

  @override
  Widget build(BuildContext context) {
    return AlertDialog(
      title: const Text('Uredjivanje termina'),
      content: Form(
        key: formKey,
        child: Column(
          mainAxisSize: MainAxisSize.min,
          mainAxisAlignment: MainAxisAlignment.center,
          crossAxisAlignment: CrossAxisAlignment.center,
          children: [
            DropdownButtonFormField<Film>(
              decoration: InputDecoration(
                labelText: 'Film',
                labelStyle: TextStyle(color: Theme.of(context).primaryColor),
                enabledBorder: UnderlineInputBorder(
                  borderSide: BorderSide(color: Theme.of(context).primaryColor),
                ),
              ),
              value: _selectedFilm,
              onChanged: (Film? p) {
                setState(() {
                  _selectedFilm = p!;
                });
              },
              validator: (value) {
                if (value == null) {
                  return 'Ovo polje je obavezno';
                }
                return null;
              },
              items: _film.map<DropdownMenuItem<Film>>((Film p) {
                return DropdownMenuItem<Film>(
                  value: p,
                  child: Text(p.naziv),
                );
              }).toList(),
            ),
            TextFormField(
              controller: cijenaKarteController,
              keyboardType: TextInputType.number,
              inputFormatters: [FilteringTextInputFormatter.digitsOnly],
              decoration: const InputDecoration(
                labelText: 'Cijena karte (KM)',
                hintText: 'Unesite cijenu karte',
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
                    formatDateTime(datumOdrzavanja),
                    style: const TextStyle(fontSize: 16),
                  ),
                ),
              ),
            ),
            const SizedBox(height: 16),
            TextFormField(
              controller: vrijemeOdrzavanjaController,
              decoration: const InputDecoration(
                  labelText: 'Satnica održavanja', hintText: ''),
              validator: (value) {
                if (value == null || value.isEmpty) {
                  return 'Ovo polje je obavezno';
                }
                return null;
              },
            ),
            const SizedBox(height: 16),
            Row(
              children: [
                Checkbox(
                  value: isPremijera,
                  onChanged: (bool? s) {
                    setState(() {
                      isPremijera = s!;
                    });
                  },
                  activeColor: Theme.of(context).primaryColor,
                ),
                const Text('Premijera'),
                const SizedBox(width: 16),
                Checkbox(
                  value: isPredPremijera,
                  onChanged: (bool? s) {
                    setState(() {
                      isPredPremijera = s!;
                    });
                  },
                  activeColor: Theme.of(context).primaryColor,
                ),
                const Text('Predpremijera'),
              ],
            ),
            const SizedBox(height: 16),
            if (displayError)
              const Text('Termin za ovaj datum i vrijeme je zauzet.',
                  style: TextStyle(color: Colors.red)),
            const SizedBox(height: 16),
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
          onPressed: () async {
            if (formKey.currentState!.validate()) {
              dynamic request = {
                'premijera': isPremijera,
                'predpremijera': isPredPremijera,
                'cijenaKarte': cijenaKarteController.text,
                'datumOdrzavanja': datumOdrzavanja.toIso8601String(),
                'vrijemeOdrzavanja': vrijemeOdrzavanjaController.text,
                'filmId': _selectedFilm!.filmId,
                'dvoranaId': widget.termin.dvoranaId
              };

              handleEdit(widget.termin.terminId, request);
            }
          },
          child: const Text('Dodaj'),
        ),
      ],
    );
  }
}
