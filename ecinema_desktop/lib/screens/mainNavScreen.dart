import 'package:ecinema_desktop/screens/glumciScreen.dart';
import 'package:flutter/material.dart';

class NavigationItem {
  final String label;
  final Widget widget;

  NavigationItem({required this.label, required this.widget});
}

class MainNavScreen extends StatefulWidget {
  static const routeName = "/home";
  const MainNavScreen({super.key});

  @override
  State<MainNavScreen> createState() => _MainNavScreenState();
}

class _MainNavScreenState extends State<MainNavScreen> {
  int _selectedIndex = 0;
  static const TextStyle optionStyle =
      TextStyle(fontSize: 30, fontWeight: FontWeight.bold);

  final List<NavigationItem> _navigationItems = [
    NavigationItem(label: 'Glumci', widget: const GlumciScreen()),
    NavigationItem(
        label: 'Filmovi', widget: const Text('Filmovi', style: optionStyle)),
    NavigationItem(
        label: 'Zanrovi', widget: const Text('Zanrovi', style: optionStyle)),
    NavigationItem(
        label: 'Kina', widget: const Text('Kina', style: optionStyle)),
    NavigationItem(
        label: 'Obavijesti',
        widget: const Text('Obavijesti', style: optionStyle)),
    NavigationItem(
        label: 'Vrste obavijesti',
        widget: const Text('Vrste obavijesti', style: optionStyle)),
    NavigationItem(
        label: 'Zarada', widget: const Text('Zarada', style: optionStyle)),
    NavigationItem(
        label: 'Profil', widget: const Text('Profil', style: optionStyle)),
  ];

  void _onItemTapped(int index) {
    setState(() {
      _selectedIndex = index;
    });
  }

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(title: Text(_navigationItems[_selectedIndex].label)),
      body: Center(
        child: _navigationItems[_selectedIndex].widget,
      ),
      drawer: Drawer(
        // Add a ListView to the drawer. This ensures the user can scroll
        // through the options in the drawer if there isn't enough vertical
        // space to fit everything.
        child: ListView.builder(
          itemCount: _navigationItems.length,
          itemBuilder: (BuildContext context, int index) {
            return ListTile(
              title: Text(_navigationItems[index].label),
              selected: _selectedIndex == index,
              onTap: () {
                _onItemTapped(index);
                Navigator.pop(context);
              },
            );
          },
        ),
      ),
    );
  }
}
