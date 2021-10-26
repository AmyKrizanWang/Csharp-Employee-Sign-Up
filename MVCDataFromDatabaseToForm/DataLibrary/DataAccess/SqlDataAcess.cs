using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Specialized;
//using System.Collections.Generic;
//using System.Configuration.Assemblies;



namespace DataLibrary.DataAccess
{

    //amycn1 make the class public first, this is where can access the database from here
    //right hand click References to add/install the software tool -- Manage New NuGet Datalibrary -->Dapper by Sam Saffron, Marc-->install
    /* add 4x using statement to use Dapper
    using Dapper;
    using System.Configuration;
    using System.Data;
    using System.Data.SqlClient; */


    public static class SqlDataAcess
    {
        //make the class static, because no needs to store data, this method just function as connect, access point to the database
        public static string GetConnectionString(string connectionName = "MVCDemoDB")
        {
            return ConfigurationManager.ConnectionStrings[connectionName].ConnectionString;

            //amycn1 when ConfigurationManager didn't work, goto DataLibrary--Refernces--Add Refernce--All assemblies--System.Configuration checkbox!
        }

        public static List<T> LoadData<T>(string sql)
        {
            using (IDbConnection cnn = new SqlConnection(GetConnectionString()))
            {
                return cnn.Query<T>(sql).ToList(); //load data function //error!!! amycn1--FIXED


            }
        }

        public static int SaveData<T>(string sql, T data)
        {
            using (IDbConnection cnn = new SqlConnection(GetConnectionString()))
            {
                return cnn.Execute(sql, data);  //save data function
            }
        }
    }
}
