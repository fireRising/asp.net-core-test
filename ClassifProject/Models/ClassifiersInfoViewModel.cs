using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ClassifProject.Models
{
    public class ClassifiersInfoViewModel
    {
        public IEnumerable<Specialties> Specialties { get; set; }
        public IEnumerable<Classifiers> Classifiers { get; set; }
        public IEnumerable<EducationLevel> EducationLevels { get; set; }
        public IEnumerable<EnlargedGroups> EnlargedGroups { get; set; }
        public IEnumerable<Transcoding> Transcodings { get; set; }
    }
}
