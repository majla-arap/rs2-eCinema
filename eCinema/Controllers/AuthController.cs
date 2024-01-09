﻿using AutoMapper;
using eCinema.Model.Requests;
using eCinema.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace eCinema.Controllers
{
    [AllowAnonymous]
    [ApiController]
    [Route("[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _authService;
        public IMapper _mapper { get; set; }

        public AuthController(IAuthService authService, IMapper mapper) : base()
        {
            _mapper = mapper;
            _authService = authService;
        }

        [HttpPost("register")]
        public async Task<Model.Korisnik> Register([FromBody] KorisnikInsertRequest body)
        {

            var user = await _authService.Register(body);
            return user;
        }

        [HttpPost("login")]
        public async Task<Model.Korisnik> Login([FromBody] KorisnikLoginRequest body)
        {
            var user = await _authService.Login(body);
            return user;
        }

        [HttpPost("login/admin")]
        public async Task<Model.Korisnik> LoginAdmin([FromBody] KorisnikLoginRequest body)
        {
            var admin = await _authService.LoginAdmin(body);
            return admin;
        }
    }
}
