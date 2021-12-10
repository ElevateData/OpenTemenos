﻿using Transact.Reference;
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
    public IBeneficiaryService BeneficiaryService => new BeneficiaryService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public IBICService BICService => new BICService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public IBrokerService BrokerService => new BrokerService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public IBundleRateService BundleRateService => new BundleRateService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public ICategoryService CategoryService => new CategoryService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public IChequeTypeService ChequeTypeService => new ChequeTypeService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public ICollateralClassificationService CollateralClassificationService => new CollateralClassificationService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public ICompanyService CompanyService => new CompanyService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public ICountryService CountryService => new CountryService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public ICurrencyService CurrencyService => new CurrencyService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public IDateService DateService => new DateService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public IDealerService DealerService => new DealerService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public IIBANService IBANService => new IBANService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public IInterestBaseService InterestBaseService => new InterestBaseService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public IInterestRateService InterestRateService => new InterestRateService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public ILookupService LookupService => new LookupService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public INationalIdService NationalIdService => new NationalIdService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public IOrganizationStructureService OrganizationStructureService => new OrganizationStructureService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public IPeriodDateService PeriodDateService => new PeriodDateService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public IPortfolioAccountService PortfolioAccountService => new PortfolioAccountService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public IProductService ProductService => new ProductService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public IRoundingRuleService RoundingRuleService => new RoundingRuleService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public ITransactionCodeService TransactionCodeService => new TransactionCodeService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public ITreasuryService TreasuryService => new TreasuryService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public IUsBenOwnerTypeService UsBenOwnerTypeService => new UsBenOwnerTypeService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public IUsCountyService UsCountyService => new UsCountyService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public IUsCovenantService UsCovenantService => new UsCovenantService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public IUsCustomerRatingService UsCustomerRatingService => new UsCustomerRatingService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public IUsCustomerSuffixService UsCustomerSuffixService => new UsCustomerSuffixService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public IUsCustomerTitleService UsCustomerTitleService => new UsCustomerTitleService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public IUsFdicClassCodeService UsFdicClassCodeService => new UsFdicClassCodeService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public IUsHoldTypeService UsHoldTypeService => new UsHoldTypeService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public IUsIdDocumentService UsIdDocumentService => new UsIdDocumentService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public IUsIndustryService UsIndustryService => new UsIndustryService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public IUsSectorService UsSectorService => new UsSectorService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public IUsSortCodeService UsSortCodeService => new UsSortCodeService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public IUsStateService UsStateService => new UsStateService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
}
