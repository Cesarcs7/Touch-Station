using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ADOX;

namespace SoftwareStation
{
    class CreateDatabase
    {
        String DBpath = "C:\\Scann\\DataBase\\Center.mdb";
        String name;
        String sex;
        String birthday;
        String height;
        String weight;
        int id;

        public CreateDatabase( String name, String sex, String birthday, String height, String weight, String id)
        {
            this.name = name;
            this.sex = sex;
            this.birthday = birthday;
            this.height = height;
            this.weight = weight;
            this.id = 1;
            
        }

        public void createDB()
        {
            if (File.Exists(DBpath)) {

                File.Delete(DBpath);
            }

            Catalog cat = new Catalog();
            cat.Create("Provider=Microsoft.Jet.OLEDB.4.0; Data Source=" + DBpath);
            cat = null;
        }

        public void createTables()
        {
            OleDbConnection conn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + DBpath);
            conn.Open();

            // create table "Table_1" if not exists
            // DO NOT USE SPACES IN TABLE AND COLUMNS NAMES TO PREVENT TROUBLES WITH SAVING, USE _
            // OLEDBCOMMANDBUILDER DON'T SUPPORT COLUMNS NAMES WITH SPACES
            try
            {
                OleDbCommand cmd = new OleDbCommand(
                    "CREATE TABLE [Examer] " +
                    "([Name] VARCHAR(15),"+
                    "[Sex] VARCHAR(15), " +
                    "[Birthday] VARCHAR(15)," +
                    "[ExamerID] INT,"+
                    "[Height] VARCHAR(15)," + 
                    "[Weight] VARCHAR(15));",
                    
                    conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                if (ex != null) ex = null;
            }
        }

        public void insertIntoTables()
        {
            OleDbConnection conn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + DBpath);
            conn.Open();

            try
            {
                OleDbCommand cmd = new OleDbCommand(
                    "INSERT INTO Examer" +
                    "([Name], [Sex], [Height], [Birthday], [Weight], [ExamerID])  VALUES(@name, @sex, @height, @birthday, @weight, @id);",
                    conn);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@sex", sex);
                cmd.Parameters.AddWithValue("@height", height);
                cmd.Parameters.AddWithValue("@birthday", birthday);
                cmd.Parameters.AddWithValue("@weight", weight);
                cmd.Parameters.AddWithValue("@id", id);

                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                if (ex != null) ex = null;

            }
        }
    }
}
