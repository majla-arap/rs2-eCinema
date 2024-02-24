import 'package:ecinema_desktop/models/filmGlumac.dart';
import 'package:ecinema_desktop/providers/filmGlumacProvider.dart';
import 'package:flutter/material.dart';
import 'package:provider/provider.dart';

class ListaGlumacaScreen extends StatefulWidget {
  static const routeName = '/lista-glumaca';
  final int filmId;
  final String naziv;
  const ListaGlumacaScreen({
    super.key,
    required this.filmId,
    required this.naziv,
  });

  @override
  State<ListaGlumacaScreen> createState() => _GlumciScreenState();
}

class _GlumciScreenState extends State<ListaGlumacaScreen> {
  FilmGlumacProvider? _provider;
  List<FilmGlumac>? _glumci;

  late TextEditingController filmController;

  @override
  void initState() {
    super.initState();
    _provider = context.read<FilmGlumacProvider>();
    filmController = TextEditingController(text: widget.naziv);
    loadData();
  }

  void loadData() async {
    dynamic request = {
      'FilmId': widget.filmId,
    };

    var data = await _provider!.get(request);
    setState(() {
      _glumci = data;
    });
  }

  void openDeleteModal(FilmGlumac fg) {
    if (_glumci!.length == 1) {
      ScaffoldMessenger.of(context).showSnackBar(
        const SnackBar(
          backgroundColor: Colors.red,
          content: Text('Film mora imati najmanje jednog glumca!'),
        ),
      );
      return;
    }
    showDialog(
      context: context,
      builder: (BuildContext context) {
        return AlertDialog(
          title: const Text('Brisanje'),
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
              onPressed: () async {
                try {
                  await _provider!.remove(fg.filmGlumacId);
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
                        content: Text('Ne možete da obrišete glumca!'),
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

  @override
  Widget build(BuildContext context) {
    if (_glumci == null) {
      return const Center(child: CircularProgressIndicator());
    }
    return Scaffold(
      appBar: AppBar(
        title: const Text('Lista glumaca'),
      ),
      body: Column(
        children: [
          const SizedBox(height: 20),
          Row(
            children: [
              const SizedBox(width: 16.0),
              Expanded(
                child: TextFormField(
                  enabled: false,
                  controller: filmController,
                  decoration: const InputDecoration(
                    labelText: 'Film',
                  ),
                ),
              ),
            ],
          ),
          const SizedBox(height: 16),
          SizedBox(
            height: 300,
            width: double.infinity,
            child: SingleChildScrollView(
              child: DataTable(
                columns: const [
                  DataColumn(label: Text('Naziv uloge')),
                  DataColumn(label: Text('Glumac')),
                  DataColumn(label: Text('Obrisi')),
                ],
                rows: _glumci!.isNotEmpty
                    ? _glumci!.map((glumac) {
                        return DataRow(cells: [
                          DataCell(Text(glumac.nazivUloge)),
                          DataCell(Text(glumac.glumac!.imePrezime)),
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
