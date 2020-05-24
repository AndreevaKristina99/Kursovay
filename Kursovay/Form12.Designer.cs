namespace Kursovay
{
    partial class Form12
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
            this.группыПродуктовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.способПриготовленияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выборкаДанныхToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.прайслистПоставщикаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.рецептБлюдToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.списокБлюдМинимальнойКалорийностиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.номерDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.названиеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.описаниеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.рецептBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet = new Kursovay.Database1DataSet();
            this.рецептTableAdapter = new Kursovay.Database1DataSetTableAdapters.РецептTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.рецетпыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.тушеныеОвощиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.кашиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сокиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.завтракиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.блюдаНаПраздникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.супыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.диетическоеМенюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.напиткиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.мясныеБлюдаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.десертыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Печать = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.рецептBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            this.menuStrip2.SuspendLayout();
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
            this.menuStrip1.Size = new System.Drawing.Size(618, 29);
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
            // выборкаДанныхToolStripMenuItem
            // 
            this.выборкаДанныхToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.прайслистПоставщикаToolStripMenuItem,
            this.рецептБлюдToolStripMenuItem,
            this.списокБлюдМинимальнойКалорийностиToolStripMenuItem});
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
            // списокБлюдМинимальнойКалорийностиToolStripMenuItem
            // 
            this.списокБлюдМинимальнойКалорийностиToolStripMenuItem.Name = "списокБлюдМинимальнойКалорийностиToolStripMenuItem";
            this.списокБлюдМинимальнойКалорийностиToolStripMenuItem.Size = new System.Drawing.Size(384, 26);
            this.списокБлюдМинимальнойКалорийностиToolStripMenuItem.Text = "Список блюд минимальной калорийности";
            this.списокБлюдМинимальнойКалорийностиToolStripMenuItem.Click += new System.EventHandler(this.списокБлюдМинимальнойКалорийностиToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.номерDataGridViewTextBoxColumn,
            this.названиеDataGridViewTextBoxColumn,
            this.описаниеDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.рецептBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(13, 71);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Size = new System.Drawing.Size(615, 367);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // номерDataGridViewTextBoxColumn
            // 
            this.номерDataGridViewTextBoxColumn.DataPropertyName = "Номер";
            this.номерDataGridViewTextBoxColumn.Frozen = true;
            this.номерDataGridViewTextBoxColumn.HeaderText = "Номер";
            this.номерDataGridViewTextBoxColumn.Name = "номерDataGridViewTextBoxColumn";
            this.номерDataGridViewTextBoxColumn.Width = 50;
            // 
            // названиеDataGridViewTextBoxColumn
            // 
            this.названиеDataGridViewTextBoxColumn.DataPropertyName = "Название";
            this.названиеDataGridViewTextBoxColumn.Frozen = true;
            this.названиеDataGridViewTextBoxColumn.HeaderText = "Название";
            this.названиеDataGridViewTextBoxColumn.Name = "названиеDataGridViewTextBoxColumn";
            // 
            // описаниеDataGridViewTextBoxColumn
            // 
            this.описаниеDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.описаниеDataGridViewTextBoxColumn.DataPropertyName = "Описание";
            this.описаниеDataGridViewTextBoxColumn.Frozen = true;
            this.описаниеDataGridViewTextBoxColumn.HeaderText = "Описание";
            this.описаниеDataGridViewTextBoxColumn.Name = "описаниеDataGridViewTextBoxColumn";
            this.описаниеDataGridViewTextBoxColumn.ReadOnly = true;
            this.описаниеDataGridViewTextBoxColumn.Width = 420;
            // 
            // рецептBindingSource
            // 
            this.рецептBindingSource.DataMember = "Рецепт";
            this.рецептBindingSource.DataSource = this.database1DataSet;
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // рецептTableAdapter
            // 
            this.рецептTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(350, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Выберите категорию рецепта";
            // 
            // menuStrip2
            // 
            this.menuStrip2.Dock = System.Windows.Forms.DockStyle.Right;
            this.menuStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.рецетпыToolStripMenuItem,
            this.тушеныеОвощиToolStripMenuItem,
            this.кашиToolStripMenuItem,
            this.сокиToolStripMenuItem,
            this.завтракиToolStripMenuItem,
            this.блюдаНаПраздникиToolStripMenuItem,
            this.супыToolStripMenuItem,
            this.диетическоеМенюToolStripMenuItem,
            this.напиткиToolStripMenuItem,
            this.мясныеБлюдаToolStripMenuItem,
            this.десертыToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(618, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(152, 450);
            this.menuStrip2.TabIndex = 3;
            this.menuStrip2.Text = "menuStrip2";
            this.menuStrip2.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip2_ItemClicked);
            // 
            // рецетпыToolStripMenuItem
            // 
            this.рецетпыToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.рецетпыToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.рецетпыToolStripMenuItem.Name = "рецетпыToolStripMenuItem";
            this.рецетпыToolStripMenuItem.Size = new System.Drawing.Size(145, 25);
            this.рецетпыToolStripMenuItem.Text = "Рецепты";
            this.рецетпыToolStripMenuItem.Click += new System.EventHandler(this.рецетпыToolStripMenuItem_Click);
            // 
            // тушеныеОвощиToolStripMenuItem
            // 
            this.тушеныеОвощиToolStripMenuItem.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.тушеныеОвощиToolStripMenuItem.Name = "тушеныеОвощиToolStripMenuItem";
            this.тушеныеОвощиToolStripMenuItem.Size = new System.Drawing.Size(145, 30);
            this.тушеныеОвощиToolStripMenuItem.Text = "Тушеные овощи";
            this.тушеныеОвощиToolStripMenuItem.Click += new System.EventHandler(this.тушеныеОвощиToolStripMenuItem_Click);
            // 
            // кашиToolStripMenuItem
            // 
            this.кашиToolStripMenuItem.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.кашиToolStripMenuItem.Name = "кашиToolStripMenuItem";
            this.кашиToolStripMenuItem.Size = new System.Drawing.Size(145, 30);
            this.кашиToolStripMenuItem.Text = "Каши";
            this.кашиToolStripMenuItem.Click += new System.EventHandler(this.кашиToolStripMenuItem_Click);
            // 
            // сокиToolStripMenuItem
            // 
            this.сокиToolStripMenuItem.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.сокиToolStripMenuItem.Name = "сокиToolStripMenuItem";
            this.сокиToolStripMenuItem.Size = new System.Drawing.Size(145, 30);
            this.сокиToolStripMenuItem.Text = "Соки";
            this.сокиToolStripMenuItem.Click += new System.EventHandler(this.сокиToolStripMenuItem_Click);
            // 
            // завтракиToolStripMenuItem
            // 
            this.завтракиToolStripMenuItem.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.завтракиToolStripMenuItem.Name = "завтракиToolStripMenuItem";
            this.завтракиToolStripMenuItem.Size = new System.Drawing.Size(145, 30);
            this.завтракиToolStripMenuItem.Text = "Завтраки";
            this.завтракиToolStripMenuItem.Click += new System.EventHandler(this.завтракиToolStripMenuItem_Click);
            // 
            // блюдаНаПраздникиToolStripMenuItem
            // 
            this.блюдаНаПраздникиToolStripMenuItem.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.блюдаНаПраздникиToolStripMenuItem.Name = "блюдаНаПраздникиToolStripMenuItem";
            this.блюдаНаПраздникиToolStripMenuItem.Size = new System.Drawing.Size(145, 25);
            this.блюдаНаПраздникиToolStripMenuItem.Text = "Блюда на праздники";
            this.блюдаНаПраздникиToolStripMenuItem.Click += new System.EventHandler(this.блюдаНаПраздникиToolStripMenuItem_Click);
            // 
            // супыToolStripMenuItem
            // 
            this.супыToolStripMenuItem.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.супыToolStripMenuItem.Name = "супыToolStripMenuItem";
            this.супыToolStripMenuItem.Size = new System.Drawing.Size(145, 30);
            this.супыToolStripMenuItem.Text = "Супы";
            this.супыToolStripMenuItem.Click += new System.EventHandler(this.супыToolStripMenuItem_Click);
            // 
            // диетическоеМенюToolStripMenuItem
            // 
            this.диетическоеМенюToolStripMenuItem.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.диетическоеМенюToolStripMenuItem.Name = "диетическоеМенюToolStripMenuItem";
            this.диетическоеМенюToolStripMenuItem.Size = new System.Drawing.Size(145, 25);
            this.диетическоеМенюToolStripMenuItem.Text = "Диетическое меню";
            this.диетическоеМенюToolStripMenuItem.Click += new System.EventHandler(this.диетическоеМенюToolStripMenuItem_Click);
            // 
            // напиткиToolStripMenuItem
            // 
            this.напиткиToolStripMenuItem.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.напиткиToolStripMenuItem.Name = "напиткиToolStripMenuItem";
            this.напиткиToolStripMenuItem.Size = new System.Drawing.Size(145, 30);
            this.напиткиToolStripMenuItem.Text = "Напитки";
            this.напиткиToolStripMenuItem.Click += new System.EventHandler(this.напиткиToolStripMenuItem_Click);
            // 
            // мясныеБлюдаToolStripMenuItem
            // 
            this.мясныеБлюдаToolStripMenuItem.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.мясныеБлюдаToolStripMenuItem.Name = "мясныеБлюдаToolStripMenuItem";
            this.мясныеБлюдаToolStripMenuItem.Size = new System.Drawing.Size(145, 30);
            this.мясныеБлюдаToolStripMenuItem.Text = "Мясные блюда";
            this.мясныеБлюдаToolStripMenuItem.Click += new System.EventHandler(this.мясныеБлюдаToolStripMenuItem_Click);
            // 
            // десертыToolStripMenuItem
            // 
            this.десертыToolStripMenuItem.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.десертыToolStripMenuItem.Name = "десертыToolStripMenuItem";
            this.десертыToolStripMenuItem.Size = new System.Drawing.Size(145, 30);
            this.десертыToolStripMenuItem.Text = "Десерты";
            this.десертыToolStripMenuItem.Click += new System.EventHandler(this.десертыToolStripMenuItem_Click);
            // 
            // Печать
            // 
            this.Печать.Location = new System.Drawing.Point(658, 403);
            this.Печать.Name = "Печать";
            this.Печать.Size = new System.Drawing.Size(75, 23);
            this.Печать.TabIndex = 4;
            this.Печать.Text = "Печать";
            this.Печать.UseVisualStyleBackColor = true;
            this.Печать.Click += new System.EventHandler(this.Печать_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage_1);
            // 
            // Form12
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Печать);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form12";
            this.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.Text = "Поиск рецептов";
            this.Load += new System.EventHandler(this.Form12_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.рецептBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem главноеМенюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem менюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поставщикToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem продуктыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem рецептToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem авторToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ингредиентыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem группыПродуктовToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem способПриготовленияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выборкаДанныхToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem прайслистПоставщикаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem рецептБлюдToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem списокБлюдМинимальнойКалорийностиToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource рецептBindingSource;
        private Database1DataSetTableAdapters.РецептTableAdapter рецептTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem рецетпыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem тушеныеОвощиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem кашиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сокиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem завтракиToolStripMenuItem;
        private System.Windows.Forms.Button Печать;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.DataGridViewTextBoxColumn номерDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn названиеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn описаниеDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStripMenuItem блюдаНаПраздникиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem супыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem диетическоеМенюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem напиткиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem мясныеБлюдаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem десертыToolStripMenuItem;
    }
}