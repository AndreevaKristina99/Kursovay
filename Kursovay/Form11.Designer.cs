namespace Kursovay
{
    partial class Form11
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.главноеМенюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.менюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поставщикToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.продуктыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.рецептToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.авторToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ингредиентыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.групптыПродуктовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.способыПриготовленияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выборкаДанныхToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.прайслистПоставщикаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.рецептБлюдToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сптсокБлюдМинимальнойКалорийностиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поставщикBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet = new Kursovay.Database1DataSet();
            this.поставщикTableAdapter = new Kursovay.Database1DataSetTableAdapters.ПоставщикTableAdapter();
            this.Введите_имя_поставщика = new System.Windows.Forms.Label();
            this.Поиск = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.авторBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.авторTableAdapter = new Kursovay.Database1DataSetTableAdapters.АвторTableAdapter();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.поставщикBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.авторBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.менюToolStripMenuItem,
            this.выборкаДанныхToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(807, 29);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оПрограммеToolStripMenuItem,
            this.выходToolStripMenuItem,
            this.главноеМенюToolStripMenuItem});
            this.файлToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(59, 25);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(183, 26);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(183, 26);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
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
            this.групптыПродуктовToolStripMenuItem,
            this.способыПриготовленияToolStripMenuItem});
            this.менюToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.менюToolStripMenuItem.Name = "менюToolStripMenuItem";
            this.менюToolStripMenuItem.Size = new System.Drawing.Size(66, 25);
            this.менюToolStripMenuItem.Text = "Меню";
            // 
            // поставщикToolStripMenuItem
            // 
            this.поставщикToolStripMenuItem.Name = "поставщикToolStripMenuItem";
            this.поставщикToolStripMenuItem.Size = new System.Drawing.Size(256, 26);
            this.поставщикToolStripMenuItem.Text = "Поставщик";
            this.поставщикToolStripMenuItem.Click += new System.EventHandler(this.поставщикToolStripMenuItem_Click);
            // 
            // продуктыToolStripMenuItem
            // 
            this.продуктыToolStripMenuItem.Name = "продуктыToolStripMenuItem";
            this.продуктыToolStripMenuItem.Size = new System.Drawing.Size(256, 26);
            this.продуктыToolStripMenuItem.Text = "Продукты";
            this.продуктыToolStripMenuItem.Click += new System.EventHandler(this.продуктыToolStripMenuItem_Click);
            // 
            // рецептToolStripMenuItem
            // 
            this.рецептToolStripMenuItem.Name = "рецептToolStripMenuItem";
            this.рецептToolStripMenuItem.Size = new System.Drawing.Size(256, 26);
            this.рецептToolStripMenuItem.Text = "Рецепт";
            this.рецептToolStripMenuItem.Click += new System.EventHandler(this.рецептToolStripMenuItem_Click);
            // 
            // авторToolStripMenuItem
            // 
            this.авторToolStripMenuItem.Name = "авторToolStripMenuItem";
            this.авторToolStripMenuItem.Size = new System.Drawing.Size(256, 26);
            this.авторToolStripMenuItem.Text = "Автор";
            this.авторToolStripMenuItem.Click += new System.EventHandler(this.авторToolStripMenuItem_Click);
            // 
            // ингредиентыToolStripMenuItem
            // 
            this.ингредиентыToolStripMenuItem.Name = "ингредиентыToolStripMenuItem";
            this.ингредиентыToolStripMenuItem.Size = new System.Drawing.Size(256, 26);
            this.ингредиентыToolStripMenuItem.Text = "Ингредиенты";
            this.ингредиентыToolStripMenuItem.Click += new System.EventHandler(this.ингредиентыToolStripMenuItem_Click);
            // 
            // групптыПродуктовToolStripMenuItem
            // 
            this.групптыПродуктовToolStripMenuItem.Name = "групптыПродуктовToolStripMenuItem";
            this.групптыПродуктовToolStripMenuItem.Size = new System.Drawing.Size(256, 26);
            this.групптыПродуктовToolStripMenuItem.Text = "Группты продуктов";
            this.групптыПродуктовToolStripMenuItem.Click += new System.EventHandler(this.групптыПродуктовToolStripMenuItem_Click);
            // 
            // способыПриготовленияToolStripMenuItem
            // 
            this.способыПриготовленияToolStripMenuItem.Name = "способыПриготовленияToolStripMenuItem";
            this.способыПриготовленияToolStripMenuItem.Size = new System.Drawing.Size(256, 26);
            this.способыПриготовленияToolStripMenuItem.Text = "Способы приготовления";
            this.способыПриготовленияToolStripMenuItem.Click += new System.EventHandler(this.способыПриготовленияToolStripMenuItem_Click);
            // 
            // выборкаДанныхToolStripMenuItem
            // 
            this.выборкаДанныхToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.прайслистПоставщикаToolStripMenuItem,
            this.рецептБлюдToolStripMenuItem,
            this.сптсокБлюдМинимальнойКалорийностиToolStripMenuItem});
            this.выборкаДанныхToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.выборкаДанныхToolStripMenuItem.Name = "выборкаДанныхToolStripMenuItem";
            this.выборкаДанныхToolStripMenuItem.Size = new System.Drawing.Size(142, 25);
            this.выборкаДанныхToolStripMenuItem.Text = "Выборка данных";
            // 
            // прайслистПоставщикаToolStripMenuItem
            // 
            this.прайслистПоставщикаToolStripMenuItem.Name = "прайслистПоставщикаToolStripMenuItem";
            this.прайслистПоставщикаToolStripMenuItem.Size = new System.Drawing.Size(384, 26);
            this.прайслистПоставщикаToolStripMenuItem.Text = "Поиск блюда по автору";
            this.прайслистПоставщикаToolStripMenuItem.Click += new System.EventHandler(this.прайслистПоставщикаToolStripMenuItem_Click);
            // 
            // рецептБлюдToolStripMenuItem
            // 
            this.рецептБлюдToolStripMenuItem.Name = "рецептБлюдToolStripMenuItem";
            this.рецептБлюдToolStripMenuItem.Size = new System.Drawing.Size(384, 26);
            this.рецептБлюдToolStripMenuItem.Text = "Рецепт блюд";
            this.рецептБлюдToolStripMenuItem.Click += new System.EventHandler(this.рецептБлюдToolStripMenuItem_Click);
            // 
            // сптсокБлюдМинимальнойКалорийностиToolStripMenuItem
            // 
            this.сптсокБлюдМинимальнойКалорийностиToolStripMenuItem.Name = "сптсокБлюдМинимальнойКалорийностиToolStripMenuItem";
            this.сптсокБлюдМинимальнойКалорийностиToolStripMenuItem.Size = new System.Drawing.Size(384, 26);
            this.сптсокБлюдМинимальнойКалорийностиToolStripMenuItem.Text = "Список блюд минимальной калорийности";
            this.сптсокБлюдМинимальнойКалорийностиToolStripMenuItem.Click += new System.EventHandler(this.сптсокБлюдМинимальнойКалорийностиToolStripMenuItem_Click);
            // 
            // поставщикBindingSource
            // 
            this.поставщикBindingSource.DataMember = "Поставщик";
            this.поставщикBindingSource.DataSource = this.database1DataSet;
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // поставщикTableAdapter
            // 
            this.поставщикTableAdapter.ClearBeforeFill = true;
            // 
            // Введите_имя_поставщика
            // 
            this.Введите_имя_поставщика.AutoSize = true;
            this.Введите_имя_поставщика.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Введите_имя_поставщика.Location = new System.Drawing.Point(56, 42);
            this.Введите_имя_поставщика.Name = "Введите_имя_поставщика";
            this.Введите_имя_поставщика.Size = new System.Drawing.Size(213, 20);
            this.Введите_имя_поставщика.TabIndex = 2;
            this.Введите_имя_поставщика.Text = "Введите фамилию автора";
            // 
            // Поиск
            // 
            this.Поиск.Location = new System.Drawing.Point(563, 41);
            this.Поиск.Name = "Поиск";
            this.Поиск.Size = new System.Drawing.Size(75, 23);
            this.Поиск.TabIndex = 6;
            this.Поиск.Text = "Поиск";
            this.Поиск.UseVisualStyleBackColor = true;
            this.Поиск.Click += new System.EventHandler(this.Поиск_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(325, 44);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(155, 20);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 86);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Size = new System.Drawing.Size(682, 381);
            this.dataGridView1.TabIndex = 7;
            // 
            // авторBindingSource
            // 
            this.авторBindingSource.DataMember = "Автор";
            this.авторBindingSource.DataSource = this.database1DataSet;
            // 
            // авторTableAdapter
            // 
            this.авторTableAdapter.ClearBeforeFill = true;
            // 
            // Form11
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 528);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Поиск);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Введите_имя_поставщика);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form11";
            this.Text = "Прайс-лист";
            this.Load += new System.EventHandler(this.Form11_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.поставщикBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.авторBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem менюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выборкаДанныхToolStripMenuItem;
        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource поставщикBindingSource;
        private Database1DataSetTableAdapters.ПоставщикTableAdapter поставщикTableAdapter;
        private System.Windows.Forms.Label Введите_имя_поставщика;
        private System.Windows.Forms.Button Поиск;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem главноеМенюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поставщикToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem продуктыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem рецептToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem авторToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ингредиентыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem групптыПродуктовToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem способыПриготовленияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem прайслистПоставщикаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem рецептБлюдToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сптсокБлюдМинимальнойКалорийностиToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource авторBindingSource;
        private Database1DataSetTableAdapters.АвторTableAdapter авторTableAdapter;
    }
}