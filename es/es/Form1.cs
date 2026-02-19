using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace es
{
    public partial class Form1 : Form
    {
        private StudentList studentList;
        private string filePath = "students.dat";

        public Form1()
        {
            InitializeComponent();
            studentList = new StudentList();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            studentList.LoadFromFile(filePath);
            RefreshGrid();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            studentList.SaveToFile(filePath);
        }

        private void btnInserisci_Click(object sender, EventArgs e)
        {
            if (ValidateInputs())
            {
                Student s = new Student(txtNome.Text, txtCognome.Text, txtID.Text, txtClasse.Text);
                studentList.Insert(s);
                ClearInputs();
                RefreshGrid();
                MessageBox.Show("Studente inserito correttamente.");
            }
        }

        private void btnCerca_Click(object sender, EventArgs e)
        {
            string id = txtID.Text;
            if (string.IsNullOrWhiteSpace(id))
            {
                MessageBox.Show("Inserire un Codice ID per la ricerca.");
                return;
            }

            Student s = studentList.Search(id);
            if (s != null)
            {
                txtNome.Text = s.Nome;
                txtCognome.Text = s.Cognome;
                txtClasse.Text = s.Classe;
                MessageBox.Show($"Studente trovato: {s.Nome} {s.Cognome}");
            }
            else
            {
                MessageBox.Show("Studente non trovato.");
            }
        }

        private void btnElimina_Click(object sender, EventArgs e)
        {
            string id = txtID.Text;
            if (string.IsNullOrWhiteSpace(id))
            {
                MessageBox.Show("Inserire un Codice ID per l'eliminazione.");
                return;
            }

            if (studentList.Remove(id))
            {
                ClearInputs();
                RefreshGrid();
                MessageBox.Show("Studente eliminato.");
            }
            else
            {
                MessageBox.Show("Studente non trovato.");
            }
        }

        private void btnAggiorna_Click(object sender, EventArgs e)
        {
            string id = txtID.Text;
            if (ValidateInputs())
            {
                Student s = new Student(txtNome.Text, txtCognome.Text, txtID.Text, txtClasse.Text);
                if (studentList.Update(id, s))
                {
                    RefreshGrid();
                    MessageBox.Show("Informazioni aggiornate.");
                }
                else
                {
                    MessageBox.Show("Studente non trovato per l'aggiornamento.");
                }
            }
        }

        private void btnVisualizzaCrescente_Click(object sender, EventArgs e)
        {
            RefreshGrid(true);
        }

        private void btnVisualizzaDecrescente_Click(object sender, EventArgs e)
        {
            RefreshGrid(false);
        }

        private void btnTermina_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void RefreshGrid(bool ascending = true)
        {
            dgvStudents.DataSource = null;
            if (ascending)
            {
                dgvStudents.DataSource = studentList.GetAllAscending();
            }
            else
            {
                dgvStudents.DataSource = studentList.GetAllDescending();
            }
        }

        private bool ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(txtNome.Text) ||
                string.IsNullOrWhiteSpace(txtCognome.Text) ||
                string.IsNullOrWhiteSpace(txtID.Text) ||
                string.IsNullOrWhiteSpace(txtClasse.Text))
            {
                MessageBox.Show("Tutti i campi sono obbligatori.");
                return false;
            }
            return true;
        }

        private void ClearInputs()
        {
            txtNome.Clear();
            txtCognome.Clear();
            txtID.Clear();
            txtClasse.Clear();
        }
    }
}
