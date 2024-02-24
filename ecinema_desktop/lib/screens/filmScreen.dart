import 'package:ecinema_desktop/models/film.dart';
import 'package:ecinema_desktop/models/models.dart';
import 'package:ecinema_desktop/providers/filmProvider.dart';
import 'package:ecinema_desktop/screens/listaGlumacaScreen.dart';
import 'package:ecinema_desktop/widgets/film/addFilmGlumacModal.dart';
import 'package:ecinema_desktop/widgets/film/addFilmModal.dart';
import 'package:ecinema_desktop/widgets/film/editFilmModal.dart';
import 'package:ecinema_desktop/widgets/film_zarada.dart';
import 'package:flutter/material.dart';
import 'package:provider/provider.dart';

class FilmScreen extends StatefulWidget {
  const FilmScreen({super.key});

  @override
  State<FilmScreen> createState() => _FilmScreenState();
}

class _FilmScreenState extends State<FilmScreen> {
  FilmProvider? _filmProvider;
  List<Film>? _film;
  final TextEditingController _searchController = TextEditingController();

  @override
  void initState() {
    super.initState();
    _filmProvider = context.read<FilmProvider>();
    loadData();
    // loadVrste();
  }

/*  void loadVrste() async {
    var data = await _zanrProvider!.get();
    setState(() {
      _zanr = [...zanr, ...data];
    });
  }*/

  void loadData() async {
    /* dynamic request = {
      'ZanrId': _selectedZanr!.zanrId == 0
          ? null
          : _selectedZanr?.zanrId,
      'Text': _searchController.text
    };*/

    var data = await _filmProvider!.get({'Text': _searchController.text});
    setState(() {
      _film = data;
    });
  }

  void resetSearch() {
    _searchController.text = '';
  }

  void handleEdit(int id, dynamic request) async {
    await _filmProvider!.update(id, request);
    if (context.mounted) {
      Navigator.pop(context);
      loadData();
      ScaffoldMessenger.of(context).showSnackBar(
        SnackBar(
          backgroundColor: Theme.of(context).primaryColor,
          content: const Text('Uspješno ste modifikovali podatke o filmu!'),
        ),
      );
    }
  }

  void openEditModal(Film f) {
    showDialog(
      context: context,
      builder: (BuildContext context) {
        return EditFilmModal(film: f, handleEdit: handleEdit);
      },
    );
  }

