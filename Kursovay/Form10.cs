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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
          
        }
        
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\kandr\Source\Repos\Kursovay\Kursovay\Database1.mdf;Integrated Security=True";
        SqlConnection sqlconnect;
        private async void button1_Click(object sender, EventArgs e)
        {
         
            try
            {
             

                DataSet ds = new DataSet();
                // this.продуктыTableAdapter.Fill(this.database1DataSet1.Продукты);

                sqlconnect = new SqlConnection(connectionString);
                SqlDataAdapter da = new SqlDataAdapter();




                //    SqlCommand comand = new SqlCommand("SELECT  [database1DataSet1.Продукты].Наименование,[database1DataSet1.Продукты].Калорийность FROM [database1DataSet1.Продукты] WHERE [database1DataSet1.Продукты].Калорийность<" + kkal.ToString() + "", sqlconnect);
               da.SelectCommand = new SqlCommand("SELECT  [Продукты].Наименование,[Продукты].Калорийность_Ккал FROM [Продукты] WHERE [Продукты].Калорийность_Ккал <" + textBox1.Text.ToString() ,sqlconnect);


              
                    
                sqlconnect.Open();
                da.Fill(ds, "Продукты");
                dataGridView1.DataSource = ds.Tables[0];
               
              
                da.Dispose();
                sqlconnect.Dispose();
                ds.Dispose();

            }

            catch (FormatException)
            {
                MessageBox.Show("Не верный формат или не введено значение в поле!!");
            }
            }
    private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private async void Form10_Load(object sender, EventArgs e)
        {
       
          

        }

        private async void button2_Click(object sender, EventArgs e)
        {
            sqlconnect = new SqlConnection(connectionString);
            await sqlconnect.OpenAsync();
        
            SqlCommand comand = new SqlCommand("SELECT *FROM [Продукты],[Рецепт] WHERE [Продукты].Id=[Рецепт].Код_продукта", sqlconnect);
           SqlDataReader sqlReader = comand.ExecuteReader();

            List<string[]> data = new List<string[]>();
            try
            {
                sqlReader = await comand.ExecuteReaderAsync();//считыв таблицу
                while (await sqlReader.ReadAsync())
                {
          
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

        private void bindingNavigator1_RefreshItems(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
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

        private void группыПродуктовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 newForm = new Form5();
            newForm.Show(); Hide();
        }

        private void способПриготовленияToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void списокБлюдМинимальнойКалорийностиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form10 newForm = new Form10();
            newForm.Show(); Hide();
        }
    }
}
