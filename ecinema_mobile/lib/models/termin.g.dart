// GENERATED CODE - DO NOT MODIFY BY HAND

part of 'termin.dart';

// **************************************************************************
// JsonSerializableGenerator
// **************************************************************************

Termin _$TerminFromJson(Map<String, dynamic> json) => Termin(
      terminId: json['terminId'] as int,
      premijera: json['premijera'] as bool,
      predpremijera: json['predpremijera'] as bool,
      cijenaKarte: json['cijenaKarte'] as int,
      datumOdrzavanja: DateTime.parse(json['datumOdrzavanja'] as String),
      vrijemeOdrzavanja: json['vrijemeOdrzavanja'] as String,
      dvoranaId: json['dvoranaId'] as int?,
      dvorana: json['dvorana'] == null
          ? null
          : Dvorana.fromJson(json['dvorana'] as Map<String, dynamic>),
      filmId: json['filmId'] as int?,
      film: json['film'] == null
          ? null
          : Film.fromJson(json['film'] as Map<String, dynamic>),
    );

Map<String, dynamic> _$TerminToJson(Termin instance) => <String, dynamic>{
      'terminId': instance.terminId,
      'premijera': instance.premijera,
      'predpremijera': instance.predpremijera,
      'cijenaKarte': instance.cijenaKarte,
      'datumOdrzavanja': instance.datumOdrzavanja.toIso8601String(),
      'vrijemeOdrzavanja': instance.vrijemeOdrzavanja,
      'dvoranaId': instance.dvoranaId,
      'dvorana': instance.dvorana,
      'filmId': instance.filmId,
      'film': instance.film,
    };
