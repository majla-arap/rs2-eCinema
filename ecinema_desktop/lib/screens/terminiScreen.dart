import 'package:ecinema_desktop/models/film.dart';
import 'package:ecinema_desktop/models/termin.dart';
import 'package:ecinema_desktop/providers/filmProvider.dart';
import 'package:ecinema_desktop/providers/terminiProvider.dart';
import 'package:ecinema_desktop/screens/karteScreen.dart';
import 'package:ecinema_desktop/utils/utils.dart';
import 'package:ecinema_desktop/widgets/termin/addTerminModal.dart';
import 'package:ecinema_desktop/widgets/termin/editTerminModal.dart';
import 'package:flutter/material.dart';
import 'package:provider/provider.dart';

class TerminiScreen extends StatefulWidget {
  final int dvoranaId;
  static const routeName = "/termini";
  const TerminiScreen({super.key, required this.dvoranaId});

  @override
  State<TerminiScreen> createState() => _TerminiScreenState();
}

class _TerminiScreenState extends State<TerminiScreen> {
  TerminProvider? _terminProvider;
  FilmProvider? _filmProvider;
  List<Termin>? _kina;
  DateTime? _selectedDate;
  bool filterPremijera = false;
  bool filterPredPrem = false;
  List<Film> _film = [
    Film(
      filmId: 0,
      naziv: 'Sve',
      godina: '',
      redatelj: '',
      sadrzaj: '',
      pocetakPrikazivanja: DateTime.now(),
      vrijemeTrajanje: 30,
      slika: '',
    )
  ];
  Film? _selectedFilm;
  @override
  void initState() {
    super.initState();
    _terminProvider = context.read<TerminProvider>();
    _filmProvider = context.read<FilmProvider>();
    _selectedFilm = _film[0];
    loadData();
    loadFilm();
  }

  void resetState() {
    setState(() {
      _selectedDate = null;
      _selectedFilm = _film[0];
      filterPremijera = false;
      filterPredPrem = false;
    });
    loadData();
  }

  Future<void> handleSelectDate(BuildContext context) async {
    final DateTime? picked = await showDatePicker(
      context: context,
      initialDate: _selectedDate,
      firstDate: DateTime(2000),
      lastDate: DateTime(2100),
    );
    if (picked != null && picked != _selectedDate) {
      setState(() {
        _selectedDate = picked;
      });
    }
  }

  void loadFilm() async {
    var data = await _filmProvider!.get();
    setState(() {
      _film = [..._film, ...data];
    });
  }

  void loadData() async {
    dynamic request = {
      'SalaId': widget.dvoranaId,
      'DatumOdrzavanja': _selectedDate?.toIso8601String(),
      'Premijera': filterPremijera ? true : null,
      'Predpremijera': filterPredPrem ? true : null,
      'FilmId': _selectedFilm!.filmId == 0 ? null : _selectedFilm!.filmId
    };
    var data = await _terminProvider!.get(request);
    setState(() {
      _kina = data;
    });
  }

  void handleEdit(int id, dynamic request) async {
    await _terminProvider!.update(id, request);
    if (context.mounted) {
      Navigator.pop(context);
      loadData();
      ScaffoldMessenger.of(context).showSnackBar(
        SnackBar(
          backgroundColor: Theme.of(context).primaryColor,
          content: const Text('Uspješno ste modifikovali podatke o terminu!'),
        ),
      );
    }
  }

  void openEditModal(Termin t) {
    showDialog(
      context: context,
      builder: (BuildContext context) {
        return EditTerminModal(termin: t, handleEdit: loadData);
      },
    );
  }

