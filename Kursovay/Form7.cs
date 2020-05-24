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

namespace Kursovay
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }
        SqlConnection sqlconnect;
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\kandr\Source\Repos\Kursovay\Kursovay\Database1.mdf;Integrated Security=True";
        private void главноеМенюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 newForm = new Form1();
            newForm.Show(); Hide();
        }

        private void менюToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void способПриготовленияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form13 fm = new Form13();
            fm.Show();
            Hide();
        }

        private void группыПродуктовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 newForm = new Form5();
            newForm.Show();
            Hide();

        }

        private void ингредиентыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form8 newForm = new Form8();
            newForm.Show(); Hide();
        }

        private void авторToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form7 newForm = new Form7();
            newForm.Show(); Hide();
        }

        private void рецептыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 newForm = new Form4();
            newForm.Show(); Hide();
        }

        private void продуктыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 newForm = new Form3();
            newForm.Show(); Hide();
        }

        private void поставщикToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 newForm = new Form2();
            newForm.Show(); Hide();
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
                SqlCommand command = new SqlCommand("INSERT INTO [Автор] (Фамилия, Имя,Страна, Год) VALUES(@Фамилия,@Имя,@Страна,@Год)", sqlconnect);
                command.Parameters.AddWithValue("Фамилия", textBox1.Text);
                command.Parameters.AddWithValue("Имя", textBox2.Text);
                command.Parameters.AddWithValue("Страна", textBox3.Text);
                command.Parameters.AddWithValue("Год", textBox4.Text);
                await command.ExecuteNonQueryAsync();
            }
            else
            {
                MessageBox.Show("Поля не заполнены!Команда не выполнена!");
            }
        }

        private async void button2_Click(object sender, EventArgs e)
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

        private async void Form7_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.Группы_продукта". При необходимости она может быть перемещена или удалена.
            this.авторTableAdapter.Fill(this.database1DataSet.Автор);

            //  this.группы_продуктаTableAdapter.Fill(this.database1DataSet.Группы_продукта);
            sqlconnect = new SqlConnection(connectionString);
            await sqlconnect.OpenAsync();
            SqlDataReader sqlReader = null;
            SqlCommand comand = new SqlCommand("SELECT * FROM [Автор]", sqlconnect);
        }

        private async void Удалить_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("DELETE FROM  [Автор] WHERE [Фамилия]=@Фамилия OR [Имя]=@Имя OR [Страна]=@Страна OR [Год]=@Год", sqlconnect);
            command.Parameters.AddWithValue("Фамилия", textBox1.Text);
            command.Parameters.AddWithValue("Имя", textBox2.Text);
            command.Parameters.AddWithValue("Страна", textBox3.Text);
            command.Parameters.AddWithValue("Год", textBox3.Text);

            await command.ExecuteNonQueryAsync();
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
