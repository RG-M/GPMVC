using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParcInformatique.Data.Entities
{
    public class Equipement
    {
        [Key]
        public int Id { get; set; }
        public int num_serie { get; set; }
        public string? libelle { get; set; }
        public string? marque { get; set; }
        public string? nom { get; set; }
        public string? type { get; set; }

        [ForeignKey("Utilisateur_Id")]
        public Utilisateur? Utilisateur { get; set; }

    }
}
