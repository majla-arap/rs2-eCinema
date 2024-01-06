namespace eCinema.Model
{
    public class Korisnik
    {
        public int KorisnikId { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string KorisnickoIme { get; set; }
        public string Email { get; set; }
        public string BrTelefona { get; set; }
        public bool Active { get; set; }
        public virtual ICollection<KorisnikUloge> KorisnikUloges { get; set; }

        public string imePrezime => $"{Ime} {Prezime}";
        public override string ToString()
        {
            return KorisnickoIme;
        }
    }
}