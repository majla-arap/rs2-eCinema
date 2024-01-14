import 'package:ecinema_desktop/providers/baseProvider.dart';
import '../models/models.dart';

class ObavijestProvider extends BaseProvider<Obavijest> {
  ObavijestProvider() : super("Obavijest");

  @override
  Obavijest fromJson(data) {
    return Obavijest.fromJson(data);
  }
}
