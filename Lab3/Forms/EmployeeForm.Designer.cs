namespace Lab3.Forms
{
    partial class EmployeeForm
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
            this.lblDodajPracownika = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblAddres = new System.Windows.Forms.Label();
            this.tbID = new System.Windows.Forms.TextBox();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.tbNazwisko = new System.Windows.Forms.TextBox();
            this.tbAdres = new System.Windows.Forms.TextBox();
            this.btnDodajPracownika = new System.Windows.Forms.Button();
            this.btnUsun = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDodajPracownika
            // 
            this.lblDodajPracownika.AutoSize = true;
            this.lblDodajPracownika.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDodajPracownika.Location = new System.Drawing.Point(21, 19);
            this.lblDodajPracownika.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDodajPracownika.Name = "lblDodajPracownika";
            this.lblDodajPracownika.Size = new System.Drawing.Size(230, 19);
            this.lblDodajPracownika.TabIndex = 0;
            this.lblDodajPracownika.Text = "Dodaj nowego Pracownika";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblID.Location = new System.Drawing.Point(9, 63);
            this.lblID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(89, 16);
            this.lblID.TabIndex = 1;
            this.lblID.Text = "ID Pracownika";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblFirstName.Location = new System.Drawing.Point(9, 115);
            this.lblFirstName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(33, 16);
            this.lblFirstName.TabIndex = 1;
            this.lblFirstName.Text = "Imię";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblLastName.Location = new System.Drawing.Point(9, 171);
            this.lblLastName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(59, 16);
            this.lblLastName.TabIndex = 1;
            this.lblLastName.Text = "Nazwisko";
            // 
            // lblAddres
            // 
            this.lblAddres.AutoSize = true;
            this.lblAddres.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblAddres.Location = new System.Drawing.Point(9, 235);
            this.lblAddres.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAddres.Name = "lblAddres";
            this.lblAddres.Size = new System.Drawing.Size(42, 16);
            this.lblAddres.TabIndex = 1;
            this.lblAddres.Text = "Adres";
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(11, 79);
            this.tbID.Margin = new System.Windows.Forms.Padding(2);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(68, 20);
            this.tbID.TabIndex = 2;
            // 
            // tbFirstName
            // 
            this.tbFirstName.Location = new System.Drawing.Point(9, 131);
            this.tbFirstName.Margin = new System.Windows.Forms.Padding(2);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(229, 20);
            this.tbFirstName.TabIndex = 2;
            // 
            // tbNazwisko
            // 
            this.tbNazwisko.Location = new System.Drawing.Point(9, 186);
            this.tbNazwisko.Margin = new System.Windows.Forms.Padding(2);
            this.tbNazwisko.Name = "tbNazwisko";
            this.tbNazwisko.Size = new System.Drawing.Size(229, 20);
            this.tbNazwisko.TabIndex = 2;
            // 
            // tbAdres
            // 
            this.tbAdres.Location = new System.Drawing.Point(11, 250);
            this.tbAdres.Margin = new System.Windows.Forms.Padding(2);
            this.tbAdres.Name = "tbAdres";
            this.tbAdres.Size = new System.Drawing.Size(227, 20);
            this.tbAdres.TabIndex = 2;
            // 
            // btnDodajPracownika
            // 
            this.btnDodajPracownika.Location = new System.Drawing.Point(56, 312);
            this.btnDodajPracownika.Margin = new System.Windows.Forms.Padding(2);
            this.btnDodajPracownika.Name = "btnDodajPracownika";
            this.btnDodajPracownika.Size = new System.Drawing.Size(145, 44);
            this.btnDodajPracownika.TabIndex = 3;
            this.btnDodajPracownika.Text = "Dodaj Pracownika";
            this.btnDodajPracownika.UseVisualStyleBackColor = true;
            this.btnDodajPracownika.Click += new System.EventHandler(this.btnDodajPracownika_Click);
            // 
            // btnUsun
            // 
            this.btnUsun.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnUsun.Location = new System.Drawing.Point(103, 77);
            this.btnUsun.Name = "btnUsun";
            this.btnUsun.Size = new System.Drawing.Size(75, 23);
            this.btnUsun.TabIndex = 4;
            this.btnUsun.Text = "Usuń";
            this.btnUsun.UseVisualStyleBackColor = true;
            this.btnUsun.Click += new System.EventHandler(this.btnUsun_Click);
            // 
            // EmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 366);
            this.Controls.Add(this.btnUsun);
            this.Controls.Add(this.btnDodajPracownika);
            this.Controls.Add(this.tbAdres);
            this.Controls.Add(this.tbNazwisko);
            this.Controls.Add(this.tbFirstName);
            this.Controls.Add(this.tbID);
            this.Controls.Add(this.lblAddres);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.lblDodajPracownika);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "EmployeeForm";
            this.Text = "Dodaj Pracownika";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDodajPracownika;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblAddres;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.TextBox tbNazwisko;
        private System.Windows.Forms.TextBox tbAdres;
        private System.Windows.Forms.Button btnDodajPracownika;
        private System.Windows.Forms.Button btnUsun;
    }
}