namespace es
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.dgvStudents = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtClasse = new System.Windows.Forms.TextBox();
            this.txtCognome = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnInserisci = new System.Windows.Forms.Button();
            this.btnCerca = new System.Windows.Forms.Button();
            this.btnElimina = new System.Windows.Forms.Button();
            this.btnAggiorna = new System.Windows.Forms.Button();
            this.btnVisualizzaCrescente = new System.Windows.Forms.Button();
            this.btnVisualizzaDecrescente = new System.Windows.Forms.Button();
            this.btnTermina = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvStudents
            // 
            this.dgvStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudents.Location = new System.Drawing.Point(344, 25);
            this.dgvStudents.MultiSelect = false;
            this.dgvStudents.Name = "dgvStudents";
            this.dgvStudents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStudents.Size = new System.Drawing.Size(430, 400);
            this.dgvStudents.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtID);
            this.groupBox1.Controls.Add(this.txtClasse);
            this.groupBox1.Controls.Add(this.txtCognome);
            this.groupBox1.Controls.Add(this.txtNome);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(25, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(300, 180);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informazioni Studente";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(100, 100);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(180, 25);
            this.txtID.TabIndex = 7;
            // 
            // txtClasse
            // 
            this.txtClasse.Location = new System.Drawing.Point(100, 135);
            this.txtClasse.Name = "txtClasse";
            this.txtClasse.Size = new System.Drawing.Size(180, 25);
            this.txtClasse.TabIndex = 6;
            // 
            // txtCognome
            // 
            this.txtCognome.Location = new System.Drawing.Point(100, 65);
            this.txtCognome.Name = "txtCognome";
            this.txtCognome.Size = new System.Drawing.Size(180, 25);
            this.txtCognome.TabIndex = 5;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(100, 30);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(180, 25);
            this.txtNome.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Classe:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Codice ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cognome:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // btnInserisci
            // 
            this.btnInserisci.BackColor = System.Drawing.Color.PaleGreen;
            this.btnInserisci.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInserisci.Location = new System.Drawing.Point(25, 220);
            this.btnInserisci.Name = "btnInserisci";
            this.btnInserisci.Size = new System.Drawing.Size(140, 35);
            this.btnInserisci.TabIndex = 2;
            this.btnInserisci.Text = "1- Inserisci";
            this.btnInserisci.UseVisualStyleBackColor = false;
            this.btnInserisci.Click += new System.EventHandler(this.btnInserisci_Click);
            // 
            // btnCerca
            // 
            this.btnCerca.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnCerca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerca.Location = new System.Drawing.Point(185, 220);
            this.btnCerca.Name = "btnCerca";
            this.btnCerca.Size = new System.Drawing.Size(140, 35);
            this.btnCerca.TabIndex = 3;
            this.btnCerca.Text = "2- Cerca";
            this.btnCerca.UseVisualStyleBackColor = false;
            this.btnCerca.Click += new System.EventHandler(this.btnCerca_Click);
            // 
            // btnElimina
            // 
            this.btnElimina.BackColor = System.Drawing.Color.LightCoral;
            this.btnElimina.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnElimina.Location = new System.Drawing.Point(25, 265);
            this.btnElimina.Name = "btnElimina";
            this.btnElimina.Size = new System.Drawing.Size(140, 35);
            this.btnElimina.TabIndex = 4;
            this.btnElimina.Text = "3- Elimina";
            this.btnElimina.UseVisualStyleBackColor = false;
            this.btnElimina.Click += new System.EventHandler(this.btnElimina_Click);
            // 
            // btnAggiorna
            // 
            this.btnAggiorna.BackColor = System.Drawing.Color.NavajoWhite;
            this.btnAggiorna.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAggiorna.Location = new System.Drawing.Point(185, 265);
            this.btnAggiorna.Name = "btnAggiorna";
            this.btnAggiorna.Size = new System.Drawing.Size(140, 35);
            this.btnAggiorna.TabIndex = 5;
            this.btnAggiorna.Text = "4- Aggiorna";
            this.btnAggiorna.UseVisualStyleBackColor = false;
            this.btnAggiorna.Click += new System.EventHandler(this.btnAggiorna_Click);
            // 
            // btnVisualizzaCrescente
            // 
            this.btnVisualizzaCrescente.Location = new System.Drawing.Point(25, 310);
            this.btnVisualizzaCrescente.Name = "btnVisualizzaCrescente";
            this.btnVisualizzaCrescente.Size = new System.Drawing.Size(300, 35);
            this.btnVisualizzaCrescente.TabIndex = 6;
            this.btnVisualizzaCrescente.Text = "5- Visualizza Ordinato";
            this.btnVisualizzaCrescente.UseVisualStyleBackColor = true;
            this.btnVisualizzaCrescente.Click += new System.EventHandler(this.btnVisualizzaCrescente_Click);
            // 
            // btnVisualizzaDecrescente
            // 
            this.btnVisualizzaDecrescente.Location = new System.Drawing.Point(25, 355);
            this.btnVisualizzaDecrescente.Name = "btnVisualizzaDecrescente";
            this.btnVisualizzaDecrescente.Size = new System.Drawing.Size(300, 35);
            this.btnVisualizzaDecrescente.TabIndex = 7;
            this.btnVisualizzaDecrescente.Text = "6- Visualizza Decrescente";
            this.btnVisualizzaDecrescente.UseVisualStyleBackColor = true;
            this.btnVisualizzaDecrescente.Click += new System.EventHandler(this.btnVisualizzaDecrescente_Click);
            // 
            // btnTermina
            // 
            this.btnTermina.BackColor = System.Drawing.Color.LightGray;
            this.btnTermina.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTermina.Location = new System.Drawing.Point(25, 400);
            this.btnTermina.Name = "btnTermina";
            this.btnTermina.Size = new System.Drawing.Size(300, 35);
            this.btnTermina.TabIndex = 8;
            this.btnTermina.Text = "7- Termina";
            this.btnTermina.UseVisualStyleBackColor = false;
            this.btnTermina.Click += new System.EventHandler(this.btnTermina_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnTermina);
            this.Controls.Add(this.btnVisualizzaDecrescente);
            this.Controls.Add(this.btnVisualizzaCrescente);
            this.Controls.Add(this.btnAggiorna);
            this.Controls.Add(this.btnElimina);
            this.Controls.Add(this.btnCerca);
            this.Controls.Add(this.btnInserisci);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvStudents);
            this.Name = "Form1";
            this.Text = "Gestione Studenti - Double Linked List";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.DataGridView dgvStudents;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtClasse;
        private System.Windows.Forms.TextBox txtCognome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnInserisci;
        private System.Windows.Forms.Button btnCerca;
        private System.Windows.Forms.Button btnElimina;
        private System.Windows.Forms.Button btnAggiorna;
        private System.Windows.Forms.Button btnVisualizzaCrescente;
        private System.Windows.Forms.Button btnVisualizzaDecrescente;
        private System.Windows.Forms.Button btnTermina;
    }
}
