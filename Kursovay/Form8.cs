using Kursovay.Database1DataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kursovay
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.AllowUserToAddRows = false;
        }
        SqlConnection sqlconnect;
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\kandr\Source\Repos\Kursovay\Kursovay\Database1.mdf;Integrated Security=True";
        private void главноеМенюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 newForm = new Form1();
            newForm.Show(); Hide();
        }

        private void поставщикToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 newForm = new Form2();
            newForm.Show(); Hide();
        }

        private void продуктыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 newForm = new Form3();
            newForm.Show(); Hide();
        }

        private void рецептToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 newForm = new Form4();
            newForm.Show(); Hide();
        }

        private void авторToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form7 newForm = new Form7();
            newForm.Show(); Hide();
        }

        private void ингредиентыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form8 newForm = new Form8();
            newForm.Show(); Hide();
        }

        private void группыПродуктовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 newForm = new Form5();
            newForm.Show(); Hide();
        }

        private void способПриготовленияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form13 fm = new Form13();
            fm.Show();
            Hide();
        }

       private async void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(textBox1.Text) && !string.IsNullOrWhiteSpace(textBox1.Text) &&
                !string.IsNullOrEmpty(textBox2.Text) && !string.IsNullOrWhiteSpace(textBox2.Text) &&
                !string.IsNullOrEmpty(textBox3.Text) && !string.IsNullOrWhiteSpace(textBox3.Text))
            {
                SqlCommand command = new SqlCommand("INSERT INTO [Ингредиенты] (Название,Количество_грамм_на_1кг_продукта,Калорийность_на_1кг_грамм_продукта,Цена_руб)VALUES(@Название,@Количество_грамм_на_1кг_продукта,@Калорийность_на_1кг_грамм_продукта,@Цена_руб)", sqlconnect);
                command.Parameters.AddWithValue("Название", textBox1.Text);
                command.Parameters.AddWithValue("Количество_грамм_на_1кг_продукта", textBox2.Text);
                command.Parameters.AddWithValue("Калорийность_на_1кг_грамм_продукта", textBox3.Text);
                command.Parameters.AddWithValue("Цена_руб", textBox4.Text);
          
                await command.ExecuteNonQueryAsync();
            }
            else
            {
                MessageBox.Show("Поля не заполнены!Команда не выполнена!");
            }
        }

        private async void button2_Click(object sender, EventArgs e)//обновление
        {
           
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
            }


            SqlCommand comand = new SqlCommand("SELECT * FROM [Ингредиенты]", sqlconnect);


        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Приложение представляет из себя автоматизированную информационные систему технологий создания блюд." +
                           "С его помощю Вы сможите  удалять и добавлять данные в базу, производить поиск рецептов блюд,их авторов,выбирать рецепты из представленных категорий, искать блюда меньше заданной калорийности!");
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private async void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
       
             }

        private void dataGridView1_CellContentClick_1(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
           
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.Продукты". При необходимости она может быть перемещена или удалена.
            this.продуктыTableAdapter.Fill(this.database1DataSet.Продукты);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.Ингредиенты". При необходимости она может быть перемещена или удалена.
            this.ингредиентыTableAdapter.Fill(this.database1DataSet.Ингредиенты);
            this.ингредиентыTableAdapter.Fill(this.database1DataSet.Ингредиенты);
            sqlconnect = new SqlConnection(connectionString);
            await sqlconnect.OpenAsync();
            SqlDataReader sqlReader = null;
            SqlCommand comand = new SqlCommand("SELECT * FROM [Ингредиенты]", sqlconnect);
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private async void button3_Click_1(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text) || !string.IsNullOrWhiteSpace(textBox1.Text) ||
               !string.IsNullOrEmpty(textBox2.Text) || !string.IsNullOrWhiteSpace(textBox2.Text) ||
               !string.IsNullOrEmpty(textBox3.Text) || !string.IsNullOrWhiteSpace(textBox3.Text))
            {
                SqlCommand comand = new SqlCommand("DELETE FROM[Ингредиенты] WHERE[Название]=@Название  OR[Количество_грамм_на_1кг_продукта]=@Количество_грамм_на_1кг_продукта OR[Калорийность_на_1кг_грамм_продукта]=@Калорийность_на_1кг_грамм_продукта ", sqlconnect);
                comand.Parameters.AddWithValue("Название", textBox1.Text);
                comand.Parameters.AddWithValue("Количество_грамм_на_1кг_продукта", textBox2.Text);
                comand.Parameters.AddWithValue("Калорийность_на_1кг_грамм_продукта", textBox3.Text);
                comand.Parameters.AddWithValue("Цена_руб", textBox4.Text);
                await comand.ExecuteNonQueryAsync();
            }
            else
            {
                MessageBox.Show("Ошибка!!");
            }
            }

        private void ингредиентыBindingSource_CurrentChanged(object sender, EventArgs e)
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

        private void dataGridView1_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
    }

