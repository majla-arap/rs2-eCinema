using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCinema.Services.Database
{
    public partial class eCinemaContext
    {
        partial void OnModelCreatingPartial(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Uloga>().HasData(new Uloga[]
             {
                new Uloga()
                {
                    UlogaId = 1,
                    Naziv = "Admin"
                },
                new Uloga()
                {
                    UlogaId = 2,
                    Naziv = "Kupac"
                }
            });

            modelBuilder.Entity<Korisnik>().HasData(new Korisnik[]
             {
                new Korisnik()
                {
                    KorisnikId = 1,
                    Ime = "Admin",
                    Prezime = "Admin",
                    KorisnickoIme = "admin",
                    Email = "admin@gmail.com",
                    BrTelefona = "062-859-752",
                    Aktivan = true,
                    LozinkaHash = "523l3SXvXt/OIGacFmI0PUlXkJM=",
                    LozinkaSalt = "ORNOSgr59Nd5PGJx/GNMKg=="
                },
                new Korisnik()
                {
                    KorisnikId = 2,
                    Ime = "Majla",
                    Prezime = "Arap",
                    KorisnickoIme = "majla123",
                    Email = "majla@gmail.com",
                    BrTelefona = "062-205-156",
                    Aktivan = true,
                    LozinkaHash = "523l3SXvXt/OIGacFmI0PUlXkJM=",
                    LozinkaSalt = "ORNOSgr59Nd5PGJx/GNMKg=="
                },
            });;

            modelBuilder.Entity<KorisnikUloge>().HasData(new KorisnikUloge[]
            {
                new KorisnikUloge()
                {
                    KorisnikUlogeId = 1,
                    KorisnikId = 1,
                    UlogaId = 1
                },
                new KorisnikUloge()
                {
                    KorisnikUlogeId = 2,
                    KorisnikId = 2,
                    UlogaId = 2
                },
           });
            modelBuilder.Entity<Glumac>().HasData(new Glumac[]
           {
                new Glumac()
                {
                    GlumacId = 1,
                    Ime = "Angelina",
                    Prezime = "Jolie",
                    ImePrezime = "Angelina Jolie"
                },
                new Glumac()
                {
                    GlumacId = 2,
                    Ime = "Brad",
                    Prezime = "Pitt",
                    ImePrezime = "Brad Pitt"
                },
                new Glumac()
                {
                    GlumacId = 3,
                    Ime = "Jennifer",
                    Prezime = "Lopez",
                    ImePrezime = "Jennifer Lopez"
                },
                new Glumac()
                {
                    GlumacId = 4,
                    Ime = "George",
                    Prezime = "Clooney",
                    ImePrezime = "George Clooney"
                },
          });
            modelBuilder.Entity<ObavijestKategorija>().HasData(new ObavijestKategorija[]
            {
                new ObavijestKategorija()
                {
                    ObavijestKategorijaId=1,
                    Naziv="Novosti"
                },
                new ObavijestKategorija()
                {
                    ObavijestKategorijaId=2,
                    Naziv="Vijesti"
                }
            });
            modelBuilder.Entity<Obavijest>().HasData(new Obavijest[]
            {
                new Obavijest()
                {
                    ObavijestId = 1,
                    Naslov = "Početak projekcije filma Spiderman",
                    Podnaslov = "Novi film oborio rekord",
                    Sadrzaj = "Otkako je izašao u kina film je oborio sve rekorde gledanosti. Karte za film Spiderman homecoming u prodaji od 14.2.2024. godine. Karte možete kupiti online ili na blagajni u našoj poslovnici.",
                    Slika = null,
                    DatumKreiranja = DateTime.Now,
                    KorisnikId = 1,
                    ObavijestKategorijaId = 1
                },
                new Obavijest()
                {
                    ObavijestId = 2,
                    Naslov = "Dan nezavisnosti",
                    Podnaslov = "Drzavni praznik",
                    Sadrzaj = "Povodom Dana nezavisnosti Bosne i Hercegovine u kino neće raditi, 01.03.2024. godine.",
                    Slika = null,
                    DatumKreiranja = DateTime.Now,
                    KorisnikId = 1,
                    ObavijestKategorijaId = 2
                }
            });
            modelBuilder.Entity<Zanr>().HasData(new Zanr[]
            {
                new Zanr()
                {
                    ZanrId = 1,
                    Naziv = "Drama",
                },
                new Zanr()
                {
                    ZanrId = 2,
                    Naziv = "Komedija",
                },
                new Zanr()
                {
                    ZanrId = 3,
                    Naziv = "Akcija",
                },
                new Zanr()
                {
                    ZanrId = 4,
                    Naziv = "Romansa",                    
                }
           });
            modelBuilder.Entity<Cinema>().HasData(new Cinema[]
            {
                new Cinema()
                {
                    CinemaId = 1,
                    Naziv = "Cinestar",
                    Adresa = "marsala tita br. 2",
                    Webstranica = "https://www.blitz-cinestar-bh.ba/cinestar-mostar",
                    Email = "info@cinestar.com",
                    BrTelefona = "036-550-128",
                    Aktivan = true,
                },
                new Cinema()
                {
                    CinemaId = 2,
                    Naziv = "cineplexx",
                    Adresa = "Plaza br. 21",
                    Webstranica = "https://www.cineplexx.ba/movies?date=2024-01-05&category=now&location=all",
                    Email = "info@cineplexx.com",
                    BrTelefona = "036-347-128",
                    Aktivan = true,
                }
           });
            modelBuilder.Entity<Dvorana>().HasData(new Dvorana[]
           {
                new Dvorana()
                {
                    DvoranaId = 1,
                    Naziv = "Velika sala",
                    BrSjedista = 150,
                    BrRedova = 10,
                    BrSjedistaPoRedu = 15,
                    CinemaId = 1
                },
                new Dvorana()
                {
                    DvoranaId = 2,
                    Naziv = "Mala sala",
                    BrSjedista = 100,
                    BrRedova = 10,
                    BrSjedistaPoRedu = 10,
                    CinemaId = 1
                },
                new Dvorana()
                {
                    DvoranaId = 3,
                    Naziv = "Velika sala",
                    BrSjedista = 150,
                    BrRedova = 10,
                    BrSjedistaPoRedu = 15,
                    CinemaId = 2
                },
                new Dvorana()
                {
                    DvoranaId = 4,
                    Naziv = "Mala sala",
                    BrSjedista = 100,
                    BrRedova = 10,
                    BrSjedistaPoRedu = 10,
                    CinemaId = 2
                }
          });
            modelBuilder.Entity<Film>().HasData(new Film[]
            {
                new Film()
                {
                    FilmId = 1,
                    Naziv = "Spiderman",
                    Sadrzaj = "Peter Parker, a shy and awkward high school student, is often bullied by people, including his best friend. His life changes when he is bitten by a genetically altered spider and gains superpowers.",
                    VrijemeTrajanje = 90,
                    Slika = null,
                    Redatelj = "Stan Lee",
                    Godina = "2023",
                    PocetakPrikazivanja = DateTime.Now,
                },
                new Film()
                {
                    FilmId = 2,
                    Naziv = "Ironman",
                    Sadrzaj = "When Tony Stark, an industrialist, is captured, he constructs a high-tech armoured suit to escape. Once he manages to escape, he decides to use his suit to fight against evil forces to save the world.",
                    VrijemeTrajanje = 90,
                    Slika = null,
                    Redatelj = "Stan Lee",
                    Godina = "2023",
                    PocetakPrikazivanja = DateTime.Now,
                },
                new Film()
                {
                    FilmId = 3,
                    Naziv = "Black widow",
                    Sadrzaj = "Natasha Romanoff, a member of the Avengers and a former KGB spy, is forced to confront her dark past when a conspiracy involving her old handler arises.",
                    Slika = null,
                    Redatelj = "Stan Lee",
                    Godina = "2023",
                    PocetakPrikazivanja = DateTime.Now,
                },
                new Film()
                {
                    FilmId = 4,
                    Naziv = "Thor",
                    Sadrzaj = "Thor is exiled by his father, Odin, the King of Asgard, to the Earth to live among mortals. When he lands on Earth, his trusted weapon Mjolnir is discovered and captured by S.H.I.E.L.D.",
                    VrijemeTrajanje = 90,
                    Slika = null,
                    Redatelj = "Stan Lee",
                    Godina = "2023",
                    PocetakPrikazivanja = DateTime.Now,
                },
                new Film()
                {
                    FilmId = 5,
                    Naziv = "Hulk",
                    Sadrzaj = "After being exposed to dangerous levels of radiation, a scientist, Bruce Banner, transforms into an angry green monster at the slightest hint of conflict.",
                    VrijemeTrajanje=90,
                    Slika = null,
                    Redatelj = "Stan Lee",
                    Godina = "2023",
                    PocetakPrikazivanja = DateTime.Now,
                },
                new Film()
                {
                    FilmId = 6,
                    Naziv = "Ant-man",
                    Sadrzaj = "Scott, a master thief, gains the ability to shrink in scale with the help of a futuristic suit. Now he must rise to the occasion of his superhero status and protect his secret from unsavoury elements.",
                    VrijemeTrajanje=90,
                    Slika = null,
                    Redatelj = "Stan Lee",
                    Godina = "2023",
                    PocetakPrikazivanja = DateTime.Now,
                }
           });

            modelBuilder.Entity<FilmZanr>().HasData(new FilmZanr[]
           {
                new FilmZanr()
                {
                    FilmZanrId = 1,
                    ZanrId = 2,
                    FilmId = 1,
                },
                 new FilmZanr()
                {
                    FilmZanrId = 2,
                    ZanrId = 2,
                    FilmId = 2,
                },
                  new FilmZanr()
                {
                    FilmZanrId = 3,
                    ZanrId = 2,
                    FilmId = 3,
                },
                   new FilmZanr()
                {
                    FilmZanrId = 4,
                    ZanrId = 1,
                    FilmId = 4,
                },
                    new FilmZanr()
                {
                    FilmZanrId = 5,
                    ZanrId = 1,
                    FilmId = 5,
                },
                     new FilmZanr()
                {
                    FilmZanrId = 6,
                    ZanrId = 1,
                    FilmId = 6,
                },
                      new FilmZanr()
                {
                    FilmZanrId = 7,
                    ZanrId = 2,
                    FilmId = 6,                    
                }
          });
            modelBuilder.Entity<FilmGlumac>().HasData(new FilmGlumac[]
           {
                new FilmGlumac()
                {
                    FilmGlumacId = 1,
                    GlumacId = 2,
                    FilmId = 1,
                    NazivUloge = "Spiderman"
                },
                 new FilmGlumac()
                {
                    FilmGlumacId = 2,
                    GlumacId = 2,
                    FilmId = 2,
                    NazivUloge = "Ironman"
                },
                  new FilmGlumac()
                {
                    FilmGlumacId = 3,
                    GlumacId = 2,
                    FilmId = 3,
                    NazivUloge ="Black widow"
                },
                   new FilmGlumac()
                {
                    FilmGlumacId = 4,
                    GlumacId = 1,
                    FilmId = 4,
                    NazivUloge = "Thor"
                },
                    new FilmGlumac()
                {
                    FilmGlumacId = 5,
                    GlumacId = 1,
                    FilmId = 5,
                    NazivUloge = "Hulk"
                },
                     new FilmGlumac()
                {
                    FilmGlumacId = 6,
                    GlumacId = 1,
                    FilmId = 6,
                    NazivUloge = "Antman"
                },
                      new FilmGlumac()
                {
                    FilmGlumacId = 7,
                    GlumacId = 2,
                    FilmId = 6,
                    NazivUloge = "Antman"
                }
          });
            modelBuilder.Entity<Termin>().HasData(new Termin[]
           {
                new Termin()
                {
                    TerminId = 1,
                    DvoranaId = 1,
                    FilmId = 1,
                    Predpremijera = true,
                    Premijera = false,
                    CijenaKarte = 20,
                    DatumOdrzavanja = DateTime.Now.Date,
                    VrijemeOdrzavanja = "20:00"
                },
                new Termin()
                {
                    TerminId = 2,
                    DvoranaId = 2,
                    FilmId = 2,
                    Predpremijera = true,
                    Premijera = false,
                    CijenaKarte = 10,
                    DatumOdrzavanja = DateTime.Now.Date.AddDays(2),
                    VrijemeOdrzavanja = "20:00"
                },
                new Termin()
                {
                    TerminId = 3,
                    DvoranaId = 2,
                    FilmId = 3,
                    Predpremijera = true,
                    Premijera = false,
                    CijenaKarte = 20,
                    DatumOdrzavanja = DateTime.Now.Date.AddDays(3),
                    VrijemeOdrzavanja = "20:00"
                },new Termin()
                {
                    TerminId = 4,
                    DvoranaId = 2,
                    FilmId = 4,
                    Predpremijera = true,
                    Premijera = false,
                    CijenaKarte = 20,
                    DatumOdrzavanja = DateTime.Now.Date.AddDays(2),
                    VrijemeOdrzavanja = "18:00"
                },
                new Termin()
                {
                    TerminId = 5,
                    DvoranaId = 2,
                    FilmId = 5,
                    Predpremijera = true,
                    Premijera = false,
                    CijenaKarte = 10,
                    DatumOdrzavanja = DateTime.Now.Date,
                    VrijemeOdrzavanja = "18:00"
                },
                new Termin()
                {
                    TerminId = 6,
                    DvoranaId = 2,
                    FilmId = 6,
                    Predpremijera = true,
                    Premijera = false,
                    CijenaKarte = 10,
                    DatumOdrzavanja = DateTime.Now.Date.AddDays(3),
                    VrijemeOdrzavanja = "18:00"
                }
           });
            modelBuilder.Entity<Kartum>().HasData(new Kartum[]
            {
                new Kartum()
                {
                    KartaId = 1,
                    Aktivna = false,
                    TerminId = 1,
                    BrojSjedista = 1,
                    BrojReda = "A",
                    Sjediste = "A1",
                    KupovinaId = 1
                },
                new Kartum()
                {
                    KartaId = 2,
                    Aktivna = false,
                    TerminId = 1,
                    BrojSjedista = 2,
                    BrojReda = "A",
                    Sjediste = "A2",
                    KupovinaId = 1
                },
                 new Kartum()
                {
                    KartaId = 3,
                    Aktivna = true,
                    TerminId = 1,
                    BrojSjedista = 3,
                    BrojReda = "A",
                    Sjediste = "A3"
                },
                new Kartum()
                {
                    KartaId = 4,
                    Aktivna = true,
                    TerminId = 1,
                    BrojSjedista = 4,
                    BrojReda = "A",
                    Sjediste = "A4"
                },
                 new Kartum()
                {
                    KartaId = 5,
                    Aktivna = true,
                    TerminId = 1,
                    BrojSjedista = 5,
                    BrojReda = "A",
                    Sjediste = "A5"
                },
                new Kartum()
                {
                    KartaId = 6,
                    Aktivna = true,
                    TerminId = 1,
                    BrojSjedista = 6,
                    BrojReda = "A",
                    Sjediste = "A6"
                },
                 new Kartum()
                {
                    KartaId = 7,
                    Aktivna = true,
                    TerminId = 1,
                    BrojSjedista = 7,
                    BrojReda = "A",
                    Sjediste = "A7"
                },
                new Kartum()
                {
                    KartaId = 8,
                    Aktivna = true,
                    TerminId = 1,
                    BrojSjedista = 8,
                    BrojReda = "A",
                    Sjediste = "A8"
                },
                 new Kartum()
                {
                    KartaId = 9,
                    Aktivna = true,
                    TerminId = 1,
                    BrojSjedista = 9,
                    BrojReda = "A",
                    Sjediste = "A9"
                },
                new Kartum()
                {
                    KartaId = 10,
                    Aktivna = true,
                    TerminId = 1,
                    BrojSjedista = 10,
                    BrojReda = "A",
                    Sjediste = "A10"
                },
                 new Kartum()
                {
                    KartaId = 11,
                    Aktivna = true,
                    TerminId = 1,
                    BrojSjedista = 11,
                    BrojReda = "A",
                    Sjediste = "A11"
                },
                new Kartum()
                {
                    KartaId = 12,
                    Aktivna = true,
                    TerminId = 1,
                    BrojSjedista = 12,
                    BrojReda = "A",
                    Sjediste = "A12"
                },
                 new Kartum()
                {
                    KartaId = 13,
                    Aktivna = true,
                    TerminId = 1,
                    BrojSjedista = 13,
                    BrojReda = "A",
                    Sjediste = "A13"
                },
                new Kartum()
                {
                    KartaId = 14,
                    Aktivna = true,
                    TerminId = 1,
                    BrojSjedista = 14,
                    BrojReda = "A",
                    Sjediste = "A14"
                },
                 new Kartum()
                 {
                    KartaId = 15,
                    Aktivna = true,
                    TerminId = 1,
                    BrojSjedista = 15,
                    BrojReda = "A",
                    Sjediste = "A15"
                },
                new Kartum()
                {
                    KartaId = 16,
                    Aktivna = true,
                    TerminId = 1,
                    BrojSjedista = 1,
                    BrojReda = "B",
                    Sjediste = "B1"
                },
                new Kartum()
                {
                    KartaId = 17,
                    Aktivna = true,
                    TerminId = 1,
                    BrojSjedista = 2,
                    BrojReda = "B",
                    Sjediste = "B2"
                },
                new Kartum()
                {
                    KartaId = 18,
                    Aktivna = true,
                    TerminId = 1,
                    BrojSjedista = 3,
                    BrojReda = "B",
                    Sjediste = "B3"
                },
                new Kartum()
                {
                    KartaId = 19,
                    Aktivna = true,
                    TerminId = 1,
                    BrojSjedista = 4,
                    BrojReda = "B",
                    Sjediste = "B4"
                },
                new Kartum()
                {
                    KartaId = 20,
                    Aktivna = true,
                    TerminId = 1,
                    BrojSjedista = 5,
                    BrojReda = "B",
                    Sjediste = "B5"
                },
                new Kartum()
                {
                    KartaId = 21,
                    Aktivna = true,
                    TerminId = 1,
                    BrojSjedista = 6,
                    BrojReda = "B",
                    Sjediste = "B6"
                },
                new Kartum()
                {
                    KartaId = 22,
                    Aktivna = true,
                    TerminId = 1,
                    BrojSjedista = 7,
                    BrojReda = "B",
                    Sjediste = "B7"
                },
                new Kartum()
                {
                    KartaId = 23,
                    Aktivna = true,
                    TerminId = 1,
                    BrojSjedista = 8,
                    BrojReda = "B",
                    Sjediste = "B8"
                },
                new Kartum()
                {
                    KartaId = 24,
                    Aktivna = true,
                    TerminId = 1,
                    BrojSjedista = 9,
                    BrojReda = "B",
                    Sjediste = "B9"
                },
                new Kartum()
                {
                    KartaId = 25,
                    Aktivna = true,
                    TerminId = 1,
                    BrojSjedista = 10,
                    BrojReda = "B",
                    Sjediste = "B10"
                },
                new Kartum()
                {
                    KartaId = 26,
                    Aktivna = true,
                    TerminId = 1,
                    BrojSjedista = 11,
                    BrojReda = "B",
                    Sjediste = "B11"
                },
                new Kartum()
                {
                    KartaId = 27,
                    Aktivna = true,
                    TerminId = 1,
                    BrojSjedista = 12,
                    BrojReda = "B",
                    Sjediste = "B12"
                },
                new Kartum()
                {
                    KartaId = 28,
                    Aktivna = true,
                    TerminId = 1,
                    BrojSjedista = 13,
                    BrojReda = "B",
                    Sjediste = "B13"
                },
                new Kartum()
                {
                    KartaId = 29,
                    Aktivna = true,
                    TerminId = 1,
                    BrojSjedista = 14,
                    BrojReda = "B",
                    Sjediste = "B14"
                },
                new Kartum()
                {
                    KartaId = 30,
                    Aktivna = true,
                    TerminId = 1,
                    BrojSjedista = 15,
                    BrojReda = "B",
                    Sjediste = "B15"
                },
                new Kartum()
                {
                    KartaId = 31,
                    Aktivna = true,
                    TerminId = 1,
                    BrojSjedista = 1,
                    BrojReda = "C",
                    Sjediste = "C1"
                },
                new Kartum()
                {
                    KartaId = 32,
                    Aktivna = true,
                    TerminId = 1,
                    BrojSjedista = 2,
                    BrojReda = "C",
                    Sjediste = "C2"
                },
                new Kartum()
                {
                    KartaId = 33,
                    Aktivna = true,
                    TerminId = 1,
                    BrojSjedista = 3,
                    BrojReda = "C",
                    Sjediste = "C3"
                },
                new Kartum()
                {
                    KartaId = 34,
                    Aktivna = true,
                    TerminId = 1,
                    BrojSjedista = 4,
                    BrojReda = "C",
                    Sjediste = "C4"
                },
                new Kartum()
                {
                    KartaId = 35,
                    Aktivna = true,
                    TerminId = 1,
                    BrojSjedista = 5,
                    BrojReda = "C",
                    Sjediste = "C5"
                },
                new Kartum()
                {
                    KartaId = 36,
                    Aktivna = true,
                    TerminId = 1,
                    BrojSjedista = 6,
                    BrojReda = "C",
                    Sjediste = "C6"
                },
                new Kartum()
                {
                    KartaId = 37,
                    Aktivna = true,
                    TerminId = 1,
                    BrojSjedista = 7,
                    BrojReda = "C",
                    Sjediste = "C7"
                },
                new Kartum()
                {
                    KartaId = 38,
                    Aktivna = true,
                    TerminId = 1,
                    BrojSjedista = 8,
                    BrojReda = "C",
                    Sjediste = "C8"
                },
                new Kartum()
                {
                    KartaId = 39,
                    Aktivna = true,
                    TerminId = 1,
                    BrojSjedista = 9,
                    BrojReda = "C",
                    Sjediste = "C9"
                },
                new Kartum()
                {
                    KartaId = 40,
                    Aktivna = true,
                    TerminId = 1,
                    BrojSjedista = 10,
                    BrojReda = "C",
                    Sjediste = "C10"
                },
                new Kartum()
                {
                    KartaId = 41,
                    Aktivna = true,
                    TerminId = 1,
                    BrojSjedista = 11,
                    BrojReda = "C",
                    Sjediste = "C11"
                },
                new Kartum()
                {
                    KartaId = 42,
                    Aktivna = true,
                    TerminId = 1,
                    BrojSjedista = 12,
                    BrojReda = "C",
                    Sjediste = "C12"
                },
                new Kartum()
                {
                    KartaId = 43,
                    Aktivna = true,
                    TerminId = 1,
                    BrojSjedista = 13,
                    BrojReda = "C",
                    Sjediste = "C13"
                },
                new Kartum()
                {
                    KartaId = 44,
                    Aktivna = true,
                    TerminId = 1,
                    BrojSjedista = 14,
                    BrojReda = "C",
                    Sjediste = "C14"
                },
                new Kartum()
                {
                    KartaId = 45,
                    Aktivna = true,
                    TerminId = 1,
                    BrojSjedista = 15,
                    BrojReda = "C",
                    Sjediste = "C15"
                },
                new Kartum()
                {
                    KartaId = 46,
                    Aktivna = true,
                    TerminId = 1,
                    BrojSjedista = 1,
                    BrojReda = "D",
                    Sjediste = "D1"
                },
                new Kartum()
                {
                    KartaId = 47,
                    Aktivna = true,
                    TerminId = 1,
                    BrojSjedista = 2,
                    BrojReda = "D",
                    Sjediste = "D2"
                },
                new Kartum()
                {
                    KartaId = 48,
                    Aktivna = true,
                    TerminId = 1,
                    BrojSjedista = 3,
                    BrojReda = "D",
                    Sjediste = "D3"
                },
                new Kartum()
                {
                    KartaId = 49,
                    Aktivna = true,
                    TerminId = 1,
                    BrojSjedista = 4,
                    BrojReda = "D",
                    Sjediste = "D4"
                },
                new Kartum()
                {
                    KartaId = 50,
                    Aktivna = true,
                    TerminId = 1,
                    BrojSjedista = 5,
                    BrojReda = "D",
                    Sjediste = "D5"
                },
                new Kartum()
                {
                    KartaId = 51,
                    Aktivna = true,
                    TerminId = 1,
                    BrojSjedista = 6,
                    BrojReda = "D",
                    Sjediste = "D6"
                },
                new Kartum()
                {
                    KartaId = 52,
                    Aktivna = true,
                    TerminId = 1,
                    BrojSjedista = 7,
                    BrojReda = "D",
                    Sjediste = "D7"
                },
                new Kartum()
                {
                    KartaId = 53,
                    Aktivna = true,
                    TerminId = 1,
                    BrojSjedista = 8,
                    BrojReda = "D",
                    Sjediste = "D8"
                },
                new Kartum()
                {
                    KartaId = 54,
                    Aktivna = true,
                    TerminId = 1,
                    BrojSjedista = 9,
                    BrojReda = "D",
                    Sjediste = "D9"
                },
                new Kartum()
                {
                    KartaId = 55,
                    Aktivna = true,
                    TerminId = 1,
                    BrojSjedista = 10,
                    BrojReda = "D",
                    Sjediste = "D10"
                },
                new Kartum()
                {
                    KartaId = 56,
                    Aktivna = true,
                    TerminId = 1,
                    BrojSjedista = 11,
                    BrojReda = "D",
                    Sjediste = "D11"
                },
                new Kartum()
                {
                    KartaId = 57,
                    Aktivna = true,
                    TerminId = 1,
                    BrojSjedista = 12,
                    BrojReda = "D",
                    Sjediste = "D12"
                },
                new Kartum()
                {
                    KartaId = 58,
                    Aktivna = true,
                    TerminId = 1,
                    BrojSjedista = 13,
                    BrojReda = "D",
                    Sjediste = "D13"
                },
                new Kartum()
                {
                    KartaId = 59,
                    Aktivna = true,
                    TerminId = 1,
                    BrojSjedista = 14,
                    BrojReda = "D",
                    Sjediste = "D14"
                },
                new Kartum()
                {
                    KartaId = 60,
                    Aktivna = true,
                    TerminId = 1,
                    BrojSjedista = 15,
                    BrojReda = "D",
                    Sjediste = "D15"
                },
                new Kartum()
                {
                    KartaId = 61,
                    Aktivna = true,
                    TerminId = 1,
                    BrojSjedista = 1,
                    BrojReda = "E",
                    Sjediste = "E1"
                },
                new Kartum()
                {
                    KartaId = 62,
                    Aktivna = true,
                    TerminId = 1,
                    BrojSjedista = 2,
                    BrojReda = "E",
                    Sjediste = "E2"
                },
                new Kartum()
                {
                    KartaId = 63,
                    Aktivna = true,
                    TerminId = 1,
                    BrojSjedista = 3,
                    BrojReda = "E",
                    Sjediste = "E3"
                },
                new Kartum()
                {
                    KartaId = 64,
                    Aktivna = true,
                    TerminId = 1,
                    BrojSjedista = 4,
                    BrojReda = "E",
                    Sjediste = "E4"
                },
                new Kartum()
                {
                    KartaId = 65,
                    Aktivna = true,
                    TerminId = 1,
                    BrojSjedista = 5,
                    BrojReda = "E",
                    Sjediste = "E5"
                },
                new Kartum()
                {
                    KartaId = 66,
                    Aktivna = true,
                    TerminId = 1,
                    BrojSjedista = 6,
                    BrojReda = "E",
                    Sjediste = "E6"
                },
                new Kartum()
                {
                    KartaId = 67,
                    Aktivna = true,
                    TerminId = 1,
                    BrojSjedista = 7,
                    BrojReda = "E",
                    Sjediste = "E7"
                },
                new Kartum()
                {
                    KartaId = 68,
                    Aktivna = true,
                    TerminId = 1,
                    BrojSjedista = 8,
                    BrojReda = "E",
                    Sjediste = "E8"
                },
                new Kartum()
                {
                    KartaId = 69,
                    Aktivna = true,
                    TerminId = 1,
                    BrojSjedista = 9,
                    BrojReda = "E",
                    Sjediste = "E9"
                },
                new Kartum()
                {
                    KartaId = 70,
                    Aktivna = true,
                    TerminId = 1,
                    BrojSjedista = 10,
                    BrojReda = "E",
                    Sjediste = "E10"
                },
                new Kartum()
                {
                    KartaId = 71,
                    Aktivna = true,
                    TerminId = 1,
                    BrojSjedista = 11,
                    BrojReda = "E",
                    Sjediste = "E11"
                },
                new Kartum()
                {
                    KartaId = 72,
                    Aktivna = true,
                    TerminId = 1,
                    BrojSjedista = 12,
                    BrojReda = "E",
                    Sjediste = "E12"
                },
                new Kartum()
                {
                    KartaId = 73,
                    Aktivna = true,
                    TerminId = 1,
                    BrojSjedista = 13,
                    BrojReda = "E",
                    Sjediste = "E13"
                },
                new Kartum()
                {
                    KartaId = 74,
                    Aktivna = true,
                    TerminId = 1,
                    BrojSjedista = 14,
                    BrojReda = "E",
                    Sjediste = "E14"
                },
                new Kartum()
                {
                    KartaId = 75,
                    Aktivna = true,
                    TerminId = 1,
                    BrojSjedista = 15,
                    BrojReda = "E",
                    Sjediste = "E15"
                },
                new Kartum()
                {
                    KartaId = 76,
                    Aktivna = true,
                    TerminId = 1,
                    BrojSjedista = 1,
                    BrojReda = "F",
                    Sjediste = "F1"
                },
                new Kartum()
                {
                    KartaId = 77,
                    Aktivna = true,
                    TerminId = 1,
                    BrojSjedista = 2,
                    BrojReda = "F",
                    Sjediste = "F2"
                },
                new Kartum()
                {
                    KartaId = 78,
                    Aktivna = true,
                    TerminId = 1,
                    BrojSjedista = 3,
                    BrojReda = "F",
                    Sjediste = "F3"
                },
                new Kartum()
                {
                    KartaId = 79,
                    Aktivna = true,
                    TerminId = 1,
                    BrojSjedista = 4,
                    BrojReda = "F",
                    Sjediste = "F4"
                },
                new Kartum()
                {
                    KartaId = 80,
                    Aktivna = true,
                    TerminId = 1,
                    BrojSjedista = 5,
                    BrojReda = "F",
                    Sjediste = "F5"
                },
                new Kartum()
                {
                    KartaId = 81,
                    Aktivna = true,
                    TerminId = 1,
                    BrojSjedista = 6,
                    BrojReda = "F",
                    Sjediste = "F6"
                },
                new Kartum()
                {
                    KartaId = 82,
                    Aktivna = true,
                    TerminId = 1,
                    BrojSjedista = 7,
                    BrojReda = "F",
                    Sjediste = "F7"
                },
                new Kartum()
                {
                    KartaId = 83,
                    Aktivna = true,
                    TerminId = 1,
                    BrojSjedista = 8,
                    BrojReda = "F",
                    Sjediste = "F8"
                },
                new Kartum()
                {
                    KartaId = 84,
                    Aktivna = true,
                    TerminId = 1,
                    BrojSjedista = 9,
                    BrojReda = "F",
                    Sjediste = "F9"
                },
                new Kartum()
                {
                    KartaId = 85,
                    Aktivna = true,
                    TerminId = 1,
                    BrojSjedista = 10,
                    BrojReda = "F",
                    Sjediste = "F10"
                },
                new Kartum()
                {
                    KartaId = 86,
                    Aktivna = true,
                    TerminId = 1,
                    BrojSjedista = 11,
                    BrojReda = "F",
                    Sjediste = "F11"
                },
                new Kartum()
                {
                    KartaId = 87,
                    Aktivna = true,
                    TerminId = 1,
                    BrojSjedista = 12,
                    BrojReda = "F",
                    Sjediste = "F12"
                },
                new Kartum()
                {
                    KartaId = 88,
                    Aktivna = true,
                    TerminId = 1,
                    BrojSjedista = 13,
                    BrojReda = "F",
                    Sjediste = "F13"
                },
                new Kartum()
                {
                    KartaId = 89,
                    Aktivna = true,
                    TerminId = 1,
                    BrojSjedista = 14,
                    BrojReda = "F",
                    Sjediste = "F14"
                },
                new Kartum()
                {
                    KartaId = 90,
                    Aktivna = true,
                    TerminId = 1,
                    BrojSjedista = 15,
                    BrojReda = "F",
                    Sjediste = "F15"
                },
                new Kartum()
                {
                    KartaId = 91,
                    Aktivna = true,
                    TerminId = 1,
                    BrojSjedista = 1,
                    BrojReda = "G",
                    Sjediste = "G1"
                },
                new Kartum()
                {
                    KartaId = 92,
                    Aktivna = true,
                    TerminId = 1,
                    BrojSjedista = 2,
                    BrojReda = "G",
                    Sjediste = "G2"
                },
                new Kartum()
                {
                    KartaId = 93,
                    Aktivna = true,
                    TerminId = 1,
                    BrojSjedista = 3,
                    BrojReda = "G",
                    Sjediste = "G3"
                },
                new Kartum()
                {
                    KartaId = 94,
                    Aktivna = true,
                    TerminId = 1,
                    BrojSjedista = 4,
                    BrojReda = "G",
                    Sjediste = "G4"
                },
                new Kartum()
                {
                    KartaId = 95,
                    Aktivna = true,
                    TerminId = 1,
                    BrojSjedista = 5,
                    BrojReda = "G",
                    Sjediste = "G5"
                },
                new Kartum()
                {
                    KartaId = 96,
                    Aktivna = true,
                    TerminId = 1,
                    BrojSjedista = 6,
                    BrojReda = "G",
                    Sjediste = "G6"
                },
                new Kartum()
                {
                    KartaId = 97,
                    Aktivna = true,
                    TerminId = 1,
                    BrojSjedista = 7,
                    BrojReda = "G",
                    Sjediste = "G7"
                },
                new Kartum()
                {
                    KartaId = 98,
                    Aktivna = true,
                    TerminId = 1,
                    BrojSjedista = 8,
                    BrojReda = "G",
                    Sjediste = "G8"
                },
                new Kartum()
                {
                    KartaId = 99,
                    Aktivna = true,
                    TerminId = 1,
                    BrojSjedista = 9,
                    BrojReda = "G",
                    Sjediste = "G9"
                },
                new Kartum()
                {
                    KartaId = 100,
                    Aktivna = true,
                    TerminId = 1,
                    BrojSjedista = 10,
                    BrojReda = "G",
                    Sjediste = "G10"
                },
                new Kartum()
                {
                    KartaId = 101,
                    Aktivna = true,
                    TerminId = 1,
                    BrojSjedista = 11,
                    BrojReda = "G",
                    Sjediste = "G11"
                },
                new Kartum()
                {
                    KartaId = 102,
                    Aktivna = true,
                    TerminId = 1,
                    BrojSjedista = 12,
                    BrojReda = "G",
                    Sjediste = "G12"
                },
                new Kartum()
                {
                    KartaId = 103,
                    Aktivna = true,
                    TerminId = 1,
                    BrojSjedista = 13,
                    BrojReda = "G",
                    Sjediste = "G13"
                },
                new Kartum()
                {
                    KartaId = 104,
                    Aktivna = true,
                    TerminId = 1,
                    BrojSjedista = 14,
                    BrojReda = "G",
                    Sjediste = "G14"
                },
                new Kartum()
                {
                    KartaId = 105,
                    Aktivna = true,
                    TerminId = 1,
                    BrojSjedista = 15,
                    BrojReda = "G",
                    Sjediste = "G15"
                },
                new Kartum()
                {
                    KartaId = 106,
                    Aktivna = true,
                    TerminId = 1,
                    BrojSjedista = 1,
                    BrojReda = "H",
                    Sjediste = "H1"
                },
                new Kartum()
                {
                    KartaId = 107,
                    Aktivna = true,
                    TerminId = 1,
                    BrojSjedista = 2,
                    BrojReda = "H",
                    Sjediste = "H2"
                },
                new Kartum()
                {
                    KartaId = 108,
                    Aktivna = true,
                    TerminId = 1,
                    BrojSjedista = 3,
                    BrojReda = "H",
                    Sjediste = "H3"
                },
                new Kartum()
                {
                    KartaId = 109,
                    Aktivna = true,
                    TerminId = 1,
                    BrojSjedista = 4,
                    BrojReda = "H",
                    Sjediste = "H4"
                },
                new Kartum()
                {
                    KartaId = 110,
                    Aktivna = true,
                    TerminId = 1,
                    BrojSjedista = 5,
                    BrojReda = "H",
                    Sjediste = "H5"
                },
                new Kartum()
                {
                    KartaId = 111,
                    Aktivna = true,
                    TerminId = 1,
                    BrojSjedista = 6,
                    BrojReda = "H",
                    Sjediste = "H6"
                },
                new Kartum()
                {
                    KartaId = 112,
                    Aktivna = true,
                    TerminId = 1,
                    BrojSjedista = 7,
                    BrojReda = "H",
                    Sjediste = "H7"
                },
                new Kartum()
                {
                    KartaId = 113,
                    Aktivna = true,
                    TerminId = 1,
                    BrojSjedista = 8,
                    BrojReda = "H",
                    Sjediste = "H8"
                },
                new Kartum()
                {
                    KartaId = 114,
                    Aktivna = true,
                    TerminId = 1,
                    BrojSjedista = 9,
                    BrojReda = "H",
                    Sjediste = "H9"
                },
                new Kartum()
                {
                    KartaId = 115,
                    Aktivna = true,
                    TerminId = 1,
                    BrojSjedista = 10,
                    BrojReda = "H",
                    Sjediste = "H10"
                },
                new Kartum()
                {
                    KartaId = 116,
                    Aktivna = true,
                    TerminId = 1,
                    BrojSjedista = 11,
                    BrojReda = "H",
                    Sjediste = "H11"
                },
                new Kartum()
                {
                    KartaId = 117,
                    Aktivna = true,
                    TerminId = 1,
                    BrojSjedista = 12,
                    BrojReda = "H",
                    Sjediste = "H12"
                },
                new Kartum()
                {
                    KartaId = 118,
                    Aktivna = true,
                    TerminId = 1,
                    BrojSjedista = 13,
                    BrojReda = "H",
                    Sjediste = "H13"
                },
                new Kartum()
                {
                    KartaId = 119,
                    Aktivna = true,
                    TerminId = 1,
                    BrojSjedista = 14,
                    BrojReda = "H",
                    Sjediste = "H14"
                },
                new Kartum()
                {
                    KartaId = 120,
                    Aktivna = true,
                    TerminId = 1,
                    BrojSjedista = 15,
                    BrojReda = "H",
                    Sjediste = "H15"
                },
                new Kartum()
                {
                    KartaId = 121,
                    Aktivna = true,
                    TerminId = 1,
                    BrojSjedista = 1,
                    BrojReda = "I",
                    Sjediste = "I1"
                },
                new Kartum()
                {
                    KartaId = 122,
                    Aktivna = true,
                    TerminId = 1,
                    BrojSjedista = 2,
                    BrojReda = "I",
                    Sjediste = "I2"
                },
                new Kartum()
                {
                    KartaId = 123,
                    Aktivna = true,
                    TerminId = 1,
                    BrojSjedista = 3,
                    BrojReda = "I",
                    Sjediste = "I3"
                },
                new Kartum()
                {
                    KartaId = 124,
                    Aktivna = true,
                    TerminId = 1,
                    BrojSjedista = 4,
                    BrojReda = "I",
                    Sjediste = "I4"
                },
                new Kartum()
                {
                    KartaId = 125,
                    Aktivna = true,
                    TerminId = 1,
                    BrojSjedista = 5,
                    BrojReda = "I",
                    Sjediste = "I5"
                },
                new Kartum()
                {
                    KartaId = 126,
                    Aktivna = true,
                    TerminId = 1,
                    BrojSjedista = 6,
                    BrojReda = "I",
                    Sjediste = "I6"
                },
                new Kartum()
                {
                    KartaId = 127,
                    Aktivna = true,
                    TerminId = 1,
                    BrojSjedista = 7,
                    BrojReda = "I",
                    Sjediste = "I7"
                },
                new Kartum()
                {
                    KartaId = 128,
                    Aktivna = true,
                    TerminId = 1,
                    BrojSjedista = 8,
                    BrojReda = "I",
                    Sjediste = "I8"
                },
                new Kartum()
                {
                    KartaId = 129,
                    Aktivna = true,
                    TerminId = 1,
                    BrojSjedista = 9,
                    BrojReda = "I",
                    Sjediste = "I9"
                },
                new Kartum()
                {
                    KartaId = 130,
                    Aktivna = true,
                    TerminId = 1,
                    BrojSjedista = 10,
                    BrojReda = "I",
                    Sjediste = "I10"
                },
                new Kartum()
                {
                    KartaId = 131,
                    Aktivna = true,
                    TerminId = 1,
                    BrojSjedista = 11,
                    BrojReda = "I",
                    Sjediste = "I11"
                },
                new Kartum()
                {
                    KartaId = 132,
                    Aktivna = true,
                    TerminId = 1,
                    BrojSjedista = 12,
                    BrojReda = "I",
                    Sjediste = "I12"
                },
                new Kartum()
                {
                    KartaId = 133,
                    Aktivna = true,
                    TerminId = 1,
                    BrojSjedista = 13,
                    BrojReda = "I",
                    Sjediste = "I13"
                },
                new Kartum()
                {
                    KartaId = 134,
                    Aktivna = true,
                    TerminId = 1,
                    BrojSjedista = 14,
                    BrojReda = "I",
                    Sjediste = "I14"
                },
                new Kartum()
                {
                    KartaId = 135,
                    Aktivna = true,
                    TerminId = 1,
                    BrojSjedista = 15,
                    BrojReda = "I",
                    Sjediste = "I15"
                },
                new Kartum()
                {
                    KartaId = 136,
                    Aktivna = true,
                    TerminId = 1,
                    BrojSjedista = 1,
                    BrojReda = "J",
                    Sjediste = "J1"
                },
                new Kartum()
                {
                    KartaId = 137,
                    Aktivna = true,
                    TerminId = 1,
                    BrojSjedista = 2,
                    BrojReda = "J",
                    Sjediste = "J2"
                },
                new Kartum()
                {
                    KartaId = 138,
                    Aktivna = true,
                    TerminId = 1,
                    BrojSjedista = 3,
                    BrojReda = "J",
                    Sjediste = "J3"
                },
                new Kartum()
                {
                    KartaId = 139,
                    Aktivna = true,
                    TerminId = 1,
                    BrojSjedista = 4,
                    BrojReda = "J",
                    Sjediste = "J4"
                },
                new Kartum()
                {
                    KartaId = 140,
                    Aktivna = true,
                    TerminId = 1,
                    BrojSjedista = 5,
                    BrojReda = "J",
                    Sjediste = "J5"
                },
                new Kartum()
                {
                    KartaId = 141,
                    Aktivna = true,
                    TerminId = 1,
                    BrojSjedista = 6,
                    BrojReda = "J",
                    Sjediste = "J6"
                },
                new Kartum()
                {
                    KartaId = 142,
                    Aktivna = true,
                    TerminId = 1,
                    BrojSjedista = 7,
                    BrojReda = "J",
                    Sjediste = "J7"
                },
                new Kartum()
                {
                    KartaId = 143,
                    Aktivna = true,
                    TerminId = 1,
                    BrojSjedista = 8,
                    BrojReda = "J",
                    Sjediste = "J8"
                },
                new Kartum()
                {
                    KartaId = 144,
                    Aktivna = true,
                    TerminId = 1,
                    BrojSjedista = 9,
                    BrojReda = "J",
                    Sjediste = "J9"
                },
                new Kartum()
                {
                    KartaId = 145,
                    Aktivna = true,
                    TerminId = 1,
                    BrojSjedista = 10,
                    BrojReda = "J",
                    Sjediste = "J10"
                },
                new Kartum()
                {
                    KartaId = 146,
                    Aktivna = true,
                    TerminId = 1,
                    BrojSjedista = 11,
                    BrojReda = "J",
                    Sjediste = "J11"
                },
                new Kartum()
                {
                    KartaId = 147,
                    Aktivna = true,
                    TerminId = 1,
                    BrojSjedista = 12,
                    BrojReda = "J",
                    Sjediste = "J12"
                },
                new Kartum()
                {
                    KartaId = 148,
                    Aktivna = true,
                    TerminId = 1,
                    BrojSjedista = 13,
                    BrojReda = "J",
                    Sjediste = "J13"
                },
                new Kartum()
                {
                    KartaId = 149,
                    Aktivna = true,
                    TerminId = 1,
                    BrojSjedista = 14,
                    BrojReda = "J",
                    Sjediste = "J14"
                },
                new Kartum()
                {
                    KartaId = 150,
                    Aktivna = true,
                    TerminId = 1,
                    BrojSjedista = 15,
                    BrojReda = "J",
                    Sjediste = "J15"
                },
                new Kartum()
                {
                    KartaId = 151,
                    Aktivna = false,
                    TerminId = 2,
                    BrojSjedista = 1,
                    BrojReda = "A",
                    Sjediste = "A1",
                    KupovinaId = 4
                },
                new Kartum()
                {
                    KartaId = 152,
                    Aktivna = false,
                    TerminId = 2,
                    BrojSjedista = 2,
                    BrojReda = "A",
                    Sjediste = "A2",
                    KupovinaId = 4
                },
                 new Kartum()
                {
                    KartaId = 153,
                    Aktivna = true,
                    TerminId = 2,
                    BrojSjedista = 3,
                    BrojReda = "A",
                    Sjediste = "A3"
                },
                new Kartum()
                {
                    KartaId = 154,
                    Aktivna = true,
                    TerminId = 2,
                    BrojSjedista = 4,
                    BrojReda = "A",
                    Sjediste = "A4"
                },
                 new Kartum()
                {
                    KartaId = 155,
                    Aktivna = true,
                    TerminId = 2,
                    BrojSjedista = 5,
                    BrojReda = "A",
                    Sjediste = "A5"
                },
                new Kartum()
                {
                    KartaId = 156,
                    Aktivna = true,
                    TerminId = 2,
                    BrojSjedista = 6,
                    BrojReda = "A",
                    Sjediste = "A6"
                },
                 new Kartum()
                {
                    KartaId = 157,
                    Aktivna = true,
                    TerminId = 2,
                    BrojSjedista = 7,
                    BrojReda = "A",
                    Sjediste = "A7"
                },
                new Kartum()
                {
                    KartaId = 158,
                    Aktivna = true,
                    TerminId = 2,
                    BrojSjedista = 8,
                    BrojReda = "A",
                    Sjediste = "A8"
                },
                 new Kartum()
                {
                    KartaId = 159,
                    Aktivna = true,
                    TerminId = 2,
                    BrojSjedista = 9,
                    BrojReda = "A",
                    Sjediste = "A9"
                },
                new Kartum()
                {
                    KartaId = 160,
                    Aktivna = true,
                    TerminId = 2,
                    BrojSjedista = 10,
                    BrojReda = "A",
                    Sjediste = "A10"
                },
                new Kartum()
                {
                    KartaId = 161,
                    Aktivna = true,
                    TerminId = 2,
                    BrojSjedista = 1,
                    BrojReda = "B",
                    Sjediste = "B1"
                },
                new Kartum()
                {
                    KartaId = 162,
                    Aktivna = true,
                    TerminId = 2,
                    BrojSjedista = 2,
                    BrojReda = "B",
                    Sjediste = "B2"
                },
                new Kartum()
                {
                    KartaId = 163,
                    Aktivna = true,
                    TerminId = 2,
                    BrojSjedista = 3,
                    BrojReda = "B",
                    Sjediste = "B3"
                },
                new Kartum()
                {
                    KartaId = 164,
                    Aktivna = true,
                    TerminId = 2,
                    BrojSjedista = 4,
                    BrojReda = "B",
                    Sjediste = "B4"
                },
                new Kartum()
                {
                    KartaId = 165,
                    Aktivna = true,
                    TerminId = 2,
                    BrojSjedista = 5,
                    BrojReda = "B",
                    Sjediste = "B5"
                },
                new Kartum()
                {
                    KartaId = 166,
                    Aktivna = true,
                    TerminId = 2,
                    BrojSjedista = 6,
                    BrojReda = "B",
                    Sjediste = "B6"
                },
                new Kartum()
                {
                    KartaId = 167,
                    Aktivna = true,
                    TerminId = 2,
                    BrojSjedista = 7,
                    BrojReda = "B",
                    Sjediste = "B7"
                },
                new Kartum()
                {
                    KartaId = 168,
                    Aktivna = true,
                    TerminId = 2,
                    BrojSjedista = 8,
                    BrojReda = "B",
                    Sjediste = "B8"
                },
                new Kartum()
                {
                    KartaId = 169,
                    Aktivna = true,
                    TerminId = 2,
                    BrojSjedista = 9,
                    BrojReda = "B",
                    Sjediste = "B9"
                },
                new Kartum()
                {
                    KartaId = 170,
                    Aktivna = true,
                    TerminId = 2,
                    BrojSjedista = 10,
                    BrojReda = "B",
                    Sjediste = "B10"
                },
                new Kartum()
                {
                    KartaId = 171,
                    Aktivna = true,
                    TerminId = 2,
                    BrojSjedista = 1,
                    BrojReda = "C",
                    Sjediste = "C1"
                },
                new Kartum()
                {
                    KartaId = 172,
                    Aktivna = true,
                    TerminId = 2,
                    BrojSjedista = 2,
                    BrojReda = "C",
                    Sjediste = "C2"
                },
                new Kartum()
                {
                    KartaId = 173,
                    Aktivna = true,
                    TerminId = 2,
                    BrojSjedista = 3,
                    BrojReda = "C",
                    Sjediste = "C3"
                },
                new Kartum()
                {
                    KartaId = 174,
                    Aktivna = true,
                    TerminId = 2,
                    BrojSjedista = 4,
                    BrojReda = "C",
                    Sjediste = "C4"
                },
                new Kartum()
                {
                    KartaId = 175,
                    Aktivna = true,
                    TerminId = 2,
                    BrojSjedista = 5,
                    BrojReda = "C",
                    Sjediste = "C5"
                },
                new Kartum()
                {
                    KartaId = 176,
                    Aktivna = true,
                    TerminId = 2,
                    BrojSjedista = 6,
                    BrojReda = "C",
                    Sjediste = "C6"
                },
                new Kartum()
                {
                    KartaId = 177,
                    Aktivna = true,
                    TerminId = 2,
                    BrojSjedista = 7,
                    BrojReda = "C",
                    Sjediste = "C7"
                },
                new Kartum()
                {
                    KartaId = 178,
                    Aktivna = true,
                    TerminId = 2,
                    BrojSjedista = 8,
                    BrojReda = "C",
                    Sjediste = "C8"
                },
                new Kartum()
                {
                    KartaId = 179,
                    Aktivna = true,
                    TerminId = 2,
                    BrojSjedista = 9,
                    BrojReda = "C",
                    Sjediste = "C9"
                },
                new Kartum()
                {
                    KartaId = 180,
                    Aktivna = true,
                    TerminId = 2,
                    BrojSjedista = 10,
                    BrojReda = "C",
                    Sjediste = "C10"
                },
                new Kartum()
                {
                    KartaId = 181,
                    Aktivna = true,
                    TerminId = 2,
                    BrojSjedista = 1,
                    BrojReda = "D",
                    Sjediste = "D1"
                },
                new Kartum()
                {
                    KartaId = 182,
                    Aktivna = true,
                    TerminId = 2,
                    BrojSjedista = 2,
                    BrojReda = "D",
                    Sjediste = "D2"
                },
                new Kartum()
                {
                    KartaId = 183,
                    Aktivna = true,
                    TerminId = 2,
                    BrojSjedista = 3,
                    BrojReda = "D",
                    Sjediste = "D3"
                },
                new Kartum()
                {
                    KartaId = 184,
                    Aktivna = true,
                    TerminId = 2,
                    BrojSjedista = 4,
                    BrojReda = "D",
                    Sjediste = "D4"
                },
                new Kartum()
                {
                    KartaId = 185,
                    Aktivna = true,
                    TerminId = 2,
                    BrojSjedista = 5,
                    BrojReda = "D",
                    Sjediste = "D5"
                },
                new Kartum()
                {
                    KartaId = 186,
                    Aktivna = true,
                    TerminId = 2,
                    BrojSjedista = 6,
                    BrojReda = "D",
                    Sjediste = "D6"
                },
                new Kartum()
                {
                    KartaId = 187,
                    Aktivna = true,
                    TerminId = 2,
                    BrojSjedista = 7,
                    BrojReda = "D",
                    Sjediste = "D7"
                },
                new Kartum()
                {
                    KartaId = 188,
                    Aktivna = true,
                    TerminId = 2,
                    BrojSjedista = 8,
                    BrojReda = "D",
                    Sjediste = "D8"
                },
                new Kartum()
                {
                    KartaId = 189,
                    Aktivna = true,
                    TerminId = 2,
                    BrojSjedista = 9,
                    BrojReda = "D",
                    Sjediste = "D9"
                },
                new Kartum()
                {
                    KartaId = 190,
                    Aktivna = true,
                    TerminId = 2,
                    BrojSjedista = 10,
                    BrojReda = "D",
                    Sjediste = "D10"
                },
                new Kartum()
                {
                    KartaId = 191,
                    Aktivna = true,
                    TerminId = 2,
                    BrojSjedista = 1,
                    BrojReda = "E",
                    Sjediste = "E1"
                },
                new Kartum()
                {
                    KartaId = 192,
                    Aktivna = true,
                    TerminId = 2,
                    BrojSjedista = 2,
                    BrojReda = "E",
                    Sjediste = "E2"
                },
                new Kartum()
                {
                    KartaId = 193,
                    Aktivna = true,
                    TerminId = 2,
                    BrojSjedista = 3,
                    BrojReda = "E",
                    Sjediste = "E3"
                },
                new Kartum()
                {
                    KartaId = 194,
                    Aktivna = true,
                    TerminId = 2,
                    BrojSjedista = 4,
                    BrojReda = "E",
                    Sjediste = "E4"
                },
                new Kartum()
                {
                    KartaId = 195,
                    Aktivna = true,
                    TerminId = 2,
                    BrojSjedista = 5,
                    BrojReda = "E",
                    Sjediste = "E5"
                },
                new Kartum()
                {
                    KartaId = 196,
                    Aktivna = true,
                    TerminId = 2,
                    BrojSjedista = 6,
                    BrojReda = "E",
                    Sjediste = "E6"
                },
                new Kartum()
                {
                    KartaId = 197,
                    Aktivna = true,
                    TerminId = 2,
                    BrojSjedista = 7,
                    BrojReda = "E",
                    Sjediste = "E7"
                },
                new Kartum()
                {
                    KartaId = 198,
                    Aktivna = true,
                    TerminId = 2,
                    BrojSjedista = 8,
                    BrojReda = "E",
                    Sjediste = "E8"
                },
                new Kartum()
                {
                    KartaId = 199,
                    Aktivna = true,
                    TerminId = 2,
                    BrojSjedista = 9,
                    BrojReda = "E",
                    Sjediste = "E9"
                },
                new Kartum()
                {
                    KartaId = 200,
                    Aktivna = true,
                    TerminId = 2,
                    BrojSjedista = 10,
                    BrojReda = "E",
                    Sjediste = "E10"
                },
                new Kartum()
                {
                    KartaId = 201,
                    Aktivna = true,
                    TerminId = 2,
                    BrojSjedista = 1,
                    BrojReda = "F",
                    Sjediste = "F1"
                },
                new Kartum()
                {
                    KartaId = 202,
                    Aktivna = true,
                    TerminId = 2,
                    BrojSjedista = 2,
                    BrojReda = "F",
                    Sjediste = "F2"
                },
                new Kartum()
                {
                    KartaId = 203,
                    Aktivna = true,
                    TerminId = 2,
                    BrojSjedista = 3,
                    BrojReda = "F",
                    Sjediste = "F3"
                },
                new Kartum()
                {
                    KartaId = 204,
                    Aktivna = true,
                    TerminId = 2,
                    BrojSjedista = 4,
                    BrojReda = "F",
                    Sjediste = "F4"
                },
                new Kartum()
                {
                    KartaId = 205,
                    Aktivna = true,
                    TerminId = 2,
                    BrojSjedista = 5,
                    BrojReda = "F",
                    Sjediste = "F5"
                },
                new Kartum()
                {
                    KartaId = 206,
                    Aktivna = true,
                    TerminId = 2,
                    BrojSjedista = 6,
                    BrojReda = "F",
                    Sjediste = "F6"
                },
                new Kartum()
                {
                    KartaId = 207,
                    Aktivna = true,
                    TerminId = 2,
                    BrojSjedista = 7,
                    BrojReda = "F",
                    Sjediste = "F7"
                },
                new Kartum()
                {
                    KartaId = 208,
                    Aktivna = true,
                    TerminId = 2,
                    BrojSjedista = 8,
                    BrojReda = "F",
                    Sjediste = "F8"
                },
                new Kartum()
                {
                    KartaId = 209,
                    Aktivna = true,
                    TerminId = 2,
                    BrojSjedista = 9,
                    BrojReda = "F",
                    Sjediste = "F9"
                },
                new Kartum()
                {
                    KartaId = 210,
                    Aktivna = true,
                    TerminId = 2,
                    BrojSjedista = 10,
                    BrojReda = "F",
                    Sjediste = "F10"
                },
                new Kartum()
                {
                    KartaId = 211,
                    Aktivna = true,
                    TerminId = 2,
                    BrojSjedista = 1,
                    BrojReda = "G",
                    Sjediste = "G1"
                },
                new Kartum()
                {
                    KartaId = 212,
                    Aktivna = true,
                    TerminId = 2,
                    BrojSjedista = 2,
                    BrojReda = "G",
                    Sjediste = "G2"
                },
                new Kartum()
                {
                    KartaId = 213,
                    Aktivna = true,
                    TerminId = 2,
                    BrojSjedista = 3,
                    BrojReda = "G",
                    Sjediste = "G3"
                },
                new Kartum()
                {
                    KartaId = 214,
                    Aktivna = true,
                    TerminId = 2,
                    BrojSjedista = 4,
                    BrojReda = "G",
                    Sjediste = "G4"
                },
                new Kartum()
                {
                    KartaId = 215,
                    Aktivna = true,
                    TerminId = 2,
                    BrojSjedista = 5,
                    BrojReda = "G",
                    Sjediste = "G5"
                },
                new Kartum()
                {
                    KartaId = 216,
                    Aktivna = true,
                    TerminId = 2,
                    BrojSjedista = 6,
                    BrojReda = "G",
                    Sjediste = "G6"
                },
                new Kartum()
                {
                    KartaId = 217,
                    Aktivna = true,
                    TerminId = 2,
                    BrojSjedista = 7,
                    BrojReda = "G",
                    Sjediste = "G7"
                },
                new Kartum()
                {
                    KartaId = 218,
                    Aktivna = true,
                    TerminId = 2,
                    BrojSjedista = 8,
                    BrojReda = "G",
                    Sjediste = "G8"
                },
                new Kartum()
                {
                    KartaId = 219,
                    Aktivna = true,
                    TerminId = 2,
                    BrojSjedista = 9,
                    BrojReda = "G",
                    Sjediste = "G9"
                },
                new Kartum()
                {
                    KartaId = 220,
                    Aktivna = true,
                    TerminId = 2,
                    BrojSjedista = 10,
                    BrojReda = "G",
                    Sjediste = "G10"
                },
                new Kartum()
                {
                    KartaId = 221,
                    Aktivna = true,
                    TerminId = 2,
                    BrojSjedista = 1,
                    BrojReda = "H",
                    Sjediste = "H1"
                },
                new Kartum()
                {
                    KartaId = 222,
                    Aktivna = true,
                    TerminId = 2,
                    BrojSjedista = 2,
                    BrojReda = "H",
                    Sjediste = "H2"
                },
                new Kartum()
                {
                    KartaId = 223,
                    Aktivna = true,
                    TerminId = 2,
                    BrojSjedista = 3,
                    BrojReda = "H",
                    Sjediste = "H3"
                },
                new Kartum()
                {
                    KartaId = 224,
                    Aktivna = true,
                    TerminId = 2,
                    BrojSjedista = 4,
                    BrojReda = "H",
                    Sjediste = "H4"
                },
                new Kartum()
                {
                    KartaId = 225,
                    Aktivna = true,
                    TerminId = 2,
                    BrojSjedista = 5,
                    BrojReda = "H",
                    Sjediste = "H5"
                },
                new Kartum()
                {
                    KartaId = 226,
                    Aktivna = true,
                    TerminId = 2,
                    BrojSjedista = 6,
                    BrojReda = "H",
                    Sjediste = "H6"
                },
                new Kartum()
                {
                    KartaId = 227,
                    Aktivna = true,
                    TerminId = 2,
                    BrojSjedista = 7,
                    BrojReda = "H",
                    Sjediste = "H7"
                },
                new Kartum()
                {
                    KartaId = 228,
                    Aktivna = true,
                    TerminId = 2,
                    BrojSjedista = 8,
                    BrojReda = "H",
                    Sjediste = "H8"
                },
                new Kartum()
                {
                    KartaId = 229,
                    Aktivna = true,
                    TerminId = 2,
                    BrojSjedista = 9,
                    BrojReda = "H",
                    Sjediste = "H9"
                },
                new Kartum()
                {
                    KartaId = 230,
                    Aktivna = true,
                    TerminId = 2,
                    BrojSjedista = 10,
                    BrojReda = "H",
                    Sjediste = "H10"
                },
                new Kartum()
                {
                    KartaId = 231,
                    Aktivna = true,
                    TerminId = 2,
                    BrojSjedista = 1,
                    BrojReda = "I",
                    Sjediste = "I1"
                },
                new Kartum()
                {
                    KartaId = 232,
                    Aktivna = true,
                    TerminId = 2,
                    BrojSjedista = 2,
                    BrojReda = "I",
                    Sjediste = "I2"
                },
                new Kartum()
                {
                    KartaId = 233,
                    Aktivna = true,
                    TerminId = 2,
                    BrojSjedista = 3,
                    BrojReda = "I",
                    Sjediste = "I3"
                },
                new Kartum()
                {
                    KartaId = 234,
                    Aktivna = true,
                    TerminId = 2,
                    BrojSjedista = 4,
                    BrojReda = "I",
                    Sjediste = "I4"
                },
                new Kartum()
                {
                    KartaId = 235,
                    Aktivna = true,
                    TerminId = 2,
                    BrojSjedista = 5,
                    BrojReda = "I",
                    Sjediste = "I5"
                },
                new Kartum()
                {
                    KartaId = 236,
                    Aktivna = true,
                    TerminId = 2,
                    BrojSjedista = 6,
                    BrojReda = "I",
                    Sjediste = "I6"
                },
                new Kartum()
                {
                    KartaId = 237,
                    Aktivna = true,
                    TerminId = 2,
                    BrojSjedista = 7,
                    BrojReda = "I",
                    Sjediste = "I7"
                },
                new Kartum()
                {
                    KartaId = 238,
                    Aktivna = true,
                    TerminId = 2,
                    BrojSjedista = 8,
                    BrojReda = "I",
                    Sjediste = "I8"
                },
                new Kartum()
                {
                    KartaId = 239,
                    Aktivna = true,
                    TerminId = 2,
                    BrojSjedista = 9,
                    BrojReda = "I",
                    Sjediste = "I9"
                },
                new Kartum()
                {
                    KartaId = 240,
                    Aktivna = true,
                    TerminId = 2,
                    BrojSjedista = 10,
                    BrojReda = "I",
                    Sjediste = "I10"
                },
                new Kartum()
                {
                    KartaId = 241,
                    Aktivna = true,
                    TerminId = 2,
                    BrojSjedista = 1,
                    BrojReda = "J",
                    Sjediste = "J1"
                },
                new Kartum()
                {
                    KartaId = 242,
                    Aktivna = true,
                    TerminId = 2,
                    BrojSjedista = 2,
                    BrojReda = "J",
                    Sjediste = "J2"
                },
                new Kartum()
                {
                    KartaId = 243,
                    Aktivna = true,
                    TerminId = 2,
                    BrojSjedista = 3,
                    BrojReda = "J",
                    Sjediste = "J3"
                },
                new Kartum()
                {
                    KartaId = 244,
                    Aktivna = true,
                    TerminId = 2,
                    BrojSjedista = 4,
                    BrojReda = "J",
                    Sjediste = "J4"
                },
                new Kartum()
                {
                    KartaId = 245,
                    Aktivna = true,
                    TerminId = 2,
                    BrojSjedista = 5,
                    BrojReda = "J",
                    Sjediste = "J5"
                },
                new Kartum()
                {
                    KartaId = 246,
                    Aktivna = true,
                    TerminId = 2,
                    BrojSjedista = 6,
                    BrojReda = "J",
                    Sjediste = "J6"
                },
                new Kartum()
                {
                    KartaId = 247,
                    Aktivna = true,
                    TerminId = 2,
                    BrojSjedista = 7,
                    BrojReda = "J",
                    Sjediste = "J7"
                },
                new Kartum()
                {
                    KartaId = 248,
                    Aktivna = true,
                    TerminId = 2,
                    BrojSjedista = 8,
                    BrojReda = "J",
                    Sjediste = "J8"
                },
                new Kartum()
                {
                    KartaId = 249,
                    Aktivna = true,
                    TerminId = 2,
                    BrojSjedista = 9,
                    BrojReda = "J",
                    Sjediste = "J9"
                },
                new Kartum()
                {
                    KartaId = 250,
                    Aktivna = true,
                    TerminId = 2,
                    BrojSjedista = 10,
                    BrojReda = "J",
                    Sjediste = "J10"
                },
                new Kartum()
                {
                    KartaId = 251,
                    Aktivna = true,
                    TerminId = 3,
                    BrojSjedista = 1,
                    BrojReda = "A",
                    Sjediste = "A1"
                },
                new Kartum()
                {
                    KartaId = 252,
                    Aktivna = true,
                    TerminId = 3,
                    BrojSjedista = 2,
                    BrojReda = "A",
                    Sjediste = "A2"
                },
                 new Kartum()
                {
                    KartaId = 253,
                    Aktivna = true,
                    TerminId = 3,
                    BrojSjedista = 3,
                    BrojReda = "A",
                    Sjediste = "A3"
                },
                new Kartum()
                {
                    KartaId = 254,
                    Aktivna = true,
                    TerminId = 3,
                    BrojSjedista = 4,
                    BrojReda = "A",
                    Sjediste = "A4"
                },
                 new Kartum()
                {
                    KartaId = 255,
                    Aktivna = true,
                    TerminId = 3,
                    BrojSjedista = 5,
                    BrojReda = "A",
                    Sjediste = "A5"
                },
                new Kartum()
                {
                    KartaId = 256,
                    Aktivna = true,
                    TerminId = 3,
                    BrojSjedista = 6,
                    BrojReda = "A",
                    Sjediste = "A6"
                },
                 new Kartum()
                {
                    KartaId = 257,
                    Aktivna = true,
                    TerminId = 3,
                    BrojSjedista = 7,
                    BrojReda = "A",
                    Sjediste = "A7"
                },
                new Kartum()
                {
                    KartaId = 258,
                    Aktivna = true,
                    TerminId = 3,
                    BrojSjedista = 8,
                    BrojReda = "A",
                    Sjediste = "A8"
                },
                 new Kartum()
                {
                    KartaId = 259,
                    Aktivna = true,
                    TerminId = 3,
                    BrojSjedista = 9,
                    BrojReda = "A",
                    Sjediste = "A9"
                },
                new Kartum()
                {
                    KartaId = 260,
                    Aktivna = true,
                    TerminId = 3,
                    BrojSjedista = 10,
                    BrojReda = "A",
                    Sjediste = "A10"
                },
                new Kartum()
                {
                    KartaId = 261,
                    Aktivna = true,
                    TerminId = 3,
                    BrojSjedista = 1,
                    BrojReda = "B",
                    Sjediste = "B1"
                },
                new Kartum()
                {
                    KartaId = 262,
                    Aktivna = true,
                    TerminId = 3,
                    BrojSjedista = 2,
                    BrojReda = "B",
                    Sjediste = "B2"
                },
                new Kartum()
                {
                    KartaId = 263,
                    Aktivna = true,
                    TerminId = 3,
                    BrojSjedista = 3,
                    BrojReda = "B",
                    Sjediste = "B3"
                },
                new Kartum()
                {
                    KartaId = 264,
                    Aktivna = true,
                    TerminId = 3,
                    BrojSjedista = 4,
                    BrojReda = "B",
                    Sjediste = "B4"
                },
                new Kartum()
                {
                    KartaId = 265,
                    Aktivna = true,
                    TerminId = 3,
                    BrojSjedista = 5,
                    BrojReda = "B",
                    Sjediste = "B5"
                },
                new Kartum()
                {
                    KartaId = 266,
                    Aktivna = true,
                    TerminId = 3,
                    BrojSjedista = 6,
                    BrojReda = "B",
                    Sjediste = "B6"
                },
                new Kartum()
                {
                    KartaId = 267,
                    Aktivna = true,
                    TerminId = 3,
                    BrojSjedista = 7,
                    BrojReda = "B",
                    Sjediste = "B7"
                },
                new Kartum()
                {
                    KartaId = 268,
                    Aktivna = true,
                    TerminId = 3,
                    BrojSjedista = 8,
                    BrojReda = "B",
                    Sjediste = "B8"
                },
                new Kartum()
                {
                    KartaId = 269,
                    Aktivna = true,
                    TerminId = 3,
                    BrojSjedista = 9,
                    BrojReda = "B",
                    Sjediste = "B9"
                },
                new Kartum()
                {
                    KartaId = 270,
                    Aktivna = true,
                    TerminId = 3,
                    BrojSjedista = 10,
                    BrojReda = "B",
                    Sjediste = "B10"
                },
                new Kartum()
                {
                    KartaId = 271,
                    Aktivna = true,
                    TerminId = 3,
                    BrojSjedista = 1,
                    BrojReda = "C",
                    Sjediste = "C1"
                },
                new Kartum()
                {
                    KartaId = 272,
                    Aktivna = true,
                    TerminId = 3,
                    BrojSjedista = 2,
                    BrojReda = "C",
                    Sjediste = "C2"
                },
                new Kartum()
                {
                    KartaId = 273,
                    Aktivna = true,
                    TerminId = 3,
                    BrojSjedista = 3,
                    BrojReda = "C",
                    Sjediste = "C3"
                },
                new Kartum()
                {
                    KartaId = 274,
                    Aktivna = true,
                    TerminId = 3,
                    BrojSjedista = 4,
                    BrojReda = "C",
                    Sjediste = "C4"
                },
                new Kartum()
                {
                    KartaId = 275,
                    Aktivna = true,
                    TerminId = 3,
                    BrojSjedista = 5,
                    BrojReda = "C",
                    Sjediste = "C5"
                },
                new Kartum()
                {
                    KartaId = 276,
                    Aktivna = true,
                    TerminId = 3,
                    BrojSjedista = 6,
                    BrojReda = "C",
                    Sjediste = "C6"
                },
                new Kartum()
                {
                    KartaId = 277,
                    Aktivna = true,
                    TerminId = 3,
                    BrojSjedista = 7,
                    BrojReda = "C",
                    Sjediste = "C7"
                },
                new Kartum()
                {
                    KartaId = 278,
                    Aktivna = true,
                    TerminId = 3,
                    BrojSjedista = 8,
                    BrojReda = "C",
                    Sjediste = "C8"
                },
                new Kartum()
                {
                    KartaId = 279,
                    Aktivna = true,
                    TerminId = 3,
                    BrojSjedista = 9,
                    BrojReda = "C",
                    Sjediste = "C9"
                },
                new Kartum()
                {
                    KartaId = 280,
                    Aktivna = true,
                    TerminId = 3,
                    BrojSjedista = 10,
                    BrojReda = "C",
                    Sjediste = "C10"
                },
                new Kartum()
                {
                    KartaId = 281,
                    Aktivna = true,
                    TerminId = 3,
                    BrojSjedista = 1,
                    BrojReda = "D",
                    Sjediste = "D1"
                },
                new Kartum()
                {
                    KartaId = 282,
                    Aktivna = true,
                    TerminId = 3,
                    BrojSjedista = 2,
                    BrojReda = "D",
                    Sjediste = "D2"
                },
                new Kartum()
                {
                    KartaId = 283,
                    Aktivna = true,
                    TerminId = 3,
                    BrojSjedista = 3,
                    BrojReda = "D",
                    Sjediste = "D3"
                },
                new Kartum()
                {
                    KartaId = 284,
                    Aktivna = true,
                    TerminId = 3,
                    BrojSjedista = 4,
                    BrojReda = "D",
                    Sjediste = "D4"
                },
                new Kartum()
                {
                    KartaId = 285,
                    Aktivna = true,
                    TerminId = 3,
                    BrojSjedista = 5,
                    BrojReda = "D",
                    Sjediste = "D5"
                },
                new Kartum()
                {
                    KartaId = 286,
                    Aktivna = true,
                    TerminId = 3,
                    BrojSjedista = 6,
                    BrojReda = "D",
                    Sjediste = "D6"
                },
                new Kartum()
                {
                    KartaId = 287,
                    Aktivna = true,
                    TerminId = 3,
                    BrojSjedista = 7,
                    BrojReda = "D",
                    Sjediste = "D7"
                },
                new Kartum()
                {
                    KartaId = 288,
                    Aktivna = true,
                    TerminId = 3,
                    BrojSjedista = 8,
                    BrojReda = "D",
                    Sjediste = "D8"
                },
                new Kartum()
                {
                    KartaId = 289,
                    Aktivna = true,
                    TerminId = 3,
                    BrojSjedista = 9,
                    BrojReda = "D",
                    Sjediste = "D9"
                },
                new Kartum()
                {
                    KartaId = 290,
                    Aktivna = true,
                    TerminId = 3,
                    BrojSjedista = 10,
                    BrojReda = "D",
                    Sjediste = "D10"
                },
                new Kartum()
                {
                    KartaId = 291,
                    Aktivna = true,
                    TerminId = 3,
                    BrojSjedista = 1,
                    BrojReda = "E",
                    Sjediste = "E1"
                },
                new Kartum()
                {
                    KartaId = 292,
                    Aktivna = true,
                    TerminId = 3,
                    BrojSjedista = 2,
                    BrojReda = "E",
                    Sjediste = "E2"
                },
                new Kartum()
                {
                    KartaId = 293,
                    Aktivna = true,
                    TerminId = 3,
                    BrojSjedista = 3,
                    BrojReda = "E",
                    Sjediste = "E3"
                },
                new Kartum()
                {
                    KartaId = 294,
                    Aktivna = true,
                    TerminId = 3,
                    BrojSjedista = 4,
                    BrojReda = "E",
                    Sjediste = "E4"
                },
                new Kartum()
                {
                    KartaId = 295,
                    Aktivna = true,
                    TerminId = 3,
                    BrojSjedista = 5,
                    BrojReda = "E",
                    Sjediste = "E5"
                },
                new Kartum()
                {
                    KartaId = 296,
                    Aktivna = true,
                    TerminId = 3,
                    BrojSjedista = 6,
                    BrojReda = "E",
                    Sjediste = "E6"
                },
                new Kartum()
                {
                    KartaId = 297,
                    Aktivna = true,
                    TerminId = 3,
                    BrojSjedista = 7,
                    BrojReda = "E",
                    Sjediste = "E7"
                },
                new Kartum()
                {
                    KartaId = 298,
                    Aktivna = true,
                    TerminId = 3,
                    BrojSjedista = 8,
                    BrojReda = "E",
                    Sjediste = "E8"
                },
                new Kartum()
                {
                    KartaId = 299,
                    Aktivna = true,
                    TerminId = 3,
                    BrojSjedista = 9,
                    BrojReda = "E",
                    Sjediste = "E9"
                },
                new Kartum()
                {
                    KartaId = 300,
                    Aktivna = true,
                    TerminId = 3,
                    BrojSjedista = 10,
                    BrojReda = "E",
                    Sjediste = "E10"
                },
                new Kartum()
                {
                    KartaId = 301,
                    Aktivna = true,
                    TerminId = 3,
                    BrojSjedista = 1,
                    BrojReda = "F",
                    Sjediste = "F1"
                },
                new Kartum()
                {
                    KartaId = 302,
                    Aktivna = true,
                    TerminId = 3,
                    BrojSjedista = 2,
                    BrojReda = "F",
                    Sjediste = "F2"
                },
                new Kartum()
                {
                    KartaId = 303,
                    Aktivna = true,
                    TerminId = 3,
                    BrojSjedista = 3,
                    BrojReda = "F",
                    Sjediste = "F3"
                },
                new Kartum()
                {
                    KartaId = 304,
                    Aktivna = true,
                    TerminId = 3,
                    BrojSjedista = 4,
                    BrojReda = "F",
                    Sjediste = "F4"
                },
                new Kartum()
                {
                    KartaId = 305,
                    Aktivna = true,
                    TerminId = 3,
                    BrojSjedista = 5,
                    BrojReda = "F",
                    Sjediste = "F5"
                },
                new Kartum()
                {
                    KartaId = 306,
                    Aktivna = true,
                    TerminId = 3,
                    BrojSjedista = 6,
                    BrojReda = "F",
                    Sjediste = "F6"
                },
                new Kartum()
                {
                    KartaId = 307,
                    Aktivna = true,
                    TerminId = 3,
                    BrojSjedista = 7,
                    BrojReda = "F",
                    Sjediste = "F7"
                },
                new Kartum()
                {
                    KartaId = 308,
                    Aktivna = true,
                    TerminId = 3,
                    BrojSjedista = 8,
                    BrojReda = "F",
                    Sjediste = "F8"
                },
                new Kartum()
                {
                    KartaId = 309,
                    Aktivna = true,
                    TerminId = 3,
                    BrojSjedista = 9,
                    BrojReda = "F",
                    Sjediste = "F9"
                },
                new Kartum()
                {
                    KartaId = 310,
                    Aktivna = true,
                    TerminId = 3,
                    BrojSjedista = 10,
                    BrojReda = "F",
                    Sjediste = "F10"
                },
                new Kartum()
                {
                    KartaId = 311,
                    Aktivna = true,
                    TerminId = 3,
                    BrojSjedista = 1,
                    BrojReda = "G",
                    Sjediste = "G1"
                },
                new Kartum()
                {
                    KartaId = 312,
                    Aktivna = true,
                    TerminId = 3,
                    BrojSjedista = 2,
                    BrojReda = "G",
                    Sjediste = "G2"
                },
                new Kartum()
                {
                    KartaId = 313,
                    Aktivna = true,
                    TerminId = 3,
                    BrojSjedista = 3,
                    BrojReda = "G",
                    Sjediste = "G3"
                },
                new Kartum()
                {
                    KartaId = 314,
                    Aktivna = true,
                    TerminId = 3,
                    BrojSjedista = 4,
                    BrojReda = "G",
                    Sjediste = "G4"
                },
                new Kartum()
                {
                    KartaId = 315,
                    Aktivna = true,
                    TerminId = 3,
                    BrojSjedista = 5,
                    BrojReda = "G",
                    Sjediste = "G5"
                },
                new Kartum()
                {
                    KartaId = 316,
                    Aktivna = true,
                    TerminId = 3,
                    BrojSjedista = 6,
                    BrojReda = "G",
                    Sjediste = "G6"
                },
                new Kartum()
                {
                    KartaId = 317,
                    Aktivna = true,
                    TerminId = 3,
                    BrojSjedista = 7,
                    BrojReda = "G",
                    Sjediste = "G7"
                },
                new Kartum()
                {
                    KartaId = 318,
                    Aktivna = true,
                    TerminId = 3,
                    BrojSjedista = 8,
                    BrojReda = "G",
                    Sjediste = "G8"
                },
                new Kartum()
                {
                    KartaId = 319,
                    Aktivna = true,
                    TerminId = 3,
                    BrojSjedista = 9,
                    BrojReda = "G",
                    Sjediste = "G9"
                },
                new Kartum()
                {
                    KartaId = 320,
                    Aktivna = true,
                    TerminId = 3,
                    BrojSjedista = 10,
                    BrojReda = "G",
                    Sjediste = "G10"
                },
                new Kartum()
                {
                    KartaId = 321,
                    Aktivna = true,
                    TerminId = 3,
                    BrojSjedista = 1,
                    BrojReda = "H",
                    Sjediste = "H1"
                },
                new Kartum()
                {
                    KartaId = 322,
                    Aktivna = true,
                    TerminId = 3,
                    BrojSjedista = 2,
                    BrojReda = "H",
                    Sjediste = "H2"
                },
                new Kartum()
                {
                    KartaId = 323,
                    Aktivna = true,
                    TerminId = 3,
                    BrojSjedista = 3,
                    BrojReda = "H",
                    Sjediste = "H3"
                },
                new Kartum()
                {
                    KartaId = 324,
                    Aktivna = true,
                    TerminId = 3,
                    BrojSjedista = 4,
                    BrojReda = "H",
                    Sjediste = "H4"
                },
                new Kartum()
                {
                    KartaId = 325,
                    Aktivna = true,
                    TerminId = 3,
                    BrojSjedista = 5,
                    BrojReda = "H",
                    Sjediste = "H5"
                },
                new Kartum()
                {
                    KartaId = 326,
                    Aktivna = true,
                    TerminId = 3,
                    BrojSjedista = 6,
                    BrojReda = "H",
                    Sjediste = "H6"
                },
                new Kartum()
                {
                    KartaId = 327,
                    Aktivna = true,
                    TerminId = 3,
                    BrojSjedista = 7,
                    BrojReda = "H",
                    Sjediste = "H7"
                },
                new Kartum()
                {
                    KartaId = 328,
                    Aktivna = true,
                    TerminId = 3,
                    BrojSjedista = 8,
                    BrojReda = "H",
                    Sjediste = "H8"
                },
                new Kartum()
                {
                    KartaId = 329,
                    Aktivna = true,
                    TerminId = 3,
                    BrojSjedista = 9,
                    BrojReda = "H",
                    Sjediste = "H9"
                },
                new Kartum()
                {
                    KartaId = 330,
                    Aktivna = true,
                    TerminId = 3,
                    BrojSjedista = 10,
                    BrojReda = "H",
                    Sjediste = "H10"
                },
                new Kartum()
                {
                    KartaId = 331,
                    Aktivna = true,
                    TerminId = 3,
                    BrojSjedista = 1,
                    BrojReda = "I",
                    Sjediste = "I1"
                },
                new Kartum()
                {
                    KartaId = 332,
                    Aktivna = true,
                    TerminId = 3,
                    BrojSjedista = 2,
                    BrojReda = "I",
                    Sjediste = "I2"
                },
                new Kartum()
                {
                    KartaId = 333,
                    Aktivna = true,
                    TerminId = 3,
                    BrojSjedista = 3,
                    BrojReda = "I",
                    Sjediste = "I3"
                },
                new Kartum()
                {
                    KartaId = 334,
                    Aktivna = true,
                    TerminId = 3,
                    BrojSjedista = 4,
                    BrojReda = "I",
                    Sjediste = "I4"
                },
                new Kartum()
                {
                    KartaId = 335,
                    Aktivna = true,
                    TerminId = 3,
                    BrojSjedista = 5,
                    BrojReda = "I",
                    Sjediste = "I5"
                },
                new Kartum()
                {
                    KartaId = 336,
                    Aktivna = true,
                    TerminId = 3,
                    BrojSjedista = 6,
                    BrojReda = "I",
                    Sjediste = "I6"
                },
                new Kartum()
                {
                    KartaId = 337,
                    Aktivna = true,
                    TerminId = 3,
                    BrojSjedista = 7,
                    BrojReda = "I",
                    Sjediste = "I7"
                },
                new Kartum()
                {
                    KartaId = 338,
                    Aktivna = true,
                    TerminId = 3,
                    BrojSjedista = 8,
                    BrojReda = "I",
                    Sjediste = "I8"
                },
                new Kartum()
                {
                    KartaId = 339,
                    Aktivna = true,
                    TerminId = 3,
                    BrojSjedista = 9,
                    BrojReda = "I",
                    Sjediste = "I9"
                },
                new Kartum()
                {
                    KartaId = 340,
                    Aktivna = true,
                    TerminId = 3,
                    BrojSjedista = 10,
                    BrojReda = "I",
                    Sjediste = "I10"
                },
                new Kartum()
                {
                    KartaId = 341,
                    Aktivna = true,
                    TerminId = 3,
                    BrojSjedista = 1,
                    BrojReda = "J",
                    Sjediste = "J1"
                },
                new Kartum()
                {
                    KartaId = 342,
                    Aktivna = true,
                    TerminId = 3,
                    BrojSjedista = 2,
                    BrojReda = "J",
                    Sjediste = "J2"
                },
                new Kartum()
                {
                    KartaId = 343,
                    Aktivna = true,
                    TerminId = 3,
                    BrojSjedista = 3,
                    BrojReda = "J",
                    Sjediste = "J3"
                },
                new Kartum()
                {
                    KartaId = 344,
                    Aktivna = true,
                    TerminId = 3,
                    BrojSjedista = 4,
                    BrojReda = "J",
                    Sjediste = "J4"
                },
                new Kartum()
                {
                    KartaId = 345,
                    Aktivna = true,
                    TerminId = 3,
                    BrojSjedista = 5,
                    BrojReda = "J",
                    Sjediste = "J5"
                },
                new Kartum()
                {
                    KartaId = 346,
                    Aktivna = true,
                    TerminId = 3,
                    BrojSjedista = 6,
                    BrojReda = "J",
                    Sjediste = "J6"
                },
                new Kartum()
                {
                    KartaId = 347,
                    Aktivna = true,
                    TerminId = 3,
                    BrojSjedista = 7,
                    BrojReda = "J",
                    Sjediste = "J7"
                },
                new Kartum()
                {
                    KartaId = 348,
                    Aktivna = true,
                    TerminId = 3,
                    BrojSjedista = 8,
                    BrojReda = "J",
                    Sjediste = "J8"
                },
                new Kartum()
                {
                    KartaId = 349,
                    Aktivna = true,
                    TerminId = 3,
                    BrojSjedista = 9,
                    BrojReda = "J",
                    Sjediste = "J9"
                },
                new Kartum()
                {
                    KartaId = 350,
                    Aktivna = true,
                    TerminId = 3,
                    BrojSjedista = 10,
                    BrojReda = "J",
                    Sjediste = "J10"
                },
                new Kartum()
                {
                    KartaId = 351,
                    Aktivna = true,
                    TerminId = 4,
                    BrojSjedista = 1,
                    BrojReda = "A",
                    Sjediste = "A1"
                },
                new Kartum()
                {
                    KartaId = 352,
                    Aktivna = true,
                    TerminId = 4,
                    BrojSjedista = 2,
                    BrojReda = "A",
                    Sjediste = "A2"
                },
                 new Kartum()
                {
                    KartaId = 353,
                    Aktivna = true,
                    TerminId = 4,
                    BrojSjedista = 3,
                    BrojReda = "A",
                    Sjediste = "A3"
                },
                new Kartum()
                {
                    KartaId = 354,
                    Aktivna = true,
                    TerminId = 4,
                    BrojSjedista = 4,
                    BrojReda = "A",
                    Sjediste = "A4"
                },
                 new Kartum()
                {
                    KartaId = 355,
                    Aktivna = true,
                    TerminId = 4,
                    BrojSjedista = 5,
                    BrojReda = "A",
                    Sjediste = "A5"
                },
                new Kartum()
                {
                    KartaId = 356,
                    Aktivna = true,
                    TerminId = 4,
                    BrojSjedista = 6,
                    BrojReda = "A",
                    Sjediste = "A6"
                },
                 new Kartum()
                {
                    KartaId = 357,
                    Aktivna = true,
                    TerminId = 4,
                    BrojSjedista = 7,
                    BrojReda = "A",
                    Sjediste = "A7"
                },
                new Kartum()
                {
                    KartaId = 358,
                    Aktivna = true,
                    TerminId = 4,
                    BrojSjedista = 8,
                    BrojReda = "A",
                    Sjediste = "A8"
                },
                 new Kartum()
                {
                    KartaId = 359,
                    Aktivna = true,
                    TerminId = 4,
                    BrojSjedista = 9,
                    BrojReda = "A",
                    Sjediste = "A9"
                },
                new Kartum()
                {
                    KartaId = 360,
                    Aktivna = true,
                    TerminId = 4,
                    BrojSjedista = 10,
                    BrojReda = "A",
                    Sjediste = "A10"
                },
                new Kartum()
                {
                    KartaId = 361,
                    Aktivna = true,
                    TerminId = 4,
                    BrojSjedista = 1,
                    BrojReda = "B",
                    Sjediste = "B1"
                },
                new Kartum()
                {
                    KartaId = 362,
                    Aktivna = true,
                    TerminId = 4,
                    BrojSjedista = 2,
                    BrojReda = "B",
                    Sjediste = "B2"
                },
                new Kartum()
                {
                    KartaId = 363,
                    Aktivna = true,
                    TerminId = 4,
                    BrojSjedista = 3,
                    BrojReda = "B",
                    Sjediste = "B3"
                },
                new Kartum()
                {
                    KartaId = 364,
                    Aktivna = true,
                    TerminId = 4,
                    BrojSjedista = 4,
                    BrojReda = "B",
                    Sjediste = "B4"
                },
                new Kartum()
                {
                    KartaId = 365,
                    Aktivna = true,
                    TerminId = 4,
                    BrojSjedista = 5,
                    BrojReda = "B",
                    Sjediste = "B5"
                },
                new Kartum()
                {
                    KartaId = 366,
                    Aktivna = true,
                    TerminId = 4,
                    BrojSjedista = 6,
                    BrojReda = "B",
                    Sjediste = "B6"
                },
                new Kartum()
                {
                    KartaId = 367,
                    Aktivna = true,
                    TerminId = 4,
                    BrojSjedista = 7,
                    BrojReda = "B",
                    Sjediste = "B7"
                },
                new Kartum()
                {
                    KartaId = 368,
                    Aktivna = true,
                    TerminId = 4,
                    BrojSjedista = 8,
                    BrojReda = "B",
                    Sjediste = "B8"
                },
                new Kartum()
                {
                    KartaId = 369,
                    Aktivna = true,
                    TerminId = 4,
                    BrojSjedista = 9,
                    BrojReda = "B",
                    Sjediste = "B9"
                },
                new Kartum()
                {
                    KartaId = 370,
                    Aktivna = true,
                    TerminId = 4,
                    BrojSjedista = 10,
                    BrojReda = "B",
                    Sjediste = "B10"
                },
                new Kartum()
                {
                    KartaId = 371,
                    Aktivna = true,
                    TerminId = 4,
                    BrojSjedista = 1,
                    BrojReda = "C",
                    Sjediste = "C1"
                },
                new Kartum()
                {
                    KartaId = 372,
                    Aktivna = true,
                    TerminId = 4,
                    BrojSjedista = 2,
                    BrojReda = "C",
                    Sjediste = "C2"
                },
                new Kartum()
                {
                    KartaId = 373,
                    Aktivna = true,
                    TerminId = 4,
                    BrojSjedista = 3,
                    BrojReda = "C",
                    Sjediste = "C3"
                },
                new Kartum()
                {
                    KartaId = 374,
                    Aktivna = true,
                    TerminId = 4,
                    BrojSjedista = 4,
                    BrojReda = "C",
                    Sjediste = "C4"
                },
                new Kartum()
                {
                    KartaId = 375,
                    Aktivna = true,
                    TerminId = 4,
                    BrojSjedista = 5,
                    BrojReda = "C",
                    Sjediste = "C5"
                },
                new Kartum()
                {
                    KartaId = 376,
                    Aktivna = true,
                    TerminId = 4,
                    BrojSjedista = 6,
                    BrojReda = "C",
                    Sjediste = "C6"
                },
                new Kartum()
                {
                    KartaId = 377,
                    Aktivna = true,
                    TerminId = 4,
                    BrojSjedista = 7,
                    BrojReda = "C",
                    Sjediste = "C7"
                },
                new Kartum()
                {
                    KartaId = 378,
                    Aktivna = true,
                    TerminId = 4,
                    BrojSjedista = 8,
                    BrojReda = "C",
                    Sjediste = "C8"
                },
                new Kartum()
                {
                    KartaId = 379,
                    Aktivna = true,
                    TerminId = 4,
                    BrojSjedista = 9,
                    BrojReda = "C",
                    Sjediste = "C9"
                },
                new Kartum()
                {
                    KartaId = 380,
                    Aktivna = true,
                    TerminId = 4,
                    BrojSjedista = 10,
                    BrojReda = "C",
                    Sjediste = "C10"
                },
                new Kartum()
                {
                    KartaId = 381,
                    Aktivna = true,
                    TerminId = 4,
                    BrojSjedista = 1,
                    BrojReda = "D",
                    Sjediste = "D1"
                },
                new Kartum()
                {
                    KartaId = 382,
                    Aktivna = true,
                    TerminId = 4,
                    BrojSjedista = 2,
                    BrojReda = "D",
                    Sjediste = "D2"
                },
                new Kartum()
                {
                    KartaId = 383,
                    Aktivna = true,
                    TerminId = 4,
                    BrojSjedista = 3,
                    BrojReda = "D",
                    Sjediste = "D3"
                },
                new Kartum()
                {
                    KartaId = 384,
                    Aktivna = true,
                    TerminId = 4,
                    BrojSjedista = 4,
                    BrojReda = "D",
                    Sjediste = "D4"
                },
                new Kartum()
                {
                    KartaId = 385,
                    Aktivna = true,
                    TerminId = 4,
                    BrojSjedista = 5,
                    BrojReda = "D",
                    Sjediste = "D5"
                },
                new Kartum()
                {
                    KartaId = 386,
                    Aktivna = true,
                    TerminId = 4,
                    BrojSjedista = 6,
                    BrojReda = "D",
                    Sjediste = "D6"
                },
                new Kartum()
                {
                    KartaId = 387,
                    Aktivna = true,
                    TerminId = 4,
                    BrojSjedista = 7,
                    BrojReda = "D",
                    Sjediste = "D7"
                },
                new Kartum()
                {
                    KartaId = 388,
                    Aktivna = true,
                    TerminId = 4,
                    BrojSjedista = 8,
                    BrojReda = "D",
                    Sjediste = "D8"
                },
                new Kartum()
                {
                    KartaId = 389,
                    Aktivna = true,
                    TerminId = 4,
                    BrojSjedista = 9,
                    BrojReda = "D",
                    Sjediste = "D9"
                },
                new Kartum()
                {
                    KartaId = 390,
                    Aktivna = true,
                    TerminId = 4,
                    BrojSjedista = 10,
                    BrojReda = "D",
                    Sjediste = "D10"
                },
                new Kartum()
                {
                    KartaId = 391,
                    Aktivna = true,
                    TerminId = 4,
                    BrojSjedista = 1,
                    BrojReda = "E",
                    Sjediste = "E1"
                },
                new Kartum()
                {
                    KartaId = 392,
                    Aktivna = true,
                    TerminId = 4,
                    BrojSjedista = 2,
                    BrojReda = "E",
                    Sjediste = "E2"
                },
                new Kartum()
                {
                    KartaId = 393,
                    Aktivna = true,
                    TerminId = 4,
                    BrojSjedista = 3,
                    BrojReda = "E",
                    Sjediste = "E3"
                },
                new Kartum()
                {
                    KartaId = 394,
                    Aktivna = true,
                    TerminId = 4,
                    BrojSjedista = 4,
                    BrojReda = "E",
                    Sjediste = "E4"
                },
                new Kartum()
                {
                    KartaId = 395,
                    Aktivna = true,
                    TerminId = 4,
                    BrojSjedista = 5,
                    BrojReda = "E",
                    Sjediste = "E5"
                },
                new Kartum()
                {
                    KartaId = 396,
                    Aktivna = true,
                    TerminId = 4,
                    BrojSjedista = 6,
                    BrojReda = "E",
                    Sjediste = "E6"
                },
                new Kartum()
                {
                    KartaId = 397,
                    Aktivna = true,
                    TerminId = 4,
                    BrojSjedista = 7,
                    BrojReda = "E",
                    Sjediste = "E7"
                },
                new Kartum()
                {
                    KartaId = 398,
                    Aktivna = true,
                    TerminId = 4,
                    BrojSjedista = 8,
                    BrojReda = "E",
                    Sjediste = "E8"
                },
                new Kartum()
                {
                    KartaId = 399,
                    Aktivna = true,
                    TerminId = 4,
                    BrojSjedista = 9,
                    BrojReda = "E",
                    Sjediste = "E9"
                },
                new Kartum()
                {
                    KartaId = 400,
                    Aktivna = true,
                    TerminId = 4,
                    BrojSjedista = 10,
                    BrojReda = "E",
                    Sjediste = "E10"
                },
                new Kartum()
                {
                    KartaId = 401,
                    Aktivna = true,
                    TerminId = 4,
                    BrojSjedista = 1,
                    BrojReda = "F",
                    Sjediste = "F1"
                },
                new Kartum()
                {
                    KartaId = 402,
                    Aktivna = true,
                    TerminId = 4,
                    BrojSjedista = 2,
                    BrojReda = "F",
                    Sjediste = "F2"
                },
                new Kartum()
                {
                    KartaId = 403,
                    Aktivna = true,
                    TerminId = 4,
                    BrojSjedista = 3,
                    BrojReda = "F",
                    Sjediste = "F3"
                },
                new Kartum()
                {
                    KartaId = 404,
                    Aktivna = true,
                    TerminId = 4,
                    BrojSjedista = 4,
                    BrojReda = "F",
                    Sjediste = "F4"
                },
                new Kartum()
                {
                    KartaId = 405,
                    Aktivna = true,
                    TerminId = 4,
                    BrojSjedista = 5,
                    BrojReda = "F",
                    Sjediste = "F5"
                },
                new Kartum()
                {
                    KartaId = 406,
                    Aktivna = true,
                    TerminId = 4,
                    BrojSjedista = 6,
                    BrojReda = "F",
                    Sjediste = "F6"
                },
                new Kartum()
                {
                    KartaId = 407,
                    Aktivna = true,
                    TerminId = 4,
                    BrojSjedista = 7,
                    BrojReda = "F",
                    Sjediste = "F7"
                },
                new Kartum()
                {
                    KartaId = 408,
                    Aktivna = true,
                    TerminId = 4,
                    BrojSjedista = 8,
                    BrojReda = "F",
                    Sjediste = "F8"
                },
                new Kartum()
                {
                    KartaId = 409,
                    Aktivna = true,
                    TerminId = 4,
                    BrojSjedista = 9,
                    BrojReda = "F",
                    Sjediste = "F9"
                },
                new Kartum()
                {
                    KartaId = 410,
                    Aktivna = true,
                    TerminId = 4,
                    BrojSjedista = 10,
                    BrojReda = "F",
                    Sjediste = "F10"
                },
                new Kartum()
                {
                    KartaId = 411,
                    Aktivna = true,
                    TerminId = 4,
                    BrojSjedista = 1,
                    BrojReda = "G",
                    Sjediste = "G1"
                },
                new Kartum()
                {
                    KartaId = 412,
                    Aktivna = true,
                    TerminId = 4,
                    BrojSjedista = 2,
                    BrojReda = "G",
                    Sjediste = "G2"
                },
                new Kartum()
                {
                    KartaId = 413,
                    Aktivna = true,
                    TerminId = 4,
                    BrojSjedista = 3,
                    BrojReda = "G",
                    Sjediste = "G3"
                },
                new Kartum()
                {
                    KartaId = 414,
                    Aktivna = true,
                    TerminId = 4,
                    BrojSjedista = 4,
                    BrojReda = "G",
                    Sjediste = "G4"
                },
                new Kartum()
                {
                    KartaId = 415,
                    Aktivna = true,
                    TerminId = 4,
                    BrojSjedista = 5,
                    BrojReda = "G",
                    Sjediste = "G5"
                },
                new Kartum()
                {
                    KartaId = 416,
                    Aktivna = true,
                    TerminId = 4,
                    BrojSjedista = 6,
                    BrojReda = "G",
                    Sjediste = "G6"
                },
                new Kartum()
                {
                    KartaId = 417,
                    Aktivna = true,
                    TerminId = 4,
                    BrojSjedista = 7,
                    BrojReda = "G",
                    Sjediste = "G7"
                },
                new Kartum()
                {
                    KartaId = 418,
                    Aktivna = true,
                    TerminId = 4,
                    BrojSjedista = 8,
                    BrojReda = "G",
                    Sjediste = "G8"
                },
                new Kartum()
                {
                    KartaId = 419,
                    Aktivna = true,
                    TerminId = 4,
                    BrojSjedista = 9,
                    BrojReda = "G",
                    Sjediste = "G9"
                },
                new Kartum()
                {
                    KartaId = 420,
                    Aktivna = true,
                    TerminId = 4,
                    BrojSjedista = 10,
                    BrojReda = "G",
                    Sjediste = "G10"
                },
                new Kartum()
                {
                    KartaId = 421,
                    Aktivna = true,
                    TerminId = 4,
                    BrojSjedista = 1,
                    BrojReda = "H",
                    Sjediste = "H1"
                },
                new Kartum()
                {
                    KartaId = 422,
                    Aktivna = true,
                    TerminId = 4,
                    BrojSjedista = 2,
                    BrojReda = "H",
                    Sjediste = "H2"
                },
                new Kartum()
                {
                    KartaId = 423,
                    Aktivna = true,
                    TerminId = 4,
                    BrojSjedista = 3,
                    BrojReda = "H",
                    Sjediste = "H3"
                },
                new Kartum()
                {
                    KartaId = 424,
                    Aktivna = true,
                    TerminId = 4,
                    BrojSjedista = 4,
                    BrojReda = "H",
                    Sjediste = "H4"
                },
                new Kartum()
                {
                    KartaId = 425,
                    Aktivna = true,
                    TerminId = 4,
                    BrojSjedista = 5,
                    BrojReda = "H",
                    Sjediste = "H5"
                },
                new Kartum()
                {
                    KartaId = 426,
                    Aktivna = true,
                    TerminId = 4,
                    BrojSjedista = 6,
                    BrojReda = "H",
                    Sjediste = "H6"
                },
                new Kartum()
                {
                    KartaId = 427,
                    Aktivna = true,
                    TerminId = 4,
                    BrojSjedista = 7,
                    BrojReda = "H",
                    Sjediste = "H7"
                },
                new Kartum()
                {
                    KartaId = 428,
                    Aktivna = true,
                    TerminId = 4,
                    BrojSjedista = 8,
                    BrojReda = "H",
                    Sjediste = "H8"
                },
                new Kartum()
                {
                    KartaId = 429,
                    Aktivna = true,
                    TerminId = 4,
                    BrojSjedista = 9,
                    BrojReda = "H",
                    Sjediste = "H9"
                },
                new Kartum()
                {
                    KartaId = 430,
                    Aktivna = true,
                    TerminId = 4,
                    BrojSjedista = 10,
                    BrojReda = "H",
                    Sjediste = "H10"
                },
                new Kartum()
                {
                    KartaId = 431,
                    Aktivna = true,
                    TerminId = 4,
                    BrojSjedista = 1,
                    BrojReda = "I",
                    Sjediste = "I1"
                },
                new Kartum()
                {
                    KartaId = 432,
                    Aktivna = true,
                    TerminId = 4,
                    BrojSjedista = 2,
                    BrojReda = "I",
                    Sjediste = "I2"
                },
                new Kartum()
                {
                    KartaId = 433,
                    Aktivna = true,
                    TerminId = 4,
                    BrojSjedista = 3,
                    BrojReda = "I",
                    Sjediste = "I3"
                },
                new Kartum()
                {
                    KartaId = 434,
                    Aktivna = true,
                    TerminId = 4,
                    BrojSjedista = 4,
                    BrojReda = "I",
                    Sjediste = "I4"
                },
                new Kartum()
                {
                    KartaId = 435,
                    Aktivna = true,
                    TerminId = 4,
                    BrojSjedista = 5,
                    BrojReda = "I",
                    Sjediste = "I5"
                },
                new Kartum()
                {
                    KartaId = 436,
                    Aktivna = true,
                    TerminId = 4,
                    BrojSjedista = 6,
                    BrojReda = "I",
                    Sjediste = "I6"
                },
                new Kartum()
                {
                    KartaId = 437,
                    Aktivna = true,
                    TerminId = 4,
                    BrojSjedista = 7,
                    BrojReda = "I",
                    Sjediste = "I7"
                },
                new Kartum()
                {
                    KartaId = 438,
                    Aktivna = true,
                    TerminId = 4,
                    BrojSjedista = 8,
                    BrojReda = "I",
                    Sjediste = "I8"
                },
                new Kartum()
                {
                    KartaId = 439,
                    Aktivna = true,
                    TerminId = 4,
                    BrojSjedista = 9,
                    BrojReda = "I",
                    Sjediste = "I9"
                },
                new Kartum()
                {
                    KartaId = 440,
                    Aktivna = true,
                    TerminId = 4,
                    BrojSjedista = 10,
                    BrojReda = "I",
                    Sjediste = "I10"
                },
                new Kartum()
                {
                    KartaId = 441,
                    Aktivna = true,
                    TerminId = 4,
                    BrojSjedista = 1,
                    BrojReda = "J",
                    Sjediste = "J1"
                },
                new Kartum()
                {
                    KartaId = 442,
                    Aktivna = true,
                    TerminId = 4,
                    BrojSjedista = 2,
                    BrojReda = "J",
                    Sjediste = "J2"
                },
                new Kartum()
                {
                    KartaId = 443,
                    Aktivna = true,
                    TerminId = 4,
                    BrojSjedista = 3,
                    BrojReda = "J",
                    Sjediste = "J3"
                },
                new Kartum()
                {
                    KartaId = 444,
                    Aktivna = true,
                    TerminId = 4,
                    BrojSjedista = 4,
                    BrojReda = "J",
                    Sjediste = "J4"
                },
                new Kartum()
                {
                    KartaId = 445,
                    Aktivna = true,
                    TerminId = 4,
                    BrojSjedista = 5,
                    BrojReda = "J",
                    Sjediste = "J5"
                },
                new Kartum()
                {
                    KartaId = 446,
                    Aktivna = true,
                    TerminId = 4,
                    BrojSjedista = 6,
                    BrojReda = "J",
                    Sjediste = "J6"
                },
                new Kartum()
                {
                    KartaId = 447,
                    Aktivna = true,
                    TerminId = 4,
                    BrojSjedista = 7,
                    BrojReda = "J",
                    Sjediste = "J7"
                },
                new Kartum()
                {
                    KartaId = 448,
                    Aktivna = true,
                    TerminId = 4,
                    BrojSjedista = 8,
                    BrojReda = "J",
                    Sjediste = "J8"
                },
                new Kartum()
                {
                    KartaId = 449,
                    Aktivna = true,
                    TerminId = 4,
                    BrojSjedista = 9,
                    BrojReda = "J",
                    Sjediste = "J9"
                },
                new Kartum()
                {
                    KartaId = 450,
                    Aktivna = true,
                    TerminId = 4,
                    BrojSjedista = 10,
                    BrojReda = "J",
                    Sjediste = "J10"
                },
                new Kartum()
                {
                    KartaId = 451,
                    Aktivna = true,
                    TerminId = 5,
                    BrojSjedista = 1,
                    BrojReda = "A",
                    Sjediste = "A1"
                },
                new Kartum()
                {
                    KartaId = 452,
                    Aktivna = true,
                    TerminId = 5,
                    BrojSjedista = 2,
                    BrojReda = "A",
                    Sjediste = "A2"
                },
                 new Kartum()
                {
                    KartaId = 453,
                    Aktivna = false,
                    TerminId = 5,
                    BrojSjedista = 3,
                    BrojReda = "A",
                    Sjediste = "A3",
                    KupovinaId = 3
                },
                new Kartum()
                {
                    KartaId = 454,
                    Aktivna = true,
                    TerminId = 5,
                    BrojSjedista = 4,
                    BrojReda = "A",
                    Sjediste = "A4"
                },
                 new Kartum()
                {
                    KartaId = 455,
                    Aktivna = true,
                    TerminId = 5,
                    BrojSjedista = 5,
                    BrojReda = "A",
                    Sjediste = "A5"
                },
                new Kartum()
                {
                    KartaId = 456,
                    Aktivna = true,
                    TerminId = 5,
                    BrojSjedista = 6,
                    BrojReda = "A",
                    Sjediste = "A6"
                },
                 new Kartum()
                {
                    KartaId = 457,
                    Aktivna = true,
                    TerminId = 5,
                    BrojSjedista = 7,
                    BrojReda = "A",
                    Sjediste = "A7"
                },
                new Kartum()
                {
                    KartaId = 458,
                    Aktivna = true,
                    TerminId = 5,
                    BrojSjedista = 8,
                    BrojReda = "A",
                    Sjediste = "A8"
                },
                 new Kartum()
                {
                    KartaId = 459,
                    Aktivna = true,
                    TerminId = 5,
                    BrojSjedista = 9,
                    BrojReda = "A",
                    Sjediste = "A9"
                },
                new Kartum()
                {
                    KartaId = 460,
                    Aktivna = true,
                    TerminId = 5,
                    BrojSjedista = 10,
                    BrojReda = "A",
                    Sjediste = "A10"
                },
                new Kartum()
                {
                    KartaId = 461,
                    Aktivna = true,
                    TerminId = 5,
                    BrojSjedista = 1,
                    BrojReda = "B",
                    Sjediste = "B1"
                },
                new Kartum()
                {
                    KartaId = 462,
                    Aktivna = true,
                    TerminId = 5,
                    BrojSjedista = 2,
                    BrojReda = "B",
                    Sjediste = "B2"
                },
                new Kartum()
                {
                    KartaId = 463,
                    Aktivna = true,
                    TerminId = 5,
                    BrojSjedista = 3,
                    BrojReda = "B",
                    Sjediste = "B3"
                },
                new Kartum()
                {
                    KartaId = 464,
                    Aktivna = true,
                    TerminId = 5,
                    BrojSjedista = 4,
                    BrojReda = "B",
                    Sjediste = "B4"
                },
                new Kartum()
                {
                    KartaId = 465,
                    Aktivna = true,
                    TerminId = 5,
                    BrojSjedista = 5,
                    BrojReda = "B",
                    Sjediste = "B5"
                },
                new Kartum()
                {
                    KartaId = 466,
                    Aktivna = true,
                    TerminId = 5,
                    BrojSjedista = 6,
                    BrojReda = "B",
                    Sjediste = "B6"
                },
                new Kartum()
                {
                    KartaId = 467,
                    Aktivna = true,
                    TerminId = 5,
                    BrojSjedista = 7,
                    BrojReda = "B",
                    Sjediste = "B7"
                },
                new Kartum()
                {
                    KartaId = 468,
                    Aktivna = true,
                    TerminId = 5,
                    BrojSjedista = 8,
                    BrojReda = "B",
                    Sjediste = "B8"
                },
                new Kartum()
                {
                    KartaId = 469,
                    Aktivna = true,
                    TerminId = 5,
                    BrojSjedista = 9,
                    BrojReda = "B",
                    Sjediste = "B9"
                },
                new Kartum()
                {
                    KartaId = 470,
                    Aktivna = true,
                    TerminId = 5,
                    BrojSjedista = 10,
                    BrojReda = "B",
                    Sjediste = "B10"
                },
                new Kartum()
                {
                    KartaId = 471,
                    Aktivna = true,
                    TerminId = 5,
                    BrojSjedista = 1,
                    BrojReda = "C",
                    Sjediste = "C1"
                },
                new Kartum()
                {
                    KartaId = 472,
                    Aktivna = true,
                    TerminId = 5,
                    BrojSjedista = 2,
                    BrojReda = "C",
                    Sjediste = "C2"
                },
                new Kartum()
                {
                    KartaId = 473,
                    Aktivna = true,
                    TerminId = 5,
                    BrojSjedista = 3,
                    BrojReda = "C",
                    Sjediste = "C3"
                },
                new Kartum()
                {
                    KartaId = 474,
                    Aktivna = true,
                    TerminId = 5,
                    BrojSjedista = 4,
                    BrojReda = "C",
                    Sjediste = "C4"
                },
                new Kartum()
                {
                    KartaId = 475,
                    Aktivna = true,
                    TerminId = 5,
                    BrojSjedista = 5,
                    BrojReda = "C",
                    Sjediste = "C5"
                },
                new Kartum()
                {
                    KartaId = 476,
                    Aktivna = true,
                    TerminId = 5,
                    BrojSjedista = 6,
                    BrojReda = "C",
                    Sjediste = "C6"
                },
                new Kartum()
                {
                    KartaId = 477,
                    Aktivna = true,
                    TerminId = 5,
                    BrojSjedista = 7,
                    BrojReda = "C",
                    Sjediste = "C7"
                },
                new Kartum()
                {
                    KartaId = 478,
                    Aktivna = true,
                    TerminId = 5,
                    BrojSjedista = 8,
                    BrojReda = "C",
                    Sjediste = "C8"
                },
                new Kartum()
                {
                    KartaId = 479,
                    Aktivna = true,
                    TerminId = 5,
                    BrojSjedista = 9,
                    BrojReda = "C",
                    Sjediste = "C9"
                },
                new Kartum()
                {
                    KartaId = 480,
                    Aktivna = true,
                    TerminId = 5,
                    BrojSjedista = 10,
                    BrojReda = "C",
                    Sjediste = "C10"
                },
                new Kartum()
                {
                    KartaId = 481,
                    Aktivna = true,
                    TerminId = 5,
                    BrojSjedista = 1,
                    BrojReda = "D",
                    Sjediste = "D1"
                },
                new Kartum()
                {
                    KartaId = 482,
                    Aktivna = true,
                    TerminId = 5,
                    BrojSjedista = 2,
                    BrojReda = "D",
                    Sjediste = "D2"
                },
                new Kartum()
                {
                    KartaId = 483,
                    Aktivna = true,
                    TerminId = 5,
                    BrojSjedista = 3,
                    BrojReda = "D",
                    Sjediste = "D3"
                },
                new Kartum()
                {
                    KartaId = 484,
                    Aktivna = true,
                    TerminId = 5,
                    BrojSjedista = 4,
                    BrojReda = "D",
                    Sjediste = "D4"
                },
                new Kartum()
                {
                    KartaId = 485,
                    Aktivna = true,
                    TerminId = 5,
                    BrojSjedista = 5,
                    BrojReda = "D",
                    Sjediste = "D5"
                },
                new Kartum()
                {
                    KartaId = 486,
                    Aktivna = true,
                    TerminId = 5,
                    BrojSjedista = 6,
                    BrojReda = "D",
                    Sjediste = "D6"
                },
                new Kartum()
                {
                    KartaId = 487,
                    Aktivna = true,
                    TerminId = 5,
                    BrojSjedista = 7,
                    BrojReda = "D",
                    Sjediste = "D7"
                },
                new Kartum()
                {
                    KartaId = 488,
                    Aktivna = true,
                    TerminId = 5,
                    BrojSjedista = 8,
                    BrojReda = "D",
                    Sjediste = "D8"
                },
                new Kartum()
                {
                    KartaId = 489,
                    Aktivna = true,
                    TerminId = 5,
                    BrojSjedista = 9,
                    BrojReda = "D",
                    Sjediste = "D9"
                },
                new Kartum()
                {
                    KartaId = 490,
                    Aktivna = true,
                    TerminId = 5,
                    BrojSjedista = 10,
                    BrojReda = "D",
                    Sjediste = "D10"
                },
                new Kartum()
                {
                    KartaId = 491,
                    Aktivna = true,
                    TerminId = 5,
                    BrojSjedista = 1,
                    BrojReda = "E",
                    Sjediste = "E1"
                },
                new Kartum()
                {
                    KartaId = 492,
                    Aktivna = true,
                    TerminId = 5,
                    BrojSjedista = 2,
                    BrojReda = "E",
                    Sjediste = "E2"
                },
                new Kartum()
                {
                    KartaId = 493,
                    Aktivna = true,
                    TerminId = 5,
                    BrojSjedista = 3,
                    BrojReda = "E",
                    Sjediste = "E3"
                },
                new Kartum()
                {
                    KartaId = 494,
                    Aktivna = true,
                    TerminId = 5,
                    BrojSjedista = 4,
                    BrojReda = "E",
                    Sjediste = "E4"
                },
                new Kartum()
                {
                    KartaId = 495,
                    Aktivna = true,
                    TerminId = 5,
                    BrojSjedista = 5,
                    BrojReda = "E",
                    Sjediste = "E5"
                },
                new Kartum()
                {
                    KartaId = 496,
                    Aktivna = true,
                    TerminId = 5,
                    BrojSjedista = 6,
                    BrojReda = "E",
                    Sjediste = "E6"
                },
                new Kartum()
                {
                    KartaId = 497,
                    Aktivna = true,
                    TerminId = 5,
                    BrojSjedista = 7,
                    BrojReda = "E",
                    Sjediste = "E7"
                },
                new Kartum()
                {
                    KartaId = 498,
                    Aktivna = true,
                    TerminId = 5,
                    BrojSjedista = 8,
                    BrojReda = "E",
                    Sjediste = "E8"
                },
                new Kartum()
                {
                    KartaId = 499,
                    Aktivna = true,
                    TerminId = 5,
                    BrojSjedista = 9,
                    BrojReda = "E",
                    Sjediste = "E9"
                },
                new Kartum()
                {
                    KartaId = 500,
                    Aktivna = true,
                    TerminId = 5,
                    BrojSjedista = 10,
                    BrojReda = "E",
                    Sjediste = "E10"
                },
                new Kartum()
                {
                    KartaId = 501,
                    Aktivna = true,
                    TerminId = 5,
                    BrojSjedista = 1,
                    BrojReda = "F",
                    Sjediste = "F1"
                },
                new Kartum()
                {
                    KartaId = 502,
                    Aktivna = true,
                    TerminId = 5,
                    BrojSjedista = 2,
                    BrojReda = "F",
                    Sjediste = "F2"
                },
                new Kartum()
                {
                    KartaId = 503,
                    Aktivna = true,
                    TerminId = 5,
                    BrojSjedista = 3,
                    BrojReda = "F",
                    Sjediste = "F3"
                },
                new Kartum()
                {
                    KartaId = 504,
                    Aktivna = true,
                    TerminId = 5,
                    BrojSjedista = 4,
                    BrojReda = "F",
                    Sjediste = "F4"
                },
                new Kartum()
                {
                    KartaId = 505,
                    Aktivna = true,
                    TerminId = 5,
                    BrojSjedista = 5,
                    BrojReda = "F",
                    Sjediste = "F5"
                },
                new Kartum()
                {
                    KartaId = 506,
                    Aktivna = true,
                    TerminId = 5,
                    BrojSjedista = 6,
                    BrojReda = "F",
                    Sjediste = "F6"
                },
                new Kartum()
                {
                    KartaId = 507,
                    Aktivna = true,
                    TerminId = 5,
                    BrojSjedista = 7,
                    BrojReda = "F",
                    Sjediste = "F7"
                },
                new Kartum()
                {
                    KartaId = 508,
                    Aktivna = true,
                    TerminId = 5,
                    BrojSjedista = 8,
                    BrojReda = "F",
                    Sjediste = "F8"
                },
                new Kartum()
                {
                    KartaId = 509,
                    Aktivna = true,
                    TerminId = 5,
                    BrojSjedista = 9,
                    BrojReda = "F",
                    Sjediste = "F9"
                },
                new Kartum()
                {
                    KartaId = 510,
                    Aktivna = true,
                    TerminId = 5,
                    BrojSjedista = 10,
                    BrojReda = "F",
                    Sjediste = "F10"
                },
                new Kartum()
                {
                    KartaId = 511,
                    Aktivna = true,
                    TerminId = 5,
                    BrojSjedista = 1,
                    BrojReda = "G",
                    Sjediste = "G1"
                },
                new Kartum()
                {
                    KartaId = 512,
                    Aktivna = true,
                    TerminId = 5,
                    BrojSjedista = 2,
                    BrojReda = "G",
                    Sjediste = "G2"
                },
                new Kartum()
                {
                    KartaId = 513,
                    Aktivna = true,
                    TerminId = 5,
                    BrojSjedista = 3,
                    BrojReda = "G",
                    Sjediste = "G3"
                },
                new Kartum()
                {
                    KartaId = 514,
                    Aktivna = true,
                    TerminId = 5,
                    BrojSjedista = 4,
                    BrojReda = "G",
                    Sjediste = "G4"
                },
                new Kartum()
                {
                    KartaId = 515,
                    Aktivna = true,
                    TerminId = 5,
                    BrojSjedista = 5,
                    BrojReda = "G",
                    Sjediste = "G5"
                },
                new Kartum()
                {
                    KartaId = 516,
                    Aktivna = true,
                    TerminId = 5,
                    BrojSjedista = 6,
                    BrojReda = "G",
                    Sjediste = "G6"
                },
                new Kartum()
                {
                    KartaId = 517,
                    Aktivna = true,
                    TerminId = 5,
                    BrojSjedista = 7,
                    BrojReda = "G",
                    Sjediste = "G7"
                },
                new Kartum()
                {
                    KartaId = 518,
                    Aktivna = true,
                    TerminId = 5,
                    BrojSjedista = 8,
                    BrojReda = "G",
                    Sjediste = "G8"
                },
                new Kartum()
                {
                    KartaId = 519,
                    Aktivna = true,
                    TerminId = 5,
                    BrojSjedista = 9,
                    BrojReda = "G",
                    Sjediste = "G9"
                },
                new Kartum()
                {
                    KartaId = 520,
                    Aktivna = true,
                    TerminId = 5,
                    BrojSjedista = 10,
                    BrojReda = "G",
                    Sjediste = "G10"
                },
                new Kartum()
                {
                    KartaId = 521,
                    Aktivna = true,
                    TerminId = 5,
                    BrojSjedista = 1,
                    BrojReda = "H",
                    Sjediste = "H1"
                },
                new Kartum()
                {
                    KartaId = 522,
                    Aktivna = true,
                    TerminId = 5,
                    BrojSjedista = 2,
                    BrojReda = "H",
                    Sjediste = "H2"
                },
                new Kartum()
                {
                    KartaId = 523,
                    Aktivna = true,
                    TerminId = 5,
                    BrojSjedista = 3,
                    BrojReda = "H",
                    Sjediste = "H3"
                },
                new Kartum()
                {
                    KartaId = 524,
                    Aktivna = true,
                    TerminId = 5,
                    BrojSjedista = 4,
                    BrojReda = "H",
                    Sjediste = "H4"
                },
                new Kartum()
                {
                    KartaId = 525,
                    Aktivna = true,
                    TerminId = 5,
                    BrojSjedista = 5,
                    BrojReda = "H",
                    Sjediste = "H5"
                },
                new Kartum()
                {
                    KartaId = 526,
                    Aktivna = true,
                    TerminId = 5,
                    BrojSjedista = 6,
                    BrojReda = "H",
                    Sjediste = "H6"
                },
                new Kartum()
                {
                    KartaId = 527,
                    Aktivna = true,
                    TerminId = 5,
                    BrojSjedista = 7,
                    BrojReda = "H",
                    Sjediste = "H7"
                },
                new Kartum()
                {
                    KartaId = 528,
                    Aktivna = true,
                    TerminId = 5,
                    BrojSjedista = 8,
                    BrojReda = "H",
                    Sjediste = "H8"
                },
                new Kartum()
                {
                    KartaId = 529,
                    Aktivna = true,
                    TerminId = 5,
                    BrojSjedista = 9,
                    BrojReda = "H",
                    Sjediste = "H9"
                },
                new Kartum()
                {
                    KartaId = 530,
                    Aktivna = true,
                    TerminId = 5,
                    BrojSjedista = 10,
                    BrojReda = "H",
                    Sjediste = "H10"
                },
                new Kartum()
                {
                    KartaId = 531,
                    Aktivna = true,
                    TerminId = 5,
                    BrojSjedista = 1,
                    BrojReda = "I",
                    Sjediste = "I1"
                },
                new Kartum()
                {
                    KartaId = 532,
                    Aktivna = true,
                    TerminId = 5,
                    BrojSjedista = 2,
                    BrojReda = "I",
                    Sjediste = "I2"
                },
                new Kartum()
                {
                    KartaId = 533,
                    Aktivna = true,
                    TerminId = 5,
                    BrojSjedista = 3,
                    BrojReda = "I",
                    Sjediste = "I3"
                },
                new Kartum()
                {
                    KartaId = 534,
                    Aktivna = true,
                    TerminId = 5,
                    BrojSjedista = 4,
                    BrojReda = "I",
                    Sjediste = "I4"
                },
                new Kartum()
                {
                    KartaId = 535,
                    Aktivna = true,
                    TerminId = 5,
                    BrojSjedista = 5,
                    BrojReda = "I",
                    Sjediste = "I5"
                },
                new Kartum()
                {
                    KartaId = 536,
                    Aktivna = true,
                    TerminId = 5,
                    BrojSjedista = 6,
                    BrojReda = "I",
                    Sjediste = "I6"
                },
                new Kartum()
                {
                    KartaId = 537,
                    Aktivna = true,
                    TerminId = 5,
                    BrojSjedista = 7,
                    BrojReda = "I",
                    Sjediste = "I7"
                },
                new Kartum()
                {
                    KartaId = 538,
                    Aktivna = true,
                    TerminId = 5,
                    BrojSjedista = 8,
                    BrojReda = "I",
                    Sjediste = "I8"
                },
                new Kartum()
                {
                    KartaId = 539,
                    Aktivna = true,
                    TerminId = 5,
                    BrojSjedista = 9,
                    BrojReda = "I",
                    Sjediste = "I9"
                },
                new Kartum()
                {
                    KartaId = 540,
                    Aktivna = true,
                    TerminId = 5,
                    BrojSjedista = 10,
                    BrojReda = "I",
                    Sjediste = "I10"
                },
                new Kartum()
                {
                    KartaId = 541,
                    Aktivna = true,
                    TerminId = 5,
                    BrojSjedista = 1,
                    BrojReda = "J",
                    Sjediste = "J1"
                },
                new Kartum()
                {
                    KartaId = 542,
                    Aktivna = true,
                    TerminId = 5,
                    BrojSjedista = 2,
                    BrojReda = "J",
                    Sjediste = "J2"
                },
                new Kartum()
                {
                    KartaId = 543,
                    Aktivna = true,
                    TerminId = 5,
                    BrojSjedista = 3,
                    BrojReda = "J",
                    Sjediste = "J3"
                },
                new Kartum()
                {
                    KartaId = 544,
                    Aktivna = true,
                    TerminId = 5,
                    BrojSjedista = 4,
                    BrojReda = "J",
                    Sjediste = "J4"
                },
                new Kartum()
                {
                    KartaId = 545,
                    Aktivna = true,
                    TerminId = 5,
                    BrojSjedista = 5,
                    BrojReda = "J",
                    Sjediste = "J5"
                },
                new Kartum()
                {
                    KartaId = 546,
                    Aktivna = true,
                    TerminId = 5,
                    BrojSjedista = 6,
                    BrojReda = "J",
                    Sjediste = "J6"
                },
                new Kartum()
                {
                    KartaId = 547,
                    Aktivna = true,
                    TerminId = 5,
                    BrojSjedista = 7,
                    BrojReda = "J",
                    Sjediste = "J7"
                },
                new Kartum()
                {
                    KartaId = 548,
                    Aktivna = true,
                    TerminId = 5,
                    BrojSjedista = 8,
                    BrojReda = "J",
                    Sjediste = "J8"
                },
                new Kartum()
                {
                    KartaId = 549,
                    Aktivna = true,
                    TerminId = 5,
                    BrojSjedista = 9,
                    BrojReda = "J",
                    Sjediste = "J9"
                },
                new Kartum()
                {
                    KartaId = 550,
                    Aktivna = false,
                    TerminId = 5,
                    BrojSjedista = 10,
                    BrojReda = "J",
                    Sjediste = "J10",
                    KupovinaId = 2
                },
                new Kartum()
                {
                    KartaId = 551,
                    Aktivna = false,
                    TerminId = 6,
                    BrojSjedista = 1,
                    BrojReda = "A",
                    Sjediste = "A1",
                    KupovinaId = 2
                },
                new Kartum()
                {
                    KartaId = 552,
                    Aktivna = false,
                    TerminId = 6,
                    BrojSjedista = 2,
                    BrojReda = "A",
                    Sjediste = "A2",
                    KupovinaId = 2
                },
                 new Kartum()
                {
                    KartaId = 553,
                    Aktivna = true,
                    TerminId = 6,
                    BrojSjedista = 3,
                    BrojReda = "A",
                    Sjediste = "A3"
                },
                new Kartum()
                {
                    KartaId = 554,
                    Aktivna = true,
                    TerminId = 6,
                    BrojSjedista = 4,
                    BrojReda = "A",
                    Sjediste = "A4"
                },
                 new Kartum()
                {
                    KartaId = 555,
                    Aktivna = true,
                    TerminId = 6,
                    BrojSjedista = 5,
                    BrojReda = "A",
                    Sjediste = "A5"
                },
                new Kartum()
                {
                    KartaId = 556,
                    Aktivna = true,
                    TerminId = 6,
                    BrojSjedista = 6,
                    BrojReda = "A",
                    Sjediste = "A6"
                },
                 new Kartum()
                {
                    KartaId = 557,
                    Aktivna = true,
                    TerminId = 6,
                    BrojSjedista = 7,
                    BrojReda = "A",
                    Sjediste = "A7"
                },
                new Kartum()
                {
                    KartaId = 558,
                    Aktivna = true,
                    TerminId = 6,
                    BrojSjedista = 8,
                    BrojReda = "A",
                    Sjediste = "A8"
                },
                 new Kartum()
                {
                    KartaId = 559,
                    Aktivna = true,
                    TerminId = 6,
                    BrojSjedista = 9,
                    BrojReda = "A",
                    Sjediste = "A9"
                },
                new Kartum()
                {
                    KartaId = 560,
                    Aktivna = true,
                    TerminId = 6,
                    BrojSjedista = 10,
                    BrojReda = "A",
                    Sjediste = "A10"
                },
                new Kartum()
                {
                    KartaId = 561,
                    Aktivna = true,
                    TerminId = 6,
                    BrojSjedista = 1,
                    BrojReda = "B",
                    Sjediste = "B1"
                },
                new Kartum()
                {
                    KartaId = 562,
                    Aktivna = true,
                    TerminId = 6,
                    BrojSjedista = 2,
                    BrojReda = "B",
                    Sjediste = "B2"
                },
                new Kartum()
                {
                    KartaId = 563,
                    Aktivna = true,
                    TerminId = 6,
                    BrojSjedista = 3,
                    BrojReda = "B",
                    Sjediste = "B3"
                },
                new Kartum()
                {
                    KartaId = 564,
                    Aktivna = true,
                    TerminId = 6,
                    BrojSjedista = 4,
                    BrojReda = "B",
                    Sjediste = "B4"
                },
                new Kartum()
                {
                    KartaId = 565,
                    Aktivna = true,
                    TerminId = 6,
                    BrojSjedista = 5,
                    BrojReda = "B",
                    Sjediste = "B5"
                },
                new Kartum()
                {
                    KartaId = 566,
                    Aktivna = true,
                    TerminId = 6,
                    BrojSjedista = 6,
                    BrojReda = "B",
                    Sjediste = "B6"
                },
                new Kartum()
                {
                    KartaId = 567,
                    Aktivna = true,
                    TerminId = 6,
                    BrojSjedista = 7,
                    BrojReda = "B",
                    Sjediste = "B7"
                },
                new Kartum()
                {
                    KartaId = 568,
                    Aktivna = true,
                    TerminId = 6,
                    BrojSjedista = 8,
                    BrojReda = "B",
                    Sjediste = "B8"
                },
                new Kartum()
                {
                    KartaId = 569,
                    Aktivna = true,
                    TerminId = 6,
                    BrojSjedista = 9,
                    BrojReda = "B",
                    Sjediste = "B9"
                },
                new Kartum()
                {
                    KartaId = 570,
                    Aktivna = true,
                    TerminId = 6,
                    BrojSjedista = 10,
                    BrojReda = "B",
                    Sjediste = "B10"
                },
                new Kartum()
                {
                    KartaId = 571,
                    Aktivna = true,
                    TerminId = 6,
                    BrojSjedista = 1,
                    BrojReda = "C",
                    Sjediste = "C1"
                },
                new Kartum()
                {
                    KartaId = 572,
                    Aktivna = true,
                    TerminId = 6,
                    BrojSjedista = 2,
                    BrojReda = "C",
                    Sjediste = "C2"
                },
                new Kartum()
                {
                    KartaId = 573,
                    Aktivna = true,
                    TerminId = 6,
                    BrojSjedista = 3,
                    BrojReda = "C",
                    Sjediste = "C3"
                },
                new Kartum()
                {
                    KartaId = 574,
                    Aktivna = true,
                    TerminId = 6,
                    BrojSjedista = 4,
                    BrojReda = "C",
                    Sjediste = "C4"
                },
                new Kartum()
                {
                    KartaId = 575,
                    Aktivna = true,
                    TerminId = 6,
                    BrojSjedista = 5,
                    BrojReda = "C",
                    Sjediste = "C5"
                },
                new Kartum()
                {
                    KartaId = 576,
                    Aktivna = true,
                    TerminId = 6,
                    BrojSjedista = 6,
                    BrojReda = "C",
                    Sjediste = "C6"
                },
                new Kartum()
                {
                    KartaId = 577,
                    Aktivna = true,
                    TerminId = 6,
                    BrojSjedista = 7,
                    BrojReda = "C",
                    Sjediste = "C7"
                },
                new Kartum()
                {
                    KartaId = 578,
                    Aktivna = true,
                    TerminId = 6,
                    BrojSjedista = 8,
                    BrojReda = "C",
                    Sjediste = "C8"
                },
                new Kartum()
                {
                    KartaId = 579,
                    Aktivna = true,
                    TerminId = 6,
                    BrojSjedista = 9,
                    BrojReda = "C",
                    Sjediste = "C9"
                },
                new Kartum()
                {
                    KartaId = 580,
                    Aktivna = true,
                    TerminId = 6,
                    BrojSjedista = 10,
                    BrojReda = "C",
                    Sjediste = "C10"
                },
                new Kartum()
                {
                    KartaId = 581,
                    Aktivna = true,
                    TerminId = 6,
                    BrojSjedista = 1,
                    BrojReda = "D",
                    Sjediste = "D1"
                },
                new Kartum()
                {
                    KartaId = 582,
                    Aktivna = true,
                    TerminId = 6,
                    BrojSjedista = 2,
                    BrojReda = "D",
                    Sjediste = "D2"
                },
                new Kartum()
                {
                    KartaId = 583,
                    Aktivna = true,
                    TerminId = 6,
                    BrojSjedista = 3,
                    BrojReda = "D",
                    Sjediste = "D3"
                },
                new Kartum()
                {
                    KartaId = 584,
                    Aktivna = true,
                    TerminId = 6,
                    BrojSjedista = 4,
                    BrojReda = "D",
                    Sjediste = "D4"
                },
                new Kartum()
                {
                    KartaId = 585,
                    Aktivna = true,
                    TerminId = 6,
                    BrojSjedista = 5,
                    BrojReda = "D",
                    Sjediste = "D5"
                },
                new Kartum()
                {
                    KartaId = 586,
                    Aktivna = true,
                    TerminId = 6,
                    BrojSjedista = 6,
                    BrojReda = "D",
                    Sjediste = "D6"
                },
                new Kartum()
                {
                    KartaId = 587,
                    Aktivna = true,
                    TerminId = 6,
                    BrojSjedista = 7,
                    BrojReda = "D",
                    Sjediste = "D7"
                },
                new Kartum()
                {
                    KartaId = 588,
                    Aktivna = true,
                    TerminId = 6,
                    BrojSjedista = 8,
                    BrojReda = "D",
                    Sjediste = "D8"
                },
                new Kartum()
                {
                    KartaId = 589,
                    Aktivna = true,
                    TerminId = 6,
                    BrojSjedista = 9,
                    BrojReda = "D",
                    Sjediste = "D9"
                },
                new Kartum()
                {
                    KartaId = 590,
                    Aktivna = true,
                    TerminId = 6,
                    BrojSjedista = 10,
                    BrojReda = "D",
                    Sjediste = "D10"
                },
                new Kartum()
                {
                    KartaId = 591,
                    Aktivna = true,
                    TerminId = 6,
                    BrojSjedista = 1,
                    BrojReda = "E",
                    Sjediste = "E1"
                },
                new Kartum()
                {
                    KartaId = 592,
                    Aktivna = true,
                    TerminId = 6,
                    BrojSjedista = 2,
                    BrojReda = "E",
                    Sjediste = "E2"
                },
                new Kartum()
                {
                    KartaId = 593,
                    Aktivna = true,
                    TerminId = 6,
                    BrojSjedista = 3,
                    BrojReda = "E",
                    Sjediste = "E3"
                },
                new Kartum()
                {
                    KartaId = 594,
                    Aktivna = true,
                    TerminId = 6,
                    BrojSjedista = 4,
                    BrojReda = "E",
                    Sjediste = "E4"
                },
                new Kartum()
                {
                    KartaId = 595,
                    Aktivna = true,
                    TerminId = 6,
                    BrojSjedista = 5,
                    BrojReda = "E",
                    Sjediste = "E5"
                },
                new Kartum()
                {
                    KartaId = 596,
                    Aktivna = true,
                    TerminId = 6,
                    BrojSjedista = 6,
                    BrojReda = "E",
                    Sjediste = "E6"
                },
                new Kartum()
                {
                    KartaId = 597,
                    Aktivna = true,
                    TerminId = 6,
                    BrojSjedista = 7,
                    BrojReda = "E",
                    Sjediste = "E7"
                },
                new Kartum()
                {
                    KartaId = 598,
                    Aktivna = true,
                    TerminId = 6,
                    BrojSjedista = 8,
                    BrojReda = "E",
                    Sjediste = "E8"
                },
                new Kartum()
                {
                    KartaId = 599,
                    Aktivna = true,
                    TerminId = 6,
                    BrojSjedista = 9,
                    BrojReda = "E",
                    Sjediste = "E9"
                },
                new Kartum()
                {
                    KartaId = 600,
                    Aktivna = true,
                    TerminId = 6,
                    BrojSjedista = 10,
                    BrojReda = "E",
                    Sjediste = "E10"
                },
                new Kartum()
                {
                    KartaId = 601,
                    Aktivna = true,
                    TerminId = 6,
                    BrojSjedista = 1,
                    BrojReda = "F",
                    Sjediste = "F1"
                },
                new Kartum()
                {
                    KartaId = 602,
                    Aktivna = true,
                    TerminId = 6,
                    BrojSjedista = 2,
                    BrojReda = "F",
                    Sjediste = "F2"
                },
                new Kartum()
                {
                    KartaId = 603,
                    Aktivna = true,
                    TerminId = 6,
                    BrojSjedista = 3,
                    BrojReda = "F",
                    Sjediste = "F3"
                },
                new Kartum()
                {
                    KartaId = 604,
                    Aktivna = true,
                    TerminId = 6,
                    BrojSjedista = 4,
                    BrojReda = "F",
                    Sjediste = "F4"
                },
                new Kartum()
                {
                    KartaId = 605,
                    Aktivna = true,
                    TerminId = 6,
                    BrojSjedista = 5,
                    BrojReda = "F",
                    Sjediste = "F5"
                },
                new Kartum()
                {
                    KartaId = 606,
                    Aktivna = true,
                    TerminId = 6,
                    BrojSjedista = 6,
                    BrojReda = "F",
                    Sjediste = "F6"
                },
                new Kartum()
                {
                    KartaId = 607,
                    Aktivna = true,
                    TerminId = 6,
                    BrojSjedista = 7,
                    BrojReda = "F",
                    Sjediste = "F7"
                },
                new Kartum()
                {
                    KartaId = 608,
                    Aktivna = true,
                    TerminId = 6,
                    BrojSjedista = 8,
                    BrojReda = "F",
                    Sjediste = "F8"
                },
                new Kartum()
                {
                    KartaId = 609,
                    Aktivna = true,
                    TerminId = 6,
                    BrojSjedista = 9,
                    BrojReda = "F",
                    Sjediste = "F9"
                },
                new Kartum()
                {
                    KartaId = 610,
                    Aktivna = true,
                    TerminId = 6,
                    BrojSjedista = 10,
                    BrojReda = "F",
                    Sjediste = "F10"
                },
                new Kartum()
                {
                    KartaId = 611,
                    Aktivna = true,
                    TerminId = 6,
                    BrojSjedista = 1,
                    BrojReda = "G",
                    Sjediste = "G1"
                },
                new Kartum()
                {
                    KartaId = 612,
                    Aktivna = true,
                    TerminId = 6,
                    BrojSjedista = 2,
                    BrojReda = "G",
                    Sjediste = "G2"
                },
                new Kartum()
                {
                    KartaId = 613,
                    Aktivna = true,
                    TerminId = 6,
                    BrojSjedista = 3,
                    BrojReda = "G",
                    Sjediste = "G3"
                },
                new Kartum()
                {
                    KartaId = 614,
                    Aktivna = true,
                    TerminId = 6,
                    BrojSjedista = 4,
                    BrojReda = "G",
                    Sjediste = "G4"
                },
                new Kartum()
                {
                    KartaId = 615,
                    Aktivna = true,
                    TerminId = 6,
                    BrojSjedista = 5,
                    BrojReda = "G",
                    Sjediste = "G5"
                },
                new Kartum()
                {
                    KartaId = 616,
                    Aktivna = true,
                    TerminId = 6,
                    BrojSjedista = 6,
                    BrojReda = "G",
                    Sjediste = "G6"
                },
                new Kartum()
                {
                    KartaId = 617,
                    Aktivna = true,
                    TerminId = 6,
                    BrojSjedista = 7,
                    BrojReda = "G",
                    Sjediste = "G7"
                },
                new Kartum()
                {
                    KartaId = 618,
                    Aktivna = true,
                    TerminId = 6,
                    BrojSjedista = 8,
                    BrojReda = "G",
                    Sjediste = "G8"
                },
                new Kartum()
                {
                    KartaId = 619,
                    Aktivna = true,
                    TerminId = 6,
                    BrojSjedista = 9,
                    BrojReda = "G",
                    Sjediste = "G9"
                },
                new Kartum()
                {
                    KartaId = 620,
                    Aktivna = true,
                    TerminId = 6,
                    BrojSjedista = 10,
                    BrojReda = "G",
                    Sjediste = "G10"
                },
                new Kartum()
                {
                    KartaId = 621,
                    Aktivna = true,
                    TerminId = 6,
                    BrojSjedista = 1,
                    BrojReda = "H",
                    Sjediste = "H1"
                },
                new Kartum()
                {
                    KartaId = 622,
                    Aktivna = true,
                    TerminId = 6,
                    BrojSjedista = 2,
                    BrojReda = "H",
                    Sjediste = "H2"
                },
                new Kartum()
                {
                    KartaId = 623,
                    Aktivna = true,
                    TerminId = 6,
                    BrojSjedista = 3,
                    BrojReda = "H",
                    Sjediste = "H3"
                },
                new Kartum()
                {
                    KartaId = 624,
                    Aktivna = true,
                    TerminId = 6,
                    BrojSjedista = 4,
                    BrojReda = "H",
                    Sjediste = "H4"
                },
                new Kartum()
                {
                    KartaId = 625,
                    Aktivna = true,
                    TerminId = 6,
                    BrojSjedista = 5,
                    BrojReda = "H",
                    Sjediste = "H5"
                },
                new Kartum()
                {
                    KartaId = 626,
                    Aktivna = true,
                    TerminId = 6,
                    BrojSjedista = 6,
                    BrojReda = "H",
                    Sjediste = "H6"
                },
                new Kartum()
                {
                    KartaId = 627,
                    Aktivna = true,
                    TerminId = 6,
                    BrojSjedista = 7,
                    BrojReda = "H",
                    Sjediste = "H7"
                },
                new Kartum()
                {
                    KartaId = 628,
                    Aktivna = true,
                    TerminId = 6,
                    BrojSjedista = 8,
                    BrojReda = "H",
                    Sjediste = "H8"
                },
                new Kartum()
                {
                    KartaId = 629,
                    Aktivna = true,
                    TerminId = 6,
                    BrojSjedista = 9,
                    BrojReda = "H",
                    Sjediste = "H9"
                },
                new Kartum()
                {
                    KartaId = 630,
                    Aktivna = true,
                    TerminId = 6,
                    BrojSjedista = 10,
                    BrojReda = "H",
                    Sjediste = "H10"
                },
                new Kartum()
                {
                    KartaId = 631,
                    Aktivna = true,
                    TerminId = 6,
                    BrojSjedista = 1,
                    BrojReda = "I",
                    Sjediste = "I1"
                },
                new Kartum()
                {
                    KartaId = 632,
                    Aktivna = true,
                    TerminId = 6,
                    BrojSjedista = 2,
                    BrojReda = "I",
                    Sjediste = "I2"
                },
                new Kartum()
                {
                    KartaId = 633,
                    Aktivna = true,
                    TerminId = 6,
                    BrojSjedista = 3,
                    BrojReda = "I",
                    Sjediste = "I3"
                },
                new Kartum()
                {
                    KartaId = 634,
                    Aktivna = true,
                    TerminId = 6,
                    BrojSjedista = 4,
                    BrojReda = "I",
                    Sjediste = "I4"
                },
                new Kartum()
                {
                    KartaId = 635,
                    Aktivna = true,
                    TerminId = 6,
                    BrojSjedista = 5,
                    BrojReda = "I",
                    Sjediste = "I5"
                },
                new Kartum()
                {
                    KartaId = 636,
                    Aktivna = true,
                    TerminId = 6,
                    BrojSjedista = 6,
                    BrojReda = "I",
                    Sjediste = "I6"
                },
                new Kartum()
                {
                    KartaId = 637,
                    Aktivna = true,
                    TerminId = 6,
                    BrojSjedista = 7,
                    BrojReda = "I",
                    Sjediste = "I7"
                },
                new Kartum()
                {
                    KartaId = 638,
                    Aktivna = true,
                    TerminId = 6,
                    BrojSjedista = 8,
                    BrojReda = "I",
                    Sjediste = "I8"
                },
                new Kartum()
                {
                    KartaId = 639,
                    Aktivna = true,
                    TerminId = 6,
                    BrojSjedista = 9,
                    BrojReda = "I",
                    Sjediste = "I9"
                },
                new Kartum()
                {
                    KartaId = 640,
                    Aktivna = true,
                    TerminId = 6,
                    BrojSjedista = 10,
                    BrojReda = "I",
                    Sjediste = "I10"
                },
                new Kartum()
                {
                    KartaId = 641,
                    Aktivna = true,
                    TerminId = 6,
                    BrojSjedista = 1,
                    BrojReda = "J",
                    Sjediste = "J1"
                },
                new Kartum()
                {
                    KartaId = 642,
                    Aktivna = true,
                    TerminId = 6,
                    BrojSjedista = 2,
                    BrojReda = "J",
                    Sjediste = "J2"
                },
                new Kartum()
                {
                    KartaId = 643,
                    Aktivna = true,
                    TerminId = 6,
                    BrojSjedista = 3,
                    BrojReda = "J",
                    Sjediste = "J3"
                },
                new Kartum()
                {
                    KartaId = 644,
                    Aktivna = true,
                    TerminId = 6,
                    BrojSjedista = 4,
                    BrojReda = "J",
                    Sjediste = "J4"
                },
                new Kartum()
                {
                    KartaId = 645,
                    Aktivna = true,
                    TerminId = 6,
                    BrojSjedista = 5,
                    BrojReda = "J",
                    Sjediste = "J5"
                },
                new Kartum()
                {
                    KartaId = 646,
                    Aktivna = true,
                    TerminId = 6,
                    BrojSjedista = 6,
                    BrojReda = "J",
                    Sjediste = "J6"
                },
                new Kartum()
                {
                    KartaId = 647,
                    Aktivna = true,
                    TerminId = 6,
                    BrojSjedista = 7,
                    BrojReda = "J",
                    Sjediste = "J7"
                },
                new Kartum()
                {
                    KartaId = 648,
                    Aktivna = true,
                    TerminId = 6,
                    BrojSjedista = 8,
                    BrojReda = "J",
                    Sjediste = "J8"
                },
                new Kartum()
                {
                    KartaId = 649,
                    Aktivna = true,
                    TerminId = 6,
                    BrojSjedista = 9,
                    BrojReda = "J",
                    Sjediste = "J9"
                },
                new Kartum()
                {
                    KartaId = 650,
                    Aktivna = true,
                    TerminId = 6,
                    BrojSjedista = 10,
                    BrojReda = "J",
                    Sjediste = "J10"
                },
            });

            modelBuilder.Entity<Kupovina>().HasData(new Kupovina[]
            {
                new Kupovina()
                {
                   KupovinaId = 1,
                   Kolicina = 2,
                   Cijena = 40,
                   DatumKupovine = DateTime.Now,
                   PaymentIntentId = "pi_3NwMiYEDYm8POibP1HZgAANw_secret_L1f7hpTvlCWjJJXmeJaTwZO06",
                   KorisnikId = 2,
                   TerminId = 1,
                   Placena = true
                },
                new Kupovina()
                {
                   KupovinaId = 2,
                   Kolicina = 3,
                   Cijena = 30,
                   DatumKupovine = DateTime.Now,
                   PaymentIntentId = "pi_3NwMiYEDYm8POibP1HZgAANw_secret_L1f7hpTvlCWjJJXmeJaTwZO06",
                   KorisnikId = 2,
                   TerminId = 6,
                   Placena = true
                },
                new Kupovina()
                {
                   KupovinaId = 3,
                   Kolicina = 1,
                   Cijena = 10,
                   DatumKupovine = DateTime.Now,
                   PaymentIntentId = "pi_3NwMiYEDYm8POibP1HZgAANw_secret_L1f7hpTvlCWjJJXmeJaTwZO06",
                   KorisnikId = 2,
                   TerminId = 5,
                   Placena = true
                },
                new Kupovina()
                {
                   KupovinaId = 4,
                   Kolicina = 2,
                   Cijena = 20,
                   DatumKupovine = DateTime.Now,
                   PaymentIntentId = "pi_3NwMiYEDYm8POibP1HZgAANw_secret_L1f7hpTvlCWjJJXmeJaTwZO06",
                   KorisnikId = 2,
                   TerminId = 2,
                   Placena = true
                },
            });

        }

    }
}
