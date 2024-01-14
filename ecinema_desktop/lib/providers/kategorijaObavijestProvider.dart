import 'package:ecinema_desktop/providers/baseProvider.dart';

import '../models/models.dart';

class KategorijaObavijestProvider extends BaseProvider<KategorijaObavijest> {
  KategorijaObavijestProvider() : super("ObavijestKategorija");

  @override
  KategorijaObavijest fromJson(data) {
    return KategorijaObavijest.fromJson(data);
  }
}
