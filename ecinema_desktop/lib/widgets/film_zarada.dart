import 'package:ecinema_desktop/models/zarada.dart';
import 'package:ecinema_desktop/providers/filmProvider.dart';
import 'package:flutter/material.dart';
import 'package:provider/provider.dart';

class FilmZarada extends StatefulWidget {
  final int filmId;
  const FilmZarada({
    super.key,
    required this.filmId,
  });

  @override
  State<FilmZarada> createState() => _FilmZaradaState();
}

class _FilmZaradaState extends State<FilmZarada> {
  FilmProvider? _predstavaProvider;
  Zarada? _zarada;
  @override
  void initState() {
    super.initState();
    _predstavaProvider = context.read<FilmProvider>();
    loadData();
  }

  void loadData() async {
    var data = await _predstavaProvider!.getZarada(widget.filmId);
    setState(() {
      _zarada = data;
    });
  }

  @override
  Widget build(BuildContext context) {
    if (_zarada == null) {
      return const Center(
        child: CircularProgressIndicator(),
      );
    }
    return Column(
      mainAxisSize: MainAxisSize.min,
      children: [
        Text(
          'Zarada: ${_zarada!.ukupnaZarada} KM',
          style: const TextStyle(
            fontSize: 20,
            fontWeight: FontWeight.bold,
          ),
        ),
        const SizedBox(height: 10),
        Text(
          'Broj termina: ${_zarada!.brTermina}',
          style: const TextStyle(
            fontSize: 20,
            fontWeight: FontWeight.bold,
          ),
        ),
        const SizedBox(height: 10),
        Text(
          'Broj prodatih karata: ${_zarada!.brKarata}',
          style: const TextStyle(
            fontSize: 20,
            fontWeight: FontWeight.bold,
          ),
        ),
      ],
    );
  }
}
