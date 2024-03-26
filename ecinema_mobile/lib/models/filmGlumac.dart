import 'package:ecinema_mobile/models/models.dart';
import 'package:json_annotation/json_annotation.dart';

part 'filmGlumac.g.dart';

@JsonSerializable()
class FilmGlumac {
  int filmGlumacId;
  int glumacId;
  int filmId;
  String nazivUloge;
  Glumac? glumac;
  Film? film;

  FilmGlumac({
    required this.filmGlumacId,
    required this.glumacId,
    required this.filmId,
    required this.nazivUloge,
    this.glumac,
    this.film,
  });
  factory FilmGlumac.fromJson(Map<String, dynamic> json) =>
      _$FilmGlumacFromJson(json);
  Map<String, dynamic> toJson() => _$FilmGlumacToJson(this);
}
