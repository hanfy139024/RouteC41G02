using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RouteC41G02.DAL.Models
{
    public class Department
    {

        public int Id { get; set; }
        [Required]//(ErrorMessage ="name is error ya hamde")]
        public string Name { get; set; }
        [Required]
        public string Code { get; set; }
        public DateTime Dateofcreation { get; set; }

         
    }
}
