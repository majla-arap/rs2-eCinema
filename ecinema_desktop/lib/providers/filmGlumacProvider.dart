import 'package:ecinema_desktop/providers/baseProvider.dart';
import '../models/models.dart';

class FilmGlumacProvider extends BaseProvider<FilmGlumac> {
  FilmGlumacProvider() : super("FilmGlumac");

  @override
  FilmGlumac fromJson(data) {
    return FilmGlumac.fromJson(data);
  }
}
