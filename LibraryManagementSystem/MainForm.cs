using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace LibraryManagementSystem
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Documents\library.mdf;Integrated Security=True;Connect Timeout=30");
        string connection_string = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Documents\library.mdf;Integrated Security=True;Connect Timeout=30";

        private void logout_btn_Click(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("Are you sure you want to logout?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(check == DialogResult.Yes)
            {
                LoginForm lForm = new LoginForm();
                lForm.Show();
                this.Hide();
            }

        }

        private void dashboard_btn_Click(object sender, EventArgs e)
        {
            dashboard1.Visible = true;
            addBooks1.Visible = false;
            returnBooks1.Visible = false;
            issueBooks1.Visible = false;
            addMember1.Visible = false;

            Dashboard dForm = dashboard1 as Dashboard;
            if (dForm != null)
            {
                dForm.refreshData();
            }
        }

        private void addBooks_btn_Click(object sender, EventArgs e)
        {
            dashboard1.Visible = false;
            addBooks1.Visible = true;
            returnBooks1.Visible = false;
            issueBooks1.Visible = false;
            addMember1.Visible = false;

            AddBooks aForm = addBooks1 as AddBooks;
            if(aForm != null)
            {
                aForm.refreshData();
            }

            

        }

        private void issueBooks_btn_Click(object sender, EventArgs e)
        {
            dashboard1.Visible = false;
            addBooks1.Visible = false;
            returnBooks1.Visible = false;
            issueBooks1.Visible = true;
            addMember1.Visible = false;

            ReturnBooks rForm = returnBooks1 as ReturnBooks;
            if (rForm != null)
            {
                rForm.refreshData();
            }
        }

        private void returnBooks_btn_Click(object sender, EventArgs e)
        {
            dashboard1.Visible = false;
            addBooks1.Visible = false;
            returnBooks1.Visible = true;
            issueBooks1.Visible = false;
            addMember1.Visible = false;

            IssueBooks iForm = issueBooks1 as IssueBooks;
            if (iForm != null)
            {
                iForm.refreshData();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dashboard1_Load(object sender, EventArgs e)
        { 

        }

        void bind_data()
        {
            SqlConnection conn = new SqlConnection(connection_string);
            SqlCommand comm = new SqlCommand("SELECT * FROM member", conn);
            conn.Open();
            SqlDataAdapter adpt = new SqlDataAdapter(comm);
            DataTable dt = new DataTable();
            dt.Clear();
            adpt.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();

        }

        private void member_btn_Click(object sender, EventArgs e)
        {
            dashboard1.Visible = false;
            addBooks1.Visible = false;
            returnBooks1.Visible = false;
            issueBooks1.Visible = false;
            addMember1.Visible = true;
            bind_data();

        }

        private void addMember_addBtn_Click(object sender, EventArgs e)
        {

            insert_data();
            bind_data();
        }

        void insert_data()
        {
            if (addMember_id.Text == null
                || addMember_name.Text == ""
                || addMember_gender.Text == ""
                || addMember_nic.Text == ""
                || addMember_address.Text == ""
                || addMember_email.Text == ""
                || addMember_date.Value == null)
            {
                MessageBox.Show("Please fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (connect.State == ConnectionState.Closed)
                {
                    try
                    {
                        DateTime today = DateTime.Today;
                        connect.Open();
                        string insertData = "INSERT INTO member " +
                            "(member_name, gender, nic, member_address, email, get_date) " +
                            "VALUES(@memberName, @Gender, @NIC, @memberAddress, @Email, @getDate)";


                        using (SqlCommand cmd = new SqlCommand(insertData, connect))
                        {
                            cmd.Parameters.AddWithValue("@memberName", addMember_name.Text.Trim());
                            cmd.Parameters.AddWithValue("@Gender", addMember_gender.Text.Trim());
                            cmd.Parameters.AddWithValue("@NIC", addMember_nic.Text.Trim());
                            cmd.Parameters.AddWithValue("@memberAddress", addMember_address.Text.Trim());
                            cmd.Parameters.AddWithValue("@Email", addMember_email.Text.Trim());
                            cmd.Parameters.AddWithValue("@getDate", today);

                            cmd.ExecuteNonQuery();

                            //displayBooks();

                            MessageBox.Show("Added successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            //clearFields();
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    finally
                    {
                        connect.Close();
                    }
                }
            }
        }

        private void addMember_clearBtn_Click(object sender, EventArgs e)
        {
            addMember_id.Text = "";
            addMember_name.Text = "";
            addMember_gender.Text = "";
            addMember_nic.Text = "";
            addMember_address.Text = "";
            addMember_email.Text = "";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.CurrentRow.Selected = true;
            addMember_id.Text = dataGridView1.CurrentRow.Cells["id"].Value.ToString();
            addMember_name.Text = dataGridView1.CurrentRow.Cells["member_name"].Value.ToString();
            addMember_gender.Text = dataGridView1.CurrentRow.Cells["gender"].Value.ToString();
            addMember_nic.Text = dataGridView1.CurrentRow.Cells["nic"].Value.ToString();
            addMember_address.Text = dataGridView1.CurrentRow.Cells["member_address"].Value.ToString();
            addMember_email.Text = dataGridView1.CurrentRow.Cells["email"].Value.ToString();
        }

        private void addMember_updateBtn_Click(object sender, EventArgs e)
        {
            if (addMember_id.Text == ""
               || addMember_name.Text == ""
               || addMember_gender.Text == ""
               || addMember_nic.Text == ""
               || addMember_address.Text == ""
               || addMember_email.Text == "")
            {
                MessageBox.Show("Please select item first", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (connect.State != ConnectionState.Open)
                {
                    DialogResult check = MessageBox.Show("Are you sure you want to UPDATE Member ID:"
                        + addMember_id.Text + "?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (check == DialogResult.Yes)
                    {
                        try
                        {
                            connect.Open();
                            DateTime today = DateTime.Today;
                            string updateData = "UPDATE member SET " +
                                "member_name = @member_name, gender = @member_gender" +
                                ", nic = @member_nic, email = @member_email,get_date = @date WHERE id = @id";

                            using (SqlCommand cmd = new SqlCommand(updateData, connect))
                            {
                                
                                cmd.Parameters.AddWithValue("@member_name", addMember_name.Text.Trim());
                                cmd.Parameters.AddWithValue("@member_gender", addMember_gender.Text.Trim());
                                cmd.Parameters.AddWithValue("@member_nic", addMember_nic.Text.Trim());
                                cmd.Parameters.AddWithValue("@member_email", addMember_address.Text.Trim());
                                cmd.Parameters.AddWithValue("@date", today);
                                cmd.Parameters.AddWithValue("@id", addMember_id.Text.Trim());

                                cmd.ExecuteNonQuery();

                                //displayBooks();
                                bind_data();

                                MessageBox.Show("Updated successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                //clearFields();
                            }

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        finally
                        {
                            connect.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Cancelled.", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }
            }
        }

        private void addMember_deleteBtn_Click(object sender, EventArgs e)
        {
            if ( addMember_id.Text == ""
               || addMember_name.Text == ""
               || addMember_gender.Text == ""
               || addMember_nic.Text == ""
               || addMember_address.Text == ""
               || addMember_email.Text == "")
            {
                MessageBox.Show("Please select item first", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (connect.State != ConnectionState.Open)
                {
                    DialogResult check = MessageBox.Show("Are you sure you want to DELETE Member ID:"
                        + addMember_id.Text + "?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (check == DialogResult.Yes)
                    {
                        try
                        {
                            connect.Open();
                            DateTime today = DateTime.Today;
                            string updateData = "DELETE FROM member WHERE id=@id;";

                            using (SqlCommand cmd = new SqlCommand(updateData, connect))
                            {
                                cmd.Parameters.AddWithValue("@id", addMember_id.Text.Trim());

                                cmd.ExecuteNonQuery();

                                //displayBooks();
                                bind_data();

                                MessageBox.Show("Deleted successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                //clearFields();
                            }

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        finally
                        {
                            connect.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Cancelled.", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }
            }
        }
    }
}


