import 'dart:convert';
import 'package:ecinema_desktop/models/zarada.dart';
import 'package:ecinema_desktop/providers/baseProvider.dart';
import '../models/models.dart';

class FilmProvider extends BaseProvider<Film> {
  static String? _baseUrl;
  FilmProvider() : super("Film") {
    _baseUrl = const String.fromEnvironment("baseUrl",
        defaultValue: "http://localhost:5192/");
  }

  @override
  Film fromJson(data) {
    return Film.fromJson(data);
  }

  Future<Zarada> getZarada(int id) async {
    var url = "${_baseUrl}Predstava/zaradaReport/$id";
    var uri = Uri.parse(url);
    Map<String, String> headers = createHeaders();

    var response = await http!.get(uri, headers: headers);

    if (isValidResponseCode(response)) {
      var data = jsonDecode(response.body);
      return Zarada.fromJson(data);
    } else {
      throw Exception("Exception... handle this gracefully");
    }
  }
}
