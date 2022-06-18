using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoregApp.Application.Responses
{
    public class CategoryResponse
    {
        public int IdCategory { get; set; }
        public string? NameCategory { get; set; } = null!;
    }
}
