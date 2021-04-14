using System;
using System.Collections.Generic;

#nullable disable

namespace DbTest.DAL.Model
{
    public partial class SalesSummary
    {
        public string Brand { get; set; }
        public string Category { get; set; }
        public short ModelYear { get; set; }
        public decimal? Sales { get; set; }
    }
}
