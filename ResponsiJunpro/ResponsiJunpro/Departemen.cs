using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsiJunpro
{
    internal class Departemen
    {
        public static List<string> GetDepartemenList()
        {
            List<string> list = new List<string>();
            using(NpgsqlConnection conn = new NpgsqlConnection(ConnectionString.conString))
            {
                try
                {
                    conn.Open();
                    string sql = "SELECT * FROM departemen;";
                    using (NpgsqlCommand cmd = new NpgsqlCommand(sql, conn))
                    {
                        using (NpgsqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string depName = reader["nama_dep"].ToString();
                                list.Add(depName);
                            }
                        }
                    }
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            return list;
        }
        public static string GetDepartemenId(string depName)
        {
            string id="";
            using (NpgsqlConnection conn = new NpgsqlConnection(ConnectionString.conString))
            {
                try
                {
                    conn.Open();
                    string sql = "SELECT * FROM departemen WHERE nama_dep = @depName;";
                    using (NpgsqlCommand cmd = new NpgsqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@depName", depName);
                        object result = cmd.ExecuteScalar();
                        if (result != null && result != DBNull.Value) id = Convert.ToString(result);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            return id;
        }
    }
}
