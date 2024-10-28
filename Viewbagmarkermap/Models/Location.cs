using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Viewbagmarkermap.Models
{ /* I used camel case for class properties to avoid javascript's pascal case animosity problems. */
    public class Location
    {
        [Key]
        public int locationId { get; set; }
        public string name { get; set; }
        [Column(TypeName = "decimal(7, 5)")] // Specifying data type and precision
        public decimal latitude { get; set; }

        [Column(TypeName = "decimal(8, 5)")] // Specifying data type and precision
        public decimal longitude { get; set; }
        public string description { get; set; }


    }
}
