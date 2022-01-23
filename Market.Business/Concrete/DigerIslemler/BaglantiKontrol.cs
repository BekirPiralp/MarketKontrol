using Market.Business.Abstract.DigerIslemler;
using Market.DataAccess.Concrete.UzakMarket.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market.Business.Concrete.DigerIslemler
{
    public class BaglantiKontrol : IBaglantiKontrol
    {
        public  static bool baglantiDurumu { get; set; }
        private static BaglantiKontrol baglantiKontrol= null;
        private static DbContext context;

        private BaglantiKontrol(){}
        /// <summary>
        /// New  sözcüğünü katmadan yazınız. TContext nesnesi şimdilik Uzakmarket içindir
        /// </summary>
        /// <typeparam name="TContext"></typeparam>
        /// <returns></returns>
        public static BaglantiKontrol KontrolGet()//<TContext>()
           // where TContext : DbContext,new()
        {
            if (baglantiKontrol == null)
            {
                baglantiKontrol = new BaglantiKontrol();
                baglantiDurumu = true;
            }
            context = new UzakMarketContext();//TContext();
            return baglantiKontrol;
        }
        /// <summary>
        /// Bağlantı varsa True baglanti birdefa bile gittiyse program sonlanan kadar false
        /// </summary>
        /// <returns></returns>
        public bool KontrolEt()
        {
            if (baglantiDurumu == false)
                return baglantiDurumu;//Birdefa bağlantı gittimi programı yeniden başlatana kadar lochalden çalışsın

            if(context.Database.Connection.State == System.Data.ConnectionState.Closed)
            {
                try
                {
                    context.Database.Connection.Open();
                }
                catch
                {
                    baglantiDurumu = false;
                }
                finally
                {
                    context.Database.Connection.Close();
                }
            }
            return baglantiDurumu;
            
        }
        public void Serbesbirak()
        {
            baglantiKontrol = null;
        }
    }
}
