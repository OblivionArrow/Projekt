using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace WindowsFormsApp2
{
    class login : DB
    {

    public int prijava(string username, string password)
        {
            
            string Query = ("SELECT COUNT(*) FROM login WHERE username = '" + username + "' AND password = '" + password + "'");
            SQLiteConnection conDataBase = new SQLiteConnection(con);
            SQLiteCommand cmdDataBase = new SQLiteCommand(Query, conDataBase);
            SQLiteDataAdapter kek = new SQLiteDataAdapter(cmdDataBase);
            DataTable dt = new DataTable();

            kek.Fill(dt);


            if (dt.Rows[0][0].ToString() == "1")
            {
    
                return 1;
            }

            else
            {
                
                return 0;
            }
        }

    public void registracija(string email, string username, string password)
        {
            
            string Query = "INSERT INTO login (email, username, password) VALUES ('" + email + "', '" + username + "', '" + password + "')";
            SQLiteConnection conDataBase = new SQLiteConnection(con);
            SQLiteCommand cmdDataBase = new SQLiteCommand(Query, conDataBase);
            cmdDataBase.ExecuteNonQuery();
            MessageBox.Show("Uspješno ste se registrirali!");
            

        }


    }
}
