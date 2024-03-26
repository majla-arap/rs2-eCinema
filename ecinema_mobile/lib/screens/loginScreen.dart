import 'package:ecinema_mobile/providers/authProvider.dart';
import 'package:ecinema_mobile/screens/mainNav.dart';
import 'package:ecinema_mobile/screens/registerScreen.dart';
import 'package:flutter/material.dart';
import 'package:provider/provider.dart';
import '../utils/util.dart';

RegExp regexLozinka = RegExp(r'^.{8,}$');
RegExp regexKorisnicko = RegExp(r'^.{4,}$');

class LoginScreen extends StatefulWidget {
  static const routeName = '/login';

  const LoginScreen({super.key});

  @override
  State<LoginScreen> createState() => _LoginScreenState();
}

class _LoginScreenState extends State<LoginScreen> {
  final formKey = GlobalKey<FormState>();
  String? korisnickoIme;
  String? lozinka;
  AuthProvider? _authProvider;
  bool loginFailed = false;

  @override
  void initState() {
    super.initState();
    _authProvider = context.read<AuthProvider>();
  }

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      backgroundColor: const Color.fromARGB(255, 86, 81, 81),
      body: Padding(
        padding: const EdgeInsets.symmetric(horizontal: 20),
        child: SingleChildScrollView(
          child: Column(
            children: [
              const SizedBox(
                height: 100,
              ),
              const Text(
                'eCinema',
                style: TextStyle(
                  fontSize: 50,
                  fontWeight: FontWeight.bold,
                  color: Color.fromARGB(225, 195, 178, 178),
                ),
              ),
              const SizedBox(
                height: 80,
              ),
              Form(
                key: formKey,
                child: Column(
                  children: [
                    TextFormField(
                      onSaved: (newValue) => korisnickoIme = newValue,
                      validator: (value) {
                        if (value!.isEmpty) {
                          return "Ovo polje je obavezno";
                        }
                        if (!regexKorisnicko.hasMatch(value)) {
                          return 'Korisničko ime mora sadržavati namjanje 4 karaktera!';
                        }
                      },
                      style: const TextStyle(
                          color: Color.fromARGB(225, 195, 178, 178)),
                      decoration: InputDecoration(
                        labelText: 'Korisničko ime',
                        hintText: 'Korisničko ime',
                        labelStyle: const TextStyle(
                            color: Color.fromARGB(225, 195, 178, 178)),
                        border: OutlineInputBorder(
                            borderRadius: BorderRadius.circular(15)),
                      ),
                    ),
                    const SizedBox(
                      height: 20,
                    ),
                    TextFormField(
                      onSaved: (newValue) => lozinka = newValue,
                      validator: (value) {
                        if (value!.isEmpty) {
                          return "Ovo polje je obavezno";
                        }
                        if (!regexLozinka.hasMatch(value)) {
                          return 'Lozinka mora sadržavati 8 karaktera!';
                        }
                        if (loginFailed) {
                          return "Pogrešno korisničko ime ili lozinka!";
                        }
                      },
                      obscureText: true,
                      autocorrect: false,
                      style: const TextStyle(
                          color: Color.fromARGB(225, 195, 178, 178)),
                      decoration: InputDecoration(
                        labelText: 'Lozinka',
                        labelStyle: const TextStyle(
                            color: Color.fromARGB(225, 195, 178, 178)),
                        border: OutlineInputBorder(
                            borderRadius: BorderRadius.circular(15)),
                        hintText: '********',
                      ),
                    ),
                  ],
                ),
              ),
              const SizedBox(
                height: 20,
              ),
              Container(
                height: 50,
                width: double.infinity,
                decoration: BoxDecoration(
                  color: const Color.fromARGB(225, 217, 217, 217),
                  borderRadius: BorderRadius.circular(10),
                ),
                child: InkWell(
                  onTap: () async {
                    loginFailed = false;
                    if (formKey.currentState!.validate()) {
                      formKey.currentState!.save();
                      Map user = {
                        'korisnickoIme': korisnickoIme,
                        'lozinka': lozinka
                      };
                      try {
                        var data = await _authProvider!.login(user);
                        if (context.mounted) {
                          _authProvider!
                              .setParameters(data!.korisnikId!.toInt());
                          Authorization.username = korisnickoIme;
                          Authorization.password = lozinka;
                          Navigator.popAndPushNamed(context, MainNav.routeName);
                        }
                      } on Exception catch (error) {
                        print(error.toString());
                        if (error.toString().contains("Bad request")) {
                          loginFailed = true;
                          formKey.currentState!.validate();
                        }
                      }
                    }
                  },
                  child: const Center(
                    child: Text(
                      'Prijavi se',
                      style: TextStyle(
                        color: Color.fromARGB(225, 86, 81, 81),
                        fontSize: 20,
                      ),
                    ),
                  ),
                ),
              ),
              const SizedBox(height: 20),
              Row(
                children: [
                  const SizedBox(width: 5),
                  const Text(
                    'Nemate račun?',
                    style: TextStyle(color: Color.fromARGB(225, 195, 178, 178)),
                  ),
                  const SizedBox(width: 20),
                  InkWell(
                    onTap: () =>
                        Navigator.pushNamed(context, RegisterScreen.routeName),
                    child: const Text(
                      'Registruj se ovdje.',
                      style: TextStyle(
                        fontWeight: FontWeight.bold,
                        color: Colors.white,
                      ),
                    ),
                  ),
                ],
              ),
            ],
          ),
        ),
      ),
    );
  }
}
