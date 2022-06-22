using AgreementsManagement.DTO.Entities;
using AgreementsManagement.DTO.Models.Agreement;
using AgreementsManagement.DTO.Models.Paginator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgreementsManagement.Data.Repositories
{
    public interface IAgreementRepository
    {
        List<Agreement> GetAll();
        PagedVM<AgreementVM> GetAllPaging(AgreementPagingDto PagedRequest);
        Agreement GetById(int id);
        AgreementVM Post(AgreementCreateDto agreement);
        bool Update(AgreementEditDto newAgreement, int idAgreement);
        bool DeleteById(int id);
     

    }
}
