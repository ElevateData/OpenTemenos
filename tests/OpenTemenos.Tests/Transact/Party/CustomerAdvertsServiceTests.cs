using Transact;
using Transact.Party.CustomerAdverts;

namespace OpenTemenos.Tests.Transact.Party;

[TestClass]
public class CustomerAdvertsServiceTests : CredentialManagement
{
    private const string CustomerId = "100282";
    private readonly IPartyClient _client = new PartyClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    public void GetCustomerAdvertsAsync()
    {
        var result = _client.CustomerAdvertsService.GetCustomerAdvertsAsync(CustomerId)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("PUT method")]
    public void UpdateAdvertAsync()
    {
        var advertId = string.Empty;
        var payload = new Advert();
        var result = _client.CustomerAdvertsService.UpdateAdvertAsync(advertId, payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("POST method")]
    public void CreateAdvertAsync()
    {
        var payload = new Advert();
        var result = _client.CustomerAdvertsService.CreateAdvertAsync(payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }
}