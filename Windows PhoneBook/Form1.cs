using System.Text.RegularExpressions;
using System.Collections;
using System.Data;
using System.Data.SqlClient;

namespace Windows_PhoneBook
{
    public partial class Form1 : Form
    {
        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-GUMF1SO;Initial Catalog=Dot_Net_Apps;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        String selection = "";
        Dictionary<String, List<String>> obj = new Dictionary<String, List<String>>()
            {
                {"Obj1", new List<String>(){ "Delali", "Funani", "dfunani@gmail.com", "0685642078", "Home" } },
            };
        
        public Form1()
        {
            InitializeComponent();
            
            DisplayData();
        }

        public void DisplayData(string like = "")
        {
            button1_Click(new object(), null);
            
            SqlDataAdapter data = new SqlDataAdapter($"SELECT * FROM [dbo].[Table] WHERE [Id] like '%{like}%' or [First Name] like '%{like}%' or [Last Name] like '%{like}%' or [Mobile] like '%{like}%' or [Email] like '%{like}%' or [Category] like '%{like}%'", connection);
            DataTable dataTable = new DataTable();

            data.Fill(dataTable);
            dataGridView1.Rows.Clear();
            foreach (DataRow obj in dataTable.Rows)
            {
                dataGridView1.Rows.Add(obj[0].ToString(), obj[1].ToString(), obj[2].ToString(), obj[4].ToString(), obj[3].ToString(), obj[5].ToString(), obj[6].ToString());
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog df = new OpenFileDialog();
            df.ShowDialog();
            pictureBox1.ImageLocation = df.FileName.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(textBox1.Text != "")
            {
                textBox1.BackColor = SystemColors.ActiveCaption;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text != "")
            {
                textBox2.BackColor = SystemColors.ActiveCaption;
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            Regex regex = new Regex("[A-Za-z0-9]+@[A-Za-z]+[.][A-Za-z]");
            if(regex.IsMatch(textBox3.Text) && textBox3.Text.Length >= 14)
            {
                textBox3.BackColor = SystemColors.ActiveCaption;
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            Regex regex = new Regex(@"[+]?[(]?[\d]+[)]?[-(]?[\d]+[)-]?[\d]+");
            if (regex.IsMatch(textBox4.Text) && textBox4.Text.Length >= 10)
            {
                textBox4.BackColor = SystemColors.ActiveCaption;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Console.WriteLine("Changed selection");
        }

        private void button1_Click(object sender, EventArgs? e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            comboBox1.Text = "";
            selection = "";
            button2.Text = "SAVE";
            button3.Text = "DELETE";
            button4.Text = "UPDATE";
            button2.Enabled = true;
            button3.Enabled = true;
            comboBox1.SelectedItem = null;
            textBox1.BackColor = SystemColors.Window;
            textBox2.BackColor = SystemColors.Window;
            textBox3.BackColor = SystemColors.Window;
            textBox4.BackColor = SystemColors.Window;
            pictureBox1.Image = pictureBox1.InitialImage;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(textBox1.Text != "" && textBox2.Text != "")
            {
                connection.Open();
                SqlCommand command = new SqlCommand("INSERT INTO [dbo].[Table] ([id], [First Name], [Last Name], [Email], [Mobile], [Category], [Image]) " +
                    "VALUES ('" + new Random().Next(1000000) + "', '" + textBox1.Text + "', '" + 
                    textBox2.Text + "', '" + textBox3.Text + "', '" + textBox4.Text + "', '" + comboBox1.Text + "', '" + pictureBox1.ImageLocation + "')", connection);
                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Successfully Saved...");
            }
            DisplayData();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int n = dataGridView1.SelectedRows[0].Index;
            string res = MessageBox.Show("Are you sure?", $"DELETE - {dataGridView1.Rows[n].Cells[1].Value.ToString()}", MessageBoxButtons.YesNoCancel).ToString();

            if(res.ToLower() != "yes")
            {
                return;
            }
            connection.Open();
            SqlCommand command = new SqlCommand("DELETE FROM [dbo].[Table] WHERE [id] = " +
                dataGridView1.Rows[n].Cells[0].Value.ToString(), connection);
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show($"Deleted {dataGridView1.Rows[n].Cells[1].Value.ToString()} Successfully");
            DisplayData();
        }

        private void Update_DB(String script)
        {
            if(textBox1.Text != "" && textBox2.Text != "")
            {
                connection.Open();
                SqlCommand command = new SqlCommand(script, connection);

                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("DB Updated SUccessfully");
            }
            DisplayData();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            if (selection == "")
            {
                int n = dataGridView1.SelectedRows[0].Index;

                textBox1.Text = dataGridView1.Rows[n].Cells[1].Value.ToString();
                textBox2.Text = dataGridView1.Rows[n].Cells[2].Value.ToString();
                textBox3.Text = dataGridView1.Rows[n].Cells[3].Value.ToString();
                textBox4.Text = dataGridView1.Rows[n].Cells[4].Value.ToString();
                comboBox1.Text = dataGridView1.Rows[n].Cells[5].Value.ToString();
                button2.Enabled = false;
                button2.Text = "";
                button3.Enabled = false;
                button3.Text = "";
                button4.Text = "SAVE";
                selection = dataGridView1.Rows[n].Cells[0].Value.ToString();
                pictureBox1.ImageLocation = dataGridView1.Rows[n].Cells[6].Value.ToString();
                return;
            }
            string script = "UPDATE [dbo].[Table] SET [First Name] = '" + textBox1.Text +
                "' ,[Last Name] = '" + textBox2.Text +
                "' ,[Email] = '" + textBox3.Text +
                "' ,[Mobile] = '" + textBox4.Text +
                "' ,[Category] = '" + comboBox1.Text +
                "' ,[Image] = '" + pictureBox1.ImageLocation +
                "' WHERE [id] = " + selection.ToString();
            Update_DB(script);
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            DisplayData(textBox6.Text);
        }
    }
}