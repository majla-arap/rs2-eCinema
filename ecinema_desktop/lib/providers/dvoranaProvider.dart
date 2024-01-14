import 'package:ecinema_desktop/providers/baseProvider.dart';
import '../models/models.dart';

class DvoranaProvider extends BaseProvider<Dvorana> {
  DvoranaProvider() : super("Dvorana");

  @override
  Dvorana fromJson(data) {
    return Dvorana.fromJson(data);
  }
}
