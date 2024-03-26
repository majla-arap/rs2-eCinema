import 'dart:convert';
import 'package:ecinema_mobile/providers/baseProvider.dart';
import '../models/models.dart';

class KartaProvider extends BaseProvider<Karta> {
  static String? _baseUrl;
  KartaProvider() : super("Karta") {
    _baseUrl = const String.fromEnvironment("baseUrl",
        defaultValue: "http://10.0.2.2:5192/");
  }

  @override
  Karta fromJson(data) {
    return Karta.fromJson(data);
  }

  Future<List<Karta>> getByTerminId(int id) async {
    var url = "$_baseUrl" + "Karta/getByTerminId/$id";
    var uri = Uri.parse(url);

    Map<String, String> headers = createHeaders();
    var response = await http!.get(uri, headers: headers);

    if (isValidResponseCode(response)) {
      var data = jsonDecode(response.body);
      return data.map((x) => Karta.fromJson(x)).cast<Karta>().toList();
    } else {
      throw Exception("Something went wrong");
    }
  }
}
