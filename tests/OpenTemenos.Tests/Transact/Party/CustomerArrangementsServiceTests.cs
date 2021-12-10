using Transact;

namespace OpenTemenos.Tests.Transact.Party;

[TestClass]
public class CustomerArrangementsServiceTests : CredentialManagement
{
    private const string CustomerId = "100282";
    private readonly IPartyClient _client = new PartyClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    public void GetArrangementListAsync()
    {
        var result = _client.CustomerArrangementsService.GetArrangementListAsync(CustomerId)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    public void GetArrangementAccountsAsync()
    {
        var result = _client.CustomerArrangementsService.GetArrangementAccountsAsync(CustomerId)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    public void GetProductBundlesAsync()
    {
        var result = _client.CustomerArrangementsService.GetProductBundlesAsync(CustomerId)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    public void GetPreferentialPricingAsync()
    {
        var result = _client.CustomerArrangementsService.GetPreferentialPricingAsync(CustomerId)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }
}