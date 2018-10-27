using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClassifProject.Models
{
    public class Transcoding
    {
        [Key]
        public int id_trans { get; set; }

        public int id_spec_1 { get; set; }
        [ForeignKey("id_spec_1")]
        public Specialties Specialties_1 { get; set; }

        public int id_spec_2 { get; set; }
        [ForeignKey("id_spec_2")]
        public Specialties Specialties_2 { get; set; }

        public int id_class_1 { get; set; }
        [ForeignKey("id_class_1")]
        public Classifiers Classifiers_1 { get; set; }

        public int id_class_2 { get; set; }
        [ForeignKey("id_class_2")]
        public Classifiers Classifiers_2 { get; set; }
    }
}
