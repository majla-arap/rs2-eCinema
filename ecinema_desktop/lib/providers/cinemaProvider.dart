import 'package:ecinema_desktop/providers/baseProvider.dart';
import '../models/models.dart';

class CinemaProvider extends BaseProvider<Cinema> {
  CinemaProvider() : super("Cinema");

  @override
  Cinema fromJson(data) {
    return Cinema.fromJson(data);
  }
}
