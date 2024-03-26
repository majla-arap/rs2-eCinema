// GENERATED CODE - DO NOT MODIFY BY HAND

part of 'dvorana.dart';

// **************************************************************************
// JsonSerializableGenerator
// **************************************************************************

Dvorana _$DvoranaFromJson(Map<String, dynamic> json) => Dvorana(
      dvoranaId: json['dvoranaId'] as int,
      naziv: json['naziv'] as String,
      brSjedista: json['brSjedista'] as int,
      brRedova: json['brRedova'] as int,
      brSjedistaPoRedu: json['brSjedistaPoRedu'] as int,
      cinemaId: json['cinemaId'] as int?,
      cinema: json['cinema'] == null
          ? null
          : Cinema.fromJson(json['cinema'] as Map<String, dynamic>),
    );

Map<String, dynamic> _$DvoranaToJson(Dvorana instance) => <String, dynamic>{
      'dvoranaId': instance.dvoranaId,
      'naziv': instance.naziv,
      'brSjedista': instance.brSjedista,
      'brRedova': instance.brRedova,
      'brSjedistaPoRedu': instance.brSjedistaPoRedu,
      'cinemaId': instance.cinemaId,
      'cinema': instance.cinema,
    };
