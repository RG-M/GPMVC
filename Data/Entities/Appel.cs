using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParcInformatique.Data.Entities
{
    public class Appel
    {
        [Key]
        public int App_Id { get; set; }

        public string? statuts { get; set; }
    }
}
