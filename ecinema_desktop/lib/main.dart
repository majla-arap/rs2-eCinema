import 'package:ecinema_desktop/models/models.dart';
import 'package:ecinema_desktop/providers/authProvider.dart';
import 'package:ecinema_desktop/providers/cinemaProvider.dart';
import 'package:ecinema_desktop/providers/dvoranaProvider.dart';
import 'package:ecinema_desktop/providers/filmGlumacProvider.dart';
import 'package:ecinema_desktop/providers/filmProvider.dart';
import 'package:ecinema_desktop/providers/glumciProvider.dart';
import 'package:ecinema_desktop/providers/kartaProvider.dart';
import 'package:ecinema_desktop/providers/kategorijaObavijestProvider.dart';
import 'package:ecinema_desktop/providers/korisnikProvider.dart';
import 'package:ecinema_desktop/providers/obavijestProvider.dart';
import 'package:ecinema_desktop/providers/terminiProvider.dart';
import 'package:ecinema_desktop/providers/zanrProvider.dart';
import 'package:ecinema_desktop/screens/loginScreen.dart';
import 'package:flutter/material.dart';
import 'package:provider/provider.dart';

import 'screens/mainNavScreen.dart';

void main() {
  runApp(
    MultiProvider(
      providers: [
        ChangeNotifierProvider(create: (_) => AuthProvider()),
        ChangeNotifierProvider(create: (_) => GlumacProvider()),
        ChangeNotifierProvider(create: (_) => KorisnikProvider()),
        ChangeNotifierProvider(create: (_) => KategorijaObavijestProvider()),
        ChangeNotifierProvider(create: (_) => ObavijestProvider()),
        ChangeNotifierProvider(create: (_) => CinemaProvider()),
        ChangeNotifierProvider(create: (_) => DvoranaProvider()),
        ChangeNotifierProvider(create: (_) => TerminProvider()),
        ChangeNotifierProvider(create: (_) => FilmProvider()),
        ChangeNotifierProvider(create: (_) => KartaProvider()),
        ChangeNotifierProvider(create: (_) => ZanrProvider()),
        ChangeNotifierProvider(create: (_) => FilmGlumacProvider()),
      ],
      child: const MyApp(),
    ),
  );
}

class MyApp extends StatelessWidget {
  const MyApp({super.key});

  // This widget is the root of your application.
  @override
  Widget build(BuildContext context) {
    return MaterialApp(
      title: 'Flutter Demo',
      theme: ThemeData(
        appBarTheme: const AppBarTheme(
            backgroundColor: Color.fromARGB(255, 41, 39, 39),
            titleTextStyle: TextStyle(
                color: Color.fromARGB(255, 200, 197, 197),
                fontWeight: FontWeight.bold,
                fontSize: 20)),
        scaffoldBackgroundColor: const Color.fromARGB(255, 41, 39, 39),
        elevatedButtonTheme: ElevatedButtonThemeData(
            style: ElevatedButton.styleFrom(
                backgroundColor: const Color.fromARGB(255, 154, 83, 219),
                foregroundColor: const Color.fromARGB(255, 200, 197, 197))),
        inputDecorationTheme: const InputDecorationTheme(
            hintStyle: TextStyle(color: Color.fromARGB(255, 80, 76, 76)),
            labelStyle: TextStyle(color: Color.fromARGB(255, 200, 197, 197)),
            focusedBorder: UnderlineInputBorder(
                borderSide:
                    BorderSide(color: Color.fromARGB(255, 200, 197, 197)))),
        dataTableTheme: DataTableThemeData(
            headingRowColor: MaterialStateColor.resolveWith(
                (states) => const Color.fromARGB(255, 154, 83, 219)),
            headingTextStyle:
                const TextStyle(color: Color.fromARGB(255, 200, 197, 197)),
            dataTextStyle:
                const TextStyle(color: Color.fromARGB(255, 200, 197, 197))),
        colorScheme: ColorScheme.fromSeed(
            seedColor: const Color.fromARGB(255, 154, 83, 219)),
        useMaterial3: true,
      ),
      initialRoute: '/login',
      routes: {
        LoginScreen.routeName: (context) => const LoginScreen(),
        MainNavScreen.routeName: (context) => const MainNavScreen(),
      },
      home: const LoginScreen(),
    );
  }
}