  void openDeleteModal(Termin t) {
    showDialog(
      context: context,
      builder: (BuildContext context) {
        return AlertDialog(
          title: const Text('Brisanje '),
          content: const Column(
            mainAxisSize: MainAxisSize.min,
            children: [
              Text('Da li ste sigurni da želite da obrišete termin?'),
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
                  await _terminProvider!.remove(t.terminId);
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
                        content:
                            Text('Ne možete obrisati termin jer se koristi!'),
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

  void openAddModal() {
    showDialog(
      context: context,
      builder: (BuildContext context) {
        return AddTerminModal(
          dvoranaId: widget.dvoranaId,
          handleAdd: () => {
            resetState(),
            loadData(),
            ScaffoldMessenger.of(context).showSnackBar(
              SnackBar(
                backgroundColor: Theme.of(context).primaryColor,
                content: const Text('Uspješno ste dodali novi termin!'),
              ),
            ),
          },
        );
      },
    );
  }

  @override
  Widget build(BuildContext context) {
    if (_kina == null) {
      return const Center(child: CircularProgressIndicator());
    }
    return Scaffold(
      appBar: AppBar(title: const Text('Pregled termina')),
      body: SingleChildScrollView(
        child: Column(
          children: [
            Row(
              crossAxisAlignment: CrossAxisAlignment.center,
              children: [
                const SizedBox(width: 16.0),
                Expanded(
                    child: Container(
                  decoration: BoxDecoration(
                    borderRadius: BorderRadius.circular(4),
                    border: Border.all(
                        color: Theme.of(context).primaryColor, width: 1),
                  ),
                  child: Padding(
                    padding: const EdgeInsets.all(8.0),
                    child: InkWell(
                      onTap: () => handleSelectDate(context),
                      child: Text(
                        formatDateTime(_selectedDate ?? DateTime.now()),
                        style: const TextStyle(fontSize: 16),
                      ),
                    ),
                  ),
                )),
                const SizedBox(width: 16.0, height: 16),
                Checkbox(
                  value: filterPremijera,
                  onChanged: (bool? s) {
                    setState(() {
                      filterPredPrem = s!;
                    });
                  },
                  activeColor: Theme.of(context).primaryColor,
                ),
                const Text('Premijera'),
                const SizedBox(width: 16),
                Checkbox(
                  value: filterPredPrem,
                  onChanged: (bool? s) {
                    setState(() {
                      filterPredPrem = s!;
                    });
                  },
                  activeColor: Theme.of(context).primaryColor,
                ),
                const Text('Predpremijera'),
                const SizedBox(width: 16),
                Expanded(
                  child: DropdownButtonFormField<Film>(
                    decoration: InputDecoration(
                      labelText: 'Film',
                      labelStyle:
                          TextStyle(color: Theme.of(context).primaryColor),
                      enabledBorder: UnderlineInputBorder(
                        borderSide:
                            BorderSide(color: Theme.of(context).primaryColor),
                      ),
                    ),
                    value: _selectedFilm,
                    onChanged: (Film? p) {
                      setState(() {
                        _selectedFilm = p!;
                      });
                    },
                    items: _film.map<DropdownMenuItem<Film>>((Film p) {
                      return DropdownMenuItem<Film>(
                        value: p,
                        child: Text(p.naziv),
                      );
                    }).toList(),
                  ),
                ),
                const SizedBox(width: 16.0, height: 16),
                ElevatedButton(
                  onPressed: () {
                    resetState();
                  },
                  child: const Text('Reset'),
                ),
                const SizedBox(width: 16.0),
                ElevatedButton(
                  onPressed: () {
                    loadData();
                  },
                  child: const Text('Pretraži'),
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
                  DataColumn(label: Text('Film')),
                  DataColumn(label: Text('Sala')),
                  DataColumn(label: Text('Datum izvodjenja')),
                  DataColumn(label: Text('Vrijeme odrzavanja')),
                  DataColumn(label: Text('Cijena karte')),
                  DataColumn(label: Text('Premijera')),
                  DataColumn(label: Text('Pretpremijera')),
                  DataColumn(label: Text('Karte')),
                  DataColumn(label: Text('Uredi')),
                  DataColumn(label: Text('Obriši')),
                ],
                rows: _kina!.isNotEmpty
                    ? _kina!.map((termin) {
                        return DataRow(cells: [
                          DataCell(
                            Tooltip(
                              message: termin.film!.naziv,
                              child: Text(
                                termin.film!.naziv.length > 20
                                    ? "${termin.film!.naziv.substring(0, 20)} ..."
                                    : termin.film!.naziv,
                              ),
                            ),
                          ),
                          DataCell(
                            Tooltip(
                              message: termin.dvorana!.naziv,
                              child: Text(
                                termin.dvorana!.naziv.length > 20
                                    ? "${termin.dvorana!.naziv.substring(0, 20)} ..."
                                    : termin.dvorana!.naziv,
                              ),
                            ),
                          ),
                          DataCell(Text(termin.datumOdrzavanja
                              .toString()
                              .substring(0, 10))),
                          DataCell(Text(termin.vrijemeOdrzavanja)),
                          DataCell(Text(termin.cijenaKarte.toString())),
                          DataCell(
                            Checkbox(
                              value: termin.premijera,
                              onChanged: (bool? s) {},
                              activeColor: Theme.of(context).primaryColor,
                            ),
                          ),
                          DataCell(
                            Checkbox(
                              value: termin.predpremijera,
                              onChanged: (bool? s) {},
                              activeColor: Theme.of(context).primaryColor,
                            ),
                          ),
                          DataCell(IconButton(
                            icon: Icon(Icons.apps_sharp,
                                color: Theme.of(context).primaryColor),
                            onPressed: () {
                              Navigator.pushNamed(
                                  context, KarteScreen.routeName,
                                  arguments: termin.terminId);
                            },
                          )),
                          DataCell(
                            IconButton(
                              icon: Icon(Icons.edit,
                                  color: Theme.of(context).primaryColor),
                              onPressed: () {
                                openEditModal(termin);
                              },
                            ),
                          ),
                          DataCell(
                            IconButton(
                              icon: const Icon(Icons.delete, color: Colors.red),
                              onPressed: () {
                                openDeleteModal(termin);
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
                          DataCell(Text('')),
                          DataCell(
                              Center(child: Text('Nema rezultata pretrage'))),
                          DataCell(Text('')),
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
