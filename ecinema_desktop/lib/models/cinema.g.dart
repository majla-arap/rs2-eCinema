// GENERATED CODE - DO NOT MODIFY BY HAND

part of 'cinema.dart';

// **************************************************************************
// JsonSerializableGenerator
// **************************************************************************

Cinema _$CinemaFromJson(Map<String, dynamic> json) => Cinema(
      cinemaId: json['cinemaId'] as int,
      naziv: json['naziv'] as String,
      adresa: json['adresa'] as String,
      webstranica: json['webstranica'] as String,
      email: json['email'] as String,
      brTelefona: json['brTelefona'] as String,
      logo: json['logo'] as String?,
      aktivan: json['aktivan'] as bool,
    );

Map<String, dynamic> _$CinemaToJson(Cinema instance) => <String, dynamic>{
      'cinemaId': instance.cinemaId,
      'naziv': instance.naziv,
      'adresa': instance.adresa,
      'webstranica': instance.webstranica,
      'email': instance.email,
      'brTelefona': instance.brTelefona,
      'logo': instance.logo,
      'aktivan': instance.aktivan,
    };
