using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorTrendApplication.Infrastructure.Models
{
   public class PageResponse<T>
    {
        public string StatusCode { get; set; }
        public string ErrorMessage { get; set; }
        public T Data { get; set; }
    }
}
