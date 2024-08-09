using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParcInformatique.Data.Entities
{
    public class Appel
    {
        [Key]
        public int Id { get; set; }
        public string? Description { get; set; }
        public string? statuts { get; set; }

        [ForeignKey("Equipement_Id")]
        public Equipement? Equipement { get; set; }

        [ForeignKey("Utilisateur_Id")]
        public Utilisateur? Utilisateur { get; set; }
    }
}
