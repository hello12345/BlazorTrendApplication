using System;
using System.Collections.Generic;

namespace BlazorTrendApplication.Infrastructure.Context
{
    public partial class User
    {
        public User()
        {
            Trends = new HashSet<Trend>();
        }

        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? UserName { get; set; }
        public string? Password { get; set; }
        public string? Email { get; set; }
        public long? Phone { get; set; }
        public bool? Active { get; set; }
        public long? OneTimePassword { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public int? DeletedBy { get; set; }
        public DateTime? DeletedDate { get; set; }

        public virtual ICollection<Trend> Trends { get; set; }
    }
}
