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

namespace OpenTemenos.DataHubs.OperationalDataStore;

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