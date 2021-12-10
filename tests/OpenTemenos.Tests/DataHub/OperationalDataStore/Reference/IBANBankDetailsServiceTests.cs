using DataHub.OperationalDataStore;

namespace OpenTemenos.Tests.DataHub.OperationalDataStore.Reference;

[TestClass, TestCategory("DataHub.OperationalDataStore")]
public class IBANBankDetailServiceTests : CredentialManagement
{
    private readonly IReferenceClient _client = new ReferenceClient(HttpClient) { ReadResponseAsString = true };
    private readonly string _recordId = string.Empty;

    [TestMethod]
    public void GetIBANBankDetailsAsync()
    {
        var result = _client.IbanDetailService.GetIBANBankDetailsAsync(_recordId).Result;
        Assert.IsNotNull(result.Data);
    }
}