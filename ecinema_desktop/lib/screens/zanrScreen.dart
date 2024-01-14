import 'package:ecinema_desktop/models/zanr.dart';
import 'package:ecinema_desktop/providers/zanrProvider.dart';
import 'package:ecinema_desktop/widgets/zanr/addZanrModal.dart';
import 'package:ecinema_desktop/widgets/zanr/editZanrModal.dart';
import 'package:flutter/material.dart';
import 'package:provider/provider.dart';

class ZanrScreen extends StatefulWidget {
  const ZanrScreen({super.key});

  @override
  State<ZanrScreen> createState() => _ZanrScreenState();
}

class _ZanrScreenState extends State<ZanrScreen> {
  ZanrProvider? _ZanrProvider;
  List<Zanr>? _vf;
  final TextEditingController _searchController = TextEditingController();

  @override
  void initState() {
    super.initState();
    _ZanrProvider = context.read<ZanrProvider>();
    loadData();
  }

  void loadData() async {
    var data = await _ZanrProvider!.get({'Text': _searchController.text});
    setState(() {
      _vf = data;
    });
  }

  void resetSearch() {
    _searchController.text = '';
  }

  void handleEdit(int id, String naziv) async {
    await _ZanrProvider!.update(id, {
      'naziv': naziv,
    });
    if (context.mounted) {
      Navigator.pop(context);
      loadData();
      ScaffoldMessenger.of(context).showSnackBar(
        SnackBar(
          backgroundColor: Theme.of(context).primaryColor,
          content: const Text('Uspješno ste modifikovali zanr!'),
        ),
      );
    }
  }

  void openEditModal(Zanr v) {
    showDialog(
      context: context,
      builder: (BuildContext context) {
        return EditZanrModal(vf: v, handleEdit: handleEdit);
      },
    );
  }

  void openDeleteModal(Zanr v) {
    showDialog(
      context: context,
      builder: (BuildContext context) {
        return AlertDialog(
          title: const Text('Brisanje '),
          content: const Column(
            mainAxisSize: MainAxisSize.min,
            children: [
              Text('Da li ste sigurni da želite da obrišete zanr?'),
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
                  await _ZanrProvider!.remove(v.zanrId);
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
                            'Ne možete obrisati zanr jer postoji film vezana za njega.'),
                      ),
                    );
                  }
                }
              },
              child: const Text(
                'Obrisi',
                style: TextStyle(color: Colors.red),
              ),
            ),
          ],
        );
      },
    );
  }

  void handleAdd(String naziv) async {
    await _ZanrProvider!.insert({
      'naziv': naziv,
    });
    if (context.mounted) {
      Navigator.pop(context);
      resetSearch();
      loadData();
      ScaffoldMessenger.of(context).showSnackBar(
        SnackBar(
          backgroundColor: Theme.of(context).primaryColor,
          content: const Text('Uspješno ste dodali novu vrstu!'),
        ),
      );
    }
  }

  void openAddModal() {
    showDialog(
      context: context,
      builder: (BuildContext context) {
        return AddZanrModal(handleAdd: handleAdd);
      },
    );
  }

  @override
  Widget build(BuildContext context) {
    if (_vf == null) {
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
                  decoration: const InputDecoration(
                    labelText: 'Vrsta filma',
                    hintText: 'Unesite zanr ',
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
            height: 300,
            width: double.infinity,
            child: SingleChildScrollView(
              child: DataTable(
                columns: const [
                  DataColumn(label: Text('Naziv')),
                  DataColumn(label: Text('Uredi')),
                  DataColumn(label: Text('Obrisi')),
                ],
                rows: _vf!.isNotEmpty
                    ? _vf!.map((vPredstava) {
                        return DataRow(cells: [
                          DataCell(Text(vPredstava.naziv)),
                          DataCell(IconButton(
                            icon: Icon(Icons.edit,
                                color: Theme.of(context).primaryColor),
                            onPressed: () {
                              openEditModal(vPredstava);
                            },
                          )),
                          DataCell(IconButton(
                            icon: const Icon(Icons.delete, color: Colors.red),
                            onPressed: () {
                              openDeleteModal(vPredstava);
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
