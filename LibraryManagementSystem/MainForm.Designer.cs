
namespace LibraryManagementSystem
{
    partial class MainForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.member_btn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.logout_btn = new System.Windows.Forms.Button();
            this.returnBooks_btn = new System.Windows.Forms.Button();
            this.issueBooks_btn = new System.Windows.Forms.Button();
            this.addBooks_btn = new System.Windows.Forms.Button();
            this.dashboard_btn = new System.Windows.Forms.Button();
            this.greet_label = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.addMember1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.addMember_email = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.addMember_address = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.addMember_nic = new System.Windows.Forms.TextBox();
            this.addMember_gender = new System.Windows.Forms.TextBox();
            this.addMember_clearBtn = new System.Windows.Forms.Button();
            this.addMember_deleteBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.addMember_date = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.addMember_updateBtn = new System.Windows.Forms.Button();
            this.addMember_addBtn = new System.Windows.Forms.Button();
            this.addMember_name = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.addMember_id = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.issueBooks1 = new LibraryManagementSystem.IssueBooks();
            this.returnBooks1 = new LibraryManagementSystem.ReturnBooks();
            this.dashboard1 = new LibraryManagementSystem.Dashboard();
            this.addBooks1 = new LibraryManagementSystem.AddBooks();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.addMember1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SandyBrown;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1467, 43);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(17, 11);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(337, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sarasavi | Library Management System";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(1443, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "X";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(19)))), ((int)(((byte)(20)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.member_btn);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.logout_btn);
            this.panel2.Controls.Add(this.returnBooks_btn);
            this.panel2.Controls.Add(this.issueBooks_btn);
            this.panel2.Controls.Add(this.addBooks_btn);
            this.panel2.Controls.Add(this.dashboard_btn);
            this.panel2.Controls.Add(this.greet_label);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 43);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(293, 695);
            this.panel2.TabIndex = 1;
            // 
            // member_btn
            // 
            this.member_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(41)))));
            this.member_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.member_btn.FlatAppearance.BorderSize = 0;
            this.member_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.member_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.member_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.member_btn.ForeColor = System.Drawing.Color.White;
            this.member_btn.Image = global::LibraryManagementSystem.Properties.Resources.follower;
            this.member_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.member_btn.Location = new System.Drawing.Point(-1, 479);
            this.member_btn.Margin = new System.Windows.Forms.Padding(4);
            this.member_btn.Name = "member_btn";
            this.member_btn.Size = new System.Drawing.Size(293, 55);
            this.member_btn.TabIndex = 8;
            this.member_btn.Text = "MEMBERS";
            this.member_btn.UseVisualStyleBackColor = false;
            this.member_btn.Click += new System.EventHandler(this.member_btn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(65, 654);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 21);
            this.label4.TabIndex = 7;
            this.label4.Text = "Log out";
            // 
            // logout_btn
            // 
            this.logout_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logout_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSeaGreen;
            this.logout_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSeaGreen;
            this.logout_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logout_btn.ForeColor = System.Drawing.Color.Black;
            this.logout_btn.Image = global::LibraryManagementSystem.Properties.Resources.icons8_logout_rounded_up_filled_20px;
            this.logout_btn.Location = new System.Drawing.Point(11, 642);
            this.logout_btn.Margin = new System.Windows.Forms.Padding(4);
            this.logout_btn.Name = "logout_btn";
            this.logout_btn.Size = new System.Drawing.Size(47, 43);
            this.logout_btn.TabIndex = 6;
            this.logout_btn.UseVisualStyleBackColor = true;
            this.logout_btn.Click += new System.EventHandler(this.logout_btn_Click);
            // 
            // returnBooks_btn
            // 
            this.returnBooks_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(41)))));
            this.returnBooks_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.returnBooks_btn.FlatAppearance.BorderSize = 0;
            this.returnBooks_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.returnBooks_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.returnBooks_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.returnBooks_btn.ForeColor = System.Drawing.Color.White;
            this.returnBooks_btn.Image = global::LibraryManagementSystem.Properties.Resources.icons8_return_32px_3;
            this.returnBooks_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.returnBooks_btn.Location = new System.Drawing.Point(-1, 416);
            this.returnBooks_btn.Margin = new System.Windows.Forms.Padding(4);
            this.returnBooks_btn.Name = "returnBooks_btn";
            this.returnBooks_btn.Size = new System.Drawing.Size(293, 55);
            this.returnBooks_btn.TabIndex = 5;
            this.returnBooks_btn.Text = "RETURN BOOKS";
            this.returnBooks_btn.UseVisualStyleBackColor = false;
            this.returnBooks_btn.Click += new System.EventHandler(this.returnBooks_btn_Click);
            // 
            // issueBooks_btn
            // 
            this.issueBooks_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(41)))));
            this.issueBooks_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.issueBooks_btn.FlatAppearance.BorderSize = 0;
            this.issueBooks_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.issueBooks_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.issueBooks_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.issueBooks_btn.ForeColor = System.Drawing.Color.White;
            this.issueBooks_btn.Image = global::LibraryManagementSystem.Properties.Resources.icons8_book_32px_1;
            this.issueBooks_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.issueBooks_btn.Location = new System.Drawing.Point(-1, 353);
            this.issueBooks_btn.Margin = new System.Windows.Forms.Padding(4);
            this.issueBooks_btn.Name = "issueBooks_btn";
            this.issueBooks_btn.Size = new System.Drawing.Size(293, 55);
            this.issueBooks_btn.TabIndex = 4;
            this.issueBooks_btn.Text = "ISSUE BOOKS";
            this.issueBooks_btn.UseVisualStyleBackColor = false;
            this.issueBooks_btn.Click += new System.EventHandler(this.issueBooks_btn_Click);
            // 
            // addBooks_btn
            // 
            this.addBooks_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(41)))));
            this.addBooks_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addBooks_btn.FlatAppearance.BorderSize = 0;
            this.addBooks_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.addBooks_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.addBooks_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addBooks_btn.ForeColor = System.Drawing.Color.White;
            this.addBooks_btn.Image = global::LibraryManagementSystem.Properties.Resources.icons8_book_32px;
            this.addBooks_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addBooks_btn.Location = new System.Drawing.Point(-1, 290);
            this.addBooks_btn.Margin = new System.Windows.Forms.Padding(4);
            this.addBooks_btn.Name = "addBooks_btn";
            this.addBooks_btn.Size = new System.Drawing.Size(293, 55);
            this.addBooks_btn.TabIndex = 3;
            this.addBooks_btn.Text = "ADD BOOKS";
            this.addBooks_btn.UseVisualStyleBackColor = false;
            this.addBooks_btn.Click += new System.EventHandler(this.addBooks_btn_Click);
            // 
            // dashboard_btn
            // 
            this.dashboard_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(41)))));
            this.dashboard_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dashboard_btn.FlatAppearance.BorderSize = 0;
            this.dashboard_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.dashboard_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.dashboard_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dashboard_btn.ForeColor = System.Drawing.Color.White;
            this.dashboard_btn.Image = global::LibraryManagementSystem.Properties.Resources.icons8_dashboard_32px;
            this.dashboard_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dashboard_btn.Location = new System.Drawing.Point(-1, 228);
            this.dashboard_btn.Margin = new System.Windows.Forms.Padding(4);
            this.dashboard_btn.Name = "dashboard_btn";
            this.dashboard_btn.Size = new System.Drawing.Size(293, 55);
            this.dashboard_btn.TabIndex = 2;
            this.dashboard_btn.Text = "DASHBOARD";
            this.dashboard_btn.UseVisualStyleBackColor = false;
            this.dashboard_btn.Click += new System.EventHandler(this.dashboard_btn_Click);
            // 
            // greet_label
            // 
            this.greet_label.AutoSize = true;
            this.greet_label.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.greet_label.ForeColor = System.Drawing.Color.White;
            this.greet_label.Location = new System.Drawing.Point(55, 161);
            this.greet_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.greet_label.Name = "greet_label";
            this.greet_label.Size = new System.Drawing.Size(168, 24);
            this.greet_label.TabIndex = 1;
            this.greet_label.Text = "Welcome | Admin";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LibraryManagementSystem.Properties.Resources.icons8_library_100px;
            this.pictureBox1.Location = new System.Drawing.Point(77, 34);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(133, 123);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dashboard1);
            this.panel3.Controls.Add(this.addBooks1);
            this.panel3.Controls.Add(this.issueBooks1);
            this.panel3.Controls.Add(this.returnBooks1);
            this.panel3.Controls.Add(this.addMember1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(293, 43);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1174, 695);
            this.panel3.TabIndex = 2;
            // 
            // addMember1
            // 
            this.addMember1.Controls.Add(this.panel4);
            this.addMember1.Controls.Add(this.panel5);
            this.addMember1.Location = new System.Drawing.Point(0, 0);
            this.addMember1.Name = "addMember1";
            this.addMember1.Size = new System.Drawing.Size(1174, 695);
            this.addMember1.TabIndex = 4;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.dataGridView1);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Location = new System.Drawing.Point(418, 24);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(737, 647);
            this.panel4.TabIndex = 5;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(128)))), ((int)(((byte)(87)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(20, 71);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(695, 550);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 22);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 29);
            this.label3.TabIndex = 0;
            this.label3.Text = "All Members";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.addMember_email);
            this.panel5.Controls.Add(this.label12);
            this.panel5.Controls.Add(this.label11);
            this.panel5.Controls.Add(this.label10);
            this.panel5.Controls.Add(this.addMember_address);
            this.panel5.Controls.Add(this.label9);
            this.panel5.Controls.Add(this.addMember_nic);
            this.panel5.Controls.Add(this.addMember_gender);
            this.panel5.Controls.Add(this.addMember_clearBtn);
            this.panel5.Controls.Add(this.addMember_deleteBtn);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.addMember_date);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Controls.Add(this.addMember_updateBtn);
            this.panel5.Controls.Add(this.addMember_addBtn);
            this.panel5.Controls.Add(this.addMember_name);
            this.panel5.Controls.Add(this.label7);
            this.panel5.Controls.Add(this.addMember_id);
            this.panel5.Controls.Add(this.label8);
            this.panel5.Location = new System.Drawing.Point(20, 24);
            this.panel5.Margin = new System.Windows.Forms.Padding(4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(370, 647);
            this.panel5.TabIndex = 4;
            // 
            // addMember_email
            // 
            this.addMember_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addMember_email.Location = new System.Drawing.Point(129, 314);
            this.addMember_email.Margin = new System.Windows.Forms.Padding(4);
            this.addMember_email.Name = "addMember_email";
            this.addMember_email.Size = new System.Drawing.Size(223, 26);
            this.addMember_email.TabIndex = 29;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(5, 316);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(117, 21);
            this.label12.TabIndex = 28;
            this.label12.Text = "Email            :";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(79, 22);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(203, 29);
            this.label11.TabIndex = 2;
            this.label11.Text = "Add New Member";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(6, 360);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(117, 21);
            this.label10.TabIndex = 27;
            this.label10.Text = "Date             :";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // addMember_address
            // 
            this.addMember_address.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addMember_address.Location = new System.Drawing.Point(129, 268);
            this.addMember_address.Margin = new System.Windows.Forms.Padding(4);
            this.addMember_address.Name = "addMember_address";
            this.addMember_address.Size = new System.Drawing.Size(223, 26);
            this.addMember_address.TabIndex = 26;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(6, 268);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(116, 21);
            this.label9.TabIndex = 25;
            this.label9.Text = "Address        :";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // addMember_nic
            // 
            this.addMember_nic.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addMember_nic.Location = new System.Drawing.Point(129, 221);
            this.addMember_nic.Margin = new System.Windows.Forms.Padding(4);
            this.addMember_nic.Name = "addMember_nic";
            this.addMember_nic.Size = new System.Drawing.Size(223, 26);
            this.addMember_nic.TabIndex = 24;
            // 
            // addMember_gender
            // 
            this.addMember_gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addMember_gender.Location = new System.Drawing.Point(129, 169);
            this.addMember_gender.Margin = new System.Windows.Forms.Padding(4);
            this.addMember_gender.Name = "addMember_gender";
            this.addMember_gender.Size = new System.Drawing.Size(223, 26);
            this.addMember_gender.TabIndex = 23;
            // 
            // addMember_clearBtn
            // 
            this.addMember_clearBtn.BackColor = System.Drawing.Color.Cyan;
            this.addMember_clearBtn.FlatAppearance.BorderSize = 0;
            this.addMember_clearBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkSeaGreen;
            this.addMember_clearBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSeaGreen;
            this.addMember_clearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addMember_clearBtn.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addMember_clearBtn.ForeColor = System.Drawing.Color.Black;
            this.addMember_clearBtn.Location = new System.Drawing.Point(195, 500);
            this.addMember_clearBtn.Margin = new System.Windows.Forms.Padding(4);
            this.addMember_clearBtn.Name = "addMember_clearBtn";
            this.addMember_clearBtn.Size = new System.Drawing.Size(132, 42);
            this.addMember_clearBtn.TabIndex = 22;
            this.addMember_clearBtn.Text = "CLEAR";
            this.addMember_clearBtn.UseVisualStyleBackColor = false;
            this.addMember_clearBtn.Click += new System.EventHandler(this.addMember_clearBtn_Click);
            // 
            // addMember_deleteBtn
            // 
            this.addMember_deleteBtn.BackColor = System.Drawing.Color.Cyan;
            this.addMember_deleteBtn.FlatAppearance.BorderSize = 0;
            this.addMember_deleteBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkSeaGreen;
            this.addMember_deleteBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSeaGreen;
            this.addMember_deleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addMember_deleteBtn.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addMember_deleteBtn.ForeColor = System.Drawing.Color.Black;
            this.addMember_deleteBtn.Location = new System.Drawing.Point(36, 500);
            this.addMember_deleteBtn.Margin = new System.Windows.Forms.Padding(4);
            this.addMember_deleteBtn.Name = "addMember_deleteBtn";
            this.addMember_deleteBtn.Size = new System.Drawing.Size(132, 42);
            this.addMember_deleteBtn.TabIndex = 21;
            this.addMember_deleteBtn.Text = "DELETE";
            this.addMember_deleteBtn.UseVisualStyleBackColor = false;
            this.addMember_deleteBtn.Click += new System.EventHandler(this.addMember_deleteBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 221);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 21);
            this.label5.TabIndex = 19;
            this.label5.Text = "NIC Number  :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // addMember_date
            // 
            this.addMember_date.Location = new System.Drawing.Point(131, 362);
            this.addMember_date.Margin = new System.Windows.Forms.Padding(4);
            this.addMember_date.Name = "addMember_date";
            this.addMember_date.Size = new System.Drawing.Size(221, 22);
            this.addMember_date.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 171);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 21);
            this.label6.TabIndex = 17;
            this.label6.Text = "Gender          :";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // addMember_updateBtn
            // 
            this.addMember_updateBtn.BackColor = System.Drawing.Color.Cyan;
            this.addMember_updateBtn.FlatAppearance.BorderSize = 0;
            this.addMember_updateBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkSeaGreen;
            this.addMember_updateBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSeaGreen;
            this.addMember_updateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addMember_updateBtn.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addMember_updateBtn.ForeColor = System.Drawing.Color.Black;
            this.addMember_updateBtn.Location = new System.Drawing.Point(195, 436);
            this.addMember_updateBtn.Margin = new System.Windows.Forms.Padding(4);
            this.addMember_updateBtn.Name = "addMember_updateBtn";
            this.addMember_updateBtn.Size = new System.Drawing.Size(132, 42);
            this.addMember_updateBtn.TabIndex = 16;
            this.addMember_updateBtn.Text = "UPDATE";
            this.addMember_updateBtn.UseVisualStyleBackColor = false;
            this.addMember_updateBtn.Click += new System.EventHandler(this.addMember_updateBtn_Click);
            // 
            // addMember_addBtn
            // 
            this.addMember_addBtn.BackColor = System.Drawing.Color.Cyan;
            this.addMember_addBtn.FlatAppearance.BorderSize = 0;
            this.addMember_addBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkSeaGreen;
            this.addMember_addBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSeaGreen;
            this.addMember_addBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addMember_addBtn.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addMember_addBtn.ForeColor = System.Drawing.Color.Black;
            this.addMember_addBtn.Location = new System.Drawing.Point(36, 436);
            this.addMember_addBtn.Margin = new System.Windows.Forms.Padding(4);
            this.addMember_addBtn.Name = "addMember_addBtn";
            this.addMember_addBtn.Size = new System.Drawing.Size(132, 42);
            this.addMember_addBtn.TabIndex = 15;
            this.addMember_addBtn.Text = "ADD";
            this.addMember_addBtn.UseVisualStyleBackColor = false;
            this.addMember_addBtn.Click += new System.EventHandler(this.addMember_addBtn_Click);
            // 
            // addMember_name
            // 
            this.addMember_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addMember_name.Location = new System.Drawing.Point(129, 119);
            this.addMember_name.Margin = new System.Windows.Forms.Padding(4);
            this.addMember_name.Name = "addMember_name";
            this.addMember_name.Size = new System.Drawing.Size(223, 26);
            this.addMember_name.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 124);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 21);
            this.label7.TabIndex = 11;
            this.label7.Text = "Name            : ";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // addMember_id
            // 
            this.addMember_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addMember_id.Location = new System.Drawing.Point(129, 73);
            this.addMember_id.Margin = new System.Windows.Forms.Padding(4);
            this.addMember_id.Name = "addMember_id";
            this.addMember_id.Size = new System.Drawing.Size(223, 26);
            this.addMember_id.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 76);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(123, 21);
            this.label8.TabIndex = 9;
            this.label8.Text = "User Number : ";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // issueBooks1
            // 
            this.issueBooks1.Location = new System.Drawing.Point(0, 0);
            this.issueBooks1.Margin = new System.Windows.Forms.Padding(5);
            this.issueBooks1.Name = "issueBooks1";
            this.issueBooks1.Size = new System.Drawing.Size(1173, 695);
            this.issueBooks1.TabIndex = 1;
            // 
            // returnBooks1
            // 
            this.returnBooks1.Location = new System.Drawing.Point(0, 0);
            this.returnBooks1.Margin = new System.Windows.Forms.Padding(5);
            this.returnBooks1.Name = "returnBooks1";
            this.returnBooks1.Size = new System.Drawing.Size(1174, 695);
            this.returnBooks1.TabIndex = 0;
            // 
            // dashboard1
            // 
            this.dashboard1.Location = new System.Drawing.Point(0, 0);
            this.dashboard1.Margin = new System.Windows.Forms.Padding(5);
            this.dashboard1.Name = "dashboard1";
            this.dashboard1.Size = new System.Drawing.Size(1173, 695);
            this.dashboard1.TabIndex = 3;
            this.dashboard1.Load += new System.EventHandler(this.dashboard1_Load);
            // 
            // addBooks1
            // 
            this.addBooks1.Location = new System.Drawing.Point(0, 0);
            this.addBooks1.Margin = new System.Windows.Forms.Padding(5);
            this.addBooks1.Name = "addBooks1";
            this.addBooks1.Size = new System.Drawing.Size(1173, 695);
            this.addBooks1.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1467, 738);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.addMember1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button addBooks_btn;
        private System.Windows.Forms.Button dashboard_btn;
        private System.Windows.Forms.Label greet_label;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button returnBooks_btn;
        private System.Windows.Forms.Button issueBooks_btn;
        private System.Windows.Forms.Button logout_btn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private Dashboard dashboard1;
        private System.Windows.Forms.Button member_btn;
        private System.Windows.Forms.Panel addMember1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button addMember_clearBtn;
        private System.Windows.Forms.Button addMember_deleteBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker addMember_date;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button addMember_updateBtn;
        private System.Windows.Forms.Button addMember_addBtn;
        private System.Windows.Forms.TextBox addMember_name;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox addMember_id;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox addMember_address;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox addMember_nic;
        private System.Windows.Forms.TextBox addMember_gender;
        private System.Windows.Forms.TextBox addMember_email;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private AddBooks addBooks1;
        private IssueBooks issueBooks1;
        private ReturnBooks returnBooks1;
    }
}