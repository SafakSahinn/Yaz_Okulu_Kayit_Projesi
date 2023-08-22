using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using EntityLayer;

namespace DataAccessLayer
{
    public class DALDers
    {
        public static List<EntityDers> DersListesi()
        {
            List<EntityDers> degerler = new List<EntityDers>();
            SqlCommand komut2 = new SqlCommand("SELECT * FROM TBLDERSLER", Baglanti.bgl);
            if (komut2.Connection.State != ConnectionState.Open)
            {
                komut2.Connection.Open();
            }
            SqlDataReader dr = komut2.ExecuteReader();
            while (dr.Read())
            {
                EntityDers ent = new EntityDers();
                ent.ID = Convert.ToInt32(dr["DERSID"]);
                ent.DERSAD = dr["DERSAD"].ToString();
                ent.MIN = short.Parse(dr["DERSMINKONT"].ToString());
                ent.MAX = short.Parse(dr["DERSMAKSKONT"].ToString());
                degerler.Add(ent);
            }
            dr.Close();
            return degerler;
        }

        public static int TalepEkle(EntityBasvuruForm parametre)
        {
            SqlCommand komut = new SqlCommand("INSERT INTO TBLBASVURUFORM (OGRENCIID,DERSID) VALUES (@P1,@P2)", Baglanti.bgl);
            komut.Parameters.AddWithValue("@P1", parametre.BASOGRID);
            komut.Parameters.AddWithValue("@P2", parametre.BASDERSID);
            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            return komut.ExecuteNonQuery();
        }
    }
}
