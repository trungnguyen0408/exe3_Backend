using AgreementsManagement.DTO.Entities;
using AgreementsManagement.DTO.Models.Agreement;
using AgreementsManagement.DTO.Models.Paginator;
using AgreementsManagement.Model.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgreementsManagement.Business.Service
{
    public interface IAgreementService
    {
        List<Agreement> GetAll();
        PagedVM<AgreementVM> GetAllPaging(AgreementPagingDto PagedRequest);
        Agreement GetById(int id);
        AgreementVM Post(AgreementCreateDto agreement);
        bool Update(AgreementEditDto newAgreement, int idAgreement);
        bool DeleteById(int id);

    }
}
