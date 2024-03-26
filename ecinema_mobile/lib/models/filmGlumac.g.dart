// GENERATED CODE - DO NOT MODIFY BY HAND

part of 'filmGlumac.dart';

// **************************************************************************
// JsonSerializableGenerator
// **************************************************************************

FilmGlumac _$FilmGlumacFromJson(Map<String, dynamic> json) => FilmGlumac(
      filmGlumacId: json['filmGlumacId'] as int,
      glumacId: json['glumacId'] as int,
      filmId: json['filmId'] as int,
      nazivUloge: json['nazivUloge'] as String,
      glumac: json['glumac'] == null
          ? null
          : Glumac.fromJson(json['glumac'] as Map<String, dynamic>),
      film: json['film'] == null
          ? null
          : Film.fromJson(json['film'] as Map<String, dynamic>),
    );

Map<String, dynamic> _$FilmGlumacToJson(FilmGlumac instance) =>
    <String, dynamic>{
      'filmGlumacId': instance.filmGlumacId,
      'glumacId': instance.glumacId,
      'filmId': instance.filmId,
      'nazivUloge': instance.nazivUloge,
      'glumac': instance.glumac,
      'film': instance.film,
    };
