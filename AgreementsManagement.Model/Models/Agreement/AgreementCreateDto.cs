
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgreementsManagement.DTO.Models.Agreement
{
    public class AgreementCreateDto
    {
        public string Status { get; set; }
        public string QuoteNumber { get; set; } = null!;
        public string AgreementName { get; set; } = null!;
        public string AgreementType { get; set; } = null!;
        public string DistributorName { get; set; } = null!;
        public DateTime EffectiveDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        public DateTime CreatedDate { get; set; }

    }
}
