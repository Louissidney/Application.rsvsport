namespace rsvsport_logiciel
{
    partial class Profils
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
            dataGridView1 = new DataGridView();
            backgroundWorker4 = new System.ComponentModel.BackgroundWorker();
            backgroundWorker3 = new System.ComponentModel.BackgroundWorker();
            backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            panel1 = new Panel();
            label15 = new Label();
            label14 = new Label();
            label9 = new Label();
            label4 = new Label();
            label10 = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            Actualiser = new Button();
            label5 = new Label();
            Enregistrer = new Button();
            Supprimer = new Button();
            Modification = new Button();
            label2 = new Label();
            label1 = new Label();
            nom = new TextBox();
            prenom = new TextBox();
            label3 = new Label();
            email = new TextBox();
            label7 = new Label();
            adresse = new TextBox();
            label8 = new Label();
            label11 = new Label();
            label12 = new Label();
            panel2 = new Panel();
            label13 = new Label();
            telephone = new TextBox();
            passwordTXT = new TextBox();
            label18 = new Label();
            label6 = new Label();
            group = new ComboBox();
            status = new ComboBox();
            label16 = new Label();
            button2 = new Button();
            label17 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(225, 378);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(812, 378);
            dataGridView1.TabIndex = 44;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 0, 192);
            panel1.Controls.Add(label15);
            panel1.Controls.Add(label14);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label10);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(206, 782);
            panel1.TabIndex = 33;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.BackColor = Color.FromArgb(0, 0, 192);
            label15.Font = new Font("Nirmala UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label15.Location = new Point(21, 340);
            label15.Margin = new Padding(2, 0, 2, 0);
            label15.Name = "label15";
            label15.Size = new Size(70, 25);
            label15.TabIndex = 107;
            label15.Text = "Rugby";
            label15.Click += label15_Click;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = Color.FromArgb(0, 0, 192);
            label14.Font = new Font("Nirmala UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label14.Location = new Point(21, 382);
            label14.Margin = new Padding(2, 0, 2, 0);
            label14.Name = "label14";
            label14.Size = new Size(85, 25);
            label14.TabIndex = 106;
            label14.Text = "Football";
            label14.Click += label14_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Blue;
            label9.Font = new Font("Nirmala UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(21, 430);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(69, 25);
            label9.TabIndex = 105;
            label9.Text = "Profils";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(0, 0, 192);
            label4.Font = new Font("Nirmala UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(21, 296);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(68, 25);
            label4.TabIndex = 104;
            label4.Text = "Tennis";
            label4.Click += label4_Click_1;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.FromArgb(255, 192, 192);
            label10.Font = new Font("Nirmala UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(11, 731);
            label10.Margin = new Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new Size(131, 25);
            label10.TabIndex = 103;
            label10.Text = "Déconnexion";
            label10.Click += label10_Click;
            // 
            // Actualiser
            // 
            Actualiser.BackColor = Color.FromArgb(128, 128, 255);
            Actualiser.ForeColor = Color.Black;
            Actualiser.Location = new Point(374, 337);
            Actualiser.Margin = new Padding(2);
            Actualiser.Name = "Actualiser";
            Actualiser.Size = new Size(111, 36);
            Actualiser.TabIndex = 56;
            Actualiser.Text = "Actualiser";
            Actualiser.UseVisualStyleBackColor = false;
            Actualiser.Click += Actualiser_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Mongolian Baiti", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(225, 352);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(115, 16);
            label5.TabIndex = 55;
            label5.Text = "Liste des profils :";
            // 
            // Enregistrer
            // 
            Enregistrer.BackColor = Color.FromArgb(128, 128, 255);
            Enregistrer.ForeColor = Color.Black;
            Enregistrer.Location = new Point(603, 284);
            Enregistrer.Margin = new Padding(2);
            Enregistrer.Name = "Enregistrer";
            Enregistrer.Size = new Size(111, 36);
            Enregistrer.TabIndex = 53;
            Enregistrer.Text = "Enregistrer";
            Enregistrer.UseVisualStyleBackColor = false;
            Enregistrer.Click += Enregistrer_Click;
            // 
            // Supprimer
            // 
            Supprimer.BackColor = Color.Red;
            Supprimer.ForeColor = Color.Black;
            Supprimer.Location = new Point(779, 284);
            Supprimer.Margin = new Padding(2);
            Supprimer.Name = "Supprimer";
            Supprimer.Size = new Size(111, 36);
            Supprimer.TabIndex = 52;
            Supprimer.Text = "Supprimer";
            Supprimer.UseVisualStyleBackColor = false;
            Supprimer.Click += Supprimer_Click;
            // 
            // Modification
            // 
            Modification.BackColor = Color.FromArgb(128, 128, 255);
            Modification.ForeColor = Color.Black;
            Modification.Location = new Point(423, 284);
            Modification.Margin = new Padding(2);
            Modification.Name = "Modification";
            Modification.Size = new Size(111, 36);
            Modification.TabIndex = 51;
            Modification.Text = "Modifier";
            Modification.UseVisualStyleBackColor = false;
            Modification.Click += Modification_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Mongolian Baiti", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(403, 73);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(39, 16);
            label2.TabIndex = 47;
            label2.Text = "Nom";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Mongolian Baiti", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(230, 72);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(61, 16);
            label1.TabIndex = 57;
            label1.Text = "Groupes";
            // 
            // nom
            // 
            nom.Location = new Point(403, 91);
            nom.Margin = new Padding(2);
            nom.Multiline = true;
            nom.Name = "nom";
            nom.Size = new Size(159, 23);
            nom.TabIndex = 60;
            // 
            // prenom
            // 
            prenom.Location = new Point(600, 91);
            prenom.Margin = new Padding(2);
            prenom.Multiline = true;
            prenom.Name = "prenom";
            prenom.Size = new Size(159, 23);
            prenom.TabIndex = 62;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Mongolian Baiti", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(600, 73);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(56, 16);
            label3.TabIndex = 61;
            label3.Text = "Prenom";
            // 
            // email
            // 
            email.Location = new Point(779, 91);
            email.Margin = new Padding(2);
            email.Multiline = true;
            email.Name = "email";
            email.Size = new Size(263, 23);
            email.TabIndex = 65;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Mongolian Baiti", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(779, 73);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(48, 16);
            label7.TabIndex = 64;
            label7.Text = "Email ";
            // 
            // adresse
            // 
            adresse.Location = new Point(403, 172);
            adresse.Margin = new Padding(2);
            adresse.Multiline = true;
            adresse.Name = "adresse";
            adresse.Size = new Size(159, 23);
            adresse.TabIndex = 68;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Mongolian Baiti", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(230, 153);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(74, 16);
            label8.TabIndex = 67;
            label8.Text = "Téléphone";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Mongolian Baiti", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(403, 154);
            label11.Margin = new Padding(2, 0, 2, 0);
            label11.Name = "label11";
            label11.Size = new Size(58, 16);
            label11.TabIndex = 66;
            label11.Text = "Adresse";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Mongolian Baiti", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(600, 153);
            label12.Margin = new Padding(2, 0, 2, 0);
            label12.Name = "label12";
            label12.Size = new Size(45, 16);
            label12.TabIndex = 70;
            label12.Text = "Status";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(128, 128, 255);
            panel2.Controls.Add(label13);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(206, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(858, 57);
            panel2.TabIndex = 72;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Mongolian Baiti", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label13.Location = new Point(334, 18);
            label13.Margin = new Padding(2, 0, 2, 0);
            label13.Name = "label13";
            label13.Size = new Size(189, 23);
            label13.TabIndex = 74;
            label13.Text = "Gestion des profils";
            // 
            // telephone
            // 
            telephone.Location = new Point(229, 172);
            telephone.Margin = new Padding(2);
            telephone.Name = "telephone";
            telephone.Size = new Size(159, 23);
            telephone.TabIndex = 75;
            // 
            // passwordTXT
            // 
            passwordTXT.Location = new Point(779, 172);
            passwordTXT.Margin = new Padding(2);
            passwordTXT.Multiline = true;
            passwordTXT.Name = "passwordTXT";
            passwordTXT.Size = new Size(263, 23);
            passwordTXT.TabIndex = 77;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Mongolian Baiti", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label18.Location = new Point(779, 154);
            label18.Margin = new Padding(2, 0, 2, 0);
            label18.Name = "label18";
            label18.Size = new Size(90, 16);
            label18.TabIndex = 76;
            label18.Text = "Mot de passe";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.White;
            label6.Font = new Font("Mongolian Baiti", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.Red;
            label6.Location = new Point(326, 248);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(679, 16);
            label6.TabIndex = 78;
            label6.Text = "Pour chaque modification effectuée, toutes les données non modifiées doivent être retapées !";
            // 
            // group
            // 
            group.DropDownStyle = ComboBoxStyle.DropDownList;
            group.FormattingEnabled = true;
            group.Items.AddRange(new object[] { "1", "2" });
            group.Location = new Point(230, 91);
            group.Name = "group";
            group.Size = new Size(130, 23);
            group.TabIndex = 145;
            // 
            // status
            // 
            status.DropDownStyle = ComboBoxStyle.DropDownList;
            status.FormattingEnabled = true;
            status.Items.AddRange(new object[] { "0", "1" });
            status.Location = new Point(603, 172);
            status.Name = "status";
            status.Size = new Size(130, 23);
            status.TabIndex = 146;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.BackColor = Color.FromArgb(192, 192, 255);
            label16.Font = new Font("Mongolian Baiti", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label16.Location = new Point(610, 201);
            label16.Margin = new Padding(2, 0, 2, 0);
            label16.Name = "label16";
            label16.Size = new Size(136, 14);
            label16.TabIndex = 150;
            label16.Text = "1 = actif           0= inactif";
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(192, 192, 255);
            button2.Location = new Point(600, 172);
            button2.Name = "button2";
            button2.Size = new Size(159, 51);
            button2.TabIndex = 149;
            button2.UseVisualStyleBackColor = false;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.BackColor = Color.FromArgb(192, 192, 255);
            label17.Font = new Font("Mongolian Baiti", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label17.Location = new Point(239, 121);
            label17.Margin = new Padding(2, 0, 2, 0);
            label17.Name = "label17";
            label17.Size = new Size(130, 14);
            label17.TabIndex = 152;
            label17.Text = "1 = admin         2 = user";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(192, 192, 255);
            button1.Location = new Point(229, 92);
            button1.Name = "button1";
            button1.Size = new Size(159, 51);
            button1.TabIndex = 151;
            button1.UseVisualStyleBackColor = false;
            // 
            // Profils
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1064, 782);
            Controls.Add(label16);
            Controls.Add(status);
            Controls.Add(group);
            Controls.Add(label6);
            Controls.Add(passwordTXT);
            Controls.Add(label18);
            Controls.Add(telephone);
            Controls.Add(panel2);
            Controls.Add(label12);
            Controls.Add(adresse);
            Controls.Add(label8);
            Controls.Add(label11);
            Controls.Add(email);
            Controls.Add(label7);
            Controls.Add(prenom);
            Controls.Add(label3);
            Controls.Add(nom);
            Controls.Add(label1);
            Controls.Add(Actualiser);
            Controls.Add(label5);
            Controls.Add(Enregistrer);
            Controls.Add(Supprimer);
            Controls.Add(Modification);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Controls.Add(button2);
            Controls.Add(label17);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Profils";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form4";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dataGridView1;
        private System.ComponentModel.BackgroundWorker backgroundWorker4;
        private System.ComponentModel.BackgroundWorker backgroundWorker3;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private Panel panel1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button Actualiser;
        private Label label5;
        private Button Enregistrer;
        private Button Supprimer;
        private Label label2;
        private Label label1;
        private TextBox nom;
        private TextBox prenom;
        private Label label3;
        private TextBox email;
        private Label label7;
        private TextBox adresse;
        private Label label8;
        private Label label11;
        private Label label12;
        private Panel panel2;
        private Label label10;
        private Label label15;
        private Label label14;
        private Label label9;
        private Label label4;
        private TextBox telephone;
        private TextBox passwordTXT;
        private Label label18;
        private Label label13;
        private Button Modification;
        private Label label6;
        private ComboBox group;
        private ComboBox status;
        private Label label16;
        private Button button2;
        private Label label17;
        private Button button1;
    }
}