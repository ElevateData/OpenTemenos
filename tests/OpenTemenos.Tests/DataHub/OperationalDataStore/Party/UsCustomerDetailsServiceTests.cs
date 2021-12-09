using DataHub.OperationalDataStore;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OpenTemenos.Tests.DataHub.OperationalDataStore.Party;

[TestClass]
public class UsCustomerDetailsServiceTests : CredentialManagement
{
    private readonly IPartyClient _client = new PartyClient(HttpClient);
    private const string RecordId = "";

    [TestMethod]
    public void SearchUsDocumentsAsync()
    {
        var result = _client.UsModelBankCustomerDetailService.SearchUsDocumentsAsync(RecordId).Result;
        Assert.IsNotNull(result.Data);
    }
}