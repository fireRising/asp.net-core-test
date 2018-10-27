using System;
using System.ComponentModel.DataAnnotations;

namespace ClassifProject.Models
{
    public class EducationLevel
    {
        [Key]
        public int id_edulvl { get; set; }

        public string code_edulvl { get; set; }
        public string name_edulvl { get; set; }
    }
}
