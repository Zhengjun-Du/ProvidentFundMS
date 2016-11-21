using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProvidentFundMS
{
    class DataAccess
    {
        private String sqlConn = null;
        private OleDbConnection myConn = null;

        public DataAccess()
        {
            //sqlConn = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source= ../../database/ProvidentFundMS.mdb";
            sqlConn = "Provider=Microsoft.Jet.OLEDB.4.0;Persist Security Info=False;Jet OLEDB:Database Password=enterprise;Data Source= ProvidentFundMS.mdb";
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
            try
            {
                myConn.Open();
                OleDbCommand myComm = new OleDbCommand(select_sql, myConn);
                OleDbDataReader myReader = myComm.ExecuteReader();
                return myReader;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public void DeleteData(string delete_sql)
        {
            try
            {
            myConn.Open();
            OleDbCommand myComm = new OleDbCommand(delete_sql, myConn);
            myComm.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void InsertData(string insert_sql)
        {
            try
            {
            myConn.Open();
            OleDbCommand myComm = new OleDbCommand(insert_sql, myConn);
            myComm.ExecuteNonQuery();
                 }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void UpdateData(string update_sql)
        {
            try
            {
            myConn.Open();
            OleDbCommand myComm = new OleDbCommand(update_sql, myConn);
            myComm.ExecuteNonQuery();
                 }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}