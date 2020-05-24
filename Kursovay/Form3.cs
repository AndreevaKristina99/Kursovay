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

namespace Kursovay
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        SqlConnection sqlconnect;
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\kandr\Source\Repos\Kursovay\Kursovay\Database1.mdf;Integrated Security=True";
        private async void Form3_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.Продукты". При необходимости она может быть перемещена или удалена.
            this.продуктыTableAdapter.Fill(this.database1DataSet.Продукты);

               this.продуктыTableAdapter.Fill(this.database1DataSet.Продукты);
            sqlconnect = new SqlConnection(connectionString);
            await sqlconnect.OpenAsync();
            SqlDataReader sqlReader = null;
            SqlCommand comand = new SqlCommand("SELECT * FROM [Продукты]", sqlconnect);

        }

        private  void главноеМенюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 newForm = new Form1();
            newForm.Show(); Hide();

        }

        private  void поставщикToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 newForm = new Form2();
            newForm.Show();
            Hide();
        }

        private void продуктыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 newForm = new Form3();
            newForm.Show();
            Hide();
        }

        private void рецептToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 newForm = new Form4();
            newForm.Show();
            Hide();
        }

        private  void авторToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form7 newForm = new Form7();
            newForm.Show();
            Hide();
        }

        private void ингредиентыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form8 newForm = new Form8();
            newForm.Show();
            Hide();
        }

        private  async void группыПродуктовToolStripMenuItem_Click(object sender, EventArgs e)
        {
        
        }

        private async void способПриготовленияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form13 fm = new Form13();
            fm.Show();
            Hide();
        }

        private async void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private async void  button2_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text) && !string.IsNullOrWhiteSpace(textBox1.Text))
            {
                SqlCommand command = new SqlCommand("INSERT INTO [Продукты] (Наименование,Калорийность_Ккал) VALUES(@Наименование,@Калорийность_Ккал)", sqlconnect);
                command.Parameters.AddWithValue("Наименование", textBox1.Text);
                command.Parameters.AddWithValue("Калорийность_Ккал", textBox2.Text);



                await command.ExecuteNonQueryAsync();
            }
            else
            {
                MessageBox.Show("Поля не заполнены!Команда не выполнена!");
            }
        }

        private async void button1_Click(object sender, EventArgs e)
        {

          
            SqlDataReader sqlReader = null;
            SqlCommand comand = new SqlCommand("SELECT * FROM [Продукты]", sqlconnect);
            try
            {
                sqlReader = await comand.ExecuteReaderAsync();//считыв таблицу
                while (await sqlReader.ReadAsync())
                {
                 //   listBox1.Items.Add(Convert.ToString(sqlReader["id"]) + "   " + Convert.ToString(sqlReader["Наименование"]));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), ex.Message.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (sqlReader != null)
                    sqlReader.Close();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Приложение представляет из себя автоматизированную информационные систему технологий создания блюд." +
                     "С его помощю Вы сможите  удалять и добавлять данные в базу, производить поиск рецептов блюд,их авторов,выбирать рецепты из представленных категорий, искать блюда меньше заданной калорийности!");
        }

        private void Калорийность_Click(object sender, EventArgs e)
        {

        }

        private async void button3_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("DELETE FROM  [Продукты] WHERE [Наименование]=@Наименование OR [Калорийность_Ккал]=@Калорийность_Ккал ", sqlconnect);
            command.Parameters.AddWithValue("Наименование", textBox1.Text);
            command.Parameters.AddWithValue("Калорийность_Ккал", textBox2.Text);

            await command.ExecuteNonQueryAsync();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void прайслистПоставщикаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form11 newForm = new Form11();
            newForm.Show(); Hide();
        }

        private void рецептБлюдToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form12 newForm = new Form12();
            newForm.Show(); Hide();
        }

        private void списокБлюдМинимальнойКалорийностиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form10 newForm = new Form10();
            newForm.Show(); Hide();
        }
    }
}
