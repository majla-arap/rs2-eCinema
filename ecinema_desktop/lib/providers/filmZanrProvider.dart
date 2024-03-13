import 'package:ecinema_desktop/models/filmZanr.dart';
import 'package:ecinema_desktop/providers/baseProvider.dart';

class FilmZanrProvider extends BaseProvider<FilmZanr> {
  FilmZanrProvider() : super("FilmZanr");

  @override
  FilmZanr fromJson(data) {
    return FilmZanr.fromJson(data);
  }
}
