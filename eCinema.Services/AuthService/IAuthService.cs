using eCinema.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCinema.Services
{
    public interface IAuthService
    {
        public Task<Model.Korisnik> Register(KorisnikInsertRequest request);
        public Task<Model.Korisnik> Login(KorisnikLoginRequest request);
        public Task<Model.Korisnik> LoginAdmin(KorisnikLoginRequest request);
    }
}
