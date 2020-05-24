namespace Kursovay
{
    partial class Form3
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
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
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
            this.менюДанныхToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.прайслистПоставщикаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.рецептыБлюдToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.списокБлюдМинимальнойКалорийностиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Калорийность = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.продуктыBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet = new Kursovay.Database1DataSet();
            this.продуктыBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.продуктыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.продуктыTableAdapter = new Kursovay.Database1DataSetTableAdapters.ПродуктыTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.продуктыBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.наименованиеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.калорийностьКкалDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.продуктыBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.продуктыBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.продуктыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.продуктыBindingSource3)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(466, 220);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Добавить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(590, 82);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(195, 29);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(462, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Наименование";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.менюToolStripMenuItem,
            this.менюДанныхToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 29);
            this.menuStrip1.TabIndex = 8;
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
            this.выходToolStripMenuItem.Text = "Выход";
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
            // менюДанныхToolStripMenuItem
            // 
            this.менюДанныхToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.прайслистПоставщикаToolStripMenuItem,
            this.рецептыБлюдToolStripMenuItem,
            this.списокБлюдМинимальнойКалорийностиToolStripMenuItem});
            this.менюДанныхToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.менюДанныхToolStripMenuItem.Name = "менюДанныхToolStripMenuItem";
            this.менюДанныхToolStripMenuItem.Size = new System.Drawing.Size(123, 25);
            this.менюДанныхToolStripMenuItem.Text = "Меню данных";
            // 
            // прайслистПоставщикаToolStripMenuItem
            // 
            this.прайслистПоставщикаToolStripMenuItem.Name = "прайслистПоставщикаToolStripMenuItem";
            this.прайслистПоставщикаToolStripMenuItem.Size = new System.Drawing.Size(384, 26);
            this.прайслистПоставщикаToolStripMenuItem.Text = "Поиск блюда по автору";
            this.прайслистПоставщикаToolStripMenuItem.Click += new System.EventHandler(this.прайслистПоставщикаToolStripMenuItem_Click);
            // 
            // рецептыБлюдToolStripMenuItem
            // 
            this.рецептыБлюдToolStripMenuItem.Name = "рецептыБлюдToolStripMenuItem";
            this.рецептыБлюдToolStripMenuItem.Size = new System.Drawing.Size(384, 26);
            this.рецептыБлюдToolStripMenuItem.Text = "Рецепты блюд";
            // 
            // списокБлюдМинимальнойКалорийностиToolStripMenuItem
            // 
            this.списокБлюдМинимальнойКалорийностиToolStripMenuItem.Name = "списокБлюдМинимальнойКалорийностиToolStripMenuItem";
            this.списокБлюдМинимальнойКалорийностиToolStripMenuItem.Size = new System.Drawing.Size(384, 26);
            this.списокБлюдМинимальнойКалорийностиToolStripMenuItem.Text = "Список блюд минимальной калорийности";
            // 
            // Калорийность
            // 
            this.Калорийность.AutoSize = true;
            this.Калорийность.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Калорийность.Location = new System.Drawing.Point(462, 131);
            this.Калорийность.Name = "Калорийность";
            this.Калорийность.Size = new System.Drawing.Size(118, 20);
            this.Калорийность.TabIndex = 10;
            this.Калорийность.Text = "Калорийность";
            this.Калорийность.Click += new System.EventHandler(this.Калорийность_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(590, 130);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(198, 30);
            this.textBox2.TabIndex = 11;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(590, 220);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 12;
            this.button3.Text = "Удалить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // продуктыBindingSource2
            // 
            this.продуктыBindingSource2.DataMember = "Продукты";
            this.продуктыBindingSource2.DataSource = this.database1DataSet;
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // продуктыBindingSource1
            // 
            this.продуктыBindingSource1.DataMember = "Продукты";
            this.продуктыBindingSource1.DataSource = this.database1DataSet;
            // 
            // продуктыBindingSource
            // 
            this.продуктыBindingSource.DataMember = "Продукты";
            this.продуктыBindingSource.DataSource = this.database1DataSet;
            // 
            // продуктыTableAdapter
            // 
            this.продуктыTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.наименованиеDataGridViewTextBoxColumn,
            this.калорийностьКкалDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.продуктыBindingSource3;
            this.dataGridView1.Location = new System.Drawing.Point(24, 54);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(412, 355);
            this.dataGridView1.TabIndex = 13;
            // 
            // продуктыBindingSource3
            // 
            this.продуктыBindingSource3.DataMember = "Продукты";
            this.продуктыBindingSource3.DataSource = this.database1DataSet;
            // 
            // наименованиеDataGridViewTextBoxColumn
            // 
            this.наименованиеDataGridViewTextBoxColumn.DataPropertyName = "Наименование";
            this.наименованиеDataGridViewTextBoxColumn.HeaderText = "Наименование";
            this.наименованиеDataGridViewTextBoxColumn.Name = "наименованиеDataGridViewTextBoxColumn";
            // 
            // калорийностьКкалDataGridViewTextBoxColumn
            // 
            this.калорийностьКкалDataGridViewTextBoxColumn.DataPropertyName = "Калорийность_Ккал";
            this.калорийностьКкалDataGridViewTextBoxColumn.HeaderText = "Калорийность_Ккал";
            this.калорийностьКкалDataGridViewTextBoxColumn.Name = "калорийностьКкалDataGridViewTextBoxColumn";
            this.калорийностьКкалDataGridViewTextBoxColumn.Width = 150;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.Калорийность);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form3";
            this.Text = "Продукты";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.продуктыBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.продуктыBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.продуктыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.продуктыBindingSource3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
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
        private System.Windows.Forms.ToolStripMenuItem менюДанныхToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem прайслистПоставщикаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem рецептыБлюдToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem списокБлюдМинимальнойКалорийностиToolStripMenuItem;
        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource продуктыBindingSource;
        private System.Windows.Forms.Label Калорийность;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.BindingSource продуктыBindingSource1;
        private Database1DataSetTableAdapters.ПродуктыTableAdapter продуктыTableAdapter;
        private System.Windows.Forms.BindingSource продуктыBindingSource2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource продуктыBindingSource3;
        private System.Windows.Forms.DataGridViewTextBoxColumn наименованиеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn калорийностьКкалDataGridViewTextBoxColumn;
    }
}