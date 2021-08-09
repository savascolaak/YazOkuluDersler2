using System;
using System.Linq;
using System.Text;

using EntityLayer;
using DataAccessLayer;


namespace BusinessLogicLayer
{
    public class BLLOgrenci
    {
        public static int OgrenciEkleBLL(EntityOgrenci p)
        {
            if (p.AD != null && p.SOYAD != null && p.NUMARA != null && p.SIFRE != null && p.FOTOGRAF != null)
            {
                return DALOgrenci.OgrenciEkle(p);
            }
            return -1;

        }
    }
}
