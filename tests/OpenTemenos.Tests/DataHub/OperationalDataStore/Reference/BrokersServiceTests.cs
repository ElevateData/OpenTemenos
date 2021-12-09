using DataHub.OperationalDataStore;

namespace OpenTemenos.Tests.DataHub.OperationalDataStore.Reference;

[TestClass]
public class BrokersServiceTests : CredentialManagement
{
    private readonly IReferenceClient _client = new ReferenceClient(HttpClient);

    [TestMethod]
    public void GetBrokersAsync()
    {
        var result = _client.BrokerService.GetBrokersAsync().Result;
        Assert.IsNotNull(result.Data);
    }
}