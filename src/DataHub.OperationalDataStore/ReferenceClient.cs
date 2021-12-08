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

    public ReferenceClient(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public IAccountOfficersService AccountOfficerService => new AccountOfficersService(_httpClient);

    public IBalanceTypesService BalanceTypeService => new BalanceTypesService(_httpClient);

    public IChequeTypesService ChequeTypeService => new ChequeTypesService(_httpClient);

    public IClassTypeActivitiesService ClassTypeActivityService => new ClassTypeActivitiesService(_httpClient);

    public ICountriesService CountryCodeService => new CountriesService(_httpClient);

    public ICurrenciesDetailsService CurrencyCodeService => new CurrenciesDetailsService(_httpClient);

    public IEvidenceTypesService EvidenceTypeService => new EvidenceTypesService(_httpClient);

    public IIBANBankDetailsService IbanDetailService => new IBANBankDetailsService(_httpClient);

    public IIBANCountriesListService IbanStructureDetailService => new IBANCountriesListService(_httpClient);

    public IIndustryListService IndustryService => new IndustryListService(_httpClient);

    public IInterestBasisService InterestBaseService => new InterestBasisService(_httpClient);

    public IRateTextsService InterestRateDescriptionService => new RateTextsService(_httpClient);

    public ILanguageListService LanguageCodeService => new LanguageListService(_httpClient);

    public IBrokersService BrokerService => new BrokersService(_httpClient);

    public ICompaniesService LegalEntityService => new CompaniesService(_httpClient);

    public IAAPurposeListService PurposeService => new AAPurposeListService(_httpClient);

    public IBankBICDetailsService SwiftBankCodeService => new BankBICDetailsService(_httpClient);

    public ILookUpTableDetailsService LookupTableService => new LookUpTableDetailsService(_httpClient);

    public IOriginationDefinitionsService OriginationDefinitionService =>
        new OriginationDefinitionsService(_httpClient);

    public IOriginationRolesService OriginationRoleService => new OriginationRolesService(_httpClient);

    public IClientPortfoliosService OwnBookPortfolioService => new ClientPortfoliosService(_httpClient);

    public ICategoriesService ProductInternalCategoryCodeService => new CategoriesService(_httpClient);

    public IQuestionnaireTypesService QuestionnaireTypeService => new QuestionnaireTypesService(_httpClient);

    public ISectorListService SectorService => new SectorListService(_httpClient);

    public ISecurityDeliveryInstructionsService SecurityDeliveryInstructionService =>
        new SecurityDeliveryInstructionsService(_httpClient);

    public ISecurityInstrumentsService SecurityInstrumentService => new SecurityInstrumentsService(_httpClient);

    public IStockExchangesService StockExchangeService => new StockExchangesService(_httpClient);

    public IDateDetailsService SystemBusinessDateService => new DateDetailsService(_httpClient);

    public IDealerDeskDetailsService TreasuryDealerDeskService => new DealerDeskDetailsService(_httpClient);

    public IBeneficialOwnerRulesService UsModelBankBeneficialRoleService =>
        new BeneficialOwnerRulesService(_httpClient);

    public IUSCustomerRatingListService UsModelBankCustomerRiskRatingService =>
        new USCustomerRatingListService(_httpClient);

    public IFdicDepositClassCodeListService UsModelBankFdicSubClassificationCodeService =>
        new FdicDepositClassCodeListService(_httpClient);

    public IHoldTypesService UsModelBankHoldTypeService => new HoldTypesService(_httpClient);

    public IUsCovenantListService UsModelBankLoanCovenantService => new UsCovenantListService(_httpClient);

    public IUSIndustrylistService UsModelBankUsIndustryClassificationService =>
        new USIndustrylistService(_httpClient);

    public IUsStateListService UsModelBankUsStateService => new UsStateListService(_httpClient);

    public IUtilityBeneficiariesService UtilityBeneficiaryService => new UtilityBeneficiariesService(_httpClient);
}
