using DataHub.OperationalDataStore;

namespace OpenTemenos.Tests.DataHub.OperationalDataStore.Reference;

[TestClass, TestCategory("DataHub.OperationalDataStore")]
public class SecurityInstrumentServiceTests : CredentialManagement
{
    private readonly IReferenceClient _client = new ReferenceClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    public void GetActiveIPOsAsync()
    {
        var result = _client.SecurityInstrumentService.GetActiveIPOsAsync().Result;
        Assert.IsNotNull(result.Data);
    }

    [TestMethod]
    public void GetInstrumentsBondsAsync()
    {
        var result = _client.SecurityInstrumentService
            .GetInstrumentsBondsAsync().Result;
        Assert.IsNotNull(result.Data);
    }

    [TestMethod]
    public void GetFutureContractsAsync()
    {
        var result = _client.SecurityInstrumentService.GetFutureContractsAsync().Result;
        Assert.IsNotNull(result.Data);
    }

    [TestMethod]
    public void GetOptionContractsAsync()
    {
        var result = _client.SecurityInstrumentService.GetOptionContractsAsync().Result;
        Assert.IsNotNull(result.Data);
    }
}