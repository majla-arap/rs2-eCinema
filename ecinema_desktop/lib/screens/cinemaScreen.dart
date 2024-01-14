import 'package:ecinema_desktop/models/cinema.dart';
import 'package:ecinema_desktop/providers/cinemaProvider.dart';
import 'package:ecinema_desktop/screens/dvoranaScreen.dart';
import 'package:ecinema_desktop/widgets/cinema/addCinemaModal.dart';
import 'package:ecinema_desktop/widgets/cinema/editCinemaModal.dart';
import 'package:flutter/material.dart';
import 'package:provider/provider.dart';

class CinemaScreen extends StatefulWidget {
  const CinemaScreen({super.key});

  @override
  State<CinemaScreen> createState() => _CinemaScreenState();
}

class _CinemaScreenState extends State<CinemaScreen> {
  CinemaProvider? _cinemaProvider;
  List<Cinema>? _cinema;
  final TextEditingController _searchController = TextEditingController();

  @override
  void initState() {
    super.initState();
    _cinemaProvider = context.read<CinemaProvider>();
    loadData();
  }

  void loadData() async {
    dynamic request = {'Text': _searchController.text};
    var data = await _cinemaProvider!.get(request);
    setState(() {
      _cinema = data;
    });
  }

  void resetSearch() {
    _searchController.text = '';
  }

  void handleEdit(int id, dynamic request) async {
    await _cinemaProvider!.update(id, request);
    if (context.mounted) {
      Navigator.pop(context);
      loadData();
      ScaffoldMessenger.of(context).showSnackBar(
        SnackBar(
          backgroundColor: Theme.of(context).primaryColor,
          content: const Text('Uspješno ste modifikovali podatke o kinu!'),
        ),
      );
    }
  }

  void openEditModal(Cinema p) {
    showDialog(
      context: context,
      builder: (BuildContext context) {
        return EditCinemaModal(cinema: p, handleEdit: handleEdit);
      },
    );
  }

  void openDeleteModal(Cinema p) {
    showDialog(
      context: context,
      builder: (BuildContext context) {
        return AlertDialog(
          title: const Text('Brisanje '),
          content: const Column(
            mainAxisSize: MainAxisSize.min,
            children: [
              Text('Da li ste sigurni da zelite da obrisete kina?'),
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
                  await _cinemaProvider!.remove(p.cinemaId);
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
                            Text('Ne možete obrisati cinema jer se koristi!'),
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
    await _cinemaProvider!.insert(request);
    if (context.mounted) {
      Navigator.pop(context);
      resetSearch();
      loadData();
      ScaffoldMessenger.of(context).showSnackBar(
        SnackBar(
          backgroundColor: Theme.of(context).primaryColor,
          content: const Text('Uspješno ste dodali novo kina!'),
        ),
      );
    }
  }

  void openAddModal() {
    showDialog(
      context: context,
      builder: (BuildContext context) {
        return AddCinemaModal(handleAdd: handleAdd);
      },
    );
  }

  @override
  Widget build(BuildContext context) {
    if (_cinema == null) {
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
                      labelText: 'Kino',
                      hintText: 'Unesite naziv kina',
                    ),
                  ),
                ),
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
                  DataColumn(label: Text('Naziv')),
                  DataColumn(label: Text('Adresa')),
                  DataColumn(label: Text('Web stranica')),
                  DataColumn(label: Text('Email')),
                  DataColumn(label: Text('Broj telefona')),
                  DataColumn(label: Text('Aktivan')),
                  DataColumn(label: Text('Uredi')),
                  DataColumn(label: Text('Obrisi')),
                  DataColumn(label: Text('Sale')),
                ],
                rows: _cinema!.isNotEmpty
                    ? _cinema!.map((cinema) {
                        return DataRow(cells: [
                          DataCell(
                            Tooltip(
                              message: cinema.naziv,
                              child: Text(
                                cinema.naziv.length > 20
                                    ? "${cinema.naziv.substring(0, 20)} ..."
                                    : cinema.naziv,
                              ),
                            ),
                          ),
                          DataCell(
                            Tooltip(
                              message: cinema.adresa,
                              child: Text(
                                cinema.adresa.length > 20
                                    ? "${cinema.adresa.substring(0, 20)} ..."
                                    : cinema.adresa,
                              ),
                            ),
                          ),
                          DataCell(
                            Tooltip(
                              message: cinema.webstranica,
                              child: Text(
                                cinema.webstranica.length > 20
                                    ? "${cinema.webstranica.substring(0, 20)} ..."
                                    : cinema.webstranica,
                              ),
                            ),
                          ),
                          DataCell(Text(cinema.email)),
                          DataCell(Text(cinema.brTelefona)),
                          DataCell(
                            Checkbox(
                              value: cinema.aktivan,
                              onChanged: (bool? s) {},
                              activeColor: Theme.of(context).primaryColor,
                            ),
                          ),
                          DataCell(
                            IconButton(
                              icon: Icon(Icons.edit,
                                  color: Theme.of(context).primaryColor),
                              onPressed: () {
                                openEditModal(cinema);
                              },
                            ),
                          ),
                          DataCell(
                            IconButton(
                              icon: const Icon(Icons.delete, color: Colors.red),
                              onPressed: () {
                                openDeleteModal(cinema);
                              },
                            ),
                          ),
                          DataCell(IconButton(
                            icon: Icon(Icons.theater_comedy,
                                color: Theme.of(context).primaryColor),
                            onPressed: () {
                              Navigator.pushNamed(
                                  context, DvoranaScreen.routeName,
                                  arguments: cinema.cinemaId);
                            },
                          )),
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
