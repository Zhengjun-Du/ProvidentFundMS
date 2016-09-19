using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvidentFundMS
{
    class DataAccess
    {
        private String sqlConn = null;
        private OleDbConnection myConn = null;

        public DataAccess()
        {
            //sqlConn = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source= ../../database/ProvidentFundMS.mdb";
            sqlConn = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source= ProvidentFundMS.mdb";
            myConn = new OleDbConnection(sqlConn);
        }

        /*
        ~DataAccess()
        {
            if (myConn != null && myConn.State == System.Data.ConnectionState.Open)
                myConn.Close();
        }*/

        public OleDbDataReader SelectData(string select_sql)
        {
            myConn.Open();
            OleDbCommand myComm = new OleDbCommand(select_sql, myConn);
            OleDbDataReader myReader = myComm.ExecuteReader();
            return myReader;
        }

        public void DeleteData(string delete_sql)
        {
            myConn.Open();
            OleDbCommand myComm = new OleDbCommand(delete_sql, myConn);
            myComm.ExecuteNonQuery();
        }

        public void InsertData(string insert_sql)
        {
            myConn.Open();
            OleDbCommand myComm = new OleDbCommand(insert_sql, myConn);
            myComm.ExecuteNonQuery();
        }

        public void UpdateData(string update_sql)
        {
            myConn.Open();
            OleDbCommand myComm = new OleDbCommand(update_sql, myConn);
            myComm.ExecuteNonQuery();
        }
    }
}