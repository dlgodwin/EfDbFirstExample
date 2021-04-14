using System;
using System.Collections.Generic;

#nullable disable

namespace DbTest.Model
{
    public partial class Project
    {
        public Project()
        {
            Members = new HashSet<Member>();
        }

        public int Id { get; set; }
        public string Title { get; set; }

        public virtual ICollection<Member> Members { get; set; }
    }
}
