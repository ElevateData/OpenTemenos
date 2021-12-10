using Transact;
using Transact.Party.CustomersMiFID;

namespace OpenTemenos.Tests.Transact.Party;

[TestClass]
public class CustomersMiFIDServiceTests : CredentialManagement
{
    private const string CustomerId = "100282";
    private readonly IPartyClient _client = new PartyClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    public void GetMiFIDClientInformationAsync()
    {
        var result = _client.CustomersMiFIDService.GetMiFIDClientInformationAsync(CustomerId)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("POST method")]
    public void CreateMiFIDClientInformationAsync()
    {
        var customerId = string.Empty;
        var payload = new MiFIDClientInformation();
        var result = _client.CustomersMiFIDService.CreateMiFIDClientInformationAsync(customerId, payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("PUT method")]
    public void UpdateMiFIDClientInformationAsync()
    {
        var customerId = string.Empty;
        var payload = new MiFIDClientInformation();
        var result = _client.CustomersMiFIDService.UpdateMiFIDClientInformationAsync(customerId, payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }
}