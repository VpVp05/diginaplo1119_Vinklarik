namespace diginaplo1119_Vinklarik
{
    partial class Form1
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
            dataGridView1 = new DataGridView();
            Nev = new DataGridViewTextBoxColumn();
            otos = new DataGridViewTextBoxColumn();
            negyes = new DataGridViewTextBoxColumn();
            harmas = new DataGridViewTextBoxColumn();
            kettes = new DataGridViewTextBoxColumn();
            egyes = new DataGridViewTextBoxColumn();
            atlag = new DataGridViewTextBoxColumn();
            pontszam = new DataGridViewTextBoxColumn();
            lbatlagalatt = new Label();
            lbatlagpont = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            panel1 = new Panel();
            txnev = new TextBox();
            txot = new TextBox();
            txnegy = new TextBox();
            txharom = new TextBox();
            txketto = new TextBox();
            txegy = new TextBox();
            btmentes = new Button();
            rtbatlagpontalatt = new RichTextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Nev, otos, negyes, harmas, kettes, egyes, atlag, pontszam });
            dataGridView1.Location = new Point(23, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(858, 449);
            dataGridView1.TabIndex = 0;
            // 
            // Nev
            // 
            Nev.HeaderText = "Név";
            Nev.Name = "Nev";
            Nev.ReadOnly = true;
            // 
            // otos
            // 
            otos.HeaderText = "5 [db]";
            otos.Name = "otos";
            otos.ReadOnly = true;
            // 
            // negyes
            // 
            negyes.HeaderText = "4 [db]";
            negyes.Name = "negyes";
            negyes.ReadOnly = true;
            // 
            // harmas
            // 
            harmas.HeaderText = "3 [db]";
            harmas.Name = "harmas";
            harmas.ReadOnly = true;
            // 
            // kettes
            // 
            kettes.HeaderText = "2 [db]";
            kettes.Name = "kettes";
            kettes.ReadOnly = true;
            // 
            // egyes
            // 
            egyes.HeaderText = "1 [db]";
            egyes.Name = "egyes";
            egyes.ReadOnly = true;
            // 
            // atlag
            // 
            atlag.HeaderText = "Átlag";
            atlag.Name = "atlag";
            atlag.ReadOnly = true;
            // 
            // pontszam
            // 
            pontszam.HeaderText = "Pontszám";
            pontszam.Name = "pontszam";
            pontszam.ReadOnly = true;
            // 
            // lbatlagalatt
            // 
            lbatlagalatt.AutoSize = true;
            lbatlagalatt.Location = new Point(22, 48);
            lbatlagalatt.Name = "lbatlagalatt";
            lbatlagalatt.Size = new Size(172, 15);
            lbatlagalatt.TabIndex = 9;
            lbatlagalatt.Text = "Átlag pontszám alatti tanulók:";
            // 
            // lbatlagpont
            // 
            lbatlagpont.AutoSize = true;
            lbatlagpont.Location = new Point(22, 19);
            lbatlagpont.Name = "lbatlagpont";
            lbatlagpont.Size = new Size(108, 15);
            lbatlagpont.TabIndex = 8;
            lbatlagpont.Text = "Átlagos pontszám:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(910, 28);
            label1.Name = "label1";
            label1.Size = new Size(33, 15);
            label1.TabIndex = 2;
            label1.Text = "Név:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(910, 75);
            label2.Name = "label2";
            label2.Size = new Size(87, 15);
            label2.TabIndex = 3;
            label2.Text = "Ötösök száma:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(910, 114);
            label3.Name = "label3";
            label3.Size = new Size(102, 15);
            label3.TabIndex = 4;
            label3.Text = "Négyesek száma:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(910, 153);
            label4.Name = "label4";
            label4.Size = new Size(103, 15);
            label4.TabIndex = 5;
            label4.Text = "Hármasok száma:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(910, 194);
            label5.Name = "label5";
            label5.Size = new Size(98, 15);
            label5.TabIndex = 6;
            label5.Text = "Kettesek száma:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(910, 232);
            label6.Name = "label6";
            label6.Size = new Size(92, 15);
            label6.TabIndex = 7;
            label6.Text = "Egyesek száma:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gray;
            panel1.Controls.Add(rtbatlagpontalatt);
            panel1.Controls.Add(lbatlagpont);
            panel1.Controls.Add(lbatlagalatt);
            panel1.Location = new Point(910, 282);
            panel1.Name = "panel1";
            panel1.Size = new Size(307, 179);
            panel1.TabIndex = 8;
            // 
            // txnev
            // 
            txnev.Location = new Point(947, 28);
            txnev.Name = "txnev";
            txnev.Size = new Size(280, 23);
            txnev.TabIndex = 9;
            // 
            // txot
            // 
            txot.BackColor = SystemColors.Window;
            txot.Location = new Point(1017, 72);
            txot.Name = "txot";
            txot.Size = new Size(100, 23);
            txot.TabIndex = 10;
            // 
            // txnegy
            // 
            txnegy.Location = new Point(1017, 106);
            txnegy.Name = "txnegy";
            txnegy.Size = new Size(100, 23);
            txnegy.TabIndex = 11;
            // 
            // txharom
            // 
            txharom.Location = new Point(1017, 150);
            txharom.Name = "txharom";
            txharom.Size = new Size(100, 23);
            txharom.TabIndex = 12;
            // 
            // txketto
            // 
            txketto.Location = new Point(1017, 194);
            txketto.Name = "txketto";
            txketto.Size = new Size(100, 23);
            txketto.TabIndex = 13;
            // 
            // txegy
            // 
            txegy.Location = new Point(1017, 229);
            txegy.Name = "txegy";
            txegy.Size = new Size(100, 23);
            txegy.TabIndex = 14;
            // 
            // btmentes
            // 
            btmentes.Location = new Point(1165, 75);
            btmentes.Name = "btmentes";
            btmentes.Size = new Size(80, 134);
            btmentes.TabIndex = 15;
            btmentes.Text = "Mentés";
            btmentes.UseVisualStyleBackColor = true;
            // 
            // rtbatlagpontalatt
            // 
            rtbatlagpontalatt.BackColor = Color.Silver;
            rtbatlagpontalatt.Location = new Point(22, 66);
            rtbatlagpontalatt.Name = "rtbatlagpontalatt";
            rtbatlagpontalatt.Size = new Size(217, 96);
            rtbatlagpontalatt.TabIndex = 10;
            rtbatlagpontalatt.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1311, 472);
            Controls.Add(btmentes);
            Controls.Add(txegy);
            Controls.Add(txketto);
            Controls.Add(txharom);
            Controls.Add(txnegy);
            Controls.Add(txot);
            Controls.Add(txnev);
            Controls.Add(panel1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            Name = "Form1";
            Text = "DigiNapló";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Nev;
        private DataGridViewTextBoxColumn otos;
        private DataGridViewTextBoxColumn negyes;
        private DataGridViewTextBoxColumn harmas;
        private DataGridViewTextBoxColumn kettes;
        private DataGridViewTextBoxColumn egyes;
        private DataGridViewTextBoxColumn atlag;
        private DataGridViewTextBoxColumn pontszam;
        private Label lbatlagalatt;
        private Label lbatlagpont;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Panel panel1;
        private RichTextBox rtbatlagpontalatt;
        private TextBox txnev;
        private TextBox txot;
        private TextBox txnegy;
        private TextBox txharom;
        private TextBox txketto;
        private TextBox txegy;
        private Button btmentes;
    }
}
