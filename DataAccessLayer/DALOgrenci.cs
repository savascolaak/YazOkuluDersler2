using System;

using System.Data.SqlClient;
using System.Data;
using EntityLayer;
namespace DataAccessLayer
{
    public class DALOgrenci
    {
        public static int OgrenciEkle(EntityOgrenci parametre)
        {
            SqlCommand komut1 = new SqlCommand("insert into TBLOGRENCI (OgrAd,OgrSoyad,OgrNumara,Ogrfotograf,Ogrsıfre) values (@p1,@p2,@p3,@p4,@p5)", Baglanti.bgl);

            if (komut1.Connection.State != ConnectionState.Open)
            {
                komut1.Connection.Open();
            }

            komut1.Parameters.AddWithValue("@p1", parametre.AD);
            komut1.Parameters.AddWithValue("@p2", parametre.SOYAD);
            komut1.Parameters.AddWithValue("@p3", parametre.NUMARA);
            komut1.Parameters.AddWithValue("@p4", parametre.FOTOGRAF);
            komut1.Parameters.AddWithValue("@p5", parametre.SIFRE);

            return komut1.ExecuteNonQuery();

        }
    }
}
