using Market.DataAccess.Abstract.LochalMarket;
using Market.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market.DataAccess.Concrete.LochalMarket
{
    public class BaglantiStringiDal : ILMBaglantiStringiDal
    {
        private String _dosyaYolu = "Lochal.bkp";
        public BaglantiStringi Get()
        {
            BaglantiStringi baglanti = null;
            String al;
            try
            {
                FileStream fileStream = new FileStream(_dosyaYolu, FileMode.Open, FileAccess.Read);
                using (StreamReader okuyucu = new StreamReader(fileStream, Encoding.UTF8))
                {
                    try
                    {
                        al = okuyucu.ReadToEnd();
                    }
                    catch
                    {
                        al = "";
                    }
                    finally
                    {
                        okuyucu.Close();
                        fileStream.Close();
                    }
                }
                if (al.Trim() != "")
                {
                    baglanti = new BaglantiStringi { ConnetionString = al };
                }
            }catch
            {
                baglanti = null;
            }
            return baglanti;
        }        
        public void Set(BaglantiStringi baglanti)
        {
            FileStream fileStream = new FileStream(_dosyaYolu, FileMode.Create,FileAccess.Write);
            using (StreamWriter yazıcı = new StreamWriter(fileStream,Encoding.UTF8))
            {
                yazıcı.Write(@baglanti.ConnetionString.Trim());
                yazıcı.Close();
            }
            fileStream.Close();
        }
    }
}
