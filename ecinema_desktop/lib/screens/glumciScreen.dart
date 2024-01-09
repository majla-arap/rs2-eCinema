import 'package:ecinema_desktop/models/glumac.dart';
import 'package:ecinema_desktop/providers/glumciProvider.dart';
import 'package:ecinema_desktop/widgets/glumac/addGlumacModal.dart';
import 'package:ecinema_desktop/widgets/glumac/editGlumacModal.dart';
import 'package:flutter/material.dart';
import 'package:provider/provider.dart';

class GlumciScreen extends StatefulWidget {
  const GlumciScreen({super.key});

  @override
  State<GlumciScreen> createState() => _GlumciScreenState();
}

class _GlumciScreenState extends State<GlumciScreen> {
  GlumacProvider? _glumacProvider;
  List<Glumac>? _glumci;
  final TextEditingController _searchController = TextEditingController();

  @override
  void initState() {
    super.initState();
    _glumacProvider = context.read<GlumacProvider>();
    loadData();
  }

  void loadData() async {
    var data = await _glumacProvider!.get({'Text': _searchController.text});
    setState(() {
      _glumci = data;
    });
  }

  void resetSearch() {
    _searchController.text = '';
  }

  void handleEdit(int id, String ime, String prezime) async {
    await _glumacProvider!.update(id, {
      'ime': ime,
      'prezime': prezime,
      'imePrezime': "$ime $prezime",
    });
    if (context.mounted) {
      Navigator.pop(context);
      loadData();
      ScaffoldMessenger.of(context).showSnackBar(
        SnackBar(
          backgroundColor: Theme.of(context).primaryColor,
          content: const Text('Uspješno ste modifikovali glumca!'),
        ),
      );
    }
  }

  void openEditModal(Glumac g) {
    showDialog(
      context: context,
      builder: (BuildContext context) {
        return EditGlumacModal(
          glumac: g,
          handleEdit: handleEdit,
        );
      },
    );
  }

  void openDeleteModal(Glumac g) {
    showDialog(
      context: context,
      builder: (BuildContext context) {
        return AlertDialog(
          title: const Text('Brisanje '),
          content: const Column(
            mainAxisSize: MainAxisSize.min,
            children: [
              Text('Da li ste sigurni da želite da obrišete glumca?'),
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
              style: ElevatedButton.styleFrom(backgroundColor: Colors.red),
              onPressed: () async {
                try {
                  await _glumacProvider!.remove(g.glumacId);
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
                            'Ne možete obrisati glumca jer već glumi u filmu!'),
                      ),
                    );
                  }
                }
              },
              child: const Text(
                'Obriši',
                style: TextStyle(color: Colors.white),
              ),
            ),
          ],
        );
      },
    );
  }

  void handleAdd(String ime, String prezime) async {
    await _glumacProvider!.insert({
      'ime': ime,
      'prezime': prezime,
      'imePrezime': "$ime $prezime",
    });
    if (context.mounted) {
      Navigator.pop(context);
      resetSearch();
      loadData();
      ScaffoldMessenger.of(context).showSnackBar(
        SnackBar(
          backgroundColor: Theme.of(context).primaryColor,
          content: const Text('Uspješno ste dodali novog glumca!'),
        ),
      );
    }
  }

  void openAddModal() {
    showDialog(
      context: context,
      builder: (BuildContext context) {
        return AddGlumacModal(handleAdd: handleAdd);
      },
    );
  }

  @override
  Widget build(BuildContext context) {
    if (_glumci == null) {
      return const Center(child: CircularProgressIndicator());
    }
    return Scaffold(
      body: Column(
        children: [
          Row(
            children: [
              const SizedBox(width: 16.0),
              Expanded(
                child: TextFormField(
                  controller: _searchController,
                  style: const TextStyle(
                      color: Color.fromARGB(255, 200, 197, 197)),
                  decoration: const InputDecoration(
                    labelText: 'Glumac',
                    hintText: 'Unesite naziv glumca',
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
            height: 520,
            width: double.infinity,
            child: SingleChildScrollView(
              child: DataTable(
                columns: const [
                  DataColumn(label: Text('Ime')),
                  DataColumn(label: Text('Prezime')),
                  DataColumn(label: Text('Uredi')),
                  DataColumn(label: Text('Obrisi')),
                ],
                rows: _glumci!.isNotEmpty
                    ? _glumci!.map((glumac) {
                        return DataRow(cells: [
                          DataCell(Text(glumac.ime)),
                          DataCell(Text(glumac.prezime)),
                          DataCell(IconButton(
                            icon: Icon(Icons.edit,
                                color: Theme.of(context).primaryColor),
                            onPressed: () {
                              openEditModal(glumac);
                            },
                          )),
                          DataCell(IconButton(
                            icon: const Icon(Icons.delete, color: Colors.red),
                            onPressed: () {
                              openDeleteModal(glumac);
                            },
                          )),
                        ]);
                      }).toList()
                    : [
                        const DataRow(cells: [
                          DataCell(Text('')),
                          DataCell(
                              Center(child: Text('Nema rezultata pretrage'))),
                          DataCell(Text('')),
                          DataCell(Text('')),
                        ])
                      ],
              ),
            ),
          ),
        ],
      ),
    );
  }
}
