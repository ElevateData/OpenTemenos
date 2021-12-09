using Transact;

namespace OpenTemenos.Tests.Transact.Enterprise;

[TestClass]
public class EnterpriseProductPricingServiceTests : CredentialManagement
{
    private const string BaseContractReference = "";
    private const string ProductId = "";
    private const string ArrangementId = "";
    private const string PackageId = "";
    private const string PartyId = "";
    private readonly IEnterpriseClient _client = new EnterpriseClient(HttpClient);

    [TestMethod]
    public void GetPackageStatementAsync()
    {
        var result = _client.EnterpriseProductPricingService
            .GetPackageStatementAsync(BaseContractReference, null, null, null, null, null, null, null, null, null, null)
            .Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    public void GetActivityChargeAmountAsync()
    {
        var result = _client.EnterpriseProductPricingService.GetActivityChargeAmountAsync(BaseContractReference, null,
            null,
            null, null, null, null, null, null, null, null, null, null, null, null, null, null).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    public void GetPeriodicChargesAmountAsync()
    {
        var result = _client.EnterpriseProductPricingService.GetPeriodicChargesAmountAsync(BaseContractReference, null,
            null, null,
            null, null, null, null, null, null, null, null, null, null, null, null, null).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    public void GetInterestRateAsync()
    {
        var result = _client.EnterpriseProductPricingService.GetInterestRateAsync(BaseContractReference, null, null,
            null, null,
            null, null, null, null, null, null, null, null, null, null, null, null).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    public void GetEligibilityDetailsAsync()
    {
        var result = _client.EnterpriseProductPricingService
            .GetEligibilityDetailsAsync(ProductId, null, null, null, null, null, null, null, null, null, null, null)
            .Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    public void GetTransactionPricingRequestAsync()
    {
        var result = _client.EnterpriseProductPricingService.GetTransactionPricingRequestAsync(BaseContractReference,
            null, null,
            null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null,
            null, null).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    public void GetNewActivityPricingAsync()
    {
        var result = _client.EnterpriseProductPricingService.GetNewActivityPricingAsync(ProductId, null, null, null,
            null, null, null, null, null, null, null, null, null, null, null, null, null, null).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    public void GetPricingDetailsEventListAsync()
    {
        var result = _client.EnterpriseProductPricingService
            .GetPricingDetailsEventListAsync(ArrangementId, null, null, null, null, null, null, null, null, null)
            .Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    public void GetPackagePeriodicPricingAsync()
    {
        var result = _client.EnterpriseProductPricingService
            .GetPackagePeriodicPricingAsync(PackageId, null, null, null, null, null, null, null, null, null).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    public void GetPackageDetailsAsync()
    {
        var result = _client.EnterpriseProductPricingService
            .GetPackageDetailsAsync(PackageId, null, null, null, null, null, null, null, null, null).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    public void GetCustomerHeldContractsAsync()
    {
        var result = _client.EnterpriseProductPricingService
            .GetCustomerHeldContractsAsync(PartyId, null, null, null, null, null, null, null, null).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    public void GetContractEventListAsync()
    {
        var result = _client.EnterpriseProductPricingService.GetContractEventListAsync(BaseContractReference, null,
            null, null, null,
            null, null, null, null, null, null, null, null).Result;
        Assert.IsNotNull(result.Body);
    }
}