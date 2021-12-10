using Transact;
using Transact.Microservice.CallbackRegistry;

namespace OpenTemenos.Tests.Transact.Microservice;

[TestClass]
public class CallbackRegistryServiceTests : CredentialManagement
{
    private readonly IMicroserviceClient _client = new MicroserviceClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    [Ignore("POST method")]
    public void CreateCallbackAsync()
    {
        var body = new Callback();
        var result = _client.CallbackRegistryService.CreateCallbackAsync(body)
            .Result;
        Assert.IsNotNull(result);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result)}");
    }

    [TestMethod]
    [Ignore("PUT method")]
    public void AcceptEventAsync()
    {
        var body = new EventMessage();
        var result = _client.CallbackRegistryService.AcceptEventAsync(body)
            .Result;
        Assert.IsNotNull(result);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result)}");
    }
}