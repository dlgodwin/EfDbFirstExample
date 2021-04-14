using System;
using System.Collections.Generic;

#nullable disable

namespace EfDbFirstExample.Domain.Model
{
    public partial class Feedback
    {
        public int FeedbackId { get; set; }
        public string Comment { get; set; }
    }
}
