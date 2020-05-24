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
    public partial class Form1 : Form
    {
        SqlConnection sqlconnect;
        public Form1()
        {
            InitializeComponent();
        }

        private void pRODUKTBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pRODUKTBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);

        }
        

        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\kandr\Source\Repos\Kursovay\Kursovay\Database1.mdf;Integrated Security=True";
        public async void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (sqlconnect != null && sqlconnect.State != ConnectionState.Closed)
                sqlconnect.Close();
            Close();


        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (sqlconnect != null && sqlconnect.State != ConnectionState.Closed)
                sqlconnect.Close();
        }

        private void менюToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private async void поставщикToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 newForm = new Form2();
            newForm.Show();

            Hide();


        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Приложение представляет из себя автоматизированную информационные систему технологий создания блюд." +
                "С его помощю Вы сможите  удалять и добавлять данные в базу, производить поиск рецептов блюд,их авторов,выбирать рецепты из представленных категорий, искать блюда меньше заданной калорийности!");
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

        private void ингредиентыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form8 newForm = new Form8();
            newForm.Show();
            Hide();
        }

        private void авторToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form7 newForm = new Form7();
            newForm.Show();
            Hide();
        }

        private void группаПродуктаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 newForm = new Form5();
            newForm.Show();
            Hide();
        }

        private void способПриготовленияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form13 fm = new Form13();
            fm.Show();
            Hide();
        }

        private void файлToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void прайслистToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form11 fm = new Form11();
            fm.Show();
            Hide();
        }

        private void списокБлюдМинимальнойКалорийностиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form10 fm = new Form10();
            fm.Show();
         
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           
        }

        private void рецептыБлюдToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form12 fm = new Form12();
            fm.Show();
            Hide();
        }

        private void главноеМенюToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