  void openDeleteModal(Film f) {
    showDialog(
      context: context,
      builder: (BuildContext context) {
        return AlertDialog(
          title: const Text('Brisanje '),
          content: const Column(
            mainAxisSize: MainAxisSize.min,
            children: [
              Text('Da li ste sigurni da želite da obrišete film?'),
            ],
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
                try {
                  await _filmProvider!.remove(f.filmId);
                  if (context.mounted) {
                    Navigator.pop(context);
                    loadData();
                  }
                } catch (e) {
                  if (context.mounted) {
                    Navigator.pop(context);
                    ScaffoldMessenger.of(context).showSnackBar(
                      const SnackBar(
                        backgroundColor: Colors.red,
                        content: Text(
                            'Ne možete obrisati predstavu  jer postoji termin za nju!'),
                      ),
                    );
                  }
                }
              },
              child: const Text(
                'Obriši',
                style: TextStyle(color: Colors.red),
              ),
            ),
          ],
        );
      },
    );
  }

  void handleAdd(dynamic request) async {
    var response = await _filmProvider!.insert(request);
    if (context.mounted) {
      Navigator.pop(context);
      showDialog(
        barrierDismissible: false,
        context: context,
        builder: (BuildContext context) {
          return AddFilmGlumacModal(
            nazivFilma: response!.naziv,
            filmId: response.filmId,
          );
        },
      );
      resetSearch();
      loadData();
      ScaffoldMessenger.of(context).showSnackBar(
        SnackBar(
          backgroundColor: Theme.of(context).primaryColor,
          content: const Text('Uspješno ste dodali novi film!'),
        ),
      );
    }
  }

  void openAddModal() {
    showDialog(
      context: context,
      builder: (BuildContext context) {
        return AddFilmModal(handleAdd: handleAdd);
      },
    );
  }

  @override
  Widget build(BuildContext context) {
    if (_film == null) {
      return const Center(child: CircularProgressIndicator());
    }
    return Scaffold(
      body: SingleChildScrollView(
        child: Column(
          children: [
            Row(
              children: [
                const SizedBox(width: 16.0),
                Expanded(
                  child: TextFormField(
                    controller: _searchController,
                    decoration: const InputDecoration(
                      labelText: 'Predstava',
                      hintText: 'Unesite naziv filma',
                    ),
                  ),
                ),
                const SizedBox(width: 16.0),
                ElevatedButton(
                  onPressed: () {
                    openAddModal();
                  },
                  child: const Text('+'),
                ),
                const SizedBox(width: 16.0),
              ],
            ),
            const SizedBox(height: 16),
            SizedBox(
              width: double.infinity,
              child: DataTable(
                columnSpacing: 0,
                columns: const [
                  DataColumn(label: Text('Naziv')),
                  DataColumn(label: Text('Vrijeme trajanja')),
                  DataColumn(label: Text('Uredi')),
                  DataColumn(label: Text('Obriši')),
                  DataColumn(label: Text('Dodaj glumca')),
                  DataColumn(label: Text('Prikaz glumaca')),
                  DataColumn(label: Text('Izvjestaj')),
                ],
                rows: _film!.isNotEmpty
                    ? _film!.map((film) {
                        return DataRow(cells: [
                          DataCell(Text(film.naziv)),
                          DataCell(Text(film.vrijemeTrajanje.toString())),
                          DataCell(
                            IconButton(
                              icon: Icon(Icons.edit,
                                  color: Theme.of(context).primaryColor),
                              onPressed: () {
                                openEditModal(film);
                              },
                            ),
                          ),
                          DataCell(
                            IconButton(
                              icon: const Icon(Icons.delete, color: Colors.red),
                              onPressed: () {
                                openDeleteModal(film);
                              },
                            ),
                          ),
                          DataCell(
                            IconButton(
                              icon: Icon(Icons.person_add,
                                  color: Theme.of(context).primaryColor),
                              onPressed: () {
                                showDialog(
                                  barrierDismissible: true,
                                  context: context,
                                  builder: (BuildContext context) {
                                    return AddFilmGlumacModal(
                                      nazivFilma: film.naziv,
                                      filmId: film.filmId,
                                    );
                                  },
                                );
                              },
                            ),
                          ),
                          DataCell(
                            IconButton(
                              icon: Icon(Icons.format_list_bulleted,
                                  color: Theme.of(context).primaryColor),
                              onPressed: () {
                                Navigator.pushNamed(
                                  context,
                                  ListaGlumacaScreen.routeName,
                                  arguments: {
                                    'filmId': film.filmId,
                                    'naziv': film.naziv
                                  },
                                );
                              },
                            ),
                          ),
                          DataCell(
                            IconButton(
                              icon: Icon(Icons.addchart,
                                  color: Theme.of(context).primaryColor),
                              onPressed: () {
                                showDialog(
                                  context: context,
                                  builder: (BuildContext context) {
                                    return AlertDialog(
                                      title: const Text('Zarada po predstavi'),
                                      content: FilmZarada(
                                        filmId: film.filmId,
                                      ),
                                    );
                                  },
                                );
                              },
                            ),
                          ),
                        ]);
                      }).toList()
                    : [
                        const DataRow(cells: [
                          DataCell(Text('')),
                          DataCell(Text('')),
                          DataCell(Text('')),
                          DataCell(
                              Center(child: Text('Nema rezultata pretrage'))),
                          DataCell(Text('')),
                          DataCell(Text('')),
                          DataCell(Text('')),
                          DataCell(Text('')),
                        ])
                      ],
              ),
            ),
          ],
        ),
      ),
    );
  }
}
