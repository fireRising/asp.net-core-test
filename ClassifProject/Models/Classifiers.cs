using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ClassifProject.Models
{
    public class Classifiers
    {
        [Key]
        public int id_class { get; set; }

        public string name_class { get; set; }
    }
}
