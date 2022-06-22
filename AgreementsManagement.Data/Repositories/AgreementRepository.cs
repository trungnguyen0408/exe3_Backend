using AgreementsManagement.Data.EF;
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
    public class AgreementRepository : IAgreementRepository
    {
        private readonly AgreementsManagementDbContext _context;

        public AgreementRepository(AgreementsManagementDbContext context)
        {
            _context = context;
        }
        public bool DeleteById(int id)
        {
            var checkDelete = false;
            var agreementIsDel = _context.Agreements.FirstOrDefault(agreement => agreement.Id == id);
            if (agreementIsDel != null)
            {
                _context.Remove(agreementIsDel);
                _context.SaveChanges();
                checkDelete = true;
            }
            return checkDelete;
        }

        public List<Agreement> GetAll()
        {
            var anAgreement = _context.Agreements.Select(agreement => new Agreement
            {
                Id = agreement.Id,
                Status = agreement.Status,
                QuoteNumber = agreement.QuoteNumber,
                AgreementName = agreement.AgreementName,
                AgreementType = agreement.AgreementType,
                DistributorName = agreement.DistributorName,
                EffectiveDate = agreement.EffectiveDate,
                ExpirationDate = agreement.ExpirationDate,
                CreatedDate = agreement.CreatedDate,

            });
            return anAgreement.ToList();
        }

        public PagedVM<AgreementVM> GetAllPaging(AgreementPagingDto PagedRequest)
        {
           

            var agreements = from agreement in _context.Agreements select agreement;

            #region filter
            agreements = agreements.Where(agreement => (!string.IsNullOrEmpty(PagedRequest.Status) ? agreement.Status.Contains(PagedRequest.Status) : true)
                             && (!string.IsNullOrEmpty(PagedRequest.QuoteNumber)  ? agreement.QuoteNumber.Contains(PagedRequest.QuoteNumber) : true)
                             && (!string.IsNullOrEmpty(PagedRequest.AgreementName) ? agreement.AgreementName.Contains(PagedRequest.AgreementName) : true)
                             && (!string.IsNullOrEmpty(PagedRequest.AgreementType) ? agreement.AgreementType.Contains(PagedRequest.AgreementType) : true)
                             && (!string.IsNullOrEmpty(PagedRequest.DistributorName) ? agreement.DistributorName.Contains(PagedRequest.DistributorName) : true)
                             && (PagedRequest.EffectiveDate.HasValue ? agreement.EffectiveDate.Equals(PagedRequest.EffectiveDate) : true)
                             && (PagedRequest.ExpirationDate.HasValue ? agreement.ExpirationDate.Equals(PagedRequest.ExpirationDate) : true)
                             && (PagedRequest.CreatedDate.HasValue ? agreement.CreatedDate.Equals(PagedRequest.CreatedDate) : true));
            
            #endregion


            int totalAgreement = agreements.Count();

            #region sorted
            var dataSorted = agreements.OrderByDescending(x => x.Id).ToList();
            switch (PagedRequest.Sorting)
            {
                case Model.Enums.Sort.AscendingStatus:
                    dataSorted = agreements.OrderBy(x => x.Status).ToList();
                    break;
                case Model.Enums.Sort.DescendingStatus:
                    dataSorted = agreements.OrderByDescending(x => x.Status).ToList();
                    break;
                case Model.Enums.Sort.AscendingQuoteNumber:
                    dataSorted = agreements.OrderBy(x => x.QuoteNumber).ToList();
                    break;
                case Model.Enums.Sort.DescendingQuoteNumber:
                    dataSorted = agreements.OrderByDescending(x => x.QuoteNumber).ToList();
                    break;
                case Model.Enums.Sort.AscendingAgreementName:
                    dataSorted = agreements.OrderBy(x => x.AgreementName).ToList();
                    break;
                case Model.Enums.Sort.DescendingAgreementName:
                    dataSorted = agreements.OrderByDescending(x => x.AgreementName).ToList();
                    break;
                case Model.Enums.Sort.AscendingAgreementType:
                    dataSorted = agreements.OrderBy(x => x.AgreementType).ToList();
                    break;
                case Model.Enums.Sort.DescendingAgreementType:
                    dataSorted = agreements.OrderByDescending(x => x.AgreementType).ToList();
                    break;
                case Model.Enums.Sort.AscendingDistributorName:
                    dataSorted = agreements.OrderBy(x => x.DistributorName).ToList();
                    break;
                case Model.Enums.Sort.DescendingDistributorName:
                    dataSorted = agreements.OrderByDescending(x => x.DistributorName).ToList();
                    break;
                case Model.Enums.Sort.AscendingEffectiveDate:
                    dataSorted = agreements.OrderBy(x => x.EffectiveDate).ToList();
                    break;
                case Model.Enums.Sort.DescendingEffectiveDate:
                    dataSorted = agreements.OrderByDescending(x => x.EffectiveDate).ToList();
                    break;
                case Model.Enums.Sort.AscendingExpirationDate:
                    dataSorted = agreements.OrderBy(x => x.ExpirationDate).ToList();
                    break;
                case Model.Enums.Sort.DescendingExpirationDate:
                    dataSorted = agreements.OrderByDescending(x => x.ExpirationDate).ToList();
                    break;
                case Model.Enums.Sort.AscendingCreateDate:
                    dataSorted = agreements.OrderBy(x => x.CreatedDate).ToList();
                    break;
                case Model.Enums.Sort.DescendingCreateDate:
                    dataSorted = agreements.OrderByDescending(x => x.CreatedDate).ToList();
                    break;

            }
            #endregion

            #region paginator
            var dataPaginator = dataSorted.Skip((PagedRequest.PageIndex - 1) * PagedRequest.PageSize)
                .Take(PagedRequest.PageSize)
                .Select(agreement => new AgreementVM()
                {
                    Id = agreement.Id,
                    Status = agreement.Status,
                    QuoteNumber = agreement.QuoteNumber,
                    AgreementName = agreement.AgreementName,
                    AgreementType = agreement.AgreementType,
                    DistributorName = agreement.DistributorName,
                    EffectiveDate = agreement.EffectiveDate,
                    ExpirationDate = agreement.ExpirationDate,
                    CreatedDate = agreement.CreatedDate,
                }).ToList();
            #endregion



            var pagedResult = new PagedVM<AgreementVM>()
            {
                TotalRecord = totalAgreement,
                Items = dataPaginator,
            };

            return pagedResult;
        }
    

        public Agreement GetById(int id)
        {
            var agreementIsGet = _context.Agreements.SingleOrDefault(agreement => agreement.Id == id);
            if (agreementIsGet != null)
            {
                return new Agreement()
                {
                    Id = agreementIsGet.Id,
                    Status = agreementIsGet.Status,
                    QuoteNumber = agreementIsGet.QuoteNumber,
                    AgreementName = agreementIsGet.AgreementName,
                    AgreementType = agreementIsGet.AgreementType,
                    DistributorName = agreementIsGet.DistributorName,
                    EffectiveDate = agreementIsGet.EffectiveDate,
                    ExpirationDate = agreementIsGet.ExpirationDate,
                    CreatedDate = agreementIsGet.CreatedDate

                };
            }
            return null;
        }

        public AgreementVM Post(AgreementCreateDto agreement)
        {
            var newAgreement = new Agreement()
            {
                Status = agreement.Status,
                QuoteNumber = agreement.QuoteNumber,
                AgreementName = agreement.AgreementName,
                AgreementType = agreement.AgreementType,
                DistributorName = agreement.DistributorName,
                EffectiveDate = agreement.EffectiveDate,
                ExpirationDate = agreement.ExpirationDate,
                CreatedDate = agreement.CreatedDate,

            };

            _context.Add(newAgreement);
            _context.SaveChanges();


            return new AgreementVM
            {
                Status = agreement.Status,
                QuoteNumber = agreement.QuoteNumber,
                AgreementName = agreement.AgreementName,
                AgreementType = agreement.AgreementType,
                DistributorName = agreement.DistributorName,
                EffectiveDate = agreement.EffectiveDate,
                ExpirationDate = agreement.ExpirationDate,
                CreatedDate = agreement.CreatedDate,

            };
        }

        public bool Update(AgreementEditDto newAgreement, int idAgreement)
        {
            var checkUpdate = false;
            var agreementIsUpdate = _context.Agreements.FirstOrDefault(agreement => agreement.Id == idAgreement);
            if (agreementIsUpdate != null)
            {
                agreementIsUpdate.Status = newAgreement.Status;
                agreementIsUpdate.QuoteNumber = newAgreement.QuoteNumber;
                agreementIsUpdate.AgreementName = newAgreement.AgreementName;
                agreementIsUpdate.AgreementType = newAgreement.AgreementType;
                agreementIsUpdate.DistributorName = newAgreement.DistributorName;
                agreementIsUpdate.EffectiveDate = newAgreement.EffectiveDate;
                agreementIsUpdate.ExpirationDate = newAgreement.ExpirationDate;
                agreementIsUpdate.CreatedDate = newAgreement.CreatedDate;

                checkUpdate = true;
                _context.SaveChanges();
            }
            return checkUpdate;
        }

    }
}
