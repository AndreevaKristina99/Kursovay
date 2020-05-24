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
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\kandr\Source\Repos\Kursovay\Kursovay\Database1.mdf;Integrated Security=True";
        SqlConnection sqlconnect;

        private void Form11_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.Автор". При необходимости она может быть перемещена или удалена.
            this.авторTableAdapter.Fill(this.database1DataSet.Автор);


        }

        private void Поиск_Click(object sender, EventArgs e)
        {
            //string namePost = textBox1.Text;
            //string st = namePost.ToString();
 
            DataSet ds = new DataSet();
                sqlconnect = new SqlConnection(connectionString);
                SqlDataAdapter da = new SqlDataAdapter();

          //  DateTime DP = dateTimePicker1.Value;

          //  string formatdate = DP.Date.ToString("yyyy-MM-dd HH:mm:ss");


            //работает с датой//      
            //da.SelectCommand = new SqlCommand("SELECT  [Поставщик].Название,[Поставщик].Адрес, [Поставщик].Телефон,[Поставщик].Дата_поставки FROM [Поставщик] WHERE [Поставщик].Дата_поставки='"+ formatdate + "'", sqlconnect);



            //не работает с именем//  
              da.SelectCommand = new SqlCommand("SELECT  [Автор].Фамилия,[Автор].Имя, [Автор].Страна,[Автор].Год,[Рецепт].Название,[Рецепт].Описание FROM [Автор] inner join Рецепт ON (Автор.Код=Рецепт.Код_автора) WHERE [Автор].Фамилия= N'" + textBox1.Text.ToString() + "'", sqlconnect);


           // da.SelectCommand = new SqlCommand("SELECT  [Поставщик].Название,[Поставщик].Адрес, [Поставщик].Телефон,[Поставщик].Дата_поставки ,[Продукты].Наименование " +
            //    "FROM [Поставщик] inner join ([Поставщик].id=[Группы_продукта-Поставщик].id )inner join ([Группы_продукта-Поставщик].id=[Продукты].Код_руппы_товара) WHERE [Поставщик].Название= N'" + textBox1.Text.ToString() + "'", sqlconnect);


            sqlconnect.Open();
                da.Fill(ds, "Автор");
            da.Fill(ds, "Рецепт ");
            dataGridView1.DataSource = ds.Tables[0];


                da.Dispose();
                sqlconnect.Dispose();
                ds.Dispose();

            

           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

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

        private void групптыПродуктовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 newForm = new Form5();
            newForm.Show(); Hide();
        }
      
        private void способыПриготовленияToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void сптсокБлюдМинимальнойКалорийностиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form10 newForm = new Form10();
            newForm.Show(); Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
