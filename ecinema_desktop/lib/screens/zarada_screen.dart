import 'package:ecinema_desktop/models/film.dart';
import 'package:ecinema_desktop/models/zarada.dart';
import 'package:ecinema_desktop/providers/filmProvider.dart';
import 'package:flutter/material.dart';
import 'package:provider/provider.dart';

class ZaradaScreen extends StatefulWidget {
  const ZaradaScreen({super.key});

  @override
  State<ZaradaScreen> createState() => _ZaradaScreenState();
}

class _ZaradaScreenState extends State<ZaradaScreen> {
  FilmProvider? _filmProvider;
  Zarada? _zarada;
  List<Film>? _filmovi;
  Film? _selectedFilm;
  @override
  void initState() {
    super.initState();
    _filmProvider = context.read<FilmProvider>();
    loadPredstave();
  }

  void loadData() async {
    var data = await _filmProvider!.getZarada(_selectedFilm!.filmId);
    setState(() {
      _zarada = data;
    });
  }

  void loadPredstave() async {
    var data = await _filmProvider!.get();
    setState(() {
      _filmovi = [...data];
      _selectedFilm = data[0];
      loadData();
    });
  }

  @override
  Widget build(BuildContext context) {
    if (_filmovi == null) {
      return const Center(child: CircularProgressIndicator());
    }
    return Scaffold(
        body: SingleChildScrollView(
            child: Center(
                child: SizedBox(
                    width: 400,
                    height: 400,
                    child: Column(children: [
                      Row(
                          crossAxisAlignment: CrossAxisAlignment.center,
                          children: [
                            Expanded(
                              child: DropdownButtonFormField<Film>(
                                decoration: InputDecoration(
                                  labelText: 'Film',
                                  labelStyle: TextStyle(
                                      color: Theme.of(context).primaryColor),
                                  enabledBorder: UnderlineInputBorder(
                                    borderSide: BorderSide(
                                        color: Theme.of(context).primaryColor),
                                  ),
                                ),
                                value: _selectedFilm,
                                onChanged: (Film? f) {
                                  setState(() {
                                    _selectedFilm = f!;
                                    loadData();
                                  });
                                },
                                items: _filmovi!
                                    .map<DropdownMenuItem<Film>>((Film f) {
                                  return DropdownMenuItem<Film>(
                                    value: f,
                                    child: Text(f.naziv),
                                  );
                                }).toList(),
                              ),
                            ),
                          ]),
                      const SizedBox(height: 30),
                      if (_zarada != null)
                        Container(
                            width: double.infinity,
                            height: 120,
                            color: Theme.of(context).primaryColor,
                            child: Column(
                              children: [
                                Text(
                                  'Zarada: ${_zarada!.ukupnaZarada} KM',
                                  style: const TextStyle(
                                      fontSize: 20,
                                      fontWeight: FontWeight.bold,
                                      color: Colors.white),
                                ),
                                const SizedBox(height: 10),
                                Text(
                                  'Broj termina: ${_zarada!.brTermina}',
                                  style: const TextStyle(
                                      fontSize: 20,
                                      fontWeight: FontWeight.bold,
                                      color: Colors.white),
                                ),
                                const SizedBox(height: 10),
                                Text(
                                  'Broj prodatih karata: ${_zarada!.brKarata}',
                                  style: const TextStyle(
                                      fontSize: 20,
                                      fontWeight: FontWeight.bold,
                                      color: Colors.white),
                                ),
                              ],
                            ))
                    ])))));
  }
}
