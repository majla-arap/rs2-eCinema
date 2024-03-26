import 'package:ecinema_mobile/models/cinema.dart';
import 'package:json_annotation/json_annotation.dart';

part 'dvorana.g.dart';

@JsonSerializable()
class Dvorana {
  int dvoranaId;
  String naziv;
  int brSjedista;
  int brRedova;
  int brSjedistaPoRedu;
  int? cinemaId;
  Cinema? cinema;

  Dvorana(
      {required this.dvoranaId,
      required this.naziv,
      required this.brSjedista,
      required this.brRedova,
      required this.brSjedistaPoRedu,
      this.cinemaId,
      this.cinema});

  factory Dvorana.fromJson(Map<String, dynamic> json) =>
      _$DvoranaFromJson(json);
  Map<String, dynamic> toJson() => _$DvoranaToJson(this);
}
