using DataHub.OperationalDataStore;

namespace OpenTemenos.Tests.DataHub.OperationalDataStore.Reference;

[TestClass, TestCategory("DataHub.OperationalDataStore")]
public class USIndustrylistServiceTests : CredentialManagement
{
    private readonly IReferenceClient _client = new ReferenceClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    public void GetUSIndustrylistAsync()
    {
        var result = _client.UsModelBankUsIndustryClassificationService.GetUSIndustrylistAsync().Result;
        Assert.IsNotNull(result.Data);
    }
}