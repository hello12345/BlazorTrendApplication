using System;
using System.Collections.Generic;

namespace BlazorTrendApplication.Infrastructure.Context
{
    public partial class SharedTrend
    {
        public int Id { get; set; }
        public string? Email { get; set; }
        public string? Message { get; set; }
        public int? TrendId { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public int? DeletedBy { get; set; }
        public DateTime? DeletedDate { get; set; }
    }
}
