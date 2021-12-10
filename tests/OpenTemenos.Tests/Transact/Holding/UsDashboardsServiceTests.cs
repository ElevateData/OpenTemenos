using Transact;

namespace OpenTemenos.Tests.Transact.Holding;

[TestClass]
public class UsDashboardsServiceTests : CredentialManagement
{
    private const string AccountId = "1";
    private const string CustomerId = "100282";
    private readonly IHoldingClient _client = new HoldingClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    public void GetUsCustomerHoldingsAsync()
    {
        var result = _client.UsModelBank.HoldingSummaryService.GetUsCustomerHoldingsAsync(CustomerId)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    public void GetUsDepositsDashboardAsync()
    {
        var result = _client.UsModelBank.HoldingSummaryService.GetUsDepositsDashboardAsync(AccountId)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    public void GetUsAccountsHoldingsAsync()
    {
        var result = _client.UsModelBank.HoldingSummaryService.GetUsAccountsHoldingsAsync(CustomerId)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    public void GetUsAccountsDashboardAsync()
    {
        var result = _client.UsModelBank.HoldingSummaryService.GetUsAccountsDashboardAsync(AccountId)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }
}