
namespace Project_Video_rental
{
    partial class Add_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.popular_button = new System.Windows.Forms.Button();
            this.popular_customer = new System.Windows.Forms.Button();
            this.delete_button_rental = new System.Windows.Forms.Button();
            this.return_button_rentals = new System.Windows.Forms.Button();
            this.Issue_button_rentals = new System.Windows.Forms.Button();
            this.Return_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.Issue_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.text_filed_customer = new System.Windows.Forms.TextBox();
            this.text_filed_videoId = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.delete_buuton_customer = new System.Windows.Forms.Button();
            this.btnAddVideo = new System.Windows.Forms.Button();
            this.btnVideoUpd = new System.Windows.Forms.Button();
            this.btnVideoDel = new System.Windows.Forms.Button();
            this.add_button_customer = new System.Windows.Forms.Button();
            this.update_button_customer = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.copies_textfiled = new System.Windows.Forms.TextBox();
            this.ratings_textfiled = new System.Windows.Forms.TextBox();
            this.year_textfiled = new System.Windows.Forms.TextBox();
            this.movie_name_textfiled = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.address_customer = new System.Windows.Forms.TextBox();
            this.email_customer = new System.Windows.Forms.TextBox();
            this.phone_customer = new System.Windows.Forms.TextBox();
            this.full_name_customer = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Rental_info = new System.Windows.Forms.Button();
            this.video_info = new System.Windows.Forms.Button();
            this.customer_info = new System.Windows.Forms.Button();
            this.show_dataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.Genre_textfield = new System.Windows.Forms.TextBox();
            this.plot_textfield = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.show_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // popular_button
            // 
            this.popular_button.BackColor = System.Drawing.Color.Red;
            this.popular_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.popular_button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.popular_button.Location = new System.Drawing.Point(427, 463);
            this.popular_button.Name = "popular_button";
            this.popular_button.Size = new System.Drawing.Size(140, 31);
            this.popular_button.TabIndex = 85;
            this.popular_button.Text = "Popular Movie";
            this.popular_button.UseVisualStyleBackColor = false;
            this.popular_button.Click += new System.EventHandler(this.popular_button_Click);
            // 
            // popular_customer
            // 
            this.popular_customer.BackColor = System.Drawing.Color.Red;
            this.popular_customer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.popular_customer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.popular_customer.Location = new System.Drawing.Point(427, 511);
            this.popular_customer.Name = "popular_customer";
            this.popular_customer.Size = new System.Drawing.Size(140, 31);
            this.popular_customer.TabIndex = 84;
            this.popular_customer.Text = "Popular Customer";
            this.popular_customer.UseVisualStyleBackColor = false;
            this.popular_customer.Click += new System.EventHandler(this.popular_customer_Click);
            // 
            // delete_button_rental
            // 
            this.delete_button_rental.BackColor = System.Drawing.Color.Red;
            this.delete_button_rental.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_button_rental.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.delete_button_rental.Location = new System.Drawing.Point(182, 519);
            this.delete_button_rental.Name = "delete_button_rental";
            this.delete_button_rental.Size = new System.Drawing.Size(100, 31);
            this.delete_button_rental.TabIndex = 83;
            this.delete_button_rental.Text = "Delete Movie";
            this.delete_button_rental.UseVisualStyleBackColor = false;
            this.delete_button_rental.Click += new System.EventHandler(this.delete_button_rental_Click);
            // 
            // return_button_rentals
            // 
            this.return_button_rentals.BackColor = System.Drawing.Color.Red;
            this.return_button_rentals.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.return_button_rentals.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.return_button_rentals.Location = new System.Drawing.Point(78, 519);
            this.return_button_rentals.Name = "return_button_rentals";
            this.return_button_rentals.Size = new System.Drawing.Size(98, 31);
            this.return_button_rentals.TabIndex = 82;
            this.return_button_rentals.Text = "Retrun Now";
            this.return_button_rentals.UseVisualStyleBackColor = false;
            this.return_button_rentals.Click += new System.EventHandler(this.return_button_rentals_Click);
            // 
            // Issue_button_rentals
            // 
            this.Issue_button_rentals.BackColor = System.Drawing.Color.Red;
            this.Issue_button_rentals.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Issue_button_rentals.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Issue_button_rentals.Location = new System.Drawing.Point(14, 519);
            this.Issue_button_rentals.Name = "Issue_button_rentals";
            this.Issue_button_rentals.Size = new System.Drawing.Size(58, 31);
            this.Issue_button_rentals.TabIndex = 81;
            this.Issue_button_rentals.Text = "Issue";
            this.Issue_button_rentals.UseVisualStyleBackColor = false;
            this.Issue_button_rentals.Click += new System.EventHandler(this.Issue_button_rentals_Click);
            // 
            // Return_dateTimePicker
            // 
            this.Return_dateTimePicker.Location = new System.Drawing.Point(137, 483);
            this.Return_dateTimePicker.Name = "Return_dateTimePicker";
            this.Return_dateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.Return_dateTimePicker.TabIndex = 80;
            // 
            // Issue_dateTimePicker
            // 
            this.Issue_dateTimePicker.Location = new System.Drawing.Point(137, 435);
            this.Issue_dateTimePicker.Name = "Issue_dateTimePicker";
            this.Issue_dateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.Issue_dateTimePicker.TabIndex = 79;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(25, 484);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(97, 20);
            this.label15.TabIndex = 78;
            this.label15.Text = "Return Date";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(25, 436);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(91, 20);
            this.label16.TabIndex = 77;
            this.label16.Text = "Issue Date ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(23, 395);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(99, 20);
            this.label13.TabIndex = 76;
            this.label13.Text = "Customer ID";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(23, 347);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(72, 20);
            this.label14.TabIndex = 75;
            this.label14.Text = "Video Id:";
            // 
            // text_filed_customer
            // 
            this.text_filed_customer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_filed_customer.Location = new System.Drawing.Point(137, 392);
            this.text_filed_customer.Name = "text_filed_customer";
            this.text_filed_customer.Size = new System.Drawing.Size(117, 26);
            this.text_filed_customer.TabIndex = 74;
            // 
            // text_filed_videoId
            // 
            this.text_filed_videoId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_filed_videoId.Location = new System.Drawing.Point(137, 347);
            this.text_filed_videoId.Name = "text_filed_videoId";
            this.text_filed_videoId.Size = new System.Drawing.Size(117, 26);
            this.text_filed_videoId.TabIndex = 73;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Red;
            this.label12.Font = new System.Drawing.Font("Perpetua Titling MT", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(25, 306);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(162, 23);
            this.label12.TabIndex = 72;
            this.label12.Text = "Rental Store";
            // 
            // delete_buuton_customer
            // 
            this.delete_buuton_customer.BackColor = System.Drawing.Color.Red;
            this.delete_buuton_customer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_buuton_customer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.delete_buuton_customer.Location = new System.Drawing.Point(182, 256);
            this.delete_buuton_customer.Name = "delete_buuton_customer";
            this.delete_buuton_customer.Size = new System.Drawing.Size(74, 31);
            this.delete_buuton_customer.TabIndex = 71;
            this.delete_buuton_customer.Text = "Delete";
            this.delete_buuton_customer.UseVisualStyleBackColor = false;
            this.delete_buuton_customer.Click += new System.EventHandler(this.delete_buuton_customer_Click);
            // 
            // btnAddVideo
            // 
            this.btnAddVideo.BackColor = System.Drawing.Color.Red;
            this.btnAddVideo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddVideo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddVideo.Location = new System.Drawing.Point(664, 358);
            this.btnAddVideo.Name = "btnAddVideo";
            this.btnAddVideo.Size = new System.Drawing.Size(58, 31);
            this.btnAddVideo.TabIndex = 70;
            this.btnAddVideo.Text = "Add";
            this.btnAddVideo.UseVisualStyleBackColor = false;
            this.btnAddVideo.Click += new System.EventHandler(this.button8_Click);
            // 
            // btnVideoUpd
            // 
            this.btnVideoUpd.BackColor = System.Drawing.Color.Red;
            this.btnVideoUpd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVideoUpd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnVideoUpd.Location = new System.Drawing.Point(733, 358);
            this.btnVideoUpd.Name = "btnVideoUpd";
            this.btnVideoUpd.Size = new System.Drawing.Size(75, 31);
            this.btnVideoUpd.TabIndex = 69;
            this.btnVideoUpd.Text = "Update";
            this.btnVideoUpd.UseVisualStyleBackColor = false;
            this.btnVideoUpd.Click += new System.EventHandler(this.btnVideoUpd_Click);
            // 
            // btnVideoDel
            // 
            this.btnVideoDel.BackColor = System.Drawing.Color.Red;
            this.btnVideoDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVideoDel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnVideoDel.Location = new System.Drawing.Point(825, 358);
            this.btnVideoDel.Name = "btnVideoDel";
            this.btnVideoDel.Size = new System.Drawing.Size(75, 31);
            this.btnVideoDel.TabIndex = 68;
            this.btnVideoDel.Text = "Delete";
            this.btnVideoDel.UseVisualStyleBackColor = false;
            this.btnVideoDel.Click += new System.EventHandler(this.btnVideoDel_Click);
            // 
            // add_button_customer
            // 
            this.add_button_customer.BackColor = System.Drawing.Color.Red;
            this.add_button_customer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_button_customer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.add_button_customer.Location = new System.Drawing.Point(23, 256);
            this.add_button_customer.Name = "add_button_customer";
            this.add_button_customer.Size = new System.Drawing.Size(65, 31);
            this.add_button_customer.TabIndex = 67;
            this.add_button_customer.Text = "Add ";
            this.add_button_customer.UseVisualStyleBackColor = false;
            this.add_button_customer.Click += new System.EventHandler(this.add_button_customer_Click);
            // 
            // update_button_customer
            // 
            this.update_button_customer.BackColor = System.Drawing.Color.Red;
            this.update_button_customer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update_button_customer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.update_button_customer.Location = new System.Drawing.Point(94, 256);
            this.update_button_customer.Name = "update_button_customer";
            this.update_button_customer.Size = new System.Drawing.Size(78, 31);
            this.update_button_customer.TabIndex = 66;
            this.update_button_customer.Text = "Update";
            this.update_button_customer.UseVisualStyleBackColor = false;
            this.update_button_customer.Click += new System.EventHandler(this.update_button_customer_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(669, 218);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 20);
            this.label8.TabIndex = 65;
            this.label8.Text = "Copies on rent";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(669, 170);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(108, 20);
            this.label9.TabIndex = 64;
            this.label9.Text = "Year realesed";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(669, 123);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 20);
            this.label10.TabIndex = 63;
            this.label10.Text = "Ratings";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(669, 75);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(104, 20);
            this.label11.TabIndex = 62;
            this.label11.Text = "Movie Name :";
            // 
            // copies_textfiled
            // 
            this.copies_textfiled.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.copies_textfiled.Location = new System.Drawing.Point(783, 212);
            this.copies_textfiled.Name = "copies_textfiled";
            this.copies_textfiled.Size = new System.Drawing.Size(117, 26);
            this.copies_textfiled.TabIndex = 61;
            // 
            // ratings_textfiled
            // 
            this.ratings_textfiled.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ratings_textfiled.Location = new System.Drawing.Point(783, 120);
            this.ratings_textfiled.Name = "ratings_textfiled";
            this.ratings_textfiled.Size = new System.Drawing.Size(117, 26);
            this.ratings_textfiled.TabIndex = 60;
            // 
            // year_textfiled
            // 
            this.year_textfiled.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.year_textfiled.Location = new System.Drawing.Point(783, 164);
            this.year_textfiled.Name = "year_textfiled";
            this.year_textfiled.Size = new System.Drawing.Size(117, 26);
            this.year_textfiled.TabIndex = 59;
            // 
            // movie_name_textfiled
            // 
            this.movie_name_textfiled.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.movie_name_textfiled.Location = new System.Drawing.Point(783, 75);
            this.movie_name_textfiled.Name = "movie_name_textfiled";
            this.movie_name_textfiled.Size = new System.Drawing.Size(117, 26);
            this.movie_name_textfiled.TabIndex = 58;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(25, 218);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 20);
            this.label7.TabIndex = 57;
            this.label7.Text = "Address :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(25, 170);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 20);
            this.label6.TabIndex = 56;
            this.label6.Text = "Phone :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(25, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 20);
            this.label5.TabIndex = 55;
            this.label5.Text = "Email :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 20);
            this.label4.TabIndex = 54;
            this.label4.Text = "Full Name :";
            // 
            // address_customer
            // 
            this.address_customer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.address_customer.Location = new System.Drawing.Point(139, 212);
            this.address_customer.Name = "address_customer";
            this.address_customer.Size = new System.Drawing.Size(117, 26);
            this.address_customer.TabIndex = 53;
            // 
            // email_customer
            // 
            this.email_customer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email_customer.Location = new System.Drawing.Point(139, 120);
            this.email_customer.Name = "email_customer";
            this.email_customer.Size = new System.Drawing.Size(117, 26);
            this.email_customer.TabIndex = 52;
            // 
            // phone_customer
            // 
            this.phone_customer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phone_customer.Location = new System.Drawing.Point(139, 164);
            this.phone_customer.Name = "phone_customer";
            this.phone_customer.Size = new System.Drawing.Size(117, 26);
            this.phone_customer.TabIndex = 51;
            // 
            // full_name_customer
            // 
            this.full_name_customer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.full_name_customer.Location = new System.Drawing.Point(139, 75);
            this.full_name_customer.Name = "full_name_customer";
            this.full_name_customer.Size = new System.Drawing.Size(117, 26);
            this.full_name_customer.TabIndex = 50;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Red;
            this.label3.Font = new System.Drawing.Font("Perpetua Titling MT", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(669, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(181, 23);
            this.label3.TabIndex = 49;
            this.label3.Text = "Add New Video";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Red;
            this.label2.Font = new System.Drawing.Font("Perpetua Titling MT", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(25, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(231, 23);
            this.label2.TabIndex = 48;
            this.label2.Text = "Add New Customer";
            // 
            // Rental_info
            // 
            this.Rental_info.BackColor = System.Drawing.Color.Red;
            this.Rental_info.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rental_info.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Rental_info.Location = new System.Drawing.Point(517, -1);
            this.Rental_info.Name = "Rental_info";
            this.Rental_info.Size = new System.Drawing.Size(126, 31);
            this.Rental_info.TabIndex = 47;
            this.Rental_info.Text = "Rental Info";
            this.Rental_info.UseVisualStyleBackColor = false;
            this.Rental_info.Click += new System.EventHandler(this.Rental_info_Click);
            // 
            // video_info
            // 
            this.video_info.BackColor = System.Drawing.Color.Red;
            this.video_info.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.video_info.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.video_info.Location = new System.Drawing.Point(390, -1);
            this.video_info.Name = "video_info";
            this.video_info.Size = new System.Drawing.Size(126, 31);
            this.video_info.TabIndex = 46;
            this.video_info.Text = "Video Info";
            this.video_info.UseVisualStyleBackColor = false;
            this.video_info.Click += new System.EventHandler(this.video_info_Click);
            // 
            // customer_info
            // 
            this.customer_info.BackColor = System.Drawing.Color.Red;
            this.customer_info.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customer_info.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.customer_info.Location = new System.Drawing.Point(262, -1);
            this.customer_info.Name = "customer_info";
            this.customer_info.Size = new System.Drawing.Size(126, 31);
            this.customer_info.TabIndex = 45;
            this.customer_info.Text = "Customer Info";
            this.customer_info.UseVisualStyleBackColor = false;
            this.customer_info.Click += new System.EventHandler(this.customer_info_Click);
            // 
            // show_dataGridView
            // 
            this.show_dataGridView.BackgroundColor = System.Drawing.Color.Red;
            this.show_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.show_dataGridView.Location = new System.Drawing.Point(262, 29);
            this.show_dataGridView.Name = "show_dataGridView";
            this.show_dataGridView.Size = new System.Drawing.Size(386, 407);
            this.show_dataGridView.TabIndex = 44;
            this.show_dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.show_dataGridView_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(669, 311);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 20);
            this.label1.TabIndex = 91;
            this.label1.Text = "Genre";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(669, 263);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(36, 20);
            this.label17.TabIndex = 90;
            this.label17.Text = "Plot";
            // 
            // Genre_textfield
            // 
            this.Genre_textfield.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Genre_textfield.Location = new System.Drawing.Point(783, 305);
            this.Genre_textfield.Name = "Genre_textfield";
            this.Genre_textfield.Size = new System.Drawing.Size(117, 26);
            this.Genre_textfield.TabIndex = 88;
            // 
            // plot_textfield
            // 
            this.plot_textfield.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plot_textfield.Location = new System.Drawing.Point(783, 257);
            this.plot_textfield.Name = "plot_textfield";
            this.plot_textfield.Size = new System.Drawing.Size(117, 26);
            this.plot_textfield.TabIndex = 86;
            // 
            // Add_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.ClientSize = new System.Drawing.Size(926, 559);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.Genre_textfield);
            this.Controls.Add(this.plot_textfield);
            this.Controls.Add(this.popular_button);
            this.Controls.Add(this.popular_customer);
            this.Controls.Add(this.delete_button_rental);
            this.Controls.Add(this.return_button_rentals);
            this.Controls.Add(this.Issue_button_rentals);
            this.Controls.Add(this.Return_dateTimePicker);
            this.Controls.Add(this.Issue_dateTimePicker);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.text_filed_customer);
            this.Controls.Add(this.text_filed_videoId);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.delete_buuton_customer);
            this.Controls.Add(this.btnAddVideo);
            this.Controls.Add(this.btnVideoUpd);
            this.Controls.Add(this.btnVideoDel);
            this.Controls.Add(this.add_button_customer);
            this.Controls.Add(this.update_button_customer);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.copies_textfiled);
            this.Controls.Add(this.ratings_textfiled);
            this.Controls.Add(this.year_textfiled);
            this.Controls.Add(this.movie_name_textfiled);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.address_customer);
            this.Controls.Add(this.email_customer);
            this.Controls.Add(this.phone_customer);
            this.Controls.Add(this.full_name_customer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Rental_info);
            this.Controls.Add(this.video_info);
            this.Controls.Add(this.customer_info);
            this.Controls.Add(this.show_dataGridView);
            this.Name = "Add_Form";
            this.Text = "Add_Form";
            this.Load += new System.EventHandler(this.Add_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.show_dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button popular_button;
        private System.Windows.Forms.Button popular_customer;
        private System.Windows.Forms.Button delete_button_rental;
        private System.Windows.Forms.Button return_button_rentals;
        private System.Windows.Forms.Button Issue_button_rentals;
        private System.Windows.Forms.DateTimePicker Return_dateTimePicker;
        private System.Windows.Forms.DateTimePicker Issue_dateTimePicker;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox text_filed_customer;
        private System.Windows.Forms.TextBox text_filed_videoId;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button delete_buuton_customer;
        private System.Windows.Forms.Button btnAddVideo;
        private System.Windows.Forms.Button btnVideoUpd;
        private System.Windows.Forms.Button btnVideoDel;
        private System.Windows.Forms.Button add_button_customer;
        private System.Windows.Forms.Button update_button_customer;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox copies_textfiled;
        private System.Windows.Forms.TextBox ratings_textfiled;
        private System.Windows.Forms.TextBox year_textfiled;
        private System.Windows.Forms.TextBox movie_name_textfiled;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox address_customer;
        private System.Windows.Forms.TextBox email_customer;
        private System.Windows.Forms.TextBox phone_customer;
        private System.Windows.Forms.TextBox full_name_customer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Rental_info;
        private System.Windows.Forms.Button video_info;
        private System.Windows.Forms.Button customer_info;
        private System.Windows.Forms.DataGridView show_dataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox Genre_textfield;
        private System.Windows.Forms.TextBox plot_textfield;
    }
}