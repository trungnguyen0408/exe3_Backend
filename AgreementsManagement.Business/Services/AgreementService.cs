
using AgreementsManagement.Data.EF;
using AgreementsManagement.Data.Repositories;
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
    public class AgreementService: IAgreementService
    {
        private readonly IAgreementRepository _agreementRepository;

        public AgreementService(IAgreementRepository agreementRepository)
        {
            _agreementRepository = agreementRepository;
        }

        public bool DeleteById(int id)
        {
           return _agreementRepository.DeleteById(id);
        }

        public List<Agreement> GetAll()
        {
            return _agreementRepository.GetAll();
        }

        public PagedVM<AgreementVM> GetAllPaging(AgreementPagingDto PagedRequest)
        {
       
          return _agreementRepository.GetAllPaging(PagedRequest);
            
        }

        public Agreement GetById(int id)
        {
            return _agreementRepository.GetById(id);
        }

        public AgreementVM Post(AgreementCreateDto agreement)
        {
           return _agreementRepository.Post(agreement);
        }

        public bool Update(AgreementEditDto newAgreement, int idAgreement)
        {
            return _agreementRepository.Update(newAgreement,idAgreement);
        }
    }
}
