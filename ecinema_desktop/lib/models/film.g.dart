// GENERATED CODE - DO NOT MODIFY BY HAND

part of 'film.dart';

// **************************************************************************
// JsonSerializableGenerator
// **************************************************************************

Film _$FilmFromJson(Map<String, dynamic> json) => Film(
      filmId: json['filmId'] as int,
      naziv: json['naziv'] as String,
      sadrzaj: json['sadrzaj'] as String,
      slika: json['slika'] as String?,
      vrijemeTrajanje: json['vrijemeTrajanje'] as int,
      redatelj: json['redatelj'] as String,
      godina: json['godina'] as String,
      pocetakPrikazivanja:
          DateTime.parse(json['pocetakPrikazivanja'] as String),
    );

Map<String, dynamic> _$FilmToJson(Film instance) => <String, dynamic>{
      'filmId': instance.filmId,
      'naziv': instance.naziv,
      'sadrzaj': instance.sadrzaj,
      'slika': instance.slika,
      'vrijemeTrajanje': instance.vrijemeTrajanje,
      'redatelj': instance.redatelj,
      'godina': instance.godina,
      'pocetakPrikazivanja': instance.pocetakPrikazivanja.toIso8601String(),
    };
