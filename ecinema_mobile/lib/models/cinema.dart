import 'package:json_annotation/json_annotation.dart';

part 'cinema.g.dart';

@JsonSerializable()
class Cinema {
  int cinemaId;
  String naziv;
  String adresa;
  String webstranica;
  String email;
  String brTelefona;
  String? logo;
  bool aktivan;

  Cinema(
      {required this.cinemaId,
      required this.naziv,
      required this.adresa,
      required this.webstranica,
      required this.email,
      required this.brTelefona,
      this.logo,
      required this.aktivan});

  factory Cinema.fromJson(Map<String, dynamic> json) => _$CinemaFromJson(json);
  Map<String, dynamic> toJson() => _$CinemaToJson(this);
}
