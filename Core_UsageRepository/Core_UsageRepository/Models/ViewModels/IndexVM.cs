using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core_UsageRepository.Models.ViewModels
{
    public class IndexVM
    {
        public List<Product> Products { get; set; }
        public List<Category> Categories { get; set; }

    }
}
