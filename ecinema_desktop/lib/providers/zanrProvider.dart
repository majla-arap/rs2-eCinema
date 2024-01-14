import 'package:ecinema_desktop/providers/baseProvider.dart';
import '../models/models.dart';

class ZanrProvider extends BaseProvider<Zanr> {
  ZanrProvider() : super("Zanr");

  @override
  Zanr fromJson(data) {
    return Zanr.fromJson(data);
  }
}
