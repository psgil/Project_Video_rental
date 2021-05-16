using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Video_rental
{
    public partial class Add_Form : Form
    {
        public FeaturedConnection connection = new FeaturedConnection();
        public int issueID = 0;

        public Add_Form()
        {
            InitializeComponent();
        }

        private void Add_Form_Load(object sender, EventArgs e)
        {

        }
        // add customer

        private void add_button_customer_Click(object sender, EventArgs e)
        {
            connection.Sqlconn = new SqlConnection(connection.conLoc);
            connection.Sqlconn.Open();
            
            String query = "insert into tblCustomer(FullName,Email,Contact,Address)values(@FullName,@Email,@Contact,@Address)";
            connection.Sqlcmd = new SqlCommand(query, connection.Sqlconn);

            connection.Sqlcmd.Parameters.AddWithValue("@FullName",full_name_customer.Text);
            connection.Sqlcmd.Parameters.AddWithValue("@Email", email_customer.Text);
            connection.Sqlcmd.Parameters.AddWithValue("@Contact", phone_customer.Text);
            connection.Sqlcmd.Parameters.AddWithValue("@Address", address_customer.Text);

            connection.Sqlcmd.ExecuteNonQuery();
            connection.Sqlconn.Close();
            MessageBox.Show("customer is registered in the Store");

            text_filed_customer.Text = "";
            full_name_customer.Text = "";
            email_customer.Text = "";
            phone_customer.Text = "";
            address_customer.Text = "";

        }

        // update button

        private void update_button_customer_Click(object sender, EventArgs e)
        {

            connection.Sqlconn = new SqlConnection(connection.conLoc);
            connection.Sqlconn.Open();

            String query = "update tblCustomer set FullName=@FullName,Email=@Email,Contact=@Contact,Address=@Address where CustID=@ID";
            connection.Sqlcmd = new SqlCommand(query, connection.Sqlconn);

            connection.Sqlcmd.Parameters.AddWithValue("@ID", Convert.ToInt16(text_filed_customer.Text.ToString()));
            connection.Sqlcmd.Parameters.AddWithValue("@FullName", full_name_customer.Text);
            connection.Sqlcmd.Parameters.AddWithValue("@Email", email_customer.Text);
            connection.Sqlcmd.Parameters.AddWithValue("@Contact", phone_customer.Text);
            connection.Sqlcmd.Parameters.AddWithValue("@Address", address_customer.Text);

            connection.Sqlcmd.ExecuteNonQuery();
            connection.Sqlconn.Close();
            MessageBox.Show("customer is Modified in the Store");

            text_filed_customer.Text = "";
            full_name_customer.Text = "";
            email_customer.Text = "";
            phone_customer.Text = "";
            address_customer.Text = "";

        }

        // delete button

        private void delete_buuton_customer_Click(object sender, EventArgs e)
        {
            connection.Sqlconn = new SqlConnection(connection.conLoc);
            connection.Sqlconn.Open();

            String query = "delete  from tblCustomer  where CustID=@ID";
            connection.Sqlcmd = new SqlCommand(query, connection.Sqlconn);

            connection.Sqlcmd.Parameters.AddWithValue("@ID", Convert.ToInt16(text_filed_customer.Text.ToString()));
         
            connection.Sqlcmd.ExecuteNonQuery();
            connection.Sqlconn.Close();
            MessageBox.Show("customer is Removed in the Store");

            text_filed_customer.Text = "";
            full_name_customer.Text = "";
            email_customer.Text = "";
            phone_customer.Text = "";
            address_customer.Text = "";

        }

        // Issue button rentals

        private void Issue_button_rentals_Click(object sender, EventArgs e)
        {
            connection.Sqlconn = new SqlConnection(connection.conLoc);
            connection.Sqlconn.Open();

            String query = "insert into Issued(VideoID,CustomerID,issuedDate,ReturnDate)values(@VideoID,@CustomerID,@IssueDt,@ReturnDt)";
            connection.Sqlcmd = new SqlCommand(query, connection.Sqlconn);

            connection.Sqlcmd.Parameters.AddWithValue("@VideoID",Convert.ToInt32(text_filed_videoId.Text.ToString()));
            connection.Sqlcmd.Parameters.AddWithValue("@CustomerID", Convert.ToInt32(text_filed_customer.Text.ToString()));
            connection.Sqlcmd.Parameters.AddWithValue("@IssueDt",Issue_dateTimePicker.Text.ToString());
            connection.Sqlcmd.Parameters.AddWithValue("@ReturnDt","Issued");

            connection.Sqlcmd.ExecuteNonQuery();
            connection.Sqlconn.Close();
            MessageBox.Show("Movie is Issued  On the Rent ");

            text_filed_customer.Text = "";
            full_name_customer.Text = "";
            email_customer.Text = "";
            phone_customer.Text = "";
            address_customer.Text = "";

            text_filed_videoId.Text = "";
            movie_name_textfiled.Text = "";
            ratings_textfiled.Text = "";
            year_textfiled.Text = "";
            copies_textfiled.Text = "";
            plot_textfield.Text = "";
            Genre_textfield.Text = "";



        }

        private void delete_button_rental_Click(object sender, EventArgs e)
        {

            connection.Sqlconn = new SqlConnection(connection.conLoc);
            connection.Sqlconn.Open();

            String query = "delete from Issued where IssueID=@issueID";
            connection.Sqlcmd = new SqlCommand(query, connection.Sqlconn);

            connection.Sqlcmd.Parameters.AddWithValue("@issueID", Convert.ToInt32(issueID));
          
            connection.Sqlcmd.ExecuteNonQuery();
            connection.Sqlconn.Close();
            MessageBox.Show(" Issued Movie is removed ");

            text_filed_customer.Text = "";
            full_name_customer.Text = "";
            email_customer.Text = "";
            phone_customer.Text = "";
            address_customer.Text = "";

            text_filed_videoId.Text = "";
            movie_name_textfiled.Text = "";
            ratings_textfiled.Text = "";
            year_textfiled.Text = "";
            copies_textfiled.Text = "";
            plot_textfield.Text = "";
            Genre_textfield.Text = "";



        }

        private void return_button_rentals_Click(object sender, EventArgs e)
        {


            DateTime current_date = DateTime.Now;

            //convert the old date from string to Date fromat
            DateTime prev_date = Convert.ToDateTime(Issue_dateTimePicker.Text);


            //get the difference in the days fromat
            String Daysdiff = (current_date - prev_date).TotalDays.ToString();


            // calculate the round off value 
            Double DaysInterval = Math.Round(Convert.ToDouble(Daysdiff));

            DataTable tbl = new DataTable();

            tbl = connection.CmdRecord("select * from tblVideo where VideoID=" + Convert.ToInt32(text_filed_videoId.Text.ToString()) + "");

            int total = Convert.ToInt32(tbl.Rows[0]["Cost"].ToString()) * Convert.ToInt32(DaysInterval);






            connection.Sqlconn = new SqlConnection(connection.conLoc);
            connection.Sqlconn.Open();

            String query = "Update Issued set VideoID=@VideoID,CustomerID=@CustomerID,issuedDate=@IssueDt,ReturnDate=@ReturnDt where IssueID=@issueID";
            connection.Sqlcmd = new SqlCommand(query, connection.Sqlconn);

            connection.Sqlcmd.Parameters.AddWithValue("@issueID", Convert.ToInt32(issueID));
            connection.Sqlcmd.Parameters.AddWithValue("@VideoID", Convert.ToInt32(text_filed_videoId.Text.ToString()));
            connection.Sqlcmd.Parameters.AddWithValue("@CustomerID", Convert.ToInt32(text_filed_customer.Text.ToString()));
            connection.Sqlcmd.Parameters.AddWithValue("@IssueDt", Issue_dateTimePicker.Text.ToString());
            connection.Sqlcmd.Parameters.AddWithValue("@ReturnDt", Return_dateTimePicker.Text.ToString());

            connection.Sqlcmd.ExecuteNonQuery();
            connection.Sqlconn.Close();
            MessageBox.Show("Movie is Returned to the store and you need to pay =$"+total);

            text_filed_customer.Text = "";
            full_name_customer.Text = "";
            email_customer.Text = "";
            phone_customer.Text = "";
            address_customer.Text = "";

            text_filed_videoId.Text = "";
            movie_name_textfiled.Text = "";
            ratings_textfiled.Text = "";
            year_textfiled.Text = "";
            copies_textfiled.Text = "";
            plot_textfield.Text = "";
            Genre_textfield.Text = "";



        }

        private void button8_Click(object sender, EventArgs e)
        {

            DateTime dateNow = DateTime.Now;

            int Currentyear = dateNow.Year;

            int diffYear = Currentyear - Convert.ToInt32(year_textfiled.Text);
            int cost = 0;
            // MessageBox.Show(diff.ToString());
            if (diffYear >= 5)
            {
                cost = 2;
            }
            if (diffYear >= 0 && diffYear < 5)
            {
                cost = 5;
            }

            connection.Sqlconn = new SqlConnection(connection.conLoc);
            connection.Sqlconn.Open();

            String query = "insert into tblVideo(MovieName,Ratting,Year,Cost,Copies,Plot,Genre)values(@MovieName,@Ratting,@Year,@Cost,@Copies,@Plot,@Genre)";
            connection.Sqlcmd = new SqlCommand(query, connection.Sqlconn);
            




            connection.Sqlcmd.Parameters.AddWithValue("@MovieName", movie_name_textfiled.Text);
            connection.Sqlcmd.Parameters.AddWithValue("@Ratting", ratings_textfiled.Text);
            connection.Sqlcmd.Parameters.AddWithValue("@Year", year_textfiled.Text);
            connection.Sqlcmd.Parameters.AddWithValue("@Cost", cost);
            connection.Sqlcmd.Parameters.AddWithValue("@Copies",copies_textfiled.Text);
            connection.Sqlcmd.Parameters.AddWithValue("@Plot",plot_textfield.Text);
            connection.Sqlcmd.Parameters.AddWithValue("@Genre", Genre_textfield.Text);

            connection.Sqlcmd.ExecuteNonQuery();
            connection.Sqlconn.Close();
            MessageBox.Show("Movie is registered in the Store");

            text_filed_customer.Text = "";
            full_name_customer.Text = "";
            email_customer.Text = "";
            phone_customer.Text = "";
            address_customer.Text = "";

            text_filed_videoId.Text = "";
            movie_name_textfiled.Text = "";
            ratings_textfiled.Text = "";
            year_textfiled.Text = "";
            copies_textfiled.Text = "";
            plot_textfield.Text = "";
            Genre_textfield.Text = "";



        }

        private void btnVideoDel_Click(object sender, EventArgs e)
        {

            connection.Sqlconn = new SqlConnection(connection.conLoc);
            connection.Sqlconn.Open();

            String query = "delete from tblVideo where VideoID=@videoID";
            connection.Sqlcmd = new SqlCommand(query, connection.Sqlconn);





            connection.Sqlcmd.Parameters.AddWithValue("@videoID",Convert.ToInt32(text_filed_videoId.Text.ToString()));
            

            connection.Sqlcmd.ExecuteNonQuery();
            connection.Sqlconn.Close();
            MessageBox.Show("Movie is removed in the Store");

            text_filed_customer.Text = "";
            full_name_customer.Text = "";
            email_customer.Text = "";
            phone_customer.Text = "";
            address_customer.Text = "";

            text_filed_videoId.Text = "";
            movie_name_textfiled.Text = "";
            ratings_textfiled.Text = "";
            year_textfiled.Text = "";
            copies_textfiled.Text = "";
            plot_textfield.Text = "";
            Genre_textfield.Text = "";


        }

        private void btnVideoUpd_Click(object sender, EventArgs e)
        {

            DateTime dateNow = DateTime.Now;

            int Currentyear = dateNow.Year;

            int diffYear = Currentyear - Convert.ToInt32(year_textfiled.Text);
            int cost = 0;
            // MessageBox.Show(diff.ToString());
            if (diffYear >= 5)
            {
                cost = 2;
            }
            if (diffYear >= 0 && diffYear < 5)
            {
                cost = 5;
            }

            connection.Sqlconn = new SqlConnection(connection.conLoc);
            connection.Sqlconn.Open();

            String query = "update tblVideo set MovieName=@MovieName,Ratting=@Ratting,Year=@Year,Cost=@Cost,Copies=@Copies,Plot=@Plot,Genre=@Genre where VideoID=@videoID";
            connection.Sqlcmd = new SqlCommand(query, connection.Sqlconn);



            connection.Sqlcmd.Parameters.AddWithValue("@videoID", Convert.ToInt32(text_filed_videoId.Text.ToString()));

            connection.Sqlcmd.Parameters.AddWithValue("@MovieName", movie_name_textfiled.Text);
            connection.Sqlcmd.Parameters.AddWithValue("@Ratting", ratings_textfiled.Text);
            connection.Sqlcmd.Parameters.AddWithValue("@Year", year_textfiled.Text);
            connection.Sqlcmd.Parameters.AddWithValue("@Cost", cost);
            connection.Sqlcmd.Parameters.AddWithValue("@Copies", copies_textfiled.Text);
            connection.Sqlcmd.Parameters.AddWithValue("@Plot", plot_textfield.Text);
            connection.Sqlcmd.Parameters.AddWithValue("@Genre", Genre_textfield.Text);

            connection.Sqlcmd.ExecuteNonQuery();
            connection.Sqlconn.Close();
            MessageBox.Show("Movie is Updated in the Store");

            text_filed_customer.Text = "";
            full_name_customer.Text = "";
            email_customer.Text = "";
            phone_customer.Text = "";
            address_customer.Text = "";

            text_filed_videoId.Text = "";
            movie_name_textfiled.Text = "";
            ratings_textfiled.Text = "";
            year_textfiled.Text = "";
            copies_textfiled.Text = "";
            plot_textfield.Text = "";
            Genre_textfield.Text = "";



        }

        private void customer_info_Click(object sender, EventArgs e)
        {
            connection.optn = 1;

            DataTable customer = new DataTable();
            customer = connection.CmdRecord("select * from  tblCustomer");
            show_dataGridView.DataSource = customer;
        }

        private void video_info_Click(object sender, EventArgs e)
        {
            connection.optn = 2;
            DataTable customer = new DataTable();
            customer = connection.CmdRecord("select * from  tblVideo");
            show_dataGridView.DataSource = customer;
        }

        private void Rental_info_Click(object sender, EventArgs e)
        {

            connection.optn = 3;
            DataTable customer = new DataTable();
            customer = connection.CmdRecord("select * from  Issued");
            show_dataGridView.DataSource = customer;
        }

        private void show_dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (connection.optn == 1) {
                text_filed_customer.Text = show_dataGridView.CurrentRow.Cells[0].Value.ToString();
                full_name_customer.Text = show_dataGridView.CurrentRow.Cells[1].Value.ToString();
                email_customer.Text = show_dataGridView.CurrentRow.Cells[2].Value.ToString();
                phone_customer.Text = show_dataGridView.CurrentRow.Cells[3].Value.ToString();
                address_customer.Text = show_dataGridView.CurrentRow.Cells[4].Value.ToString();
            } else if (connection.optn == 2) {
                text_filed_videoId.Text = show_dataGridView.CurrentRow.Cells[0].Value.ToString();
                movie_name_textfiled.Text = show_dataGridView.CurrentRow.Cells[1].Value.ToString();
                ratings_textfiled.Text = show_dataGridView.CurrentRow.Cells[2].Value.ToString();
                year_textfiled.Text = show_dataGridView.CurrentRow.Cells[3].Value.ToString();
                copies_textfiled.Text = show_dataGridView.CurrentRow.Cells[5].Value.ToString();
                plot_textfield.Text = show_dataGridView.CurrentRow.Cells[6].Value.ToString();
                Genre_textfield.Text = show_dataGridView.CurrentRow.Cells[7].Value.ToString();

            } else if (connection.optn==3) {
                issueID = Convert.ToInt32(show_dataGridView.CurrentRow.Cells[0].Value.ToString());
                text_filed_videoId.Text = show_dataGridView.CurrentRow.Cells[1].Value.ToString();
                text_filed_customer.Text =  show_dataGridView.CurrentRow.Cells[2].Value.ToString();
                Issue_dateTimePicker.Text = show_dataGridView.CurrentRow.Cells[3].Value.ToString();
            }


        }

        private void popular_button_Click(object sender, EventArgs e)
        {
            int x = 0, y = 0, cunt = 0;
            String Title = "";

            DataTable tblvideo = new DataTable();

            tblvideo = connection.CmdRecord("select * from tblVideo");

            
            while(x<tblvideo.Rows.Count)
            {
                DataTable Rental = new DataTable();

                Rental= connection.CmdRecord("select * from Issued where VideoID=" + Convert.ToInt32(tblvideo.Rows[x]["VideoID"]) + "");


                if (Rental.Rows.Count > cunt)
                {

                    Title = tblvideo.Rows[x]["MovieName"].ToString();
                    cunt = Rental.Rows.Count;

                }
                x++;
            }


            MessageBox.Show("Best Movie Name   is " + Title);




        }

        private void popular_customer_Click(object sender, EventArgs e)
        {
            int x = 0, y = 0, cunt = 0;
            String Title = "";

            DataTable video = new DataTable();

            video = connection.CmdRecord("select * from tblCustomer");


            while (x < video.Rows.Count)
            {
                DataTable Rental = new DataTable();

                Rental = connection.CmdRecord("select * from Issued where CustomerID=" + Convert.ToInt32(video.Rows[x]["CustID"]) + "");


                if (Rental.Rows.Count > cunt)
                {

                    Title = video.Rows[x]["FullName"].ToString();
                    cunt = Rental.Rows.Count;

                }
                x++;
            }


            MessageBox.Show("Best Customer Name   is " + Title);

        }
    }
}
