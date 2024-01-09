import 'package:ecinema_desktop/providers/authProvider.dart';
import 'package:ecinema_desktop/screens/mainNavScreen.dart';
import 'package:ecinema_desktop/utils/utils.dart';
import 'package:flutter/material.dart';
import 'package:provider/provider.dart';

RegExp regexPassword = RegExp(r'^.{8,}$');
RegExp regexUserName = RegExp(r'^.{4,}$');

class LoginScreen extends StatefulWidget {
  static const routeName = "/login";
  const LoginScreen({super.key});

  @override
  State<LoginScreen> createState() => _LoginScreenState();
}

class _LoginScreenState extends State<LoginScreen> {
  AuthProvider? _authProvider;
  final formKey = GlobalKey<FormState>();
  String? userName;
  String? password;
  bool loginFailed = false;

  @override
  void initState() {
    super.initState();
    _authProvider = context.read<AuthProvider>();
  }

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(
        title: const Text('Dobrodošli na eCinema'),
      ),
      body: Padding(
        padding: const EdgeInsets.all(16.0),
        child: Center(
          child: SizedBox(
            width: 500,
            child: Form(
              key: formKey,
              child: Column(
                mainAxisAlignment: MainAxisAlignment.center,
                children: [
                  const SizedBox(height: 16.0),
                  TextFormField(
                    onSaved: (newValue) => userName = newValue,
                    validator: (value) {
                      if (value!.isEmpty) {
                        return "Ovo polje je obavezno";
                      }
                      if (!regexUserName.hasMatch(value)) {
                        return 'Korisničko ime mora sadržavati najmanje 4 karaktera!';
                      }
                    },
                    style: const TextStyle(
                        color: Color.fromARGB(255, 200, 197, 197)),
                    decoration: const InputDecoration(
                      labelText: 'Korisničko ime',
                      hintText: 'Korisničko ime',
                    ),
                  ),
                  const SizedBox(
                    height: 20,
                  ),
                  TextFormField(
                    onSaved: (newValue) => password = newValue,
                    validator: (value) {
                      if (value!.isEmpty) {
                        return "Ovo polje je obavezno";
                      }
                      if (!regexPassword.hasMatch(value)) {
                        return 'Lozinka mora sadržavati 8 karaktera!';
                      }
                      if (loginFailed) {
                        return "Pogrešno korisničko ime ili lozinka!";
                      }
                    },
                    obscureText: true,
                    autocorrect: false,
                    style: const TextStyle(
                        color: Color.fromARGB(255, 200, 197, 197)),
                    decoration: const InputDecoration(
                      labelText: 'Lozinka',
                      hintText: '********',
                    ),
                  ),
                  const SizedBox(height: 16.0),
                  if (loginFailed)
                    const Text(
                      'Login Failed',
                      style: TextStyle(color: Colors.red),
                    ),
                  const SizedBox(height: 16.0),
                  ElevatedButton(
                    style: ElevatedButton.styleFrom(
                      minimumSize: const Size(double.infinity, 50),
                    ),
                    onPressed: () async {
                      loginFailed = false;
                      if (formKey.currentState!.validate()) {
                        formKey.currentState!.save();
                        Map user = {
                          'korisnickoIme': userName,
                          'lozinka': password
                        };
                        try {
                          var data = await _authProvider!.loginAdmin(user);
                          if (context.mounted) {
                            _authProvider!
                                .setParameters(data!.korisnikId!.toInt());
                            Authorization.username = userName;
                            Authorization.password = password;
                            Authorization.korisnikId = data.korisnikId!.toInt();
                            Navigator.pushReplacementNamed(
                                context, MainNavScreen.routeName);
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
                    child: const Text('Login', style: TextStyle(fontSize: 20)),
                  ),
                ],
              ),
            ),
          ),
        ),
      ),
    );
  }
}
