
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text.Json;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace ToDoApp
{
    public partial class Form1 : Form
    {
        DataTable table;
        public Dictionary<String, String[]> keyValuePairs= new Dictionary<String, String[]>(){};
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            table = new DataTable();

            table.Columns.Add("Category", typeof(String));
            table.Columns.Add("Task", typeof(String));
            table.Columns.Add("Description", typeof(String));
            table.Columns.Add("Date", typeof(String));
            table.Columns.Add("Status", typeof(String));
            dataGridView1.DataSource= table;
            GetData();
        }

        public void GetData() 
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            comboBox1.SelectedIndex = -1;
            table.Rows.Clear();
            try
            {
                using (StreamReader file = File.OpenText(@".\test.json"))
                {
                    Newtonsoft.Json.JsonSerializer serializer = new Newtonsoft.Json.JsonSerializer();
                    keyValuePairs = (Dictionary<string, string[]>)serializer.Deserialize(file, typeof(Dictionary<String, String[]>));
                }
            }
            catch(Exception ex) { Console.WriteLine(""); }
            foreach (KeyValuePair<String, String[]> obj in keyValuePairs)
            {
                table.Rows.Add(obj.Value[0], obj.Value[1], obj.Value[2], obj.Value[3], obj.Value[4]);
            }

        }
        public void SaveData() 
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                using(StreamWriter file = File.CreateText(@".\test.json"))
                {
                    Newtonsoft.Json.JsonSerializer serializer = new Newtonsoft.Json.JsonSerializer();
                    keyValuePairs[textBox1.Text + "_" + textBox2.Text] = new string[] { textBox1.Text, textBox2.Text, textBox3.Text, DateTime.Now.ToString(), comboBox1.Text };
                    serializer.Serialize(file, keyValuePairs);
                }
                GetData();
            }
        }
        public void DeleteData()
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                using (StreamWriter file = File.CreateText(@".\test.json"))
                {
                    Newtonsoft.Json.JsonSerializer serializer = new Newtonsoft.Json.JsonSerializer();
                    keyValuePairs[textBox1.Text + "_" + textBox2.Text] = new string[] { textBox1.Text, textBox2.Text, textBox3.Text, DateTime.Now.ToString(), comboBox1.Text };
                    serializer.Serialize(file, keyValuePairs);
                }
                GetData();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            GetData();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SaveData();
            GetData();
        }

        private void button5_Click(object sender, EventArgs e)
        {

            try
            {
                int index = dataGridView1.CurrentCell.RowIndex;
                table.Rows[index].Delete();
            }
            catch(Exception ex) { Console.WriteLine("Error deleting line item"); }
        }

        private void button4_Click(object sender, EventArgs e)
        {

            try
            {
                int index = dataGridView1.CurrentCell.RowIndex;
                keyValuePairs.Remove(table.Rows[index]["Category"].ToString() + "_" + table.Rows[index]["Task"].ToString());
                keyValuePairs.Add(table.Rows[index]["Category"].ToString() + "_" + table.Rows[index]["Task"].ToString(), new String[] {
                table.Rows[index]["Category"].ToString(), table.Rows[index]["Task"].ToString(),
                table.Rows[index]["Description"].ToString(), table.Rows[index]["Date"].ToString(),
                "true" 
                });
            }
            catch(Exception ex) { Console.WriteLine("Error Updating the line item"); }
            GetData();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentCell.RowIndex;

            textBox1.Text = table.Rows[index]["Category"].ToString();
            textBox2.Text = table.Rows[index]["Task"].ToString();
            textBox3.Text = table.Rows[index]["Description"].ToString();
            comboBox1.Text = table.Rows[index]["Status"].ToString();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            List<String> res = new List<String>();
            string temp = "";
            Regex regex = new Regex(textBox4.Text);
            foreach(string key in keyValuePairs.Keys)
            {
                if(regex.IsMatch(key)) {
                    res.Add(key);
                    temp += key;
                }
            }
            MessageBox.Show(temp);
        }
    }
}