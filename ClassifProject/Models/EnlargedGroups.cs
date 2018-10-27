using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClassifProject.Models
{
    public class EnlargedGroups
    {
        [Key]
        public int id_engr { get; set; }

        public string code_engr { get; set; }
        public string name_engr { get; set; }

        public int id_class { get; set; }
        [ForeignKey("id_class")]
        public Classifiers Classifiers { get; set; }
    }
}
