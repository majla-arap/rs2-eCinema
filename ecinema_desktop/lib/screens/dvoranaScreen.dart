import 'package:ecinema_desktop/models/models.dart';
import 'package:ecinema_desktop/providers/dvoranaProvider.dart';
import 'package:ecinema_desktop/screens/terminiScreen.dart';
import 'package:ecinema_desktop/widgets/dvorana/EditDvoranaModal.dart';
import 'package:ecinema_desktop/widgets/dvorana/addDvoranaModal.dart';
import 'package:flutter/material.dart';
import 'package:provider/provider.dart';

class DvoranaScreen extends StatefulWidget {
  final int id;
  static const routeName = '/dvorane';
  const DvoranaScreen({super.key, required this.id});

  @override
  State<DvoranaScreen> createState() => _DvoranaScreenState();
}

class _DvoranaScreenState extends State<DvoranaScreen> {
  DvoranaProvider? _dvoranaProvider;
  List<Dvorana>? _dvorane;
  final TextEditingController _searchController = TextEditingController();

  @override
  void initState() {
    super.initState();
    _dvoranaProvider = context.read<DvoranaProvider>();
    loadData();
  }

  void loadData() async {
    var data = await _dvoranaProvider!.get({
      'CinemaId': widget.id,
      'Text': _searchController.text,
    });
    setState(() {
      _dvorane = data;
    });
  }

  void resetSearch() {
    _searchController.text = "";
  }

  void handleEdit(int id, dynamic request) async {
    await _dvoranaProvider!.update(id, request);
    if (context.mounted) {
      Navigator.pop(context);
      loadData();
      ScaffoldMessenger.of(context).showSnackBar(
        SnackBar(
          backgroundColor: Theme.of(context).primaryColor,
          content: const Text('Uspješno ste modifikovali podatke o dvorani!'),
        ),
      );
    }
  }

  void openEditModal(Dvorana s) {
    showDialog(
      context: context,
      builder: (BuildContext context) {
        return EditDvoranaModal(dvorana: s, handleEdit: handleEdit);
      },
    );
  }

  void openDeleteModal(Dvorana s) {
    showDialog(
      context: context,
      builder: (BuildContext context) {
        return AlertDialog(
          title: const Text('Brisanje'),
          content: const Column(
            mainAxisSize: MainAxisSize.min,
            children: [
              Text('Da li ste sigurni da želite da obrišete dvoranu?'),
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
                  await _dvoranaProvider!.remove(s.dvoranaId);
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
                        content: Text('Ne možete obrisati ovu dvoranu!'),
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
    request["dvoranaId"] = widget.id;
    await _dvoranaProvider!.insert(request);
    if (context.mounted) {
      Navigator.pop(context);
      resetSearch();
      loadData();
      ScaffoldMessenger.of(context).showSnackBar(
        SnackBar(
          backgroundColor: Theme.of(context).primaryColor,
          content: const Text('Uspješno ste dodali novu dvoranu!'),
        ),
      );
    }
  }

  void openAddModal() {
    showDialog(
      context: context,
      builder: (BuildContext context) {
        return AddDvoranaModal(handleAdd: handleAdd);
      },
    );
  }

  @override
  Widget build(BuildContext context) {
    if (_dvorane == null) {
      return const Center(child: CircularProgressIndicator());
    }
    return Scaffold(
      appBar: AppBar(
        title: const Text('Prikaz dvorana'),
      ),
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
                      labelText: 'Naziv dvorane',
                      hintText: 'Unesite naziv dvorane',
                    ),
                  ),
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
                  DataColumn(label: Text('Naziv')),
                  DataColumn(label: Text('Broj sjedista'), numeric: true),
                  DataColumn(label: Text('Broj redova'), numeric: true),
                  DataColumn(
                      label: Text('Broj sjedista po redu'), numeric: true),
                  DataColumn(
                    numeric: false,
                    label: Expanded(
                      child: Row(
                        mainAxisAlignment: MainAxisAlignment.center,
                        children: [Text("Uredi")],
                      ),
                    ),
                  ),
                  DataColumn(
                    numeric: false,
                    label: Expanded(
                      child: Row(
                        mainAxisAlignment: MainAxisAlignment.center,
                        children: [Text("Obrisi")],
                      ),
                    ),
                  ),
                  DataColumn(
                    numeric: false,
                    label: Expanded(
                      child: Row(
                        mainAxisAlignment: MainAxisAlignment.center,
                        children: [Text("Termini")],
                      ),
                    ),
                  ),
                ],
                rows: _dvorane!.isNotEmpty
                    ? _dvorane!.map((dvorana) {
                        return DataRow(
                          cells: [
                            DataCell(
                              Tooltip(
                                message: dvorana.naziv,
                                child: Text(
                                  dvorana.naziv.length > 20
                                      ? "${dvorana.naziv.substring(0, 20)} ..."
                                      : dvorana.naziv,
                                ),
                              ),
                            ),
                            DataCell(Text(dvorana.brSjedista.toString())),
                            DataCell(Text(dvorana.brRedova.toString())),
                            DataCell(Text(dvorana.brSjedistaPoRedu.toString())),
                            DataCell(
                              Center(
                                child: IconButton(
                                  icon: Icon(Icons.edit,
                                      color: Theme.of(context).primaryColor),
                                  onPressed: () {
                                    openEditModal(dvorana);
                                  },
                                ),
                              ),
                            ),
                            DataCell(
                              Center(
                                child: IconButton(
                                  icon: const Icon(Icons.delete,
                                      color: Colors.red),
                                  onPressed: () {
                                    openDeleteModal(dvorana);
                                  },
                                ),
                              ),
                            ),
                            DataCell(
                              Center(
                                child: IconButton(
                                  icon: Icon(Icons.date_range_rounded,
                                      color: Theme.of(context).primaryColor),
                                  onPressed: () {
                                    Navigator.pushNamed(
                                      context,
                                      TerminiScreen.routeName,
                                      arguments: dvorana.dvoranaId,
                                    );
                                  },
                                ),
                              ),
                            ),
                          ],
                        );
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
