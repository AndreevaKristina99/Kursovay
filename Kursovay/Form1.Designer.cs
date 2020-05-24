namespace Kursovay
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.database1DataSet = new Kursovay.Database1DataSet();
            this.pRODUKTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pRODUKTTableAdapter = new Kursovay.Database1DataSetTableAdapters.PRODUKTTableAdapter();
            this.tableAdapterManager = new Kursovay.Database1DataSetTableAdapters.TableAdapterManager();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.главноеМенюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.менюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.продуктыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.рецептToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.авторToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ингредиентыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.группаПродуктаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.способПриготовленияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выборДанныхToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.прайслистToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.рецептыБлюдToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.списокБлюдМинимальнойКалорийностиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUKTBindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pRODUKTBindingSource
            // 
            this.pRODUKTBindingSource.DataMember = "PRODUKT";
            this.pRODUKTBindingSource.DataSource = this.database1DataSet;
            // 
            // pRODUKTTableAdapter
            // 
            this.pRODUKTTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.PRODUKTTableAdapter = this.pRODUKTTableAdapter;
            this.tableAdapterManager.UpdateOrder = Kursovay.Database1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.АвторTableAdapter = null;
            this.tableAdapterManager.Группы_продукта_ПоставщикTableAdapter = null;
            this.tableAdapterManager.Группы_продуктаTableAdapter = null;
            this.tableAdapterManager.Ингредиенты_РецептTableAdapter = null;
            this.tableAdapterManager.ИнгредиентыTableAdapter = null;
            this.tableAdapterManager.Категория_рецептаTableAdapter = null;
            this.tableAdapterManager.ПоставщикTableAdapter = null;
            this.tableAdapterManager.ПродуктыTableAdapter = null;
            this.tableAdapterManager.РецептTableAdapter = null;
            this.tableAdapterManager.Способ_проготовленияTableAdapter = null;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.менюToolStripMenuItem,
            this.выборДанныхToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 31);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выходToolStripMenuItem,
            this.оПрограммеToolStripMenuItem,
            this.главноеМенюToolStripMenuItem});
            this.файлToolStripMenuItem.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(63, 27);
            this.файлToolStripMenuItem.Text = "Файл";
            this.файлToolStripMenuItem.Click += new System.EventHandler(this.файлToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(191, 28);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(191, 28);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // главноеМенюToolStripMenuItem
            // 
            this.главноеМенюToolStripMenuItem.Name = "главноеМенюToolStripMenuItem";
            this.главноеМенюToolStripMenuItem.Size = new System.Drawing.Size(191, 28);
            this.главноеМенюToolStripMenuItem.Text = "Главное меню";
            this.главноеМенюToolStripMenuItem.Click += new System.EventHandler(this.главноеМенюToolStripMenuItem_Click);
            // 
            // менюToolStripMenuItem
            // 
            this.менюToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.продуктыToolStripMenuItem,
            this.рецептToolStripMenuItem,
            this.авторToolStripMenuItem,
            this.ингредиентыToolStripMenuItem,
            this.группаПродуктаToolStripMenuItem,
            this.способПриготовленияToolStripMenuItem});
            this.менюToolStripMenuItem.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.менюToolStripMenuItem.Name = "менюToolStripMenuItem";
            this.менюToolStripMenuItem.Size = new System.Drawing.Size(67, 27);
            this.менюToolStripMenuItem.Text = "Меню";
            this.менюToolStripMenuItem.Click += new System.EventHandler(this.менюToolStripMenuItem_Click);
            // 
            // продуктыToolStripMenuItem
            // 
            this.продуктыToolStripMenuItem.Name = "продуктыToolStripMenuItem";
            this.продуктыToolStripMenuItem.Size = new System.Drawing.Size(260, 28);
            this.продуктыToolStripMenuItem.Text = "Продукты";
            this.продуктыToolStripMenuItem.Click += new System.EventHandler(this.продуктыToolStripMenuItem_Click);
            // 
            // рецептToolStripMenuItem
            // 
            this.рецептToolStripMenuItem.Name = "рецептToolStripMenuItem";
            this.рецептToolStripMenuItem.Size = new System.Drawing.Size(260, 28);
            this.рецептToolStripMenuItem.Text = "Рецепт";
            this.рецептToolStripMenuItem.Click += new System.EventHandler(this.рецептToolStripMenuItem_Click);
            // 
            // авторToolStripMenuItem
            // 
            this.авторToolStripMenuItem.Name = "авторToolStripMenuItem";
            this.авторToolStripMenuItem.Size = new System.Drawing.Size(260, 28);
            this.авторToolStripMenuItem.Text = "Автор";
            this.авторToolStripMenuItem.Click += new System.EventHandler(this.авторToolStripMenuItem_Click);
            // 
            // ингредиентыToolStripMenuItem
            // 
            this.ингредиентыToolStripMenuItem.Name = "ингредиентыToolStripMenuItem";
            this.ингредиентыToolStripMenuItem.Size = new System.Drawing.Size(260, 28);
            this.ингредиентыToolStripMenuItem.Text = "Ингредиенты";
            this.ингредиентыToolStripMenuItem.Click += new System.EventHandler(this.ингредиентыToolStripMenuItem_Click);
            // 
            // группаПродуктаToolStripMenuItem
            // 
            this.группаПродуктаToolStripMenuItem.Name = "группаПродуктаToolStripMenuItem";
            this.группаПродуктаToolStripMenuItem.Size = new System.Drawing.Size(260, 28);
            this.группаПродуктаToolStripMenuItem.Text = "Группа продукта";
            this.группаПродуктаToolStripMenuItem.Click += new System.EventHandler(this.группаПродуктаToolStripMenuItem_Click);
            // 
            // способПриготовленияToolStripMenuItem
            // 
            this.способПриготовленияToolStripMenuItem.Name = "способПриготовленияToolStripMenuItem";
            this.способПриготовленияToolStripMenuItem.Size = new System.Drawing.Size(260, 28);
            this.способПриготовленияToolStripMenuItem.Text = "Способ приготовления";
            this.способПриготовленияToolStripMenuItem.Click += new System.EventHandler(this.способПриготовленияToolStripMenuItem_Click);
            // 
            // выборДанныхToolStripMenuItem
            // 
            this.выборДанныхToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.прайслистToolStripMenuItem,
            this.рецептыБлюдToolStripMenuItem,
            this.списокБлюдМинимальнойКалорийностиToolStripMenuItem});
            this.выборДанныхToolStripMenuItem.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.выборДанныхToolStripMenuItem.Name = "выборДанныхToolStripMenuItem";
            this.выборДанныхToolStripMenuItem.Size = new System.Drawing.Size(138, 27);
            this.выборДанныхToolStripMenuItem.Text = "Выбор данных";
            // 
            // прайслистToolStripMenuItem
            // 
            this.прайслистToolStripMenuItem.Name = "прайслистToolStripMenuItem";
            this.прайслистToolStripMenuItem.Size = new System.Drawing.Size(415, 28);
            this.прайслистToolStripMenuItem.Text = "Поиск блюд по автору";
            this.прайслистToolStripMenuItem.Click += new System.EventHandler(this.прайслистToolStripMenuItem_Click);
            // 
            // рецептыБлюдToolStripMenuItem
            // 
            this.рецептыБлюдToolStripMenuItem.Name = "рецептыБлюдToolStripMenuItem";
            this.рецептыБлюдToolStripMenuItem.Size = new System.Drawing.Size(415, 28);
            this.рецептыБлюдToolStripMenuItem.Text = "Рецепты блюд";
            this.рецептыБлюдToolStripMenuItem.Click += new System.EventHandler(this.рецептыБлюдToolStripMenuItem_Click);
            // 
            // списокБлюдМинимальнойКалорийностиToolStripMenuItem
            // 
            this.списокБлюдМинимальнойКалорийностиToolStripMenuItem.Name = "списокБлюдМинимальнойКалорийностиToolStripMenuItem";
            this.списокБлюдМинимальнойКалорийностиToolStripMenuItem.Size = new System.Drawing.Size(415, 28);
            this.списокБлюдМинимальнойКалорийностиToolStripMenuItem.Text = "Список блюд минимальной калорийности";
            this.списокБлюдМинимальнойКалорийностиToolStripMenuItem.Click += new System.EventHandler(this.списокБлюдМинимальнойКалорийностиToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 96);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(713, 332);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Кулинарное приложение";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUKTBindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource pRODUKTBindingSource;
        private Database1DataSetTableAdapters.PRODUKTTableAdapter pRODUKTTableAdapter;
        private Database1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem менюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem продуктыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem рецептToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem авторToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ингредиентыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem группаПродуктаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem способПриготовленияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выборДанныхToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem прайслистToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem рецептыБлюдToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem списокБлюдМинимальнойКалорийностиToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem главноеМенюToolStripMenuItem;
    }
}

