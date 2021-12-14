using OpenTemenos.DataHubs.OperationalDataStore;

namespace OpenTemenos.Tests.DataHub.OperationalDataStore.Reference;

[TestClass]
[TestCategory("DataHub.OperationalDataStore")]
public class LookUpTableDetailServiceTests : CredentialManagement
{
    private readonly IReferenceClient _client = new ReferenceClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    public void GetEbLookupsAsync()
    {
        var result = _client.LookupTableService.GetEbLookupsAsync().Result;
        Assert.IsNotNull(result.Data);
    }
}