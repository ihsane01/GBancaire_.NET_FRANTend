using FrantGB.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrantGB
{
    public partial class Form1 : Form
    {
        public List<compte> comptes { get; set; }
        public Form1()
        {
            InitializeComponent();

            // Abonnez-vous à l'événement Form.Load
            this.Load += MainForm_Load;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            ChargerComptes();
        }
     
        private async Task ChargerComptes()
        {
            using (HttpClient client = new HttpClient())
            {
                // URL de votre API pour récupérer les comptes
                string apiUrl = "https://localhost:7107/api/Compte/comptes";

                try
                {
                    // Envoyer une requête HTTP GET pour récupérer les comptes
                    HttpResponseMessage response = await client.GetAsync(apiUrl);

                    // Vérifier si la requête a réussi
                    if (response.IsSuccessStatusCode)
                    {
                        // Lire la réponse JSON
                        string jsonResponse = await response.Content.ReadAsStringAsync();

                        // Désérialiser la réponse JSON en une liste de comptes
                        this.comptes = JsonConvert.DeserializeObject<List<Models.compte>>(jsonResponse);

                        // Ajouter les comptes à la liste déroulante
                        comboBoxComptes.DataSource = comptes;
                        comboBoxComptes.DisplayMember = "nom"; // Afficher la propriété "Nom" des comptes
                        comboBoxComptes.ValueMember = "Id"; // Utiliser la propriété "Id" des comptes comme valeur
                    }
                    else
                    {
                        // La requête a échoué
                        MessageBox.Show("Erreur lors de la requête : " + response.StatusCode);
                    }
                }
                catch (Exception ex)
                {
                    // Une erreur s'est produite lors de la requête
                    MessageBox.Show("Erreur lors de la requête : " + ex.Message);
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ok_Click(object sender, EventArgs e)
        {
            if (comboBoxComptes.SelectedItem == null)
            {
                MessageBox.Show("Veuillez sélectionner un compte.");
                return;
            }

            // Récupérer les valeurs sélectionnées par l'utilisateur
            compte compte = comboBoxComptes.SelectedItem as compte;
            bool isCredit = crd.Checked;
            bool isDebit = dbt.Checked;
            float montant; 

            // Vérifier si le montant est valide
            if (!float.TryParse(mnt.Text, out montant))
            {
                MessageBox.Show("Veuillez saisir un montant valide.");
                return;
            }

            // Vérifier si un type de mouvement est sélectionné
            if (!isCredit && !isDebit)
            {
                MessageBox.Show("Veuillez sélectionner un type de mouvement (crédit ou débit).");
                return;
            }

            // Appeler la fonction appropriée en fonction du type de mouvement sélectionné
            if (isCredit)
            {
              
                Crediter(compte.Id, montant);
            }
            else if (isDebit)
            {
                Debiter(compte.Id, montant);
            }
        }


        private async void Crediter(int compteId, float montant)
        {
            using (HttpClient client = new HttpClient())
            {
                string url = $"https://localhost:7107/api/Mouvement/crediter?compteId={compteId}&montant={montant}";

                Console.WriteLine(compteId);
                Console.WriteLine(montant);
                Console.WriteLine("ggggggggggggggggggggggggg");
                HttpContent content = new StringContent(string.Empty);

                HttpResponseMessage response = await client.PostAsync(url, content);
                string responseContent = await response.Content.ReadAsStringAsync();
                Console.WriteLine("dddddddddddd"+responseContent);
                if (response.IsSuccessStatusCode)
                {
                    // Opération de débit réussie
                    MessageBox.Show("Opération de Credite effectuée avec succès.");
                }
                else
                {
                    // Gestion des erreurs
                    MessageBox.Show("Erreur lors de l'opération de Credite.");
                }
            }
        
    }


// ...

private async void Debiter(int compteId, float montant)
    {
        using (HttpClient client = new HttpClient())
        {
            string url = $"https://localhost:7107/api/Mouvement/debiter?compteId={compteId}&montant={montant}";
                HttpContent content = new StringContent(string.Empty);

                HttpResponseMessage response = await client.PostAsync(url, content);


            if (response.IsSuccessStatusCode)
            {
                // Opération de débit réussie
                MessageBox.Show("Opération de débit effectuée avec succès.");
            }
            else
            {
                // Gestion des erreurs
                MessageBox.Show("Erreur lors de l'opération de débit.");
            }
        }
    }

        private void button1_Click(object sender, EventArgs e)
        {

            // Créez une instance de la deuxième fenêtre
            ReleveCompte form2 = new ReleveCompte();

            // Passez la liste des comptes à la deuxième fenêtre
            form2.Comptes = comptes;

                // Affichez la deuxième fenêtre
                form2.Show();
            }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void trn_Click(object sender, EventArgs e)
        {

        }
    }


}
