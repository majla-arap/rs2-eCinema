import 'package:ecinema_desktop/models/filmZanr.dart';
import 'package:ecinema_desktop/providers/filmZanrProvider.dart';
import 'package:flutter/material.dart';
import 'package:provider/provider.dart';

class ListaZanrovaScreen extends StatefulWidget {
  static const routeName = '/lista-zanrova';
  final int filmId;
  final String naziv;
  const ListaZanrovaScreen({
    super.key,
    required this.filmId,
    required this.naziv,
  });

  @override
  State<ListaZanrovaScreen> createState() => _ListaZanrovaScreenState();
}

class _ListaZanrovaScreenState extends State<ListaZanrovaScreen> {
  FilmZanrProvider? _provider;
  List<FilmZanr>? _zanrovi;

  late TextEditingController filmController;

  @override
  void initState() {
    super.initState();
    _provider = context.read<FilmZanrProvider>();
    filmController = TextEditingController(text: widget.naziv);
    loadData();
  }

  void loadData() async {
    dynamic request = {
      'FilmId': widget.filmId,
    };

    var data = await _provider!.get(request);
    setState(() {
      _zanrovi = data;
    });
  }

  void openDeleteModal(FilmZanr fz) {
    if (_zanrovi!.length == 1) {
      ScaffoldMessenger.of(context).showSnackBar(
        const SnackBar(
          backgroundColor: Colors.red,
          content: Text('Film mora imati najmanje jedan žanr!'),
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
              Text('Da li ste sigurni da želite da obrišete žanr?'),
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
                  await _provider!.remove(fz.filmZanrId);
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
                        content: Text('Ne možete da obrišete žanr!'),
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

  @override
  Widget build(BuildContext context) {
    if (_zanrovi == null) {
      return const Center(child: CircularProgressIndicator());
    }
    return Scaffold(
      appBar: AppBar(
        title: const Text('Lista žanrova'),
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
                  DataColumn(label: Text('Žanr')),
                  DataColumn(label: Text('Obrisi')),
                ],
                rows: _zanrovi!.isNotEmpty
                    ? _zanrovi!.map((zanr) {
                        return DataRow(cells: [
                          DataCell(Text(zanr.zanr!.naziv)),
                          DataCell(IconButton(
                            icon: const Icon(Icons.delete, color: Colors.red),
                            onPressed: () {
                              openDeleteModal(zanr);
                            },
                          )),
                        ]);
                      }).toList()
                    : [
                        const DataRow(cells: [
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
