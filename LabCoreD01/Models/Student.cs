using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace LabCoreD01.Models
{
    public partial class Student
    {
        public Student()
        {
            InverseStSuperNavigation = new HashSet<Student>();
            StudCourses = new HashSet<StudCourse>();
        }

        public int StId { get; set; }
        [Required(ErrorMessage ="*")]
        public string StFname { get; set; }

        [Required(ErrorMessage = "*")]
        public string StLname { get; set; }

        [Required(ErrorMessage = "*")]

        public string StAddress { get; set; }

        [Required(ErrorMessage = "*")]
        [Range(20,30,ErrorMessage ="age must be between 20 and 30")]

        public int? StAge { get; set; }
        public int? DeptId { get; set; }
        public int? StSuper { get; set; }
        public string Photo { get; set; }
        public string Cv { get; set; }

        public virtual Department Dept { get; set; }
        public virtual Student StSuperNavigation { get; set; }
        public virtual ICollection<Student> InverseStSuperNavigation { get; set; }
        public virtual ICollection<StudCourse> StudCourses { get; set; }
    }
}
