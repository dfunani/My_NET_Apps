
using System.Data;
using System.Windows.Forms;
namespace ToDoApp
{
    public partial class Form1 : Form
    {
        DataTable table;
        public Dictionary<String, String[]> keyValuePairs= new Dictionary<String, String[]>()
        {
            {"Programming_.NET", new String[]{"Programming", ".NET", "Develop a to do app using .net", "2022/07/19 15:00:00", "false" } },
            {"Programming_Py", new String[]{"Programming", "Py", "Develop a to do app using .net", "2022/07/19 15:00:00", "false"  }},
            {"Programming_TS", new String[]{"Programming", "TS", "Develop a to do app using .net", "2022/07/19 15:00:00", "false"  }},
            {"Programming_C", new String[]{"Programming", "C", "Develop a to do app using .net", "2022/07/19 15:00:00", "false"  }},
        };
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
            table.Columns.Add("Completed", typeof(Boolean));

            dataGridView1.DataSource= table;
            GetData();
        }

        public void GetData() 
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            table.Rows.Clear();
            foreach(KeyValuePair<String, String[]> obj in keyValuePairs)
            {
                table.Rows.Add(obj.Value[0], obj.Value[1], obj.Value[2], obj.Value[3], obj.Value[4] == "true" ? true : false);
            }

        }
        public void SaveData() 
        {
            if(textBox1.Text != "" && textBox2.Text != "")
            {
                try
                {
                    keyValuePairs.Add(textBox1.Text + "_"+ textBox2.Text, new String[] { textBox1.Text, textBox2.Text, textBox3.Text, DateTime.Now.ToString(), "false" });
                }
                catch 
                {
                    keyValuePairs.Remove(textBox1.Text + "_" + textBox2.Text);
                    keyValuePairs.Add(textBox1.Text + "_"+ textBox2.Text, new String[] { textBox1.Text, textBox2.Text, textBox3.Text, DateTime.Now.ToString(), "false" });

                }
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
            int index = dataGridView1.CurrentCell.RowIndex;

            try
            {
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

        }
    }
}