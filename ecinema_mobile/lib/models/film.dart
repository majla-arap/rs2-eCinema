import 'package:json_annotation/json_annotation.dart';

part 'film.g.dart';

@JsonSerializable()
class Film {
  int filmId;
  String naziv;
  String sadrzaj;
  String? slika;
  int vrijemeTrajanje;
  String redatelj;
  String godina;
  DateTime pocetakPrikazivanja;

  Film({
    required this.filmId,
    required this.naziv,
    required this.sadrzaj,
    this.slika,
    required this.vrijemeTrajanje,
    required this.redatelj,
    required this.godina,
    required this.pocetakPrikazivanja,
  });

  factory Film.fromJson(Map<String, dynamic> json) => _$FilmFromJson(json);
  Map<String, dynamic> toJson() => _$FilmToJson(this);
}
