using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrantGB.Models
{
    internal class Mouvement
    {
        public int id { get; set; }
        public int compte_id { get; set; }
        public float montant { get; set; }
        public DateTime date_mvt { get; set; }
    }
}
