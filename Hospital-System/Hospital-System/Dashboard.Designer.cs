namespace Hospital_System
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.btn_PatientList = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAddRecord = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Doctor = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_PatientList
            // 
            this.btn_PatientList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(171)))));
            this.btn_PatientList.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_PatientList.BackgroundImage")));
            this.btn_PatientList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_PatientList.FlatAppearance.BorderSize = 0;
            this.btn_PatientList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_PatientList.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_PatientList.Location = new System.Drawing.Point(200, 101);
            this.btn_PatientList.Name = "btn_PatientList";
            this.btn_PatientList.Size = new System.Drawing.Size(126, 97);
            this.btn_PatientList.TabIndex = 0;
            this.btn_PatientList.UseVisualStyleBackColor = false;
            this.btn_PatientList.Click += new System.EventHandler(this.btn_PatientList_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gadugi", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(171)))));
            this.label1.Location = new System.Drawing.Point(176, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "Dashboard";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(171)))));
            this.label2.Location = new System.Drawing.Point(220, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Patient List";
            // 
            // btnAddRecord
            // 
            this.btnAddRecord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(171)))));
            this.btnAddRecord.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddRecord.BackgroundImage")));
            this.btnAddRecord.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddRecord.FlatAppearance.BorderSize = 0;
            this.btnAddRecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddRecord.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(171)))));
            this.btnAddRecord.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddRecord.Location = new System.Drawing.Point(339, 103);
            this.btnAddRecord.Name = "btnAddRecord";
            this.btnAddRecord.Size = new System.Drawing.Size(135, 97);
            this.btnAddRecord.TabIndex = 3;
            this.btnAddRecord.UseVisualStyleBackColor = false;
            this.btnAddRecord.Click += new System.EventHandler(this.btnAddRecord_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(171)))));
            this.label3.Location = new System.Drawing.Point(352, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Patient History";
            // 
            // btn_Doctor
            // 
            this.btn_Doctor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(171)))));
            this.btn_Doctor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Doctor.BackgroundImage")));
            this.btn_Doctor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Doctor.FlatAppearance.BorderSize = 0;
            this.btn_Doctor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Doctor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(171)))));
            this.btn_Doctor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Doctor.Location = new System.Drawing.Point(59, 100);
            this.btn_Doctor.Name = "btn_Doctor";
            this.btn_Doctor.Size = new System.Drawing.Size(126, 97);
            this.btn_Doctor.TabIndex = 7;
            this.btn_Doctor.UseVisualStyleBackColor = false;
            this.btn_Doctor.Click += new System.EventHandler(this.btn_Doctor_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(171)))));
            this.label5.Location = new System.Drawing.Point(78, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 18);
            this.label5.TabIndex = 8;
            this.label5.Text = "Doctors List";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(171)))));
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(-4, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(522, 44);
            this.panel1.TabIndex = 9;
            // 
            // btnExit
            // 
            this.btnExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExit.BackgroundImage")));
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Location = new System.Drawing.Point(484, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(24, 20);
            this.btnExit.TabIndex = 0;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(171)))));
            this.panel2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Location = new System.Drawing.Point(0, 232);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(518, 45);
            this.panel2.TabIndex = 10;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(516, 277);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_Doctor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnAddRecord);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_PatientList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_PatientList;
        private Label label1;
        private Label label2;
        private Button btnAddRecord;
        private Label label3;
        private Button btn_Doctor;
        private Label label5;
        private Panel panel1;
        private Panel panel2;
        private Button btnExit;
    }
}