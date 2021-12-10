using Transact.Reference.AccountOfficers;
using Transact.Reference.BalanceTypes;
using Transact.Reference.Beneficiaries;
using Transact.Reference.BICs;
using Transact.Reference.Brokers;
using Transact.Reference.BundleRates;
using Transact.Reference.Categories;
using Transact.Reference.ChequeTypes;
using Transact.Reference.CollateralClassifications;
using Transact.Reference.Companies;
using Transact.Reference.Countries;
using Transact.Reference.Currencies;
using Transact.Reference.Dates;
using Transact.Reference.Dealers;
using Transact.Reference.IBANs;
using Transact.Reference.InterestBases;
using Transact.Reference.InterestRates;
using Transact.Reference.Lookups;
using Transact.Reference.NationalIds;
using Transact.Reference.OrganizationStructures;
using Transact.Reference.PeriodDates;
using Transact.Reference.PortfolioAccounts;
using Transact.Reference.Products;
using Transact.Reference.RoundingRules;
using Transact.Reference.TransactionCodes;
using Transact.Reference.Treasuries;
using Transact.Reference.UsBenOwnerTypes;
using Transact.Reference.UsCounties;
using Transact.Reference.UsCovenants;
using Transact.Reference.UsCustomerRatings;
using Transact.Reference.UsCustomerSuffixs;
using Transact.Reference.UsCustomerTitles;
using Transact.Reference.UsFdicClassCodes;
using Transact.Reference.UsHoldTypes;
using Transact.Reference.UsIdDocuments;
using Transact.Reference.UsIndustries;
using Transact.Reference.UsSectors;
using Transact.Reference.UsSortCodes;
using Transact.Reference.UsStates;

namespace Transact;

//TODO: Rename Transact.IReferenceClient methods
public interface IReferenceClient
{
    public IAccountOfficerService AccountOfficerService { get; }
    public IBalanceTypeService BalanceTypeService { get; }
    public IBeneficiaryService BeneficiaryService { get; }
    public IBICService BICService { get; }
    public IBrokerService BrokerService { get; }
    public IBundleRateService BundleRateService { get; }
    public ICategoryService CategoryService { get; }
    public IChequeTypeService ChequeTypeService { get; }
    public ICollateralClassificationService CollateralClassificationService { get; }
    public ICompanyService CompanyService { get; }
    public ICountryService CountryService { get; }
    public ICurrencyService CurrencyService { get; }
    public IDateService DateService { get; }
    public IDealerService DealerService { get; }
    public IIBANService IBANService { get; }
    public IInterestBaseService InterestBaseService { get; }
    public IInterestRateService InterestRateService { get; }
    public ILookupService LookupService { get; }
    public INationalIdService NationalIdService { get; }
    public IOrganizationStructureService OrganizationStructureService { get; }
    public IPeriodDateService PeriodDateService { get; }
    public IPortfolioAccountService PortfolioAccountService { get; }
    public IProductService ProductService { get; }
    public IRoundingRuleService RoundingRuleService { get; }
    public ITransactionCodeService TransactionCodeService { get; }
    public ITreasuryService TreasuryService { get; }
    public IUsBenOwnerTypeService UsBenOwnerTypeService { get; }
    public IUsCountyService UsCountyService { get; }
    public IUsCovenantService UsCovenantService { get; }
    public IUsCustomerRatingService UsCustomerRatingService { get; }
    public IUsCustomerSuffixService UsCustomerSuffixService { get; }
    public IUsCustomerTitleService UsCustomerTitleService { get; }
    public IUsFdicClassCodeService UsFdicClassCodeService { get; }
    public IUsHoldTypeService UsHoldTypeService { get; }
    public IUsIdDocumentService UsIdDocumentService { get; }
    public IUsIndustryService UsIndustryService { get; }
    public IUsSectorService UsSectorService { get; }
    public IUsSortCodeService UsSortCodeService { get; }
    public IUsStateService UsStateService { get; }

}