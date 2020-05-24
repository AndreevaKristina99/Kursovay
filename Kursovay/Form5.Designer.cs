namespace Kursovay
{
    partial class Form5
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.главноеМенюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.менюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поставщикToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.продуктыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.рецептToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.авторToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ингредиентыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.группыПродуктовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.способПриготовленияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.менюБлюдToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.прайслистПоставщикаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.рецептБлюдToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.спискоБлюдМинимальнойКалорийностиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.группыпродуктаBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet = new Kursovay.Database1DataSet();
            this.группыпродуктаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button3 = new System.Windows.Forms.Button();
            this.группы_продуктаTableAdapter = new Kursovay.Database1DataSetTableAdapters.Группы_продуктаTableAdapter();
            this.наименованиеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.группыпродуктаBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.группыпродуктаBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.менюToolStripMenuItem,
            this.менюБлюдToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 29);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выходToolStripMenuItem,
            this.оПрограммеToolStripMenuItem,
            this.главноеМенюToolStripMenuItem});
            this.файлToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(59, 25);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(183, 26);
            this.выходToolStripMenuItem.Text = "Выход ";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(183, 26);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // главноеМенюToolStripMenuItem
            // 
            this.главноеМенюToolStripMenuItem.Name = "главноеМенюToolStripMenuItem";
            this.главноеМенюToolStripMenuItem.Size = new System.Drawing.Size(183, 26);
            this.главноеМенюToolStripMenuItem.Text = "Главное меню";
            this.главноеМенюToolStripMenuItem.Click += new System.EventHandler(this.главноеМенюToolStripMenuItem_Click);
            // 
            // менюToolStripMenuItem
            // 
            this.менюToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.поставщикToolStripMenuItem,
            this.продуктыToolStripMenuItem,
            this.рецептToolStripMenuItem,
            this.авторToolStripMenuItem,
            this.ингредиентыToolStripMenuItem,
            this.группыПродуктовToolStripMenuItem,
            this.способПриготовленияToolStripMenuItem});
            this.менюToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.менюToolStripMenuItem.Name = "менюToolStripMenuItem";
            this.менюToolStripMenuItem.Size = new System.Drawing.Size(66, 25);
            this.менюToolStripMenuItem.Text = "Меню";
            // 
            // поставщикToolStripMenuItem
            // 
            this.поставщикToolStripMenuItem.Name = "поставщикToolStripMenuItem";
            this.поставщикToolStripMenuItem.Size = new System.Drawing.Size(245, 26);
            this.поставщикToolStripMenuItem.Text = "Поставщик";
            this.поставщикToolStripMenuItem.Click += new System.EventHandler(this.поставщикToolStripMenuItem_Click);
            // 
            // продуктыToolStripMenuItem
            // 
            this.продуктыToolStripMenuItem.Name = "продуктыToolStripMenuItem";
            this.продуктыToolStripMenuItem.Size = new System.Drawing.Size(245, 26);
            this.продуктыToolStripMenuItem.Text = "Продукты";
            this.продуктыToolStripMenuItem.Click += new System.EventHandler(this.продуктыToolStripMenuItem_Click);
            // 
            // рецептToolStripMenuItem
            // 
            this.рецептToolStripMenuItem.Name = "рецептToolStripMenuItem";
            this.рецептToolStripMenuItem.Size = new System.Drawing.Size(245, 26);
            this.рецептToolStripMenuItem.Text = "Рецепт";
            this.рецептToolStripMenuItem.Click += new System.EventHandler(this.рецептToolStripMenuItem_Click);
            // 
            // авторToolStripMenuItem
            // 
            this.авторToolStripMenuItem.Name = "авторToolStripMenuItem";
            this.авторToolStripMenuItem.Size = new System.Drawing.Size(245, 26);
            this.авторToolStripMenuItem.Text = "Автор";
            this.авторToolStripMenuItem.Click += new System.EventHandler(this.авторToolStripMenuItem_Click);
            // 
            // ингредиентыToolStripMenuItem
            // 
            this.ингредиентыToolStripMenuItem.Name = "ингредиентыToolStripMenuItem";
            this.ингредиентыToolStripMenuItem.Size = new System.Drawing.Size(245, 26);
            this.ингредиентыToolStripMenuItem.Text = "Ингредиенты";
            this.ингредиентыToolStripMenuItem.Click += new System.EventHandler(this.ингредиентыToolStripMenuItem_Click);
            // 
            // группыПродуктовToolStripMenuItem
            // 
            this.группыПродуктовToolStripMenuItem.Name = "группыПродуктовToolStripMenuItem";
            this.группыПродуктовToolStripMenuItem.Size = new System.Drawing.Size(245, 26);
            this.группыПродуктовToolStripMenuItem.Text = "Группы продуктов";
            this.группыПродуктовToolStripMenuItem.Click += new System.EventHandler(this.группыПродуктовToolStripMenuItem_Click);
            // 
            // способПриготовленияToolStripMenuItem
            // 
            this.способПриготовленияToolStripMenuItem.Name = "способПриготовленияToolStripMenuItem";
            this.способПриготовленияToolStripMenuItem.Size = new System.Drawing.Size(245, 26);
            this.способПриготовленияToolStripMenuItem.Text = "Способ приготовления";
            this.способПриготовленияToolStripMenuItem.Click += new System.EventHandler(this.способПриготовленияToolStripMenuItem_Click);
            // 
            // менюБлюдToolStripMenuItem
            // 
            this.менюБлюдToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.прайслистПоставщикаToolStripMenuItem,
            this.рецептБлюдToolStripMenuItem,
            this.спискоБлюдМинимальнойКалорийностиToolStripMenuItem});
            this.менюБлюдToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.менюБлюдToolStripMenuItem.Name = "менюБлюдToolStripMenuItem";
            this.менюБлюдToolStripMenuItem.Size = new System.Drawing.Size(126, 25);
            this.менюБлюдToolStripMenuItem.Text = "Выбор данных";
            this.менюБлюдToolStripMenuItem.Click += new System.EventHandler(this.менюБлюдToolStripMenuItem_Click);
            // 
            // прайслистПоставщикаToolStripMenuItem
            // 
            this.прайслистПоставщикаToolStripMenuItem.Name = "прайслистПоставщикаToolStripMenuItem";
            this.прайслистПоставщикаToolStripMenuItem.Size = new System.Drawing.Size(392, 26);
            this.прайслистПоставщикаToolStripMenuItem.Text = "Поиск блюда по автору";
            this.прайслистПоставщикаToolStripMenuItem.Click += new System.EventHandler(this.прайслистПоставщикаToolStripMenuItem_Click);
            // 
            // рецептБлюдToolStripMenuItem
            // 
            this.рецептБлюдToolStripMenuItem.Name = "рецептБлюдToolStripMenuItem";
            this.рецептБлюдToolStripMenuItem.Size = new System.Drawing.Size(392, 26);
            this.рецептБлюдToolStripMenuItem.Text = "Рецепт блюд";
            // 
            // спискоБлюдМинимальнойКалорийностиToolStripMenuItem
            // 
            this.спискоБлюдМинимальнойКалорийностиToolStripMenuItem.Name = "спискоБлюдМинимальнойКалорийностиToolStripMenuItem";
            this.спискоБлюдМинимальнойКалорийностиToolStripMenuItem.Size = new System.Drawing.Size(392, 26);
            this.спискоБлюдМинимальнойКалорийностиToolStripMenuItem.Text = "Спискок блюд минимальной калорийности";
            this.спискоБлюдМинимальнойКалорийностиToolStripMenuItem.Click += new System.EventHandler(this.спискоБлюдМинимальнойКалорийностиToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(613, 175);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(532, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Наименование";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(688, 95);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 5;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.наименованиеDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.группыпродуктаBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(0, 77);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(417, 318);
            this.dataGridView1.TabIndex = 6;
            // 
            // группыпродуктаBindingSource1
            // 
            this.группыпродуктаBindingSource1.DataMember = "Группы_продукта";
            this.группыпродуктаBindingSource1.DataSource = this.database1DataSet;
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // группыпродуктаBindingSource
            // 
            this.группыпродуктаBindingSource.DataMember = "Группы_продукта";
            this.группыпродуктаBindingSource.DataSource = this.database1DataSet;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(713, 175);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 7;
            this.button3.Text = "Удалить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // группы_продуктаTableAdapter
            // 
            this.группы_продуктаTableAdapter.ClearBeforeFill = true;
            // 
            // наименованиеDataGridViewTextBoxColumn
            // 
            this.наименованиеDataGridViewTextBoxColumn.DataPropertyName = "Наименование";
            this.наименованиеDataGridViewTextBoxColumn.HeaderText = "Наименование";
            this.наименованиеDataGridViewTextBoxColumn.Name = "наименованиеDataGridViewTextBoxColumn";
            this.наименованиеDataGridViewTextBoxColumn.Width = 200;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form5";
            this.Text = "Группы продуктов";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.группыпродуктаBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.группыпродуктаBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem главноеМенюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem менюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поставщикToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem продуктыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem рецептToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem авторToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ингредиентыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem группыПродуктовToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem способПриготовленияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem менюБлюдToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem прайслистПоставщикаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem рецептБлюдToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem спискоБлюдМинимальнойКалорийностиToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource группыпродуктаBindingSource;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.BindingSource группыпродуктаBindingSource1;
        private Database1DataSetTableAdapters.Группы_продуктаTableAdapter группы_продуктаTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn наименованиеDataGridViewTextBoxColumn;
    }
}