namespace ООО__Поваренок_.Forms
{
    partial class OrderForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderForm));
            this.NoteLabel = new System.Windows.Forms.Label();
            this.FIOLabel = new System.Windows.Forms.Label();
            this.ViewProductFormButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PagesLabel = new System.Windows.Forms.Label();
            this.NextButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.OrderGroupBox2 = new System.Windows.Forms.GroupBox();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.DiscountLabel2 = new System.Windows.Forms.Label();
            this.CostLabel2 = new System.Windows.Forms.Label();
            this.OldlCostLabel2 = new System.Windows.Forms.Label();
            this.ManufactureLabel2 = new System.Windows.Forms.Label();
            this.NameLabel2 = new System.Windows.Forms.Label();
            this.DiscriptinListBox2 = new System.Windows.Forms.ListBox();
            this.ImagePictureBox2 = new System.Windows.Forms.PictureBox();
            this.OrderGroupBox1 = new System.Windows.Forms.GroupBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.DiscountLabel1 = new System.Windows.Forms.Label();
            this.CostLabel1 = new System.Windows.Forms.Label();
            this.OldlCostLabel1 = new System.Windows.Forms.Label();
            this.ManufactureLabel1 = new System.Windows.Forms.Label();
            this.NameLabel1 = new System.Windows.Forms.Label();
            this.DiscriptinListBox1 = new System.Windows.Forms.ListBox();
            this.ImagePictureBox1 = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.изменитьКоличествоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ReportButton = new System.Windows.Forms.Button();
            this.AddressComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.OrderGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImagePictureBox2)).BeginInit();
            this.OrderGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImagePictureBox1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.contextMenuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // NoteLabel
            // 
            this.NoteLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NoteLabel.AutoSize = true;
            this.NoteLabel.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NoteLabel.Location = new System.Drawing.Point(438, 9);
            this.NoteLabel.Name = "NoteLabel";
            this.NoteLabel.Size = new System.Drawing.Size(70, 36);
            this.NoteLabel.TabIndex = 23;
            this.NoteLabel.Text = "100000\r\n10000000\r\n";
            // 
            // FIOLabel
            // 
            this.FIOLabel.AutoSize = true;
            this.FIOLabel.Location = new System.Drawing.Point(12, 64);
            this.FIOLabel.Name = "FIOLabel";
            this.FIOLabel.Size = new System.Drawing.Size(280, 23);
            this.FIOLabel.TabIndex = 20;
            this.FIOLabel.Text = "Фамильевич Человек Отчевствович";
            // 
            // ViewProductFormButton
            // 
            this.ViewProductFormButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ViewProductFormButton.Location = new System.Drawing.Point(12, 12);
            this.ViewProductFormButton.Name = "ViewProductFormButton";
            this.ViewProductFormButton.Size = new System.Drawing.Size(41, 30);
            this.ViewProductFormButton.TabIndex = 18;
            this.ViewProductFormButton.Text = "<-";
            this.ViewProductFormButton.UseVisualStyleBackColor = true;
            this.ViewProductFormButton.Click += new System.EventHandler(this.ViewProductFormButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Location = new System.Drawing.Point(154, -8);
            this.groupBox1.MinimumSize = new System.Drawing.Size(206, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(206, 58);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "ООО «Поваренок»";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(4, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(52, 35);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // PagesLabel
            // 
            this.PagesLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.PagesLabel.AutoSize = true;
            this.PagesLabel.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PagesLabel.Location = new System.Drawing.Point(15, 413);
            this.PagesLabel.Name = "PagesLabel";
            this.PagesLabel.Size = new System.Drawing.Size(154, 18);
            this.PagesLabel.TabIndex = 28;
            this.PagesLabel.Text = "стр 100000 из 1000000";
            // 
            // NextButton
            // 
            this.NextButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.NextButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NextButton.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NextButton.Location = new System.Drawing.Point(471, 405);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(36, 30);
            this.NextButton.TabIndex = 27;
            this.NextButton.Text = ">";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackButton.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BackButton.Location = new System.Drawing.Point(429, 405);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(36, 30);
            this.BackButton.TabIndex = 26;
            this.BackButton.Text = "<";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // OrderGroupBox2
            // 
            this.OrderGroupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OrderGroupBox2.Controls.Add(this.numericUpDown2);
            this.OrderGroupBox2.Controls.Add(this.DiscountLabel2);
            this.OrderGroupBox2.Controls.Add(this.CostLabel2);
            this.OrderGroupBox2.Controls.Add(this.OldlCostLabel2);
            this.OrderGroupBox2.Controls.Add(this.ManufactureLabel2);
            this.OrderGroupBox2.Controls.Add(this.NameLabel2);
            this.OrderGroupBox2.Controls.Add(this.DiscriptinListBox2);
            this.OrderGroupBox2.Controls.Add(this.ImagePictureBox2);
            this.OrderGroupBox2.Location = new System.Drawing.Point(12, 243);
            this.OrderGroupBox2.Name = "OrderGroupBox2";
            this.OrderGroupBox2.Size = new System.Drawing.Size(495, 158);
            this.OrderGroupBox2.TabIndex = 25;
            this.OrderGroupBox2.TabStop = false;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDown2.Enabled = false;
            this.numericUpDown2.Location = new System.Drawing.Point(405, 113);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(68, 30);
            this.numericUpDown2.TabIndex = 30;
            this.numericUpDown2.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // DiscountLabel2
            // 
            this.DiscountLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DiscountLabel2.AutoSize = true;
            this.DiscountLabel2.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DiscountLabel2.Location = new System.Drawing.Point(398, 62);
            this.DiscountLabel2.Name = "DiscountLabel2";
            this.DiscountLabel2.Size = new System.Drawing.Size(83, 38);
            this.DiscountLabel2.TabIndex = 6;
            this.DiscountLabel2.Text = "150%";
            // 
            // CostLabel2
            // 
            this.CostLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CostLabel2.AutoSize = true;
            this.CostLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(102)))), ((int)(((byte)(0)))));
            this.CostLabel2.Location = new System.Drawing.Point(224, 120);
            this.CostLabel2.Name = "CostLabel2";
            this.CostLabel2.Size = new System.Drawing.Size(64, 23);
            this.CostLabel2.TabIndex = 5;
            this.CostLabel2.Text = "220.00";
            // 
            // OldlCostLabel2
            // 
            this.OldlCostLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.OldlCostLabel2.AutoSize = true;
            this.OldlCostLabel2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Strikeout, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OldlCostLabel2.Location = new System.Drawing.Point(154, 120);
            this.OldlCostLabel2.Name = "OldlCostLabel2";
            this.OldlCostLabel2.Size = new System.Drawing.Size(64, 23);
            this.OldlCostLabel2.TabIndex = 4;
            this.OldlCostLabel2.Text = "220.00";
            // 
            // ManufactureLabel2
            // 
            this.ManufactureLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ManufactureLabel2.AutoSize = true;
            this.ManufactureLabel2.Location = new System.Drawing.Point(154, 93);
            this.ManufactureLabel2.Name = "ManufactureLabel2";
            this.ManufactureLabel2.Size = new System.Drawing.Size(59, 23);
            this.ManufactureLabel2.TabIndex = 3;
            this.ManufactureLabel2.Text = "Alaska";
            // 
            // NameLabel2
            // 
            this.NameLabel2.AutoSize = true;
            this.NameLabel2.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameLabel2.Location = new System.Drawing.Point(154, 20);
            this.NameLabel2.Name = "NameLabel2";
            this.NameLabel2.Size = new System.Drawing.Size(156, 26);
            this.NameLabel2.TabIndex = 2;
            this.NameLabel2.Text = "Вилка столовая";
            // 
            // DiscriptinListBox2
            // 
            this.DiscriptinListBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DiscriptinListBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DiscriptinListBox2.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DiscriptinListBox2.FormattingEnabled = true;
            this.DiscriptinListBox2.HorizontalScrollbar = true;
            this.DiscriptinListBox2.ItemHeight = 18;
            this.DiscriptinListBox2.Items.AddRange(new object[] {
            "Вилка столовая 21,2 см «Аляска бэйсик» сталь KunstWerk"});
            this.DiscriptinListBox2.Location = new System.Drawing.Point(158, 53);
            this.DiscriptinListBox2.Name = "DiscriptinListBox2";
            this.DiscriptinListBox2.Size = new System.Drawing.Size(211, 36);
            this.DiscriptinListBox2.TabIndex = 1;
            // 
            // ImagePictureBox2
            // 
            this.ImagePictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ImagePictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(153)))));
            this.ImagePictureBox2.ErrorImage = ((System.Drawing.Image)(resources.GetObject("ImagePictureBox2.ErrorImage")));
            this.ImagePictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("ImagePictureBox2.Image")));
            this.ImagePictureBox2.InitialImage = ((System.Drawing.Image)(resources.GetObject("ImagePictureBox2.InitialImage")));
            this.ImagePictureBox2.Location = new System.Drawing.Point(6, 20);
            this.ImagePictureBox2.Name = "ImagePictureBox2";
            this.ImagePictureBox2.Size = new System.Drawing.Size(142, 123);
            this.ImagePictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ImagePictureBox2.TabIndex = 0;
            this.ImagePictureBox2.TabStop = false;
            // 
            // OrderGroupBox1
            // 
            this.OrderGroupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OrderGroupBox1.Controls.Add(this.numericUpDown1);
            this.OrderGroupBox1.Controls.Add(this.DiscountLabel1);
            this.OrderGroupBox1.Controls.Add(this.CostLabel1);
            this.OrderGroupBox1.Controls.Add(this.OldlCostLabel1);
            this.OrderGroupBox1.Controls.Add(this.ManufactureLabel1);
            this.OrderGroupBox1.Controls.Add(this.NameLabel1);
            this.OrderGroupBox1.Controls.Add(this.DiscriptinListBox1);
            this.OrderGroupBox1.Controls.Add(this.ImagePictureBox1);
            this.OrderGroupBox1.Location = new System.Drawing.Point(12, 86);
            this.OrderGroupBox1.Name = "OrderGroupBox1";
            this.OrderGroupBox1.Size = new System.Drawing.Size(495, 158);
            this.OrderGroupBox1.TabIndex = 24;
            this.OrderGroupBox1.TabStop = false;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDown1.Enabled = false;
            this.numericUpDown1.Location = new System.Drawing.Point(405, 113);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(68, 30);
            this.numericUpDown1.TabIndex = 29;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // DiscountLabel1
            // 
            this.DiscountLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DiscountLabel1.AutoSize = true;
            this.DiscountLabel1.BackColor = System.Drawing.Color.Transparent;
            this.DiscountLabel1.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DiscountLabel1.Location = new System.Drawing.Point(398, 62);
            this.DiscountLabel1.Name = "DiscountLabel1";
            this.DiscountLabel1.Size = new System.Drawing.Size(67, 38);
            this.DiscountLabel1.TabIndex = 6;
            this.DiscountLabel1.Text = "10%";
            // 
            // CostLabel1
            // 
            this.CostLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CostLabel1.AutoSize = true;
            this.CostLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(102)))), ((int)(((byte)(0)))));
            this.CostLabel1.Location = new System.Drawing.Point(224, 120);
            this.CostLabel1.Name = "CostLabel1";
            this.CostLabel1.Size = new System.Drawing.Size(64, 23);
            this.CostLabel1.TabIndex = 5;
            this.CostLabel1.Text = "220.00";
            // 
            // OldlCostLabel1
            // 
            this.OldlCostLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.OldlCostLabel1.AutoSize = true;
            this.OldlCostLabel1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Strikeout, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OldlCostLabel1.Location = new System.Drawing.Point(154, 120);
            this.OldlCostLabel1.Name = "OldlCostLabel1";
            this.OldlCostLabel1.Size = new System.Drawing.Size(64, 23);
            this.OldlCostLabel1.TabIndex = 4;
            this.OldlCostLabel1.Text = "220.00";
            // 
            // ManufactureLabel1
            // 
            this.ManufactureLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ManufactureLabel1.AutoSize = true;
            this.ManufactureLabel1.Location = new System.Drawing.Point(154, 93);
            this.ManufactureLabel1.Name = "ManufactureLabel1";
            this.ManufactureLabel1.Size = new System.Drawing.Size(59, 23);
            this.ManufactureLabel1.TabIndex = 3;
            this.ManufactureLabel1.Text = "Alaska";
            // 
            // NameLabel1
            // 
            this.NameLabel1.AutoSize = true;
            this.NameLabel1.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameLabel1.Location = new System.Drawing.Point(154, 20);
            this.NameLabel1.Name = "NameLabel1";
            this.NameLabel1.Size = new System.Drawing.Size(156, 26);
            this.NameLabel1.TabIndex = 2;
            this.NameLabel1.Text = "Вилка столовая";
            // 
            // DiscriptinListBox1
            // 
            this.DiscriptinListBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DiscriptinListBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DiscriptinListBox1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DiscriptinListBox1.FormattingEnabled = true;
            this.DiscriptinListBox1.HorizontalScrollbar = true;
            this.DiscriptinListBox1.ItemHeight = 18;
            this.DiscriptinListBox1.Items.AddRange(new object[] {
            "Вилка столовая 21,2 см «Аляска бэйсик» сталь KunstWerk"});
            this.DiscriptinListBox1.Location = new System.Drawing.Point(158, 53);
            this.DiscriptinListBox1.Name = "DiscriptinListBox1";
            this.DiscriptinListBox1.Size = new System.Drawing.Size(211, 36);
            this.DiscriptinListBox1.TabIndex = 1;
            // 
            // ImagePictureBox1
            // 
            this.ImagePictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ImagePictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(153)))));
            this.ImagePictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("ImagePictureBox1.ErrorImage")));
            this.ImagePictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("ImagePictureBox1.Image")));
            this.ImagePictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("ImagePictureBox1.InitialImage")));
            this.ImagePictureBox1.Location = new System.Drawing.Point(6, 20);
            this.ImagePictureBox1.Name = "ImagePictureBox1";
            this.ImagePictureBox1.Size = new System.Drawing.Size(142, 123);
            this.ImagePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ImagePictureBox1.TabIndex = 0;
            this.ImagePictureBox1.TabStop = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.изменитьКоличествоToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(212, 26);
            // 
            // изменитьКоличествоToolStripMenuItem
            // 
            this.изменитьКоличествоToolStripMenuItem.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.изменитьКоличествоToolStripMenuItem.Name = "изменитьКоличествоToolStripMenuItem";
            this.изменитьКоличествоToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.изменитьКоличествоToolStripMenuItem.Text = "Изменить количество";
            this.изменитьКоличествоToolStripMenuItem.Click += new System.EventHandler(this.изменитьКоличествоToolStripMenuItem_Click);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.contextMenuStrip2.Name = "contextMenuStrip1";
            this.contextMenuStrip2.Size = new System.Drawing.Size(212, 26);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(211, 22);
            this.toolStripMenuItem1.Text = "Изменить количество";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // ReportButton
            // 
            this.ReportButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ReportButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReportButton.Location = new System.Drawing.Point(402, 60);
            this.ReportButton.Name = "ReportButton";
            this.ReportButton.Size = new System.Drawing.Size(105, 30);
            this.ReportButton.TabIndex = 29;
            this.ReportButton.Text = "Оформить";
            this.ReportButton.UseVisualStyleBackColor = true;
            this.ReportButton.Click += new System.EventHandler(this.ReportButton_Click);
            // 
            // AddressComboBox
            // 
            this.AddressComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddressComboBox.DropDownHeight = 100;
            this.AddressComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AddressComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddressComboBox.FormattingEnabled = true;
            this.AddressComboBox.IntegralHeight = false;
            this.AddressComboBox.Location = new System.Drawing.Point(175, 404);
            this.AddressComboBox.Name = "AddressComboBox";
            this.AddressComboBox.Size = new System.Drawing.Size(235, 31);
            this.AddressComboBox.Sorted = true;
            this.AddressComboBox.TabIndex = 36;
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(520, 439);
            this.Controls.Add(this.AddressComboBox);
            this.Controls.Add(this.ReportButton);
            this.Controls.Add(this.PagesLabel);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.OrderGroupBox2);
            this.Controls.Add(this.OrderGroupBox1);
            this.Controls.Add(this.NoteLabel);
            this.Controls.Add(this.FIOLabel);
            this.Controls.Add(this.ViewProductFormButton);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MinimumSize = new System.Drawing.Size(536, 478);
            this.Name = "OrderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Просмотр заказов";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OrderForm_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.OrderGroupBox2.ResumeLayout(false);
            this.OrderGroupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImagePictureBox2)).EndInit();
            this.OrderGroupBox1.ResumeLayout(false);
            this.OrderGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImagePictureBox1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.contextMenuStrip2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NoteLabel;
        private System.Windows.Forms.Label FIOLabel;
        private System.Windows.Forms.Button ViewProductFormButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label PagesLabel;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.GroupBox OrderGroupBox2;
        private System.Windows.Forms.Label DiscountLabel2;
        private System.Windows.Forms.Label CostLabel2;
        private System.Windows.Forms.Label OldlCostLabel2;
        private System.Windows.Forms.Label ManufactureLabel2;
        private System.Windows.Forms.Label NameLabel2;
        private System.Windows.Forms.ListBox DiscriptinListBox2;
        private System.Windows.Forms.PictureBox ImagePictureBox2;
        private System.Windows.Forms.GroupBox OrderGroupBox1;
        private System.Windows.Forms.Label DiscountLabel1;
        private System.Windows.Forms.Label CostLabel1;
        private System.Windows.Forms.Label OldlCostLabel1;
        private System.Windows.Forms.Label ManufactureLabel1;
        private System.Windows.Forms.Label NameLabel1;
        private System.Windows.Forms.ListBox DiscriptinListBox1;
        private System.Windows.Forms.PictureBox ImagePictureBox1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem изменитьКоличествоToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.Button ReportButton;
        private System.Windows.Forms.ComboBox AddressComboBox;
    }
}