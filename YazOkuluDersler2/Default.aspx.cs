using System;

using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityLayer;
using DataAccessLayer;
using BusinessLogicLayer;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        EntityOgrenci ent = new EntityOgrenci();
        ent.AD = "Savaş";
        ent.SOYAD = "Çolak";
        ent.NUMARA = "195035052";
        ent.FOTOGRAF = "Yol";
        ent.SIFRE = "123";

        BLLOgrenci.OgrenciEkleBLL(ent);
    }
}