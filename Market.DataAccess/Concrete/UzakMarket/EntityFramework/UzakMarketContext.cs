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
        public DbSet<Bayi> Bayi { get; set; }
        public DbSet<BayiAdres> BayiAdres { get; set; }
        public DbSet<Calisan> Calisan { get; set; }
        public DbSet<Defo> Defo { get; set; }
        public DbSet<EkBilgi> EkBilgi { get; set; }
        public DbSet<Firma> Firma { get; set; }
        public DbSet<Fis> Fis { get; set; }
        public DbSet<Fotograf> Fotograf { get; set; }
        public DbSet<Iade> Iade { get; set; }
        public DbSet<Il> Il { get; set; }
        public DbSet<Ilce> Ilce { get; set; }
        public DbSet<Mudur> Mudur { get; set; }
        public DbSet<Personel> Personel { get; set; }
        public DbSet<PersonelAdres> PersonelAdres { get; set; }
        public DbSet<PersonelSifre> PersonelSifre { get; set; }
        public DbSet<PersonelSil> PersonelSil { get; set; }
        public DbSet<Satis> Satis { get; set; }
        public DbSet<Ulke> Ulke { get; set; }
        public DbSet<Urun> Urun { get; set; }
        public DbSet<Yonetici> Yonetici { get; set; }
    }
}
