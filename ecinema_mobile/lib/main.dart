import 'package:ecinema_mobile/screens/loginScreen.dart';
import 'package:ecinema_mobile/screens/mainNav.dart';
import 'package:flutter/material.dart';

void main() {
  runApp(const MyApp());
}

class MyApp extends StatelessWidget {
  const MyApp({super.key});

  @override
  Widget build(BuildContext context) {
    return MaterialApp(
      title: 'eCinema',
      theme: ThemeData(
        colorScheme: ColorScheme.fromSeed(seedColor: Colors.deepPurple),
        useMaterial3: true,
      ),
      initialRoute: '/login',
      routes: {
        LoginScreen.routeName: (context) => const LoginScreen(),
        MainNav.routeName: (context) => const MainNav(),
      },
    );
  }
}
