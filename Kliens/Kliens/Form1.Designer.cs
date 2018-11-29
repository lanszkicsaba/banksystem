namespace Kliens
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.bejelentkezestabPage = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.jelszotextBox = new System.Windows.Forms.TextBox();
            this.felhnevtextBox = new System.Windows.Forms.TextBox();
            this.bejelentkezesbutton = new System.Windows.Forms.Button();
            this.feltoltestabPage = new System.Windows.Forms.TabPage();
            this.osszeglabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lekerdezesbutton = new System.Windows.Forms.Button();
            this.feltoltestextBox = new System.Windows.Forms.TextBox();
            this.feltoltesbutton = new System.Windows.Forms.Button();
            this.utalastabPage = new System.Windows.Forms.TabPage();
            this.utalasinfolabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.mennyittextBox = new System.Windows.Forms.TextBox();
            this.kinektextBox = new System.Windows.Forms.TextBox();
            this.utalasbutton = new System.Windows.Forms.Button();
            this.utalaselozmenytabPage = new System.Windows.Forms.TabPage();
            this.lekerdezbutton = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Kinek = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Mikor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Osszeg = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.kijelentkezesbutton = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.bejelentkezestabPage.SuspendLayout();
            this.feltoltestabPage.SuspendLayout();
            this.utalastabPage.SuspendLayout();
            this.utalaselozmenytabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.bejelentkezestabPage);
            this.tabControl1.Controls.Add(this.feltoltestabPage);
            this.tabControl1.Controls.Add(this.utalastabPage);
            this.tabControl1.Controls.Add(this.utalaselozmenytabPage);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tabControl1.Location = new System.Drawing.Point(28, 40);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(727, 307);
            this.tabControl1.TabIndex = 0;
            // 
            // bejelentkezestabPage
            // 
            this.bejelentkezestabPage.Controls.Add(this.label2);
            this.bejelentkezestabPage.Controls.Add(this.label1);
            this.bejelentkezestabPage.Controls.Add(this.jelszotextBox);
            this.bejelentkezestabPage.Controls.Add(this.felhnevtextBox);
            this.bejelentkezestabPage.Controls.Add(this.bejelentkezesbutton);
            this.bejelentkezestabPage.Location = new System.Drawing.Point(4, 25);
            this.bejelentkezestabPage.Name = "bejelentkezestabPage";
            this.bejelentkezestabPage.Padding = new System.Windows.Forms.Padding(3);
            this.bejelentkezestabPage.Size = new System.Drawing.Size(719, 278);
            this.bejelentkezestabPage.TabIndex = 0;
            this.bejelentkezestabPage.Text = "Bejelentkezés";
            this.bejelentkezestabPage.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(326, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Jelszó:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(293, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Felhasználó név:";
            // 
            // jelszotextBox
            // 
            this.jelszotextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.jelszotextBox.Location = new System.Drawing.Point(271, 146);
            this.jelszotextBox.Name = "jelszotextBox";
            this.jelszotextBox.PasswordChar = '*';
            this.jelszotextBox.Size = new System.Drawing.Size(166, 26);
            this.jelszotextBox.TabIndex = 2;
            // 
            // felhnevtextBox
            // 
            this.felhnevtextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.felhnevtextBox.Location = new System.Drawing.Point(271, 76);
            this.felhnevtextBox.Name = "felhnevtextBox";
            this.felhnevtextBox.Size = new System.Drawing.Size(166, 26);
            this.felhnevtextBox.TabIndex = 1;
            // 
            // bejelentkezesbutton
            // 
            this.bejelentkezesbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bejelentkezesbutton.Location = new System.Drawing.Point(281, 194);
            this.bejelentkezesbutton.Name = "bejelentkezesbutton";
            this.bejelentkezesbutton.Size = new System.Drawing.Size(140, 39);
            this.bejelentkezesbutton.TabIndex = 0;
            this.bejelentkezesbutton.Text = "Bejelentkezés";
            this.bejelentkezesbutton.UseVisualStyleBackColor = true;
            this.bejelentkezesbutton.Click += new System.EventHandler(this.bejelentkezesbutton_Click);
            // 
            // feltoltestabPage
            // 
            this.feltoltestabPage.Controls.Add(this.osszeglabel);
            this.feltoltestabPage.Controls.Add(this.label4);
            this.feltoltestabPage.Controls.Add(this.label3);
            this.feltoltestabPage.Controls.Add(this.lekerdezesbutton);
            this.feltoltestabPage.Controls.Add(this.feltoltestextBox);
            this.feltoltestabPage.Controls.Add(this.feltoltesbutton);
            this.feltoltestabPage.Location = new System.Drawing.Point(4, 25);
            this.feltoltestabPage.Name = "feltoltestabPage";
            this.feltoltestabPage.Padding = new System.Windows.Forms.Padding(3);
            this.feltoltestabPage.Size = new System.Drawing.Size(719, 278);
            this.feltoltestabPage.TabIndex = 1;
            this.feltoltestabPage.Text = "Egyenleg feltöltése";
            this.feltoltestabPage.UseVisualStyleBackColor = true;
            // 
            // osszeglabel
            // 
            this.osszeglabel.AutoSize = true;
            this.osszeglabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.osszeglabel.Location = new System.Drawing.Point(466, 103);
            this.osszeglabel.Name = "osszeglabel";
            this.osszeglabel.Size = new System.Drawing.Size(0, 20);
            this.osszeglabel.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(102, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Az Ön egyenlege:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(307, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Összeg:";
            // 
            // lekerdezesbutton
            // 
            this.lekerdezesbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lekerdezesbutton.Location = new System.Drawing.Point(248, 28);
            this.lekerdezesbutton.Name = "lekerdezesbutton";
            this.lekerdezesbutton.Size = new System.Drawing.Size(205, 42);
            this.lekerdezesbutton.TabIndex = 2;
            this.lekerdezesbutton.Text = "Egyenleg lekérdezése";
            this.lekerdezesbutton.UseVisualStyleBackColor = true;
            this.lekerdezesbutton.Click += new System.EventHandler(this.lekerdezesbutton_Click);
            // 
            // feltoltestextBox
            // 
            this.feltoltestextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.feltoltestextBox.Location = new System.Drawing.Point(277, 168);
            this.feltoltestextBox.Name = "feltoltestextBox";
            this.feltoltestextBox.Size = new System.Drawing.Size(128, 26);
            this.feltoltestextBox.TabIndex = 1;
            // 
            // feltoltesbutton
            // 
            this.feltoltesbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.feltoltesbutton.Location = new System.Drawing.Point(292, 200);
            this.feltoltesbutton.Name = "feltoltesbutton";
            this.feltoltesbutton.Size = new System.Drawing.Size(93, 32);
            this.feltoltesbutton.TabIndex = 0;
            this.feltoltesbutton.Text = "Feltöltés";
            this.feltoltesbutton.UseVisualStyleBackColor = true;
            this.feltoltesbutton.Click += new System.EventHandler(this.feltoltesbutton_Click);
            // 
            // utalastabPage
            // 
            this.utalastabPage.Controls.Add(this.utalasinfolabel);
            this.utalastabPage.Controls.Add(this.label6);
            this.utalastabPage.Controls.Add(this.label5);
            this.utalastabPage.Controls.Add(this.mennyittextBox);
            this.utalastabPage.Controls.Add(this.kinektextBox);
            this.utalastabPage.Controls.Add(this.utalasbutton);
            this.utalastabPage.Location = new System.Drawing.Point(4, 25);
            this.utalastabPage.Name = "utalastabPage";
            this.utalastabPage.Padding = new System.Windows.Forms.Padding(3);
            this.utalastabPage.Size = new System.Drawing.Size(719, 278);
            this.utalastabPage.TabIndex = 2;
            this.utalastabPage.Text = "Utalás";
            this.utalastabPage.UseVisualStyleBackColor = true;
            // 
            // utalasinfolabel
            // 
            this.utalasinfolabel.AutoSize = true;
            this.utalasinfolabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.utalasinfolabel.Location = new System.Drawing.Point(130, 187);
            this.utalasinfolabel.Name = "utalasinfolabel";
            this.utalasinfolabel.Size = new System.Drawing.Size(0, 20);
            this.utalasinfolabel.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(99, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Kinek:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(347, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Összeg:";
            // 
            // mennyittextBox
            // 
            this.mennyittextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.mennyittextBox.Location = new System.Drawing.Point(436, 36);
            this.mennyittextBox.Name = "mennyittextBox";
            this.mennyittextBox.Size = new System.Drawing.Size(100, 26);
            this.mennyittextBox.TabIndex = 8;
            // 
            // kinektextBox
            // 
            this.kinektextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.kinektextBox.Location = new System.Drawing.Point(176, 36);
            this.kinektextBox.Name = "kinektextBox";
            this.kinektextBox.Size = new System.Drawing.Size(100, 26);
            this.kinektextBox.TabIndex = 7;
            // 
            // utalasbutton
            // 
            this.utalasbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.utalasbutton.Location = new System.Drawing.Point(278, 103);
            this.utalasbutton.Name = "utalasbutton";
            this.utalasbutton.Size = new System.Drawing.Size(93, 32);
            this.utalasbutton.TabIndex = 6;
            this.utalasbutton.Text = "Utalás";
            this.utalasbutton.UseVisualStyleBackColor = true;
            this.utalasbutton.Click += new System.EventHandler(this.utalasbutton_Click);
            // 
            // utalaselozmenytabPage
            // 
            this.utalaselozmenytabPage.Controls.Add(this.lekerdezbutton);
            this.utalaselozmenytabPage.Controls.Add(this.listView1);
            this.utalaselozmenytabPage.Location = new System.Drawing.Point(4, 25);
            this.utalaselozmenytabPage.Name = "utalaselozmenytabPage";
            this.utalaselozmenytabPage.Padding = new System.Windows.Forms.Padding(3);
            this.utalaselozmenytabPage.Size = new System.Drawing.Size(719, 278);
            this.utalaselozmenytabPage.TabIndex = 3;
            this.utalaselozmenytabPage.Text = "Utalási előzmények";
            this.utalaselozmenytabPage.UseVisualStyleBackColor = true;
            // 
            // lekerdezbutton
            // 
            this.lekerdezbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lekerdezbutton.Location = new System.Drawing.Point(272, 188);
            this.lekerdezbutton.Name = "lekerdezbutton";
            this.lekerdezbutton.Size = new System.Drawing.Size(116, 37);
            this.lekerdezbutton.TabIndex = 1;
            this.lekerdezbutton.Text = "Lekérdez";
            this.lekerdezbutton.UseVisualStyleBackColor = true;
            this.lekerdezbutton.Click += new System.EventHandler(this.lekerdezbutton_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Kinek,
            this.Mikor,
            this.Osszeg});
            this.listView1.Location = new System.Drawing.Point(121, 27);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(470, 155);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // Kinek
            // 
            this.Kinek.Text = "Kinek";
            this.Kinek.Width = 125;
            // 
            // Mikor
            // 
            this.Mikor.Text = "Mikor";
            this.Mikor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Mikor.Width = 257;
            // 
            // Osszeg
            // 
            this.Osszeg.Text = "Összeg";
            this.Osszeg.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Osszeg.Width = 84;
            // 
            // kijelentkezesbutton
            // 
            this.kijelentkezesbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.kijelentkezesbutton.Location = new System.Drawing.Point(619, 12);
            this.kijelentkezesbutton.Name = "kijelentkezesbutton";
            this.kijelentkezesbutton.Size = new System.Drawing.Size(129, 33);
            this.kijelentkezesbutton.TabIndex = 1;
            this.kijelentkezesbutton.Text = "Kijelentkezés";
            this.kijelentkezesbutton.UseVisualStyleBackColor = true;
            this.kijelentkezesbutton.Click += new System.EventHandler(this.kijelentkezesbutton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 359);
            this.Controls.Add(this.kijelentkezesbutton);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Bank Rendszer";
            this.tabControl1.ResumeLayout(false);
            this.bejelentkezestabPage.ResumeLayout(false);
            this.bejelentkezestabPage.PerformLayout();
            this.feltoltestabPage.ResumeLayout(false);
            this.feltoltestabPage.PerformLayout();
            this.utalastabPage.ResumeLayout(false);
            this.utalastabPage.PerformLayout();
            this.utalaselozmenytabPage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage bejelentkezestabPage;
        private System.Windows.Forms.TabPage feltoltestabPage;
        private System.Windows.Forms.Button kijelentkezesbutton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox jelszotextBox;
        private System.Windows.Forms.TextBox felhnevtextBox;
        private System.Windows.Forms.Button bejelentkezesbutton;
        private System.Windows.Forms.Button lekerdezesbutton;
        private System.Windows.Forms.TextBox feltoltestextBox;
        private System.Windows.Forms.Button feltoltesbutton;
        private System.Windows.Forms.TabPage utalastabPage;
        private System.Windows.Forms.TabPage utalaselozmenytabPage;
        private System.Windows.Forms.TextBox mennyittextBox;
        private System.Windows.Forms.TextBox kinektextBox;
        private System.Windows.Forms.Button utalasbutton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label osszeglabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label utalasinfolabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button lekerdezbutton;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Kinek;
        private System.Windows.Forms.ColumnHeader Mikor;
        private System.Windows.Forms.ColumnHeader Osszeg;
    }
}

