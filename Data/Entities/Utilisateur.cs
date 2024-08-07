using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParcInformatique.Data.Entities
{
    public class Utilisateur : IdentityUser
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? LastName { get; set; }
        public int? Age { get; set; }
    }
}
