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
using Transact.Reference.Product;
using Transact.Reference.RoundingRule;
using Transact.Reference.TransactionCodes;
using Transact.Reference.Treasury;
using Transact.Reference.UsBenOwnerTypes;
using Transact.Reference.UsCounty;
using Transact.Reference.UsCovenant;
using Transact.Reference.UsCustomerRating;
using Transact.Reference.UsCustomerSuffix;
using Transact.Reference.UsCustomerTitle;
using Transact.Reference.UsFdicClassCodes;
using Transact.Reference.UsHoldTypes;
using Transact.Reference.UsIdDocuments;
using Transact.Reference.UsIndustry;
using Transact.Reference.UsSector;
using Transact.Reference.UsSortCodes;
using Transact.Reference.UsState;

namespace Transact;

//TODO: Rename Transact.IReferenceClient methods
public interface IReferenceClient
{
    public IAccountOfficersService AccountOfficersService { get; }
    public IBalanceTypesService BalanceTypesService { get; }
    public IBeneficiariesService BeneficiariesService { get; }
    public IBICsService BICsService { get; }
    public IBrokersService BrokersService { get; }
    public IBundleRatesService BundleRatesService { get; }
    public ICategoriesService CategoriesService { get; }
    public IChequeTypesService ChequeTypesService { get; }
    public ICollateralClassificationsService CollateralClassificationsService { get; }
    public ICompaniesService CompaniesService { get; }
    public ICountriesService CountriesService { get; }
    public ICurrenciesService CurrenciesService { get; }
    public IDatesService DatesService { get; }
    public IDealersService DealersService { get; }
    public IIBANsService IBANsService { get; }
    public IInterestBasesService InterestBasesService { get; }
    public IInterestRatesService InterestRatesService { get; }
    public ILookupsService LookupsService { get; }
    public INationalIdsService NationalIdsService { get; }
    public IOrganizationStructuresService OrganizationStructuresService { get; }
    public IPeriodDatesService PeriodDatesService { get; }
    public IPortfolioAccountsService PortfolioAccountsService { get; }
    public IProductService ProductService { get; }
    public IRoundingRuleService RoundingRuleService { get; }
    public ITransactionCodesService TransactionCodesService { get; }
    public ITreasuryService TreasuryService { get; }
    public IUsBenOwnerTypesService UsBenOwnerTypesService { get; }
    public IUsCountyService UsCountyService { get; }
    public IUsCovenantService UsCovenantService { get; }
    public IUsCustomerRatingService UsCustomerRatingService { get; }
    public IUsCustomerSuffixService UsCustomerSuffixService { get; }
    public IUsCustomerTitleService UsCustomerTitleService { get; }
    public IUsFdicClassCodesService UsFdicClassCodesService { get; }
    public IUsHoldTypesService UsHoldTypesService { get; }
    public IUsIdDocumentsService UsIdDocumentsService { get; }
    public IUsIndustryService UsIndustryService { get; }
    public IUsSectorService UsSectorService { get; }
    public IUsSortCodesService UsSortCodesService { get; }
    public IUsStateService UsStateService { get; }

}