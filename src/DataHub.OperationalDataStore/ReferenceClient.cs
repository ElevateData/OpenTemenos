using DataHub.OperationalDataStore.Reference;
using DataHub.OperationalDataStore.Reference.AAPurposeList;
using DataHub.OperationalDataStore.Reference.AccountOfficers;
using DataHub.OperationalDataStore.Reference.BalanceTypes;
using DataHub.OperationalDataStore.Reference.BankBICDetails;
using DataHub.OperationalDataStore.Reference.BeneficialOwnerRules;
using DataHub.OperationalDataStore.Reference.Brokers;
using DataHub.OperationalDataStore.Reference.Categories;
using DataHub.OperationalDataStore.Reference.ChequeTypes;
using DataHub.OperationalDataStore.Reference.ClassTypeActivities;
using DataHub.OperationalDataStore.Reference.ClientPortfolios;
using DataHub.OperationalDataStore.Reference.Companies;
using DataHub.OperationalDataStore.Reference.Countries;
using DataHub.OperationalDataStore.Reference.CurrenciesDetails;
using DataHub.OperationalDataStore.Reference.DateDetails;
using DataHub.OperationalDataStore.Reference.DealerDeskDetails;
using DataHub.OperationalDataStore.Reference.EvidenceTypes;
using DataHub.OperationalDataStore.Reference.FdicDepositClassCodeList;
using DataHub.OperationalDataStore.Reference.HoldTypes;
using DataHub.OperationalDataStore.Reference.IBANBankDetails;
using DataHub.OperationalDataStore.Reference.IBANCountriesList;
using DataHub.OperationalDataStore.Reference.IndustryList;
using DataHub.OperationalDataStore.Reference.InterestBasis;
using DataHub.OperationalDataStore.Reference.LanguageList;
using DataHub.OperationalDataStore.Reference.LookUpTableDetails;
using DataHub.OperationalDataStore.Reference.OriginationDefinitions;
using DataHub.OperationalDataStore.Reference.OriginationRoles;
using DataHub.OperationalDataStore.Reference.QuestionnaireTypes;
using DataHub.OperationalDataStore.Reference.RateTexts;
using DataHub.OperationalDataStore.Reference.SectorList;
using DataHub.OperationalDataStore.Reference.SecurityDeliveryInstructions;
using DataHub.OperationalDataStore.Reference.SecurityInstruments;
using DataHub.OperationalDataStore.Reference.StockExchanges;
using DataHub.OperationalDataStore.Reference.UsCovenantList;
using DataHub.OperationalDataStore.Reference.USCustomerRatingList;
using DataHub.OperationalDataStore.Reference.USIndustrylist;
using DataHub.OperationalDataStore.Reference.UsStateList;
using DataHub.OperationalDataStore.Reference.UtilityBeneficiaries;

namespace DataHub.OperationalDataStore;

public class ReferenceClient : IReferenceClient
{
    private readonly HttpClient _httpClient;
    public string BaseUrl { get; set; } = Shared.Data.DefaultConfig.BaseUrl;

