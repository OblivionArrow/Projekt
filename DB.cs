using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Windows.Forms;
using System.Data;

namespace WindowsFormsApp2
{
    class DB
    {
        protected SQLiteConnection connection;
        private SQLiteCommand command;
        private SQLiteDataAdapter db;
        private DataSet ds;
        private DataTable table = new DataTable();

        public DB()
        {
            con = new SQLiteConnection("Data Source = baza.db");
            con.Open();
           
        }

        public SQLiteConnection con
        { 
            get { return connection; }
            private set { connection = value; }
        }

        

        //kod za izvođenje pod bazoom BILO KOJI al mora bit sql
        private long Query(string sqlCode)
        {
            command = connection.CreateCommand();
            command.CommandText = sqlCode;
            MessageBox.Show(sqlCode);
            command.ExecuteNonQuery();
            return connection.LastInsertRowId;
        }

        //loudanje baze u formsima tj u tablici i vraca tu tablicu za grid view
        private DataTable LoadDataBase(string load)
        {
            command = connection.CreateCommand();
            db = new SQLiteDataAdapter(load, connection);
            ds = new DataSet();
            db.Fill(ds);
            table = ds.Tables[0];
            return table;
        }
    }
}
