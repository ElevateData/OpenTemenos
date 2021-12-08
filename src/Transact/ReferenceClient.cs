using Transact.Reference;
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
using Transact.Reference.OrganizationStructuresServices;
using Transact.Reference.PeriodDates;
using Transact.Reference.PortfolioAccounts;
using Transact.Reference.Product;
using Transact.Reference.RoundingRule;
using Transact.Reference.TransactionCodesServices;
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
using Transact.Reference.UsSortCodesServices;
using Transact.Reference.UsState;

namespace Transact;

public class ReferenceClient : IReferenceClient
{
    private readonly HttpClient _httpClient;

    public ReferenceClient(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }
    public IAccountOfficersService AccountOfficersService => new AccountOfficersService(_httpClient);
    public IBalanceTypesService BalanceTypesService => new BalanceTypesService(_httpClient);
    public IBeneficiariesService BeneficiariesService => new BeneficiariesService(_httpClient);
    public IBICsService BICsService => new BICsService(_httpClient);
    public IBrokersService BrokersService => new BrokersService(_httpClient);
    public IBundleRatesService BundleRatesService => new BundleRatesService(_httpClient);
    public ICategoriesService CategoriesService => new CategoriesService(_httpClient);
    public IChequeTypesService ChequeTypesService => new ChequeTypesService(_httpClient);
    public ICollateralClassificationsService CollateralClassificationsService => new CollateralClassificationsService(_httpClient);
    public ICompaniesService CompaniesService => new CompaniesService(_httpClient){BaseUrl = "https://api.temenos.com/api/v1.0.0" };
    public ICountriesService CountriesService => new CountriesService(_httpClient);
    public ICurrenciesService CurrenciesService => new CurrenciesService(_httpClient);
    public IDatesService DatesService => new DatesService(_httpClient);
    public IDealersService DealersService => new DealersService(_httpClient);
    public IIBANsService IBANsService => new IBANsService(_httpClient);
    public IInterestBasesService InterestBasesService => new InterestBasesService(_httpClient);
    public IInterestRatesService InterestRatesService => new InterestRatesService(_httpClient);
    public ILookupsService LookupsService => new LookupsService(_httpClient);
    public INationalIdsService NationalIdsService => new NationalIdsService(_httpClient);
    public IOrganizationStructuresServicesService OrganizationStructuresServicesService => new OrganizationStructuresServicesService(_httpClient);
    public IPeriodDatesService PeriodDatesService => new PeriodDatesService(_httpClient);
    public IPortfolioAccountsService PortfolioAccountsService => new PortfolioAccountsService(_httpClient);
    public IProductService ProductService => new ProductService(_httpClient);
    public IRoundingRuleService RoundingRuleService => new RoundingRuleService(_httpClient);
    public ITransactionCodesServicesService TransactionCodesServicesService => new TransactionCodesServicesService(_httpClient);
    public ITreasuryService TreasuryService => new TreasuryService(_httpClient);
    public IUsBenOwnerTypesService UsBenOwnerTypesService => new UsBenOwnerTypesService(_httpClient);
    public IUsCountyService UsCountyService => new UsCountyService(_httpClient);
    public IUsCovenantService UsCovenantService => new UsCovenantService(_httpClient);
    public IUsCustomerRatingService UsCustomerRatingService => new UsCustomerRatingService(_httpClient);
    public IUsCustomerSuffixService UsCustomerSuffixService => new UsCustomerSuffixService(_httpClient);
    public IUsCustomerTitleService UsCustomerTitleService => new UsCustomerTitleService(_httpClient);
    public IUsFdicClassCodesService UsFdicClassCodesService => new UsFdicClassCodesService(_httpClient);
    public IUsHoldTypesService UsHoldTypesService => new UsHoldTypesService(_httpClient);
    public IUsIdDocumentsService UsIdDocumentsService => new UsIdDocumentsService(_httpClient);
    public IUsIndustryService UsIndustryService => new UsIndustryService(_httpClient);
    public IUsSectorService UsSectorService => new UsSectorService(_httpClient);
    public IUsSortCodesServicesService UsSortCodesServicesService => new UsSortCodesServicesService(_httpClient);
    public IUsStateService UsStateService => new UsStateService(_httpClient);
}
