using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace KutuphaneYonetimSistemi.API.DbAccess
{
    public class SqlBaglantisi
    {
        public static readonly string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=KutuphaneYonetimSistemi;Integrated Security=True";

        public static SqlConnection BaglantiDondur()
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            return connection;
        }
    }
}
