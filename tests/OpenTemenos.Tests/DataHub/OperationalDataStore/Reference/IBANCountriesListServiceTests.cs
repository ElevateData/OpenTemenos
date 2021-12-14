using OpenTemenos.DataHubs.OperationalDataStore;

namespace OpenTemenos.Tests.DataHub.OperationalDataStore.Reference;

[TestClass]
[TestCategory("DataHub.OperationalDataStore")]
public class IBANCountriesListServiceTests : CredentialManagement
{
    private readonly IReferenceClient _client = new ReferenceClient(HttpClient) { ReadResponseAsString = true };

    private readonly string _recordId = string.Empty;

    [TestMethod]
    public void GetIBANBankDetailsAsync()
    {
        var result = _client.IbanStructureDetailService.GetIBANCountriesListAsync(_recordId).Result;
        Assert.IsNotNull(result.Data);
    }
}