using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz_15
{
    public class Associate
    {
        [Key]
        public int Id { get; set; }
        public string AssociateName { get; set; }
        public virtual ICollection<Department> Departments { get; set; }
    }
}
