using Transact;

namespace OpenTemenos.Tests.Transact.Holding;

[TestClass]
public class CashManagementBundlesServiceTests : CredentialManagement
{
    private const string AccountId = "";
    private const string BundleId = "";
    private const string CurrencyId = "USD";
    private const string CustomerId = "";
    private readonly IHoldingClient _client = new HoldingClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    public void GetCashPoolExceptionLogAsync()
    {
        var result = _client.CashManagementBundleArrangementService.GetCashPoolExceptionLogAsync(BundleId, null, null,
                null,
                null, null, null, null, null)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body.First())}");
    }

    [TestMethod]
    public void GetBundleAccountsAsync()
    {
        var result = _client.CashManagementBundleArrangementService.GetBundleAccountsAsync(BundleId, null, null, null,
                null, null, null, null, null)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body.First())}");
    }

    [TestMethod]
    public void GetBundleHistoryDetailsAsync()
    {
        var result = _client.CashManagementBundleArrangementService.GetBundleHistoryDetailsAsync(BundleId, null, null,
                null,
                null, null, null, null, null)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body.First())}");
    }

    [TestMethod]
    public void GetBundleArrangementsAsync()
    {
        var result = _client.CashManagementBundleArrangementService.GetBundleArrangementsAsync(CustomerId, null, null,
                null,
                null, null, null, null, null, null)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body.First())}");
    }

    [TestMethod]
    public void GetBundleBalancesAsync()
    {
        var result = _client.CashManagementBundleArrangementService.GetBundleBalancesAsync(BundleId, null, null, null,
                null, null, null, null, null)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body.First())}");
    }

    [TestMethod]
    public void GetCustomerBundleAccountsAsync()
    {
        var result = _client.CashManagementBundleArrangementService.GetCustomerBundleAccountsAsync(CustomerId, null,
                null, null,
                null, null, null, null, null, null)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body.First())}");
    }

    [TestMethod]
    public void GetDraftArrangementsAsync()
    {
        var result = _client.CashManagementBundleArrangementService.GetDraftArrangementsAsync(CustomerId, null, null,
                null,
                null, null, null, null, null)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body.First())}");
    }

    [TestMethod]
    public void GetDraftBundleListAsync()
    {
        var result = _client.CashManagementBundleArrangementService.GetDraftBundleListAsync(BundleId, null, null, null,
                null, null, null, null, null)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body.First())}");
    }

    [TestMethod]
    public void GetNonBalanceNettingAccountsAsync()
    {
        var result = _client.CashManagementBundleArrangementService.GetNonBalanceNettingAccountsAsync(BundleId, null,
                null, null,
                null, null, null, null, null)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body.First())}");
    }

    [TestMethod]
    public void GetBundleAccountBalancesAsync()
    {
        var result = _client.CashManagementBundleArrangementService.GetBundleAccountBalancesAsync(AccountId, null, null,
                null,
                null, null, null, null, null)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body.First())}");
    }

    [TestMethod]
    public void GetBalanceInPreferredCurrencyAsync()
    {
        var result = _client.CashManagementBundleArrangementService.GetBalanceInPreferredCurrencyAsync(BundleId,
                CurrencyId, null, null, null,
                null, null, null, null, null, null, null)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body.First())}");
    }
}