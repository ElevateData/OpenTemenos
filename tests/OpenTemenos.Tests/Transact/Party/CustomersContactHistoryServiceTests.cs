using Transact;
using Transact.Party.CustomersContactHistory;

namespace OpenTemenos.Tests.Transact.Party;

[TestClass]
public class CustomersContactHistoryServiceTests : CredentialManagement
{
    private const string ContactHistoryId = "1000";
    private const string CustomerId = "100282";
    private readonly IPartyClient _client = new PartyClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    [Ignore("POST method")]
    public void CreateCustomerContactLogAsync()
    {
        var payload = new CustomerContactLog();
        var result = _client.CustomersContactHistoryService.CreateCustomerContactLogAsync(payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    public void GetCustomerContactLogAsync()
    {
        var result = _client.CustomersContactHistoryService.GetCustomerContactLogAsync(ContactHistoryId)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("PUT method")]
    public void UpdateCustomerContactLogAsync()
    {
        var contactHistoryId = string.Empty;
        var payload = new CustomerContactLog();
        var result = _client.CustomersContactHistoryService.UpdateCustomerContactLogAsync(contactHistoryId, payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    public void GetCustomerContactHistoryAsync()
    {
        var result = _client.CustomersContactHistoryService.GetCustomerContactHistoryAsync(CustomerId)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }
}