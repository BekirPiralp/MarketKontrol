using Market.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market.DataAccess.Concrete.LochalMarket.EntityFramework
{
    public class LochalMarketContext : DbContext
    {
        public DbSet<Bayi> Bayiler { get; set; }
        public DbSet<Defo> Defolar { get; set; }
        public DbSet<DepoEkleUrun> DepoEkleUrunler { get; set; }
        public DbSet<EkBilgi> EkBilgiler { get; set; }
        public DbSet<Firma> Firmalar { get; set; }
        public DbSet<Fis> Fisler { get; set; }
        public DbSet<Iade> Iadeler { get; set; }
        public DbSet<Personel> Personeller { get; set; }
        public DbSet<PersonelSifre> PersonelSifreler { get; set; }
        public DbSet<Satis> Satislar { get; set; }
        public DbSet<Ulke> Ulkeler { get; set; }
    }
}
