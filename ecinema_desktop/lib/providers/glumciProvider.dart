import 'package:ecinema_desktop/providers/baseProvider.dart';
import '../models/models.dart';

class GlumacProvider extends BaseProvider<Glumac> {
  GlumacProvider() : super("Glumac");

  @override
  Glumac fromJson(data) {
    return Glumac.fromJson(data);
  }
}
