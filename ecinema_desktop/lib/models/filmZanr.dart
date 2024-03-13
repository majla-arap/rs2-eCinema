import 'package:ecinema_desktop/models/models.dart';
import 'package:json_annotation/json_annotation.dart';

part 'filmZanr.g.dart';

@JsonSerializable()
class FilmZanr {
  int filmZanrId;
  int zanrId;
  int filmId;
  Zanr? zanr;
  Film? film;

  FilmZanr({
    required this.filmZanrId,
    required this.zanrId,
    required this.filmId,
    this.zanr,
    this.film,
  });
  factory FilmZanr.fromJson(Map<String, dynamic> json) =>
      _$FilmZanrFromJson(json);
  Map<String, dynamic> toJson() => _$FilmZanrToJson(this);
}
