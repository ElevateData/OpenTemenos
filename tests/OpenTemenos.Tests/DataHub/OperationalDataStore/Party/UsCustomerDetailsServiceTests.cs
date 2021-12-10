using DataHub.OperationalDataStore;

namespace OpenTemenos.Tests.DataHub.OperationalDataStore.Party;

[TestClass, TestCategory("DataHub.OperationalDataStore")]
public class UsCustomerDetailServiceTests : CredentialManagement
{
    private const string RecordId = "";
    private readonly IPartyClient _client = new PartyClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    public void SearchUsDocumentsAsync()
    {
        var result = _client.UsModelBankCustomerDetailService.SearchUsDocumentsAsync(RecordId).Result;
        Assert.IsNotNull(result.Data);
    }
}