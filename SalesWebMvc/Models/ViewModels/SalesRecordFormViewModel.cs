using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMvc.Models.ViewModels
{
    public class SalesRecordFormViewModel
    {
        public SalesRecord SalesRecord { get; set; }
        public ICollection<Seller> Seller { get; set; }
    }
}
