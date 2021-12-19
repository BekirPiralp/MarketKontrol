using Market.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market.DataAccess.Concrete.UzakMarket.EntityFramework
{
    public class UzakMarketContext : DbContext
    {
        public DbSet<Bayi> Bayiler { get; set; }
        public DbSet<BayiAdres> BayiAdresler { get; set; }
        public DbSet<Calisan> Calisanlar { get; set; }
        public DbSet<Defo> Defolar { get; set; }
        public DbSet<EkBilgi> EkBilgiler { get; set; }
        public DbSet<Firma> Firmalar { get; set; }
        public DbSet<Fis> Fisler { get; set; }
        public DbSet<Fotograf> Fotograflar { get; set; }
        public DbSet<Iade> Iadeler { get; set; }
        public DbSet<Il> Iller { get; set; }
        public DbSet<Ilce> Ilceler { get; set; }
        public DbSet<Mudur> Mudurler { get; set; }
        public DbSet<Personel> Personeller { get; set; }
        public DbSet<PersonelAdres> PersonelAdresler { get; set; }
        public DbSet<PersonelSifre> PersonelSifreler { get; set; }
        public DbSet<PersonelSil> PersonelSiller { get; set; }
        public DbSet<Satis> Satislar { get; set; }
        public DbSet<Ulke> Ulkeler { get; set; }
        public DbSet<Urun> Urunler { get; set; }
        public DbSet<Yonetici> Yoneticiler { get; set; }
    }
}
