using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kursovay
{
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
        }
        private string result = " ";

        private int current_row = 0;
        private int current_col = 0;
        private int tempRow1, tempCol1, tempRow2, tempCol2, count;

        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\kandr\Source\Repos\Kursovay\Kursovay\Database1.mdf;Integrated Security=True";
        SqlConnection sqlconnect;
        private void Form12_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.Рецепт". При необходимости она может быть перемещена или удалена.
            // this.рецептTableAdapter.Fill(this.database1DataSet.Рецепт);

        }

        private void тушеныеОвощиToolStripMenuItem_Click(object sender, EventArgs e)
        {

            DataSet ds = new DataSet();
            // this.продуктыTableAdapter.Fill(this.database1DataSet1.Продукты);
            dataGridView1.RowTemplate.MinimumHeight = 35;

            sqlconnect = new SqlConnection(connectionString);
            SqlDataAdapter da = new SqlDataAdapter();
            //    SqlCommand comand = new SqlCommand("SELECT  [database1DataSet1.Продукты].Наименование,[database1DataSet1.Продукты].Калорийность FROM [database1DataSet1.Продукты] WHERE [database1DataSet1.Продукты].Калорийность<" + kkal.ToString() + "", sqlconnect);
            da.SelectCommand = new SqlCommand("SELECT  [Рецепт].Номер,[Рецепт].Название,[Рецепт].Описание FROM [Рецепт] WHERE [Рецепт].Код_категории_рецепта='1'", sqlconnect);

            sqlconnect.Open();
            da.Fill(ds, "Рецепт");
            dataGridView1.DataSource = ds.Tables[0];
            da.Dispose();
            sqlconnect.Dispose();
            ds.Dispose();


        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void кашиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            dataGridView1.RowTemplate.MinimumHeight = 35;

            sqlconnect = new SqlConnection(connectionString);
            SqlDataAdapter da = new SqlDataAdapter();
            //    SqlCommand comand = new SqlCommand("SELECT  [database1DataSet1.Продукты].Наименование,[database1DataSet1.Продукты].Калорийность FROM [database1DataSet1.Продукты] WHERE [database1DataSet1.Продукты].Калорийность<" + kkal.ToString() + "", sqlconnect);
            da.SelectCommand = new SqlCommand("SELECT  [Рецепт].Номер,[Рецепт].Название,[Рецепт].Описание FROM [Рецепт] WHERE [Рецепт].Код_категории_рецепта='3'", sqlconnect);

            sqlconnect.Open();
            da.Fill(ds, "Рецепт");
            dataGridView1.DataSource = ds.Tables[0];
            da.Dispose();
            sqlconnect.Dispose();
            ds.Dispose();
        }

        private void сокиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            // this.продуктыTableAdapter.Fill(this.database1DataSet1.Продукты);
            dataGridView1.RowTemplate.MinimumHeight = 35;

            sqlconnect = new SqlConnection(connectionString);
            SqlDataAdapter da = new SqlDataAdapter();
            //    SqlCommand comand = new SqlCommand("SELECT  [database1DataSet1.Продукты].Наименование,[database1DataSet1.Продукты].Калорийность FROM [database1DataSet1.Продукты] WHERE [database1DataSet1.Продукты].Калорийность<" + kkal.ToString() + "", sqlconnect);
            da.SelectCommand = new SqlCommand("SELECT  [Рецепт].Номер,[Рецепт].Название,[Рецепт].Описание FROM [Рецепт] WHERE [Рецепт].Код_категории_рецепта='2'", sqlconnect);

            sqlconnect.Open();
            da.Fill(ds, "Рецепт");
            dataGridView1.DataSource = ds.Tables[0];
            da.Dispose();
            sqlconnect.Dispose();
            ds.Dispose();
        }

        private void завтракиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            // this.продуктыTableAdapter.Fill(this.database1DataSet1.Продукты);
            dataGridView1.RowTemplate.MinimumHeight = 35;

            sqlconnect = new SqlConnection(connectionString);
            SqlDataAdapter da = new SqlDataAdapter();
            //    SqlCommand comand = new SqlCommand("SELECT  [database1DataSet1.Продукты].Наименование,[database1DataSet1.Продукты].Калорийность FROM [database1DataSet1.Продукты] WHERE [database1DataSet1.Продукты].Калорийность<" + kkal.ToString() + "", sqlconnect);
            da.SelectCommand = new SqlCommand("SELECT  [Рецепт].Номер,[Рецепт].Название,[Рецепт].Описание FROM [Рецепт] WHERE [Рецепт].Код_категории_рецепта='4'", sqlconnect);

            sqlconnect.Open();
            da.Fill(ds, "Рецепт");
            dataGridView1.DataSource = ds.Tables[0];
            da.Dispose();
            sqlconnect.Dispose();
            ds.Dispose();
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
            Form13 fm = new Form13();
            fm.Show();
            Hide();
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Печать_Click(object sender, EventArgs e)
        {
            PrintDocument Document = new PrintDocument();
            Document.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage_1);
            PrintPreviewDialog dlg = new PrintPreviewDialog();
            dlg.Document = Document;
            dlg.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            
        }

        private void printDocument1_PrintPage_1(object sender, PrintPageEventArgs e)
        {
            tempRow1 = 0; tempRow2 = 0; tempCol1 = 0; count = 0;

            Graphics g = e.Graphics;
            count++;
            g.DrawString("стр. " + count.ToString(),
                            new Font("Tahoma", 9, FontStyle.Bold, GraphicsUnit.Point),
                            Brushes.Black, 350, 50);
            int x = 100;
            int y = 100;
            int cell_height = 0;
            current_col = tempCol1;
            tempCol2 = tempCol1;
            current_row = tempRow1;
            int colCount = dataGridView1.ColumnCount;
            int rowCount = dataGridView1.RowCount - 1;
            int width = dataGridView1[current_col, current_row].Size.Width;
            int height = dataGridView1[current_col, current_row].Size.Height;
            Rectangle cell_border;

            SolidBrush brush = new SolidBrush(Color.Black);
            StringFormat str = new StringFormat();
            str.Alignment = StringAlignment.Near;
            str.LineAlignment = StringAlignment.Center;
            str.Trimming = StringTrimming.EllipsisCharacter;
            cell_height = dataGridView1[current_col, current_row].Size.Height + 10;
            while (current_col < colCount)
            {
                /**/
                if (x > e.MarginBounds.Width)
                {
                    e.HasMorePages = true;
                    break;
                }/**/
                g.FillRectangle(Brushes.LightGray,
                            new Rectangle(x, y, dataGridView1.Columns[current_col].Width,
                                cell_height));
                g.DrawRectangle(Pens.Black,
                    x, y, dataGridView1.Columns[current_col].Width,
                    cell_height);
                g.DrawString(dataGridView1.Columns[current_col].HeaderText,
                    new Font("Tahoma", 9, FontStyle.Bold, GraphicsUnit.Point),
                    Brushes.Black,
                    new RectangleF(x, y, dataGridView1.Columns[current_col].Width,
                        cell_height), str);
                x += dataGridView1[current_col, current_row].Size.Width;
                current_col++;
            }

            y += cell_height; x = 100; current_col = tempCol1;
            while (current_row < rowCount)
            {
                if (y > e.MarginBounds.Height + 100)
                {
                    tempRow1 = tempRow2;
                    if (x < e.MarginBounds.Width)
                        tempCol1 = 0;
                    else
                        tempRow2 = current_row;
                    e.HasMorePages = true;
                    y = 100;
                    return;
                }
                x = 100;
                while (current_col < colCount)
                {
                    if (x > e.MarginBounds.Width)
                    {
                        tempCol1 = current_col;
                        e.HasMorePages = true;
                        break;
                    }
                    cell_height = dataGridView1[current_col, current_row].Size.Height + 10;
                    cell_border = new Rectangle(x, y, width, height);
                    g.DrawRectangle(Pens.Black, x, y,
                        dataGridView1.Columns[current_col].Width,
                        cell_height);
                    g.DrawString(dataGridView1.Rows[current_row].Cells[current_col].Value.ToString(),
                        dataGridView1.Font, Brushes.Black,
                        new RectangleF(x, y,
                            dataGridView1.Columns[current_col].Width,
                            cell_height),
                        str);
                    x += dataGridView1[current_col, current_row].Size.Width;
                    current_col++;
                }
                current_col = tempCol2;
                current_row++;
                y += cell_height;
            }
        }

        private void рецетпыToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void блюдаНаПраздникиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            sqlconnect = new SqlConnection(connectionString);
            SqlDataAdapter da = new SqlDataAdapter();
            //    SqlCommand comand = new SqlCommand("SELECT  [database1DataSet1.Продукты].Наименование,[database1DataSet1.Продукты].Калорийность FROM [database1DataSet1.Продукты] WHERE [database1DataSet1.Продукты].Калорийность<" + kkal.ToString() + "", sqlconnect);
            da.SelectCommand = new SqlCommand("SELECT  [Рецепт].Номер,[Рецепт].Название,[Рецепт].Описание FROM [Рецепт] WHERE [Рецепт].Код_категории_рецепта='5'", sqlconnect);

            sqlconnect.Open();
            da.Fill(ds, "Рецепт");
            dataGridView1.DataSource = ds.Tables[0];
            da.Dispose();
            sqlconnect.Dispose();
            ds.Dispose();
        }

        private void супыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            sqlconnect = new SqlConnection(connectionString);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = new SqlCommand("SELECT  [Рецепт].Номер,[Рецепт].Название,[Рецепт].Описание FROM [Рецепт] WHERE [Рецепт].Код_категории_рецепта='6'", sqlconnect);
            sqlconnect.Open();
            da.Fill(ds, "Рецепт");
            dataGridView1.DataSource = ds.Tables[0];
            da.Dispose();
            sqlconnect.Dispose();
            ds.Dispose();
        }

        private void диетическоеМенюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            sqlconnect = new SqlConnection(connectionString);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = new SqlCommand("SELECT  [Рецепт].Номер,[Рецепт].Название,[Рецепт].Описание FROM [Рецепт] WHERE [Рецепт].Код_категории_рецепта='7'", sqlconnect);

            sqlconnect.Open();
            da.Fill(ds, "Рецепт");
            dataGridView1.DataSource = ds.Tables[0];
            da.Dispose();
            sqlconnect.Dispose();
            ds.Dispose();
        }

        private void напиткиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            sqlconnect = new SqlConnection(connectionString);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = new SqlCommand("SELECT  [Рецепт].Номер,[Рецепт].Название,[Рецепт].Описание FROM [Рецепт] WHERE [Рецепт].Код_категории_рецепта='8'", sqlconnect);

            sqlconnect.Open();
            da.Fill(ds, "Рецепт");
            dataGridView1.DataSource = ds.Tables[0];
            da.Dispose();
            sqlconnect.Dispose();
            ds.Dispose();
        }
        private void мясныеБлюдаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            sqlconnect = new SqlConnection(connectionString);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = new SqlCommand("SELECT  [Рецепт].Номер,[Рецепт].Название,[Рецепт].Описание FROM [Рецепт] WHERE [Рецепт].Код_категории_рецепта='9'", sqlconnect);

            sqlconnect.Open();
            da.Fill(ds, "Рецепт");
            dataGridView1.DataSource = ds.Tables[0];
            da.Dispose();
            sqlconnect.Dispose();
            ds.Dispose();
        }

        private void десертыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            sqlconnect = new SqlConnection(connectionString);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = new SqlCommand("SELECT  [Рецепт].Номер,[Рецепт].Название,[Рецепт].Описание FROM [Рецепт] WHERE [Рецепт].Код_категории_рецепта='10'", sqlconnect);

            sqlconnect.Open();
            da.Fill(ds, "Рецепт");
            dataGridView1.DataSource = ds.Tables[0];
            da.Dispose();
            sqlconnect.Dispose();
            ds.Dispose();
        }
    }

}
