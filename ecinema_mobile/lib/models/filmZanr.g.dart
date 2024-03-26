// GENERATED CODE - DO NOT MODIFY BY HAND

part of 'filmZanr.dart';

// **************************************************************************
// JsonSerializableGenerator
// **************************************************************************

FilmZanr _$FilmZanrFromJson(Map<String, dynamic> json) => FilmZanr(
      filmZanrId: json['filmZanrId'] as int,
      zanrId: json['zanrId'] as int,
      filmId: json['filmId'] as int,
      zanr: json['zanr'] == null
          ? null
          : Zanr.fromJson(json['zanr'] as Map<String, dynamic>),
      film: json['film'] == null
          ? null
          : Film.fromJson(json['film'] as Map<String, dynamic>),
    );

Map<String, dynamic> _$FilmZanrToJson(FilmZanr instance) => <String, dynamic>{
      'filmZanrId': instance.filmZanrId,
      'zanrId': instance.zanrId,
      'filmId': instance.filmId,
      'zanr': instance.zanr,
      'film': instance.film,
    };
