using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgreementsManagement.DTO.Models.Paginator
{
    public class PagedVM<T>
    {
        public List<T> Items { get; set; }
        public int TotalRecord { get; set; }
    }
}
