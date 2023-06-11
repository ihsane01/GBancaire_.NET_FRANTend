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
    public partial class ReleveCompte : Form
    {
        public List<compte> Comptes { get; set; }

        public ReleveCompte()
        {
            InitializeComponent();
        }

        private void ReleveCompte_Load(object sender, EventArgs e)
        {
            if (Comptes != null && Comptes.Any())
            {
                comboBoxComptes.DataSource = Comptes;
                comboBoxComptes.DisplayMember = "nom";
                comboBoxComptes.ValueMember = "Id";
            }

        }


  

            private async Task<List<Mouvement>> GetMouvementsByCompteId(int compteId)
            {
                List<Mouvement> mouvements = new List<Mouvement>();

                try
                {
                    using (HttpClient client = new HttpClient())
                    {
                        string apiUrl = $"https://localhost:7107/api/Mouvement/compte/{compteId}";

                        // Envoyer une requête HTTP GET pour récupérer les mouvements pour le compte spécifié
                        HttpResponseMessage response = await client.GetAsync(apiUrl);

                        // Vérifier si la requête a réussi
                        if (response.IsSuccessStatusCode)
                        {
                            // Lire la réponse JSON
                            string jsonResponse = await response.Content.ReadAsStringAsync();

                            // Désérialiser la réponse JSON en une liste de mouvements
                            mouvements = JsonConvert.DeserializeObject<List<Mouvement>>(jsonResponse);
                        }
                        else
                        {
                            // La requête a échoué
                            Console.WriteLine("Erreur lors de la requête : " + response.StatusCode);
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Gérer les erreurs
                    Console.WriteLine("Erreur lors de la récupération des mouvements : " + ex.Message);
                }

                return mouvements;
            }

        private async void ok_Click(object sender, EventArgs e)
        {
            if (comboBoxComptes.SelectedItem == null)
            {
                MessageBox.Show("Veuillez sélectionner un compte.");
                return;
            }

            // Récupérer le compte sélectionné
           compte compte = comboBoxComptes.SelectedItem as compte;

            // Récupérer les mouvements pour le compte sélectionné
            List<Mouvement> mouvements = await GetMouvementsByCompteId(compte.Id);

            // Afficher les mouvements dans votre interface utilisateur (par exemple, dans une DataGridView)
            dataGridViewMouvements.DataSource = mouvements;
        }
    }
    }



