namespace Kursovay
{
    partial class Form13
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.главноеМенюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.менюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поставщикToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.продуктыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.рецептыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.авторToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ингредиентыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.группыПродуктовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.способПриготовленияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выборкаДанныхToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.прайслистПоставщикаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.рецептыБлюдToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.списокБлюдСМинимальнойКалорийностьюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.названиеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.способпроготовленияBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet = new Kursovay.Database1DataSet();
            this.способ_проготовленияTableAdapter = new Kursovay.Database1DataSetTableAdapters.Способ_проготовленияTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.способпроготовленияBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.названиеDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.способпроготовленияBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(77, 84);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(346, 309);
            this.dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(531, 251);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(531, 309);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Удалить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(612, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Название";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(550, 178);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(216, 20);
            this.textBox1.TabIndex = 4;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.менюToolStripMenuItem,
            this.выборкаДанныхToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 33);
            this.menuStrip1.TabIndex = 5;
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
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(59, 29);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(183, 26);
            this.оПрограммеToolStripMenuItem.Text = "О программе ";
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
            this.рецептыToolStripMenuItem,
            this.авторToolStripMenuItem,
            this.ингредиентыToolStripMenuItem,
            this.группыПродуктовToolStripMenuItem,
            this.способПриготовленияToolStripMenuItem});
            this.менюToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.менюToolStripMenuItem.Name = "менюToolStripMenuItem";
            this.менюToolStripMenuItem.Size = new System.Drawing.Size(77, 29);
            this.менюToolStripMenuItem.Text = "Меню";
            // 
            // поставщикToolStripMenuItem
            // 
            this.поставщикToolStripMenuItem.Name = "поставщикToolStripMenuItem";
            this.поставщикToolStripMenuItem.Size = new System.Drawing.Size(286, 30);
            this.поставщикToolStripMenuItem.Text = "Поставщик";
            this.поставщикToolStripMenuItem.Click += new System.EventHandler(this.поставщикToolStripMenuItem_Click);
            // 
            // продуктыToolStripMenuItem
            // 
            this.продуктыToolStripMenuItem.Name = "продуктыToolStripMenuItem";
            this.продуктыToolStripMenuItem.Size = new System.Drawing.Size(286, 30);
            this.продуктыToolStripMenuItem.Text = "Продукты";
            this.продуктыToolStripMenuItem.Click += new System.EventHandler(this.продуктыToolStripMenuItem_Click);
            // 
            // рецептыToolStripMenuItem
            // 
            this.рецептыToolStripMenuItem.Name = "рецептыToolStripMenuItem";
            this.рецептыToolStripMenuItem.Size = new System.Drawing.Size(286, 30);
            this.рецептыToolStripMenuItem.Text = "Рецепты";
            this.рецептыToolStripMenuItem.Click += new System.EventHandler(this.рецептыToolStripMenuItem_Click);
            // 
            // авторToolStripMenuItem
            // 
            this.авторToolStripMenuItem.Name = "авторToolStripMenuItem";
            this.авторToolStripMenuItem.Size = new System.Drawing.Size(286, 30);
            this.авторToolStripMenuItem.Text = "Автор";
            this.авторToolStripMenuItem.Click += new System.EventHandler(this.авторToolStripMenuItem_Click);
            // 
            // ингредиентыToolStripMenuItem
            // 
            this.ингредиентыToolStripMenuItem.Name = "ингредиентыToolStripMenuItem";
            this.ингредиентыToolStripMenuItem.Size = new System.Drawing.Size(286, 30);
            this.ингредиентыToolStripMenuItem.Text = "Ингредиенты";
            this.ингредиентыToolStripMenuItem.Click += new System.EventHandler(this.ингредиентыToolStripMenuItem_Click);
            // 
            // группыПродуктовToolStripMenuItem
            // 
            this.группыПродуктовToolStripMenuItem.Name = "группыПродуктовToolStripMenuItem";
            this.группыПродуктовToolStripMenuItem.Size = new System.Drawing.Size(286, 30);
            this.группыПродуктовToolStripMenuItem.Text = "Группы продуктов";
            this.группыПродуктовToolStripMenuItem.Click += new System.EventHandler(this.группыПродуктовToolStripMenuItem_Click);
            // 
            // способПриготовленияToolStripMenuItem
            // 
            this.способПриготовленияToolStripMenuItem.Name = "способПриготовленияToolStripMenuItem";
            this.способПриготовленияToolStripMenuItem.Size = new System.Drawing.Size(286, 30);
            this.способПриготовленияToolStripMenuItem.Text = "Способ приготовления";
            this.способПриготовленияToolStripMenuItem.Click += new System.EventHandler(this.способПриготовленияToolStripMenuItem_Click);
            // 
            // выборкаДанныхToolStripMenuItem
            // 
            this.выборкаДанныхToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.прайслистПоставщикаToolStripMenuItem,
            this.рецептыБлюдToolStripMenuItem,
            this.списокБлюдСМинимальнойКалорийностьюToolStripMenuItem});
            this.выборкаДанныхToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.выборкаДанныхToolStripMenuItem.Name = "выборкаДанныхToolStripMenuItem";
            this.выборкаДанныхToolStripMenuItem.Size = new System.Drawing.Size(142, 29);
            this.выборкаДанныхToolStripMenuItem.Text = "Выборка данных";
            this.выборкаДанныхToolStripMenuItem.Click += new System.EventHandler(this.выборкаДанныхToolStripMenuItem_Click);
            // 
            // прайслистПоставщикаToolStripMenuItem
            // 
            this.прайслистПоставщикаToolStripMenuItem.Name = "прайслистПоставщикаToolStripMenuItem";
            this.прайслистПоставщикаToolStripMenuItem.Size = new System.Drawing.Size(407, 26);
            this.прайслистПоставщикаToolStripMenuItem.Text = "Поиск блюд по автору";
            this.прайслистПоставщикаToolStripMenuItem.Click += new System.EventHandler(this.прайслистПоставщикаToolStripMenuItem_Click);
            // 
            // рецептыБлюдToolStripMenuItem
            // 
            this.рецептыБлюдToolStripMenuItem.Name = "рецептыБлюдToolStripMenuItem";
            this.рецептыБлюдToolStripMenuItem.Size = new System.Drawing.Size(407, 26);
            this.рецептыБлюдToolStripMenuItem.Text = "Рецепты блюд";
            this.рецептыБлюдToolStripMenuItem.Click += new System.EventHandler(this.рецептыБлюдToolStripMenuItem_Click);
            // 
            // списокБлюдСМинимальнойКалорийностьюToolStripMenuItem
            // 
            this.списокБлюдСМинимальнойКалорийностьюToolStripMenuItem.Name = "списокБлюдСМинимальнойКалорийностьюToolStripMenuItem";
            this.списокБлюдСМинимальнойКалорийностьюToolStripMenuItem.Size = new System.Drawing.Size(407, 26);
            this.списокБлюдСМинимальнойКалорийностьюToolStripMenuItem.Text = "Список блюд с минимальной калорийностью";
            this.списокБлюдСМинимальнойКалорийностьюToolStripMenuItem.Click += new System.EventHandler(this.списокБлюдСМинимальнойКалорийностьюToolStripMenuItem_Click);
            // 
            // названиеDataGridViewTextBoxColumn
            // 
            this.названиеDataGridViewTextBoxColumn.DataPropertyName = "Название";
            this.названиеDataGridViewTextBoxColumn.HeaderText = "Название";
            this.названиеDataGridViewTextBoxColumn.Name = "названиеDataGridViewTextBoxColumn";
            this.названиеDataGridViewTextBoxColumn.Width = 180;
            // 
            // способпроготовленияBindingSource
            // 
            this.способпроготовленияBindingSource.DataMember = "Способ_проготовления";
            this.способпроготовленияBindingSource.DataSource = this.database1DataSet;
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // способ_проготовленияTableAdapter
            // 
            this.способ_проготовленияTableAdapter.ClearBeforeFill = true;
            // 
            // Form13
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form13";
            this.Text = "Способ приготовления";
            this.Load += new System.EventHandler(this.Form13_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.способпроготовленияBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource способпроготовленияBindingSource;
        private Database1DataSetTableAdapters.Способ_проготовленияTableAdapter способ_проготовленияTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem главноеМенюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem менюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выборкаДанныхToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поставщикToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem продуктыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem рецептыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem авторToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ингредиентыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem группыПродуктовToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem способПриготовленияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem прайслистПоставщикаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem рецептыБлюдToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem списокБлюдСМинимальнойКалорийностьюToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn названиеDataGridViewTextBoxColumn;
    }
}