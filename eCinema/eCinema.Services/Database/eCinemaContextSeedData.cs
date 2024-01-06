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


        }

    }
}
