using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Video_rental
{
public    class FeaturedConnection
    {
        //create the instance of the SQL Connection class
        public SqlConnection Sqlconn;

        public int optn = 0;
        //write the connection sstring to assthe data form one for to the database 
        public String conLoc = "Data Source=DESKTOP-G2UGPMF\\SQLEXPRESS;Initial Catalog=Project_Video;Integrated Security=True";

        //command are use to excute the command of isnert , delete , update
        public SqlCommand Sqlcmd;

        //data reader is used to read thedata from the database table 
        public SqlDataReader SqlDReader;

        //here this code is used to insert the  data into the table 
        public void CustomerInsert(String Name, String Contact, String Address)
        {
            Sqlconn = new SqlConnection(conLoc);
            Sqlconn.Open();
            String query = "insert into Customer(Name,Contact,Address)values(@Name,@Contact,@Address)";
            Sqlcmd = new SqlCommand(query, Sqlconn);

            Sqlcmd.Parameters.AddWithValue("@Name", Name);
            Sqlcmd.Parameters.AddWithValue("@Contact", Contact);
            Sqlcmd.Parameters.AddWithValue("@Address", Address);
            Sqlcmd.ExecuteNonQuery();
            Sqlconn.Close();

        }


        public DataTable CmdRecord(String qry)
        {
            DataTable tbl = new DataTable();

            Sqlconn = new SqlConnection(conLoc);

            Sqlconn.Open();

            Sqlcmd = new SqlCommand(qry, Sqlconn);

            SqlDReader = Sqlcmd.ExecuteReader();

            tbl.Load(SqlDReader);

            Sqlconn.Close();

            return tbl;
        }
    }
}
