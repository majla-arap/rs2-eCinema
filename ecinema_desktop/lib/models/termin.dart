import 'package:ecinema_desktop/models/models.dart';
import 'package:json_annotation/json_annotation.dart';

part 'termin.g.dart';

@JsonSerializable()
class Termin {
  int terminId;
  bool premijera;
  bool predpremijera;
  int cijenaKarte;
  DateTime datumOdrzavanja;
  String vrijemeOdrzavanja;
  int? dvoranaId;
  Dvorana? dvorana;
  int? filmId;
  Film? film;

  Termin(
      {required this.terminId,
      required this.premijera,
      required this.predpremijera,
      required this.cijenaKarte,
      required this.datumOdrzavanja,
      required this.vrijemeOdrzavanja,
      this.dvoranaId,
      this.dvorana,
      this.filmId,
      this.film});

  factory Termin.fromJson(Map<String, dynamic> json) => _$TerminFromJson(json);
  Map<String, dynamic> toJson() => _$TerminToJson(this);
}