    public ReferenceClient(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public IAccountOfficersService AccountOfficerService => new AccountOfficersService(_httpClient) { BaseUrl = BaseUrl };

    public IBalanceTypesService BalanceTypeService => new BalanceTypesService(_httpClient) { BaseUrl = BaseUrl };

    public IChequeTypesService ChequeTypeService => new ChequeTypesService(_httpClient) { BaseUrl = BaseUrl };

    public IClassTypeActivitiesService ClassTypeActivityService => new ClassTypeActivitiesService(_httpClient) { BaseUrl = BaseUrl };

    public ICountriesService CountryCodeService => new CountriesService(_httpClient) { BaseUrl = BaseUrl };

    public ICurrenciesDetailsService CurrencyCodeService => new CurrenciesDetailsService(_httpClient) { BaseUrl = BaseUrl };

    public IEvidenceTypesService EvidenceTypeService => new EvidenceTypesService(_httpClient) { BaseUrl = BaseUrl };

    public IIBANBankDetailsService IbanDetailService => new IBANBankDetailsService(_httpClient) { BaseUrl = BaseUrl };

    public IIBANCountriesListService IbanStructureDetailService => new IBANCountriesListService(_httpClient) { BaseUrl = BaseUrl };

    public IIndustryListService IndustryService => new IndustryListService(_httpClient) { BaseUrl = BaseUrl };

    public IInterestBasisService InterestBaseService => new InterestBasisService(_httpClient) { BaseUrl = BaseUrl };

    public IRateTextsService InterestRateDescriptionService => new RateTextsService(_httpClient) { BaseUrl = BaseUrl };

    public ILanguageListService LanguageCodeService => new LanguageListService(_httpClient) { BaseUrl = BaseUrl };

    public IBrokersService BrokerService => new BrokersService(_httpClient) { BaseUrl = BaseUrl };

    public ICompaniesService LegalEntityService => new CompaniesService(_httpClient) { BaseUrl = BaseUrl };

    public IAAPurposeListService PurposeService => new AAPurposeListService(_httpClient) { BaseUrl = BaseUrl };

    public IBankBICDetailsService SwiftBankCodeService => new BankBICDetailsService(_httpClient) { BaseUrl = BaseUrl };

    public ILookUpTableDetailsService LookupTableService => new LookUpTableDetailsService(_httpClient) { BaseUrl = BaseUrl };

    public IOriginationDefinitionsService OriginationDefinitionService =>
        new OriginationDefinitionsService(_httpClient) { BaseUrl = BaseUrl };

    public IOriginationRolesService OriginationRoleService => new OriginationRolesService(_httpClient) { BaseUrl = BaseUrl };

    public IClientPortfoliosService OwnBookPortfolioService => new ClientPortfoliosService(_httpClient) { BaseUrl = BaseUrl };

    public ICategoriesService ProductInternalCategoryCodeService => new CategoriesService(_httpClient) { BaseUrl = BaseUrl };

    public IQuestionnaireTypesService QuestionnaireTypeService => new QuestionnaireTypesService(_httpClient) { BaseUrl = BaseUrl };

    public ISectorListService SectorService => new SectorListService(_httpClient) { BaseUrl = BaseUrl };

    public ISecurityDeliveryInstructionsService SecurityDeliveryInstructionService =>
        new SecurityDeliveryInstructionsService(_httpClient) { BaseUrl = BaseUrl };

    public ISecurityInstrumentsService SecurityInstrumentService => new SecurityInstrumentsService(_httpClient) { BaseUrl = BaseUrl };

    public IStockExchangesService StockExchangeService => new StockExchangesService(_httpClient) { BaseUrl = BaseUrl };

    public IDateDetailsService SystemBusinessDateService => new DateDetailsService(_httpClient) { BaseUrl = BaseUrl };

    public IDealerDeskDetailsService TreasuryDealerDeskService => new DealerDeskDetailsService(_httpClient) { BaseUrl = BaseUrl };

    public IBeneficialOwnerRulesService UsModelBankBeneficialRoleService =>
        new BeneficialOwnerRulesService(_httpClient) { BaseUrl = BaseUrl };

    public IUSCustomerRatingListService UsModelBankCustomerRiskRatingService =>
        new USCustomerRatingListService(_httpClient) { BaseUrl = BaseUrl };

    public IFdicDepositClassCodeListService UsModelBankFdicSubClassificationCodeService =>
        new FdicDepositClassCodeListService(_httpClient) { BaseUrl = BaseUrl };

    public IHoldTypesService UsModelBankHoldTypeService => new HoldTypesService(_httpClient) { BaseUrl = BaseUrl };

    public IUsCovenantListService UsModelBankLoanCovenantService => new UsCovenantListService(_httpClient) { BaseUrl = BaseUrl };

    public IUSIndustrylistService UsModelBankUsIndustryClassificationService =>
        new USIndustrylistService(_httpClient) { BaseUrl = BaseUrl };

    public IUsStateListService UsModelBankUsStateService => new UsStateListService(_httpClient) { BaseUrl = BaseUrl };

    public IUtilityBeneficiariesService UtilityBeneficiaryService => new UtilityBeneficiariesService(_httpClient) { BaseUrl = BaseUrl };
}
