using System;
using System.Collections.Generic;

namespace BlazorTrendApplication.Infrastructure.Context
{
    public partial class Trend
    {
        public int Id { get; set; }
        public string? TrendType { get; set; }
        public string? Title { get; set; }
        public string? Introduction { get; set; }
        public string? Summary { get; set; }
        public string? FileUpload { get; set; }
        public string? TargetedViewer { get; set; }
        public int? UserId { get; set; }
        public bool? Active { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public int? DeletedBy { get; set; }
        public DateTime? DeletedDate { get; set; }
        public long? Price { get; set; }

        public virtual User? User { get; set; }
    }
}
