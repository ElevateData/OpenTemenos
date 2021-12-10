using Transact;
using Transact.Microservice.ServiceOrchestrators;

namespace OpenTemenos.Tests.Transact.Microservice;

[TestClass, TestCategory("Transact")]
public class ServiceOrchestratorServiceTests : CredentialManagement
{
    private const string SequenceId = "1";
    private readonly IMicroserviceClient _client = new MicroserviceClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    [Ignore("POST method")]
    public void CreateSequenceAsync()
    {
        var body = new Sequence();
        var result = _client.ServiceOrchestratorService.CreateSequenceAsync(body)
            .Result;
        Assert.IsNotNull(result);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result)}");
    }

    [TestMethod]
    public void GetSequenceAsync()
    {
        var result = _client.ServiceOrchestratorService.GetSequenceAsync()
            .Result;
        Assert.IsNotNull(result);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result)}");
    }

    [TestMethod]
    public void GetSequenceByIdAsync()
    {
        var result = _client.ServiceOrchestratorService.GetSequenceByIdAsync(SequenceId)
            .Result;
        Assert.IsNotNull(result);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result)}");
    }

    [TestMethod]
    [Ignore("PUT method")]
    public void CancelSequenceAsync()
    {
        var result = _client.ServiceOrchestratorService.CancelSequenceAsync(SequenceId)
            .Result;
        Assert.IsNotNull(result);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result)}");
    }
}