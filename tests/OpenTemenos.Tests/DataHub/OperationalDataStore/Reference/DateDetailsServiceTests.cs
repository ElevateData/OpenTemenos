using OpenTemenos.DataHubs.OperationalDataStore;

namespace OpenTemenos.Tests.DataHub.OperationalDataStore.Reference;

[TestClass]
[TestCategory("DataHub.OperationalDataStore")]
public class DateDetailServiceTests : CredentialManagement
{
    private readonly IReferenceClient _client = new ReferenceClient(HttpClient) { ReadResponseAsString = true };
    private readonly string _recordId = string.Empty;

    [TestMethod]
    public void GetDatesByCompanyAsync()
    {
        var result = _client.SystemBusinessDateService.GetDatesByCompanyAsync(_recordId).Result;
        Assert.IsNotNull(result.Data);
    }

    [TestMethod]
    public void GetDatesAsync()
    {
        var result = _client.SystemBusinessDateService.GetDatesAsync().Result;
        Assert.IsNotNull(result.Data);
    }
}