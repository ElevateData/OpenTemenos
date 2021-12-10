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

public interface IReferenceClient
{
    public IAccountOfficerService AccountOfficerService { get; }
    public IBalanceTypeService BalanceTypeService { get; }
    public IChequeTypeService ChequeTypeService { get; }
    public IClassTypeActivityService ClassTypeActivityService { get; }
    public ICountryService CountryCodeService { get; }
    public ICurrenciesDetailService CurrencyCodeService { get; }
    public IEvidenceTypeService EvidenceTypeService { get; }
    public IIBANBankDetailService IbanDetailService { get; }
    public IIBANCountriesListService IbanStructureDetailService { get; }
    public IIndustryListService IndustryService { get; }
    public IInterestBasiService InterestBaseService { get; }
    public IRateTextService InterestRateDescriptionService { get; }
    public ILanguageListService LanguageCodeService { get; }
    public IBrokerService BrokerService { get; }
    public ICompanyService LegalEntityService { get; }
    public IAAPurposeListService PurposeService { get; }
    public IBankBICDetailService SwiftBankCodeService { get; }
    public ILookUpTableDetailService LookupTableService { get; }
    public IOriginationDefinitionService OriginationDefinitionService { get; }
    public IOriginationRoleService OriginationRoleService { get; }
    public IClientPortfolioService OwnBookPortfolioService { get; }
    public ICategoryService ProductInternalCategoryCodeService { get; }
    public IQuestionnaireTypeService QuestionnaireTypeService { get; }
    public ISectorListService SectorService { get; }
    public ISecurityDeliveryInstructionService SecurityDeliveryInstructionService { get; }
    public ISecurityInstrumentService SecurityInstrumentService { get; }
    public IStockExchangeService StockExchangeService { get; }
    public IDateDetailService SystemBusinessDateService { get; }
    public IDealerDeskDetailService TreasuryDealerDeskService { get; }
    public IBeneficialOwnerRuleService UsModelBankBeneficialRoleService { get; }
    public IUSCustomerRatingListService UsModelBankCustomerRiskRatingService { get; }
    public IFdicDepositClassCodeListService UsModelBankFdicSubClassificationCodeService { get; }
    public IHoldTypeService UsModelBankHoldTypeService { get; }
    public IUsCovenantListService UsModelBankLoanCovenantService { get; }
    public IUSIndustrylistService UsModelBankUsIndustryClassificationService { get; }
    public IUsStateListService UsModelBankUsStateService { get; }
    public IUtilityBeneficiaryService UtilityBeneficiaryService { get; }
}
