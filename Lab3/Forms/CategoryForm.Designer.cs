namespace Lab3.Forms
{
    partial class CategoryForm
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
            this.btnDodajKategorie = new System.Windows.Forms.Button();
            this.tbDesc = new System.Windows.Forms.TextBox();
            this.tbCategoryName = new System.Windows.Forms.TextBox();
            this.tbID = new System.Windows.Forms.TextBox();
            this.lblDesc = new System.Windows.Forms.Label();
            this.lblCategoryName = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.lblDodajKategorie = new System.Windows.Forms.Label();
            this.btnUsun = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDodajKategorie
            // 
            this.btnDodajKategorie.Location = new System.Drawing.Point(51, 311);
            this.btnDodajKategorie.Margin = new System.Windows.Forms.Padding(2);
            this.btnDodajKategorie.Name = "btnDodajKategorie";
            this.btnDodajKategorie.Size = new System.Drawing.Size(145, 44);
            this.btnDodajKategorie.TabIndex = 13;
            this.btnDodajKategorie.Text = "Dodaj Kategorie";
            this.btnDodajKategorie.UseVisualStyleBackColor = true;
            this.btnDodajKategorie.Click += new System.EventHandler(this.btnDodajKategorie_Click);
            // 
            // tbDesc
            // 
            this.tbDesc.Location = new System.Drawing.Point(9, 187);
            this.tbDesc.Margin = new System.Windows.Forms.Padding(2);
            this.tbDesc.Name = "tbDesc";
            this.tbDesc.Size = new System.Drawing.Size(229, 20);
            this.tbDesc.TabIndex = 10;
            // 
            // tbCategoryName
            // 
            this.tbCategoryName.Location = new System.Drawing.Point(9, 129);
            this.tbCategoryName.Margin = new System.Windows.Forms.Padding(2);
            this.tbCategoryName.Name = "tbCategoryName";
            this.tbCategoryName.Size = new System.Drawing.Size(229, 20);
            this.tbCategoryName.TabIndex = 11;
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(11, 77);
            this.tbID.Margin = new System.Windows.Forms.Padding(2);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(68, 20);
            this.tbID.TabIndex = 12;
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblDesc.Location = new System.Drawing.Point(9, 169);
            this.lblDesc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(32, 16);
            this.lblDesc.TabIndex = 6;
            this.lblDesc.Text = "Opis";
            // 
            // lblCategoryName
            // 
            this.lblCategoryName.AutoSize = true;
            this.lblCategoryName.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblCategoryName.Location = new System.Drawing.Point(9, 113);
            this.lblCategoryName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCategoryName.Name = "lblCategoryName";
            this.lblCategoryName.Size = new System.Drawing.Size(45, 16);
            this.lblCategoryName.TabIndex = 7;
            this.lblCategoryName.Text = "Nazwa";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblID.Location = new System.Drawing.Point(9, 61);
            this.lblID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(79, 16);
            this.lblID.TabIndex = 8;
            this.lblID.Text = "ID Kategorii";
            // 
            // lblDodajKategorie
            // 
            this.lblDodajKategorie.AutoSize = true;
            this.lblDodajKategorie.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDodajKategorie.Location = new System.Drawing.Point(24, 13);
            this.lblDodajKategorie.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDodajKategorie.Name = "lblDodajKategorie";
            this.lblDodajKategorie.Size = new System.Drawing.Size(196, 19);
            this.lblDodajKategorie.TabIndex = 4;
            this.lblDodajKategorie.Text = "Dodaj nową kateogorię";
            // 
            // btnUsun
            // 
            this.btnUsun.BackColor = System.Drawing.Color.White;
            this.btnUsun.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnUsun.Location = new System.Drawing.Point(121, 74);
            this.btnUsun.Name = "btnUsun";
            this.btnUsun.Size = new System.Drawing.Size(75, 23);
            this.btnUsun.TabIndex = 14;
            this.btnUsun.Text = "Usuń";
            this.btnUsun.UseVisualStyleBackColor = false;
            this.btnUsun.Click += new System.EventHandler(this.btnUsun_Click);
            // 
            // CategoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 366);
            this.Controls.Add(this.btnUsun);
            this.Controls.Add(this.btnDodajKategorie);
            this.Controls.Add(this.tbDesc);
            this.Controls.Add(this.tbCategoryName);
            this.Controls.Add(this.tbID);
            this.Controls.Add(this.lblDesc);
            this.Controls.Add(this.lblCategoryName);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.lblDodajKategorie);
            this.Name = "CategoryForm";
            this.Text = "CategoryForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDodajKategorie;
        private System.Windows.Forms.TextBox tbDesc;
        private System.Windows.Forms.TextBox tbCategoryName;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.Label lblCategoryName;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblDodajKategorie;
        private System.Windows.Forms.Button btnUsun;
    }
}