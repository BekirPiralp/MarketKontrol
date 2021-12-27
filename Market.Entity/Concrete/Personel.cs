namespace Market.Entity.Concrete
{
    public class Personel : EntityBase
    {
        public int Firma { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Tc { get; set; }
        public char Cinsiyet { get; set; }
    }
}
