using System;
using System.Collections.Generic;

namespace BlazorTrendApplication.Infrastructure.Context
{
    public partial class UserDetail
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? Email { get; set; }
    }
}
