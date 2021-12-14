using OpenTemenos.DataHubs.OperationalDataStore.Reference;
using OpenTemenos.DataHubs.OperationalDataStore.Reference.AAPurposeLists;
using OpenTemenos.DataHubs.OperationalDataStore.Reference.AccountOfficers;
using OpenTemenos.DataHubs.OperationalDataStore.Reference.BalanceTypes;
using OpenTemenos.DataHubs.OperationalDataStore.Reference.BankBICDetails;
using OpenTemenos.DataHubs.OperationalDataStore.Reference.BeneficialOwnerRules;
using OpenTemenos.DataHubs.OperationalDataStore.Reference.Brokers;
using OpenTemenos.DataHubs.OperationalDataStore.Reference.Categories;
using OpenTemenos.DataHubs.OperationalDataStore.Reference.ChequeTypes;
using OpenTemenos.DataHubs.OperationalDataStore.Reference.ClassTypeActivities;
using OpenTemenos.DataHubs.OperationalDataStore.Reference.ClientPortfolios;
using OpenTemenos.DataHubs.OperationalDataStore.Reference.Companies;
using OpenTemenos.DataHubs.OperationalDataStore.Reference.Countries;
using OpenTemenos.DataHubs.OperationalDataStore.Reference.CurrenciesDetails;
using OpenTemenos.DataHubs.OperationalDataStore.Reference.DateDetails;
using OpenTemenos.DataHubs.OperationalDataStore.Reference.DealerDeskDetails;
using OpenTemenos.DataHubs.OperationalDataStore.Reference.EvidenceTypes;
using OpenTemenos.DataHubs.OperationalDataStore.Reference.FdicDepositClassCodeLists;
using OpenTemenos.DataHubs.OperationalDataStore.Reference.HoldTypes;
using OpenTemenos.DataHubs.OperationalDataStore.Reference.IBANBankDetails;
using OpenTemenos.DataHubs.OperationalDataStore.Reference.IBANCountriesLists;
using OpenTemenos.DataHubs.OperationalDataStore.Reference.IndustryLists;
using OpenTemenos.DataHubs.OperationalDataStore.Reference.InterestBasis;
using OpenTemenos.DataHubs.OperationalDataStore.Reference.LanguageLists;
using OpenTemenos.DataHubs.OperationalDataStore.Reference.LookUpTableDetails;
using OpenTemenos.DataHubs.OperationalDataStore.Reference.OriginationDefinitions;
using OpenTemenos.DataHubs.OperationalDataStore.Reference.OriginationRoles;
using OpenTemenos.DataHubs.OperationalDataStore.Reference.QuestionnaireTypes;
using OpenTemenos.DataHubs.OperationalDataStore.Reference.RateTexts;
using OpenTemenos.DataHubs.OperationalDataStore.Reference.SectorLists;
using OpenTemenos.DataHubs.OperationalDataStore.Reference.SecurityDeliveryInstructions;
using OpenTemenos.DataHubs.OperationalDataStore.Reference.SecurityInstruments;
using OpenTemenos.DataHubs.OperationalDataStore.Reference.StockExchanges;
using OpenTemenos.DataHubs.OperationalDataStore.Reference.UsCovenantLists;
using OpenTemenos.DataHubs.OperationalDataStore.Reference.USCustomerRatingLists;
using OpenTemenos.DataHubs.OperationalDataStore.Reference.USIndustrylists;
using OpenTemenos.DataHubs.OperationalDataStore.Reference.UsStateLists;
using OpenTemenos.DataHubs.OperationalDataStore.Reference.UtilityBeneficiaries;
using OpenTemenos.Shared.Data;

namespace OpenTemenos.DataHubs.OperationalDataStore;

public class ReferenceClient : IReferenceClient
{
    private readonly HttpClient _httpClient;

