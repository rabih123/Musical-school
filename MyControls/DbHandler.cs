using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyControls
{
    public sealed class DbHandler
    {

        private static DbHandler instance = null;
        private static readonly object padlock = new object();
        private static List<DbHandler> connections = new List<DbHandler>();
        private String _CnxString;

       private DbHandler(String ConnectionString)
        {
            _CnxString = ConnectionString;
            connections.Add(instance);
        }

        public static DbHandler getInstance(String ConnectionString)
        {
            if (instance == null)
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        if (connections.Any(x => x._CnxString == ConnectionString))
                        {
                            instance = connections.Find(x => x._CnxString == ConnectionString);
                        }
                        else
                        {
                            instance = new DbHandler(ConnectionString);
                        }

                    }
                }
            }
            return instance;
        }

        public DataTable FillMyDt(String Query)
        {
            DataTable dt;
            try
            {
                using (SqlConnection cnsql = new SqlConnection(_CnxString))
                {
                    cnsql.Open();
                    using (SqlDataAdapter da = new SqlDataAdapter(Query, cnsql))
                    {
                        dt = new DataTable();
                        da.Fill(dt);
                    }
                    cnsql.Close();
                }
            }
            catch (Exception)
            {
                throw;
            }
            return dt;
        }

        public String ExecuteScalar(String query)
        {
            string val = null;
            try
            {
                using (SqlConnection cnsql = new SqlConnection(_CnxString))
                {
                    cnsql.Open();
                    using (SqlCommand cmsql = new SqlCommand(query, cnsql))
                    {

                        object retval = cmsql.ExecuteScalar();

                        if (val == null)
                        {
                            val = null;
                        }
                        else
                        {
                            val = val.ToString();
                        }
                    }
                    cnsql.Close();
                }
            }
            catch (Exception)
            {

                throw;
            }

            return val;
        }
    }
}
