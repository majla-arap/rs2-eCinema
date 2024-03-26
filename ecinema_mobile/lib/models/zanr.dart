import 'package:json_annotation/json_annotation.dart';

part 'zanr.g.dart';

@JsonSerializable()
class Zanr {
  int zanrId;
  String naziv;

  Zanr({required this.zanrId, required this.naziv});

  factory Zanr.fromJson(Map<String, dynamic> json) => _$ZanrFromJson(json);
  Map<String, dynamic> toJson() => _$ZanrToJson(this);
}
