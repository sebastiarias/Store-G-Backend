using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoregApp.Application.Requests
{
    public class UpdateCategoryRequest
    {
        public int IdCategory { get; set; }
        public string? NameCategory { get; set; } = null!;
    }
}
