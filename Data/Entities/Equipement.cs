using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParcInformatiqueData.Entities
{
    public class Equipement
    {
        [Key]
        public int num_serie { get; set; }
        public string? libelle { get; set; }
        public string? marque { get; set; }
    }
}
