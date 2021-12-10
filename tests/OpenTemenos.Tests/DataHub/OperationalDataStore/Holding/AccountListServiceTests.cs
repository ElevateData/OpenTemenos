using DataHub.OperationalDataStore;

namespace OpenTemenos.Tests.DataHub.OperationalDataStore.Holding;

[TestClass, TestCategory("DataHub.OperationalDataStore")]
public class AccountListServiceTests : CredentialManagement
{
    private readonly IHoldingClient _client = new HoldingClient(HttpClient) { ReadResponseAsString = true };


    [TestMethod]
    public void GetNostroAccountListAsync()
    {
        var result = _client.NostroVostroAccountListService.GetNostroAccountListAsync().Result;
        Assert.IsNotNull(result.Data);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Data)}");
    }

    [TestMethod]
    public void GetVostroAccountListAsync()
    {
        var result = _client.NostroVostroAccountListService.GetVostroAccountListAsync().Result;
        Assert.IsNotNull(result.Data);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Data)}");
    }
}