    public ReferenceClient(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public string BaseUrl { get; set; } = DefaultConfig.BaseUrl;
    public bool ReadResponseAsString { get; set; } = DefaultConfig.ReadResponseAsString;

    public IAccountOfficerService AccountOfficerService => new AccountOfficerService(_httpClient)
        { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IBalanceTypeService BalanceTypeService => new BalanceTypeService(_httpClient)
        { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IChequeTypeService ChequeTypeService => new ChequeTypeService(_httpClient)
        { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IClassTypeActivityService ClassTypeActivityService => new ClassTypeActivityService(_httpClient)
        { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public ICountryService CountryCodeService => new CountryService(_httpClient)
        { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public ICurrenciesDetailService CurrencyCodeService => new CurrenciesDetailService(_httpClient)
        { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IEvidenceTypeService EvidenceTypeService => new EvidenceTypeService(_httpClient)
        { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IIBANBankDetailService IbanDetailService => new IBANBankDetailService(_httpClient)
        { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IIBANCountriesListService IbanStructureDetailService => new IBANCountriesListService(_httpClient)
        { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IIndustryListService IndustryService => new IndustryListService(_httpClient)
        { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IInterestBasiService InterestBaseService => new InterestBasiService(_httpClient)
        { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IRateTextService InterestRateDescriptionService => new RateTextService(_httpClient)
        { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public ILanguageListService LanguageCodeService => new LanguageListService(_httpClient)
        { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IBrokerService BrokerService => new BrokerService(_httpClient)
        { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public ICompanyService LegalEntityService => new CompanyService(_httpClient)
        { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IAAPurposeListService PurposeService => new AAPurposeListService(_httpClient)
        { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IBankBICDetailService SwiftBankCodeService => new BankBICDetailService(_httpClient)
        { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public ILookUpTableDetailService LookupTableService => new LookUpTableDetailService(_httpClient)
        { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IOriginationDefinitionService OriginationDefinitionService =>
        new OriginationDefinitionService(_httpClient)
            { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IOriginationRoleService OriginationRoleService => new OriginationRoleService(_httpClient)
        { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IClientPortfolioService OwnBookPortfolioService => new ClientPortfolioService(_httpClient)
        { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public ICategoryService ProductInternalCategoryCodeService => new CategoryService(_httpClient)
        { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IQuestionnaireTypeService QuestionnaireTypeService => new QuestionnaireTypeService(_httpClient)
        { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public ISectorListService SectorService => new SectorListService(_httpClient)
        { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public ISecurityDeliveryInstructionService SecurityDeliveryInstructionService =>
        new SecurityDeliveryInstructionService(_httpClient)
            { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public ISecurityInstrumentService SecurityInstrumentService => new SecurityInstrumentService(_httpClient)
        { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IStockExchangeService StockExchangeService => new StockExchangeService(_httpClient)
        { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IDateDetailService SystemBusinessDateService => new DateDetailService(_httpClient)
        { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IDealerDeskDetailService TreasuryDealerDeskService => new DealerDeskDetailService(_httpClient)
        { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IBeneficialOwnerRuleService UsModelBankBeneficialRoleService =>
        new BeneficialOwnerRuleService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IUSCustomerRatingListService UsModelBankCustomerRiskRatingService =>
        new USCustomerRatingListService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IFdicDepositClassCodeListService UsModelBankFdicSubClassificationCodeService =>
        new FdicDepositClassCodeListService(_httpClient)
            { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IHoldTypeService UsModelBankHoldTypeService => new HoldTypeService(_httpClient)
        { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IUsCovenantListService UsModelBankLoanCovenantService => new UsCovenantListService(_httpClient)
        { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IUSIndustrylistService UsModelBankUsIndustryClassificationService =>
        new USIndustrylistService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IUsStateListService UsModelBankUsStateService => new UsStateListService(_httpClient)
        { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IUtilityBeneficiaryService UtilityBeneficiaryService => new UtilityBeneficiaryService(_httpClient)
        { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
}