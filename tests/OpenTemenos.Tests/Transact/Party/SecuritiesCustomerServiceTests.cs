using Transact;
using Transact.Party.SecuritiesCustomers;

namespace OpenTemenos.Tests.Transact.Party;

[TestClass, TestCategory("Transact")]
public class SecuritiesCustomerServiceTests : CredentialManagement
{
    private const string CustomerId = "100282";
    private readonly IPartyClient _client = new PartyClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    public void GetSecuritiesCustomerAsync()
    {
        var result = _client.SecuritiesCustomerService.GetSecuritiesCustomerAsync(CustomerId)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("POST method")]
    public void CreateSecuritiesCustomerAsync()
    {
        var customerId = string.Empty;
        var payload = new SecuritiesCustomer();
        var result = _client.SecuritiesCustomerService.CreateSecuritiesCustomerAsync(customerId, payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("PUT method")]
    public void UpdateSecuritiesCustomerAsync()
    {
        var customerId = string.Empty;
        var payload = new SecuritiesCustomer();
        var result = _client.SecuritiesCustomerService.UpdateSecuritiesCustomerAsync(customerId, payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }
}