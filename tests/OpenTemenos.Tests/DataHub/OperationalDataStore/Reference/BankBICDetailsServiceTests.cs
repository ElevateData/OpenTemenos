using DataHub.OperationalDataStore;

namespace OpenTemenos.Tests.DataHub.OperationalDataStore.Reference;

[TestClass, TestCategory("DataHub.OperationalDataStore")]
public class BankBICDetailServiceTests : CredentialManagement
{
    private readonly IReferenceClient _client = new ReferenceClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    public void GetBankBICDetailsAsync()
    {
        var result = _client.SwiftBankCodeService.GetBankBICDetailsAsync().Result;
        Assert.IsNotNull(result.Data);
    }
}