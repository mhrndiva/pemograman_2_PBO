using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;

namespace P10_1_714220050
{
    internal class Koneksi
    {
        string conectionstring = "Server=localhost;Database=ulbi;Uid=root;Pad=;";
        MySqlConnection kon;
        

        public void OpenConnection()
        {
            kon = new MySqlConnection(conectionstring);
            kon.Open();
        }

        public void CloseConnection()
        {
            kon.Close();
        }

        public void ExecuteQuery(string query)
        {
            MySqlCommand command = new MySqlCommand(query, kon);
            command.ExecuteNonQuery();
        }

        public object ShowData(string query)
        {
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, conectionstring);
            DataSet data = new DataSet();
            adapter.Fill(data);
            object datatabel = data.Tables[0];
            return datatabel;
        }

        public MySqlDataReader reader(string query)
        {
            MySqlCommand cmd = new MySqlCommand(query, kon);
            MySqlDataReader dr = cmd.ExecuteReader();
            return dr;
        }


    }
}
