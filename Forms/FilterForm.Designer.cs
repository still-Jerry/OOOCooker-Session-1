namespace ООО__Поваренок_.Forms
{
    partial class FilterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FilterForm));
            this.CostСomboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DiscountComboBox = new System.Windows.Forms.ComboBox();
            this.DropButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CostСomboBox
            // 
            this.CostСomboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CostСomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CostСomboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CostСomboBox.FormattingEnabled = true;
            this.CostСomboBox.Items.AddRange(new object[] {
            "Min",
            "Max",
            "Не учитывать"});
            this.CostСomboBox.Location = new System.Drawing.Point(0, 37);
            this.CostСomboBox.Name = "CostСomboBox";
            this.CostСomboBox.Size = new System.Drawing.Size(201, 31);
            this.CostСomboBox.TabIndex = 0;
            this.CostСomboBox.SelectedIndexChanged += new System.EventHandler(this.CostСomboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(2, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "По цене:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(2, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "По скидке:";
            // 
            // DiscountComboBox
            // 
            this.DiscountComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DiscountComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DiscountComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DiscountComboBox.FormattingEnabled = true;
            this.DiscountComboBox.Items.AddRange(new object[] {
            "до 10%",
            "10-15%",
            "от 15%",
            "Все диапазоны"});
            this.DiscountComboBox.Location = new System.Drawing.Point(0, 112);
            this.DiscountComboBox.Name = "DiscountComboBox";
            this.DiscountComboBox.Size = new System.Drawing.Size(201, 31);
            this.DiscountComboBox.TabIndex = 2;
            this.DiscountComboBox.SelectedIndexChanged += new System.EventHandler(this.DiscountComboBox_SelectedIndexChanged);
            // 
            // DropButton
            // 
            this.DropButton.BackColor = System.Drawing.Color.White;
            this.DropButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DropButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DropButton.Location = new System.Drawing.Point(0, 152);
            this.DropButton.Name = "DropButton";
            this.DropButton.Size = new System.Drawing.Size(201, 35);
            this.DropButton.TabIndex = 4;
            this.DropButton.Text = "Сброс фильтров";
            this.DropButton.UseVisualStyleBackColor = false;
            this.DropButton.Click += new System.EventHandler(this.DropButton_Click);
            // 
            // FilterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(153)))));
            this.ClientSize = new System.Drawing.Size(201, 187);
            this.Controls.Add(this.DropButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DiscountComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CostСomboBox);
            this.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FilterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Фильтры";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FilterForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CostСomboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox DiscountComboBox;
        private System.Windows.Forms.Button DropButton;
    }
}