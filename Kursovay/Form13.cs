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
    public partial class Form13 : Form
    {
        public Form13()
        {
            InitializeComponent();
        }
        SqlConnection sqlconnect;
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\kandr\Source\Repos\Kursovay\Kursovay\Database1.mdf;Integrated Security=True";
        private async void Form13_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.Способ_проготовления". При необходимости она может быть перемещена или удалена.
            this.способ_проготовленияTableAdapter.Fill(this.database1DataSet.Способ_проготовления);
            sqlconnect = new SqlConnection(connectionString);
            await sqlconnect.OpenAsync();
            SqlDataReader sqlReader = null;
            SqlCommand comand = new SqlCommand("SELECT * FROM [Способ_приготовления]", sqlconnect);

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text) && !string.IsNullOrWhiteSpace(textBox1.Text))
            {
                SqlCommand command = new SqlCommand("INSERT INTO [Способ_проготовления] (Название) VALUES(@Название)", sqlconnect);
                command.Parameters.AddWithValue("Название", textBox1.Text);

                await command.ExecuteNonQueryAsync();
            }
            else
            {
                MessageBox.Show("Поля не заполнены!Команда не выполнена!");
            }
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("DELETE FROM  [Способ_проготовления] WHERE [Название]=@Название ", sqlconnect);
            command.Parameters.AddWithValue("Название", textBox1.Text);


            await command.ExecuteNonQueryAsync();
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Приложение представляет из себя автоматизированную информационные систему технологий создания блюд." +
                  "С его помощю Вы сможите  удалять и добавлять данные в базу, производить поиск рецептов блюд,их авторов,выбирать рецепты из представленных категорий, искать блюда меньше заданной калорийности!");
        }

        private void поставщикToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 newForm = new Form2();
            newForm.Show(); Hide();
        }

        private void главноеМенюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 newForm = new Form1();
            newForm.Show(); Hide();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void продуктыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 newForm = new Form3();
            newForm.Show(); Hide();
        }

        private void рецептыToolStripMenuItem_Click(object sender, EventArgs e)
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
            Form13 newForm = new Form13();
            newForm.Show(); Hide();
        }

        private void выборкаДанныхToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void прайслистПоставщикаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form11 newForm = new Form11();
            newForm.Show(); Hide();
        }

        private void рецептыБлюдToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form12 newForm = new Form12();
            newForm.Show(); Hide();
        }

        private void списокБлюдСМинимальнойКалорийностьюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form10 newForm = new Form10();
            newForm.Show(); Hide();
        }
    }
}
