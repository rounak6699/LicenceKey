
namespace LicenceKey
{
    partial class KeyGeneration
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KeyGeneration));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ProductVesion = new System.Windows.Forms.Label();
            this.validate = new System.Windows.Forms.Button();
            this.LicenceKey = new System.Windows.Forms.Label();
            this.generatedKey = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.machineText = new System.Windows.Forms.TextBox();
            this.productText = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(104, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Product Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(104, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Machine Code";
            // 
            // ProductVesion
            // 
            this.ProductVesion.AutoSize = true;
            this.ProductVesion.Location = new System.Drawing.Point(236, 230);
            this.ProductVesion.Name = "ProductVesion";
            this.ProductVesion.Size = new System.Drawing.Size(0, 15);
            this.ProductVesion.TabIndex = 2;
            this.ProductVesion.Click += new System.EventHandler(this.label3_Click);
            // 
            // validate
            // 
            this.validate.Location = new System.Drawing.Point(493, 175);
            this.validate.Name = "validate";
            this.validate.Size = new System.Drawing.Size(56, 23);
            this.validate.TabIndex = 7;
            this.validate.Text = "Get Key";
            this.validate.UseVisualStyleBackColor = true;
            this.validate.Click += new System.EventHandler(this.validate_Click);
            // 
            // LicenceKey
            // 
            this.LicenceKey.AutoSize = true;
            this.LicenceKey.Location = new System.Drawing.Point(205, 281);
            this.LicenceKey.Name = "LicenceKey";
            this.LicenceKey.Size = new System.Drawing.Size(0, 15);
            this.LicenceKey.TabIndex = 8;
            // 
            // generatedKey
            // 
            this.generatedKey.BackColor = System.Drawing.SystemColors.Control;
            this.generatedKey.Location = new System.Drawing.Point(236, 237);
            this.generatedKey.Name = "generatedKey";
            this.generatedKey.ReadOnly = true;
            this.generatedKey.Size = new System.Drawing.Size(390, 23);
            this.generatedKey.TabIndex = 9;
            this.generatedKey.TextChanged += new System.EventHandler(this.generatedKey_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(21, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(274, 61);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(236, 384);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 15);
            this.label3.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(104, 245);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "Licence Key";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(328, 307);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 35);
            this.button1.TabIndex = 14;
            this.button1.Text = "Validate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // machineText
            // 
            this.machineText.AccessibleRole = System.Windows.Forms.AccessibleRole.ComboBox;
            this.machineText.BackColor = System.Drawing.SystemColors.Control;
            this.machineText.Location = new System.Drawing.Point(236, 175);
            this.machineText.Name = "machineText";
            this.machineText.ReadOnly = true;
            this.machineText.Size = new System.Drawing.Size(184, 23);
            this.machineText.TabIndex = 13;
            this.machineText.TextChanged += new System.EventHandler(this.machineText_TextChanged_1);
            // 
            // productText
            // 
            this.productText.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.productText.AllowDrop = true;
            this.productText.BackColor = System.Drawing.SystemColors.Control;
            this.productText.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.productText.FormattingEnabled = true;
            this.productText.Items.AddRange(new object[] {
            "Pdt-1",
            "Pdt-2",
            "Pdt-3",
            "Pdt-4",
            "Pdt-5"});
            this.productText.Location = new System.Drawing.Point(236, 127);
            this.productText.Name = "productText";
            this.productText.Size = new System.Drawing.Size(184, 23);
            this.productText.TabIndex = 15;
            this.productText.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(587, 236);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(55, 23);
            this.button2.TabIndex = 16;
            this.button2.Text = "Copy";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // KeyGeneration
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.SpinButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(698, 431);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.productText);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.machineText);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.generatedKey);
            this.Controls.Add(this.LicenceKey);
            this.Controls.Add(this.validate);
            this.Controls.Add(this.ProductVesion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "KeyGeneration";
            this.Text = "keyGeneration";
            this.Load += new System.EventHandler(this.KeyGeneration_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label ProductVesion;
        private System.Windows.Forms.Button validate;
        private System.Windows.Forms.Label LicenceKey;
        private System.Windows.Forms.TextBox generatedKey;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox machineText;
        private System.Windows.Forms.ComboBox productText;
        private System.Windows.Forms.Button button2;
    }
}

