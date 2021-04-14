using System;
using System.Collections.Generic;

#nullable disable

namespace DbTest.Model
{
    public partial class Member
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? ProjectId { get; set; }

        public virtual Project Project { get; set; }
    }
}
