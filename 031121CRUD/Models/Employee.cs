using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace _031121CRUD.Models
{
    public class Employee
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Bu sahə boş buraxıla bilməz"), MaxLength(50,ErrorMessage ="Maksimum 50 simvol!")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Bu sahə boş buraxıla bilməz"), MaxLength(100, ErrorMessage = "Maksimum 100 simvol!")]
        public string Surname { get; set; }

        [Required(ErrorMessage ="Bu sahə boş buraxıla bilməz"), Range(1, 3,ErrorMessage ="1-3 arası ədəd daxil edilə bilər")]
        public int Experience { get; set; }
    }
}
