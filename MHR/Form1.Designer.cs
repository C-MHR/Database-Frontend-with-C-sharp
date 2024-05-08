namespace MHR
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CNIClabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbGender = new System.Windows.Forms.TextBox();
            this.tbAge = new System.Windows.Forms.TextBox();
            this.tbFName = new System.Windows.Forms.TextBox();
            this.tbCNIC = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.delete = new System.Windows.Forms.Button();
            this.view = new System.Windows.Forms.Button();
            this.viewField = new System.Windows.Forms.DataGridView();
            this.update = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.viewField)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(95, 423);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Gender :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label3.Location = new System.Drawing.Point(95, 372);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Age :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(95, 286);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Father Name : ";
            // 
            // CNIClabel
            // 
            this.CNIClabel.AutoSize = true;
            this.CNIClabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CNIClabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.CNIClabel.Location = new System.Drawing.Point(95, 329);
            this.CNIClabel.Name = "CNIClabel";
            this.CNIClabel.Size = new System.Drawing.Size(55, 20);
            this.CNIClabel.TabIndex = 6;
            this.CNIClabel.Text = "CNIC :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label4.Location = new System.Drawing.Point(95, 241);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Name : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Turquoise;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Teal;
            this.label5.Location = new System.Drawing.Point(220, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(412, 39);
            this.label5.TabIndex = 13;
            this.label5.Text = "Enter Citizen\'s Particulars";
            // 
            // tbGender
            // 
            this.tbGender.BackColor = System.Drawing.SystemColors.Info;
            this.tbGender.Location = new System.Drawing.Point(288, 417);
            this.tbGender.Name = "tbGender";
            this.tbGender.Size = new System.Drawing.Size(287, 26);
            this.tbGender.TabIndex = 8;
            this.tbGender.Text = "Enter citizen\'s gender";
            this.tbGender.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbGender.Enter += new System.EventHandler(this.TbGender_Enter);
            // 
            // tbAge
            // 
            this.tbAge.BackColor = System.Drawing.SystemColors.Info;
            this.tbAge.Location = new System.Drawing.Point(288, 366);
            this.tbAge.Name = "tbAge";
            this.tbAge.Size = new System.Drawing.Size(287, 26);
            this.tbAge.TabIndex = 9;
            this.tbAge.Text = "Enter citizen\'s age";
            this.tbAge.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbAge.Enter += new System.EventHandler(this.TbAge_Enter);
            // 
            // tbFName
            // 
            this.tbFName.BackColor = System.Drawing.SystemColors.Info;
            this.tbFName.Location = new System.Drawing.Point(288, 280);
            this.tbFName.Name = "tbFName";
            this.tbFName.Size = new System.Drawing.Size(287, 26);
            this.tbFName.TabIndex = 10;
            this.tbFName.Text = "Enter citizen\'s Father\'s name";
            this.tbFName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbFName.Enter += new System.EventHandler(this.TbFName_Enter);
            // 
            // tbCNIC
            // 
            this.tbCNIC.BackColor = System.Drawing.SystemColors.Info;
            this.tbCNIC.Location = new System.Drawing.Point(288, 323);
            this.tbCNIC.Name = "tbCNIC";
            this.tbCNIC.Size = new System.Drawing.Size(287, 26);
            this.tbCNIC.TabIndex = 11;
            this.tbCNIC.Text = "Enter citizen\'s CNIC";
            this.tbCNIC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbCNIC.Enter += new System.EventHandler(this.TbCNIC_Enter);
            // 
            // tbName
            // 
            this.tbName.AcceptsReturn = true;
            this.tbName.BackColor = System.Drawing.SystemColors.Info;
            this.tbName.Location = new System.Drawing.Point(288, 235);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(287, 26);
            this.tbName.TabIndex = 12;
            this.tbName.Text = "Enter citizen\'s name";
            this.tbName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbName.Enter += new System.EventHandler(this.TbName_Enter);
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.SystemColors.Highlight;
            this.delete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.delete.ForeColor = System.Drawing.SystemColors.Info;
            this.delete.Location = new System.Drawing.Point(623, 538);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(122, 55);
            this.delete.TabIndex = 14;
            this.delete.Text = "Delete Record";
            this.delete.UseVisualStyleBackColor = false;
            this.delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // view
            // 
            this.view.BackColor = System.Drawing.SystemColors.Highlight;
            this.view.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.view.ForeColor = System.Drawing.SystemColors.Info;
            this.view.Location = new System.Drawing.Point(280, 538);
            this.view.Name = "view";
            this.view.Size = new System.Drawing.Size(122, 55);
            this.view.TabIndex = 14;
            this.view.Text = "View Record";
            this.view.UseVisualStyleBackColor = false;
            this.view.Click += new System.EventHandler(this.View_Click);
            // 
            // viewField
            // 
            this.viewField.BackgroundColor = System.Drawing.Color.SeaGreen;
            this.viewField.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.viewField.Location = new System.Drawing.Point(66, 599);
            this.viewField.Name = "viewField";
            this.viewField.RowTemplate.Height = 28;
            this.viewField.Size = new System.Drawing.Size(679, 218);
            this.viewField.TabIndex = 15;
            // 
            // update
            // 
            this.update.BackColor = System.Drawing.SystemColors.Highlight;
            this.update.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.update.ForeColor = System.Drawing.SystemColors.Info;
            this.update.Location = new System.Drawing.Point(453, 538);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(122, 55);
            this.update.TabIndex = 14;
            this.update.Text = "Update Record";
            this.update.UseVisualStyleBackColor = false;
            this.update.Click += new System.EventHandler(this.Update_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Highlight;
            this.button1.ForeColor = System.Drawing.SystemColors.Info;
            this.button1.Location = new System.Drawing.Point(66, 538);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 55);
            this.button1.TabIndex = 16;
            this.button1.Text = "Insert Record";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(867, 940);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.viewField);
            this.Controls.Add(this.view);
            this.Controls.Add(this.update);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbGender);
            this.Controls.Add(this.tbAge);
            this.Controls.Add(this.tbFName);
            this.Controls.Add(this.tbCNIC);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CNIClabel);
            this.Controls.Add(this.label4);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Nadra Form";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.viewField)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label CNIClabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbGender;
        private System.Windows.Forms.TextBox tbAge;
        private System.Windows.Forms.TextBox tbFName;
        private System.Windows.Forms.TextBox tbCNIC;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button view;
        private System.Windows.Forms.DataGridView viewField;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button button1;
    }
}

