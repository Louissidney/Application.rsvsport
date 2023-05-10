namespace rsvsport_logiciel
{
    partial class Tennis
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
            IdStade = new Label();
            label1 = new Label();
            button3 = new Button();
            label5 = new Label();
            Enregistrer = new Button();
            Supprimer = new Button();
            modifierBtn = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            panel1 = new Panel();
            label10 = new Label();
            label15 = new Label();
            label14 = new Label();
            Deconnection = new Label();
            label9 = new Label();
            label6 = new Label();
            backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            backgroundWorker3 = new System.ComponentModel.BackgroundWorker();
            backgroundWorker4 = new System.ComponentModel.BackgroundWorker();
            dataGridView1 = new DataGridView();
            IdTypeStade = new ComboBox();
            panel2 = new Panel();
            label4 = new Label();
            NomStades = new ComboBox();
            Comm = new Label();
            Commentaire = new TextBox();
            user = new ComboBox();
            label3 = new Label();
            label12 = new Label();
            label13 = new Label();
            label20 = new Label();
            label16 = new Label();
            label21 = new Label();
            label22 = new Label();
            label23 = new Label();
            panel3 = new Panel();
            panel4 = new Panel();
            panel5 = new Panel();
            label17 = new Label();
            label7 = new Label();
            panel6 = new Panel();
            panel7 = new Panel();
            panel8 = new Panel();
            label2 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label19 = new Label();
            label11 = new Label();
            label8 = new Label();
            DebutTimePicker = new DateTimePicker();
            FinTimePicker = new DateTimePicker();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            SuspendLayout();
            // 
            // IdStade
            // 
            IdStade.AutoSize = true;
            IdStade.Font = new Font("Mongolian Baiti", 12F, FontStyle.Regular, GraphicsUnit.Point);
            IdStade.Location = new Point(190, 80);
            IdStade.Margin = new Padding(2, 0, 2, 0);
            IdStade.Name = "IdStade";
            IdStade.Size = new Size(40, 16);
            IdStade.TabIndex = 87;
            IdStade.Text = "Type";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Mongolian Baiti", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(458, 78);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(60, 16);
            label1.TabIndex = 82;
            label1.Text = "Id_stade";
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(128, 128, 255);
            button3.ForeColor = Color.Black;
            button3.Location = new Point(331, 384);
            button3.Margin = new Padding(2);
            button3.Name = "button3";
            button3.Size = new Size(111, 36);
            button3.TabIndex = 81;
            button3.Text = "Actualiser";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Mongolian Baiti", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(179, 403);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.RightToLeft = RightToLeft.Yes;
            label5.Size = new Size(148, 16);
            label5.TabIndex = 80;
            label5.Text = "Listes des réservations";
            // 
            // Enregistrer
            // 
            Enregistrer.BackColor = Color.FromArgb(128, 128, 255);
            Enregistrer.ForeColor = Color.Black;
            Enregistrer.Location = new Point(763, 337);
            Enregistrer.Margin = new Padding(2);
            Enregistrer.Name = "Enregistrer";
            Enregistrer.Size = new Size(111, 36);
            Enregistrer.TabIndex = 78;
            Enregistrer.Text = "Enregistrer";
            Enregistrer.UseVisualStyleBackColor = false;
            Enregistrer.Click += Enregistrer_Click;
            // 
            // Supprimer
            // 
            Supprimer.BackColor = Color.Red;
            Supprimer.ForeColor = Color.Black;
            Supprimer.Location = new Point(888, 337);
            Supprimer.Margin = new Padding(2);
            Supprimer.Name = "Supprimer";
            Supprimer.Size = new Size(111, 36);
            Supprimer.TabIndex = 77;
            Supprimer.Text = "Supprimer";
            Supprimer.UseVisualStyleBackColor = false;
            Supprimer.Click += Supprimer_Click;
            // 
            // modifierBtn
            // 
            modifierBtn.BackColor = Color.FromArgb(128, 128, 255);
            modifierBtn.ForeColor = Color.Black;
            modifierBtn.Location = new Point(632, 337);
            modifierBtn.Margin = new Padding(2);
            modifierBtn.Name = "modifierBtn";
            modifierBtn.Size = new Size(111, 36);
            modifierBtn.TabIndex = 76;
            modifierBtn.Text = "Modifier";
            modifierBtn.UseVisualStyleBackColor = false;
            modifierBtn.Click += modifierBtn_Click_1;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 0, 192);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(label15);
            panel1.Controls.Add(label14);
            panel1.Controls.Add(Deconnection);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label6);
            panel1.Location = new Point(0, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(159, 805);
            panel1.TabIndex = 72;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.FromArgb(255, 192, 192);
            label10.Font = new Font("Nirmala UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(11, 730);
            label10.Margin = new Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new Size(131, 25);
            label10.TabIndex = 104;
            label10.Text = "Déconnexion";
            label10.Click += label10_Click;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.BackColor = Color.FromArgb(0, 0, 192);
            label15.Font = new Font("Nirmala UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label15.Location = new Point(11, 325);
            label15.Margin = new Padding(2, 0, 2, 0);
            label15.Name = "label15";
            label15.Size = new Size(70, 25);
            label15.TabIndex = 97;
            label15.Text = "Rugby";
            label15.Click += label15_Click;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = Color.FromArgb(0, 0, 192);
            label14.Font = new Font("Nirmala UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label14.Location = new Point(11, 367);
            label14.Margin = new Padding(2, 0, 2, 0);
            label14.Name = "label14";
            label14.Size = new Size(85, 25);
            label14.TabIndex = 96;
            label14.Text = "Football";
            label14.Click += label14_Click;
            // 
            // Deconnection
            // 
            Deconnection.Location = new Point(0, 0);
            Deconnection.Name = "Deconnection";
            Deconnection.Size = new Size(100, 23);
            Deconnection.TabIndex = 105;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.FromArgb(0, 0, 192);
            label9.Font = new Font("Nirmala UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(11, 415);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(69, 25);
            label9.TabIndex = 36;
            label9.Text = "Profils";
            label9.Click += label9_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Blue;
            label6.Font = new Font("Nirmala UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(11, 281);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(68, 25);
            label6.TabIndex = 33;
            label6.Text = "Tennis";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.DarkGray;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(180, 425);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(872, 367);
            dataGridView1.TabIndex = 74;
            // 
            // IdTypeStade
            // 
            IdTypeStade.BackColor = Color.Silver;
            IdTypeStade.DropDownStyle = ComboBoxStyle.DropDownList;
            IdTypeStade.FormattingEnabled = true;
            IdTypeStade.Items.AddRange(new object[] { "1 " });
            IdTypeStade.Location = new Point(190, 97);
            IdTypeStade.Name = "IdTypeStade";
            IdTypeStade.Size = new Size(119, 31);
            IdTypeStade.TabIndex = 95;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(128, 128, 255);
            panel2.Controls.Add(label4);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1064, 57);
            panel2.TabIndex = 110;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Mongolian Baiti", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(370, 21);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(420, 23);
            label4.TabIndex = 73;
            label4.Text = "Gestion des réservations de stade de Tennis";
            // 
            // NomStades
            // 
            NomStades.BackColor = Color.Silver;
            NomStades.DropDownStyle = ComboBoxStyle.DropDownList;
            NomStades.FormattingEnabled = true;
            NomStades.Items.AddRange(new object[] { "1 ", "3 " });
            NomStades.Location = new Point(458, 97);
            NomStades.Name = "NomStades";
            NomStades.Size = new Size(205, 31);
            NomStades.TabIndex = 121;
            // 
            // Comm
            // 
            Comm.AutoSize = true;
            Comm.Location = new Point(740, 220);
            Comm.Name = "Comm";
            Comm.Size = new Size(102, 23);
            Comm.TabIndex = 123;
            Comm.Text = "Commentaire :";
            // 
            // Commentaire
            // 
            Commentaire.Location = new Point(740, 245);
            Commentaire.Multiline = true;
            Commentaire.Name = "Commentaire";
            Commentaire.Size = new Size(312, 60);
            Commentaire.TabIndex = 124;
            // 
            // user
            // 
            user.BackColor = Color.Silver;
            user.DropDownStyle = ComboBoxStyle.DropDownList;
            user.FormattingEnabled = true;
            user.Items.AddRange(new object[] { "18", "1", "2", "23" });
            user.Location = new Point(817, 97);
            user.Name = "user";
            user.Size = new Size(96, 31);
            user.TabIndex = 128;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Mongolian Baiti", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(817, 80);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(53, 16);
            label3.TabIndex = 127;
            label3.Text = "id_user";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.FromArgb(192, 192, 255);
            label12.Font = new Font("Mongolian Baiti", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(668, 107);
            label12.Margin = new Padding(2, 0, 2, 0);
            label12.Name = "label12";
            label12.Size = new Size(106, 14);
            label12.TabIndex = 134;
            label12.Text = "1 = Roland-Garros";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.FromArgb(192, 192, 255);
            label13.Font = new Font("Mongolian Baiti", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(668, 126);
            label13.Margin = new Padding(2, 0, 2, 0);
            label13.Name = "label13";
            label13.Size = new Size(75, 14);
            label13.TabIndex = 137;
            label13.Text = "3 = US Open";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.BackColor = Color.FromArgb(192, 192, 255);
            label20.Font = new Font("Mongolian Baiti", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label20.Location = new Point(140, 9);
            label20.Margin = new Padding(2, 0, 2, 0);
            label20.Name = "label20";
            label20.Size = new Size(64, 14);
            label20.TabIndex = 138;
            label20.Text = "1 = Tennis";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.BackColor = Color.FromArgb(192, 192, 255);
            label16.Font = new Font("Mongolian Baiti", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label16.Location = new Point(935, 103);
            label16.Margin = new Padding(2, 0, 2, 0);
            label16.Name = "label16";
            label16.Size = new Size(82, 14);
            label16.TabIndex = 144;
            label16.Text = "18 = admin02";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.BackColor = Color.FromArgb(192, 192, 255);
            label21.Font = new Font("Mongolian Baiti", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label21.Location = new Point(942, 118);
            label21.Margin = new Padding(2, 0, 2, 0);
            label21.Name = "label21";
            label21.Size = new Size(75, 14);
            label21.TabIndex = 141;
            label21.Text = "1 = admin01";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.BackColor = Color.FromArgb(192, 192, 255);
            label22.Font = new Font("Mongolian Baiti", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label22.Location = new Point(943, 134);
            label22.Margin = new Padding(2, 0, 2, 0);
            label22.Name = "label22";
            label22.Size = new Size(63, 14);
            label22.TabIndex = 145;
            label22.Text = "2 = user01";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.BackColor = Color.FromArgb(192, 192, 255);
            label23.Font = new Font("Mongolian Baiti", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label23.Location = new Point(939, 150);
            label23.Margin = new Padding(2, 0, 2, 0);
            label23.Name = "label23";
            label23.Size = new Size(75, 14);
            label23.TabIndex = 146;
            label23.Text = "23= test.user";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(192, 192, 255);
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(panel4);
            panel3.Controls.Add(label20);
            panel3.Location = new Point(190, 97);
            panel3.Name = "panel3";
            panel3.Size = new Size(217, 51);
            panel3.TabIndex = 147;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(192, 192, 255);
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(panel5);
            panel4.Controls.Add(label7);
            panel4.Location = new Point(-1, -1);
            panel4.Name = "panel4";
            panel4.Size = new Size(217, 51);
            panel4.TabIndex = 148;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(192, 192, 255);
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(label17);
            panel5.Location = new Point(-1, -1);
            panel5.Name = "panel5";
            panel5.Size = new Size(217, 51);
            panel5.TabIndex = 148;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.BackColor = Color.FromArgb(192, 192, 255);
            label17.Font = new Font("Mongolian Baiti", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label17.Location = new Point(140, 9);
            label17.Margin = new Padding(2, 0, 2, 0);
            label17.Name = "label17";
            label17.Size = new Size(64, 14);
            label17.TabIndex = 138;
            label17.Text = "1 = Tennis";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.FromArgb(192, 192, 255);
            label7.Font = new Font("Mongolian Baiti", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(140, 9);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(64, 14);
            label7.TabIndex = 138;
            label7.Text = "1 = Tennis";
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(192, 192, 255);
            panel6.BorderStyle = BorderStyle.FixedSingle;
            panel6.Controls.Add(panel7);
            panel6.Location = new Point(458, 97);
            panel6.Name = "panel6";
            panel6.Size = new Size(332, 51);
            panel6.TabIndex = 149;
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(192, 192, 255);
            panel7.BorderStyle = BorderStyle.FixedSingle;
            panel7.Location = new Point(-1, -1);
            panel7.Name = "panel7";
            panel7.Size = new Size(332, 51);
            panel7.TabIndex = 150;
            // 
            // panel8
            // 
            panel8.BackColor = Color.FromArgb(192, 192, 255);
            panel8.BorderStyle = BorderStyle.FixedSingle;
            panel8.Location = new Point(817, 97);
            panel8.Name = "panel8";
            panel8.Size = new Size(209, 74);
            panel8.TabIndex = 150;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Mongolian Baiti", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(425, 290);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(120, 16);
            label2.TabIndex = 156;
            label2.Text = "Fin de réservation";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(210, 279);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(128, 26);
            dateTimePicker1.TabIndex = 155;
            dateTimePicker1.Value = new DateTime(2023, 5, 4, 0, 0, 0, 0);
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Mongolian Baiti", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label19.Location = new Point(210, 257);
            label19.Margin = new Padding(2, 0, 2, 0);
            label19.Name = "label19";
            label19.Size = new Size(106, 16);
            label19.TabIndex = 154;
            label19.Text = "Date disponible";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Mongolian Baiti", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(425, 224);
            label11.Margin = new Padding(2, 0, 2, 0);
            label11.Name = "label11";
            label11.Size = new Size(138, 16);
            label11.TabIndex = 152;
            label11.Text = "Début de réservation";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.White;
            label8.Font = new Font("Mongolian Baiti", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.Red;
            label8.Location = new Point(164, 191);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(601, 14);
            label8.TabIndex = 151;
            label8.Text = "Les créneaux sont imposé pour une durée de 2h ( 08h00-10h00, 10h00-12h00, 14h00-16h00 )";
            // 
            // DebutTimePicker
            // 
            DebutTimePicker.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            DebutTimePicker.Format = DateTimePickerFormat.Time;
            DebutTimePicker.Location = new Point(425, 251);
            DebutTimePicker.Name = "DebutTimePicker";
            DebutTimePicker.ShowUpDown = true;
            DebutTimePicker.Size = new Size(128, 26);
            DebutTimePicker.TabIndex = 158;
            DebutTimePicker.Value = new DateTime(2023, 5, 4, 0, 0, 0, 0);
            // 
            // FinTimePicker
            // 
            FinTimePicker.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FinTimePicker.Format = DateTimePickerFormat.Time;
            FinTimePicker.Location = new Point(425, 309);
            FinTimePicker.Name = "FinTimePicker";
            FinTimePicker.ShowUpDown = true;
            FinTimePicker.Size = new Size(128, 26);
            FinTimePicker.TabIndex = 159;
            FinTimePicker.Value = new DateTime(2023, 5, 4, 0, 0, 0, 0);
            // 
            // Tennis
            // 
            AutoScaleDimensions = new SizeF(8F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1064, 804);
            Controls.Add(FinTimePicker);
            Controls.Add(DebutTimePicker);
            Controls.Add(label2);
            Controls.Add(dateTimePicker1);
            Controls.Add(label19);
            Controls.Add(label11);
            Controls.Add(label8);
            Controls.Add(label23);
            Controls.Add(label22);
            Controls.Add(label16);
            Controls.Add(label21);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(user);
            Controls.Add(label3);
            Controls.Add(Commentaire);
            Controls.Add(Comm);
            Controls.Add(NomStades);
            Controls.Add(panel2);
            Controls.Add(IdTypeStade);
            Controls.Add(IdStade);
            Controls.Add(label1);
            Controls.Add(button3);
            Controls.Add(label5);
            Controls.Add(Enregistrer);
            Controls.Add(Supprimer);
            Controls.Add(modifierBtn);
            Controls.Add(panel1);
            Controls.Add(dataGridView1);
            Controls.Add(panel3);
            Controls.Add(panel6);
            Controls.Add(panel8);
            Font = new Font("Sitka Banner", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(3, 5, 3, 5);
            Name = "Tennis";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel6.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label IdStade;
        private Label label1;
        private Button button3;
        private Label label5;
        private Button Enregistrer;
        private Button Supprimer;
        private Button modifierBtn;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Panel panel1;
        private Label label6;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.ComponentModel.BackgroundWorker backgroundWorker3;
        private System.ComponentModel.BackgroundWorker backgroundWorker4;
        private DataGridView dataGridView1;
        private Label Deconnection;
        private ComboBox IdTypeStade;
        private Panel panel2;
        private Label label4;
        private Label label9;
        private Label label15;
        private Label label14;
        private Label label10;
        private ComboBox NomStades;
        private Label Comm;
        private TextBox Commentaire;
        //private ComboBox comboBox1;
        private ComboBox user;
        private Label label3;
        private Label label12;
        private Label label13;
        private Label label20;
        private Label label16;
        private Label label21;
        private Label label22;
        private Label label23;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Label label17;
        private Label label7;
        private Panel panel6;
        private Panel panel7;
        private Panel panel8;
        private Label label2;
        private DateTimePicker dateTimePicker1;
        private Label label19;
        private Label label11;
        private Label label8;
        private DateTimePicker DebutTimePicker;
        private DateTimePicker FinTimePicker;
    }
}