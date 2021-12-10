using DataHub.OperationalDataStore.Reference;
using DataHub.OperationalDataStore.Reference.AAPurposeLists;
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
using DataHub.OperationalDataStore.Reference.FdicDepositClassCodeLists;
using DataHub.OperationalDataStore.Reference.HoldTypes;
using DataHub.OperationalDataStore.Reference.IBANBankDetails;
using DataHub.OperationalDataStore.Reference.IBANCountriesLists;
using DataHub.OperationalDataStore.Reference.IndustryLists;
using DataHub.OperationalDataStore.Reference.InterestBasis;
using DataHub.OperationalDataStore.Reference.LanguageLists;
using DataHub.OperationalDataStore.Reference.LookUpTableDetails;
using DataHub.OperationalDataStore.Reference.OriginationDefinitions;
using DataHub.OperationalDataStore.Reference.OriginationRoles;
using DataHub.OperationalDataStore.Reference.QuestionnaireTypes;
using DataHub.OperationalDataStore.Reference.RateTexts;
using DataHub.OperationalDataStore.Reference.SectorLists;
using DataHub.OperationalDataStore.Reference.SecurityDeliveryInstructions;
using DataHub.OperationalDataStore.Reference.SecurityInstruments;
using DataHub.OperationalDataStore.Reference.StockExchanges;
using DataHub.OperationalDataStore.Reference.UsCovenantLists;
using DataHub.OperationalDataStore.Reference.USCustomerRatingLists;
using DataHub.OperationalDataStore.Reference.USIndustrylists;
using DataHub.OperationalDataStore.Reference.UsStateLists;
using DataHub.OperationalDataStore.Reference.UtilityBeneficiaries;

namespace DataHub.OperationalDataStore;

public class ReferenceClient : IReferenceClient
{
    private readonly HttpClient _httpClient;
    public string BaseUrl { get; set; } = Shared.Data.DefaultConfig.BaseUrl;
    public bool ReadResponseAsString { get; set; } = Shared.Data.DefaultConfig.ReadResponseAsString;

    public ReferenceClient(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public IAccountOfficerService AccountOfficerService => new AccountOfficerService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IBalanceTypeService BalanceTypeService => new BalanceTypeService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IChequeTypeService ChequeTypeService => new ChequeTypeService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IClassTypeActivityService ClassTypeActivityService => new ClassTypeActivityService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public ICountryService CountryCodeService => new CountryService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public ICurrenciesDetailService CurrencyCodeService => new CurrenciesDetailService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IEvidenceTypeService EvidenceTypeService => new EvidenceTypeService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IIBANBankDetailService IbanDetailService => new IBANBankDetailService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IIBANCountriesListService IbanStructureDetailService => new IBANCountriesListService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IIndustryListService IndustryService => new IndustryListService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IInterestBasiService InterestBaseService => new InterestBasiService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IRateTextService InterestRateDescriptionService => new RateTextService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public ILanguageListService LanguageCodeService => new LanguageListService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IBrokerService BrokerService => new BrokerService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public ICompanyService LegalEntityService => new CompanyService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IAAPurposeListService PurposeService => new AAPurposeListService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IBankBICDetailService SwiftBankCodeService => new BankBICDetailService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public ILookUpTableDetailService LookupTableService => new LookUpTableDetailService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IOriginationDefinitionService OriginationDefinitionService =>
        new OriginationDefinitionService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IOriginationRoleService OriginationRoleService => new OriginationRoleService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IClientPortfolioService OwnBookPortfolioService => new ClientPortfolioService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public ICategoryService ProductInternalCategoryCodeService => new CategoryService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IQuestionnaireTypeService QuestionnaireTypeService => new QuestionnaireTypeService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public ISectorListService SectorService => new SectorListService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public ISecurityDeliveryInstructionService SecurityDeliveryInstructionService =>
        new SecurityDeliveryInstructionService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public ISecurityInstrumentService SecurityInstrumentService => new SecurityInstrumentService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IStockExchangeService StockExchangeService => new StockExchangeService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IDateDetailService SystemBusinessDateService => new DateDetailService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IDealerDeskDetailService TreasuryDealerDeskService => new DealerDeskDetailService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IBeneficialOwnerRuleService UsModelBankBeneficialRoleService =>
        new BeneficialOwnerRuleService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IUSCustomerRatingListService UsModelBankCustomerRiskRatingService =>
        new USCustomerRatingListService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IFdicDepositClassCodeListService UsModelBankFdicSubClassificationCodeService =>
        new FdicDepositClassCodeListService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IHoldTypeService UsModelBankHoldTypeService => new HoldTypeService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IUsCovenantListService UsModelBankLoanCovenantService => new UsCovenantListService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IUSIndustrylistService UsModelBankUsIndustryClassificationService =>
        new USIndustrylistService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IUsStateListService UsModelBankUsStateService => new UsStateListService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IUtilityBeneficiaryService UtilityBeneficiaryService => new UtilityBeneficiaryService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
}
