using System;
using System.Collections.Generic;

#nullable disable

namespace LabCoreD01.Models
{
    public partial class Topic
    {
        public Topic()
        {
            Courses = new HashSet<Course>();
        }

        public int TopId { get; set; }
        public string TopName { get; set; }

        public virtual ICollection<Course> Courses { get; set; }
    }
}
