using System;
using System.Collections.Generic;

#nullable disable

namespace LabCoreD01.Models
{
    public partial class Tab2
    {
        public int StId { get; set; }
        public string StFname { get; set; }
        public string StLname { get; set; }
        public string StAddress { get; set; }
        public int? StAge { get; set; }
        public int? DeptId { get; set; }
        public int? StSuper { get; set; }
    }
}
