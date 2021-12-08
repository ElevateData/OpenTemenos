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

public interface IReferenceClient
{
    public IAccountOfficersService AccountOfficerService { get; }
    public IBalanceTypesService BalanceTypeService { get; }
    public IChequeTypesService ChequeTypeService { get; }
    public IClassTypeActivitiesService ClassTypeActivityService { get; }
    public ICountriesService CountryCodeService { get; }
    public ICurrenciesDetailsService CurrencyCodeService { get; }
    public IEvidenceTypesService EvidenceTypeService { get; }
    public IIBANBankDetailsService IbanDetailService { get; }
    public IIBANCountriesListService IbanStructureDetailService { get; }
    public IIndustryListService IndustryService { get; }
    public IInterestBasisService InterestBaseService { get; }
    public IRateTextsService InterestRateDescriptionService { get; }
    public ILanguageListService LanguageCodeService { get; }
    public IBrokersService BrokerService { get; }
    public ICompaniesService LegalEntityService { get; }
    public IAAPurposeListService PurposeService { get; }
    public IBankBICDetailsService SwiftBankCodeService { get; }
    public ILookUpTableDetailsService LookupTableService { get; }
    public IOriginationDefinitionsService OriginationDefinitionService { get; }
    public IOriginationRolesService OriginationRoleService { get; }
    public IClientPortfoliosService OwnBookPortfolioService { get; }
    public ICategoriesService ProductInternalCategoryCodeService { get; }
    public IQuestionnaireTypesService QuestionnaireTypeService { get; }
    public ISectorListService SectorService { get; }
    public ISecurityDeliveryInstructionsService SecurityDeliveryInstructionService { get; }
    public ISecurityInstrumentsService SecurityInstrumentService { get; }
    public IStockExchangesService StockExchangeService { get; }
    public IDateDetailsService SystemBusinessDateService { get; }
    public IDealerDeskDetailsService TreasuryDealerDeskService { get; }
    public IBeneficialOwnerRulesService UsModelBankBeneficialRoleService { get; }
    public IUSCustomerRatingListService UsModelBankCustomerRiskRatingService { get; }
    public IFdicDepositClassCodeListService UsModelBankFdicSubClassificationCodeService { get; }
    public IHoldTypesService UsModelBankHoldTypeService { get; }
    public IUsCovenantListService UsModelBankLoanCovenantService { get; }
    public IUSIndustrylistService UsModelBankUsIndustryClassificationService { get; }
    public IUsStateListService UsModelBankUsStateService { get; }
    public IUtilityBeneficiariesService UtilityBeneficiaryService { get; }
}
