using OpenTemenos.Transacts;

namespace OpenTemenos.Tests.Transact.Enterprise;

[TestClass]
[TestCategory("Transact")]
public class EnterpriseProductPricingServiceTests : CredentialManagement
{
    private const string BaseContractReference = "101125";
    private const string ProductId = "CURRENT.ACCOUNT";
    private const string ArrangementId = "AA21082XK3KZ";
    private const string PackageId = "";
    private const string PartyId = "";
    private readonly IEnterpriseClient _client = new EnterpriseClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    public void GetPackageStatementAsync()
    {
        var result = _client.EnterpriseProductPricingService
            .GetPackageStatementAsync(BaseContractReference)
            .Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    public void GetActivityChargeAmountAsync()
    {
        var result = _client.EnterpriseProductPricingService.GetActivityChargeAmountAsync(BaseContractReference).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    public void GetPeriodicChargesAmountAsync()
    {
        var result = _client.EnterpriseProductPricingService.GetPeriodicChargesAmountAsync(BaseContractReference)
            .Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    public void GetInterestRateAsync()
    {
        var result = _client.EnterpriseProductPricingService.GetInterestRateAsync(BaseContractReference).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    public void GetEligibilityDetailsAsync()
    {
        var result = _client.EnterpriseProductPricingService
            .GetEligibilityDetailsAsync(ProductId)
            .Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    public void GetTransactionPricingRequestAsync()
    {
        var result = _client.EnterpriseProductPricingService.GetTransactionPricingRequestAsync(BaseContractReference)
            .Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    public void GetNewActivityPricingAsync()
    {
        var result = _client.EnterpriseProductPricingService.GetNewActivityPricingAsync(ProductId).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    public void GetPricingDetailsEventListAsync()
    {
        var result = _client.EnterpriseProductPricingService
            .GetPricingDetailsEventListAsync(ArrangementId)
            .Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    public void GetPackagePeriodicPricingAsync()
    {
        var result = _client.EnterpriseProductPricingService
            .GetPackagePeriodicPricingAsync(PackageId).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    public void GetPackageDetailsAsync()
    {
        var result = _client.EnterpriseProductPricingService
            .GetPackageDetailsAsync(PackageId).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    public void GetCustomerHeldContractsAsync()
    {
        var result = _client.EnterpriseProductPricingService
            .GetCustomerHeldContractsAsync(PartyId).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    public void GetContractEventListAsync()
    {
        var result = _client.EnterpriseProductPricingService.GetContractEventListAsync(BaseContractReference).Result;
        Assert.IsNotNull(result.Body);
    }
}