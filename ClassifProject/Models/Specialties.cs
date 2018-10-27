using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClassifProject.Models
{
    public class Specialties
    {
        [Key]
        public int id_spec { get; set; }

        public string code_spec { get; set; }
        public string name_spec { get; set; }

        public int id_engr { get; set; }
        [ForeignKey("id_engr")]
        public EnlargedGroups EnlargedGroups { get; set; }

        public int id_class { get; set; }
        [ForeignKey("id_class")]
        public Classifiers Classifiers { get; set; }

        public int id_edulvl { get; set; }
        [ForeignKey("id_edulvl")]
        public EducationLevel EducationLevel { get; set; }
    }
}
