using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domin.Entity
{
    public class SubCategory
    {
        public Guid Id { get; set; }
        [Required(ErrorMessageResourceType = typeof(Ressources.ResourceData), ErrorMessageResourceName = ("SubCategName"))]
        [MaxLength(20, ErrorMessageResourceType = typeof(Ressources.ResourceData), ErrorMessageResourceName = ("MaxLength"))]
        [MinLength(3, ErrorMessageResourceType = typeof(Ressources.ResourceData), ErrorMessageResourceName = ("MinLength"))]
        public string Name { get; set; }

        public Guid CategoryId { get; set; }
        [ForeignKey("CategoryId")]
        public Category Category { get; set; }

        public int CurrentStaut { get; set; }
    }
}
