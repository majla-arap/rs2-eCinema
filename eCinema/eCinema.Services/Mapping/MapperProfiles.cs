using AutoMapper;
using eCinema.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCinema.Services.Mapping
{
    public class MapperProfiles : Profile
    {
        public MapperProfiles()
        {
          
            CreateMap<Database.Uloga, Model.Uloga>();
            CreateMap<Database.ObavijestKategorija, Model.ObavijestKategorija>();
            CreateMap<Database.Obavijest, Model.Obavijest>();
            CreateMap<Database.Cinema, Model.Cinema>();
            CreateMap<Database.Dvorana, Model.Dvorana>();
            CreateMap<Database.Zanr, Model.Zanr>();
            CreateMap<Database.Glumac, Model.Glumac>();
            CreateMap<Database.Film, Model.Film>();
            CreateMap<Database.Termin, Model.Termin>();
            CreateMap<Database.FilmGlumac, Model.FilmGlumac>();
            CreateMap<Database.Kartum, Model.Karta>();
            CreateMap<Database.Kupovina, Model.Kupovina>();
            CreateMap<Database.Korisnik, Model.Korisnik>();
            CreateMap<Database.KorisnikUloge, Model.KorisnikUloge>();
            CreateMap<Database.FilmZanr,Model.FilmZanr>();



            CreateMap<ObavijestKategorijaInsertRequest, Database.ObavijestKategorija>();
            CreateMap<ObavijestInsertRequest, Database.Obavijest>();
            CreateMap<ObavijestUpdateRequest, Database.Obavijest>();
            CreateMap<CinemaInsertRequest, Database.Cinema>();
            CreateMap<DvoranaInsertRequest, Database.Dvorana>();
            CreateMap<DvoranaUpdateRequest, Database.Dvorana>();
            CreateMap<ZanrInsertRequest, Database.Zanr>();
            CreateMap<GlumacInsertRequest, Database.Glumac>();
            CreateMap<FilmInsertRequest, Database.Film>();
            CreateMap<TerminInsertRequest, Database.Termin>();
            CreateMap<FilmGlumacInsertRequest, Database.FilmGlumac>();
            CreateMap<KartaInsertRequest, Database.Kartum>();
            CreateMap<KupovinaInsertRequest, Database.Kupovina>();
            CreateMap<KorisnikInsertRequest, Database.Korisnik>();
            CreateMap<KorisnikUpdateRequest, Database.Korisnik>();
            CreateMap<KorisnikUlogeInsertRequest, Database.KorisnikUloge>();
            CreateMap<FilmZanrInsertRequest,Database.FilmZanr>();

        }
    }
}
