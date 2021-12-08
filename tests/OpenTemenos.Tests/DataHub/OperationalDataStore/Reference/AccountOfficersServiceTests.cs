using DataHub.OperationalDataStore;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OpenTemenos.Tests.DataHub.OperationalDataStore.Reference;

[TestClass]
public class AccountOfficersServiceTests : CredentialManagement
{
    private readonly IReferenceClient _client = new ReferenceClient(HttpClient);

    [TestMethod]
    public void GetAccountOfficersAsync()
    {
        var result = _client.AccountOfficerService.GetAccountOfficersAsync().Result;
        Assert.IsNotNull(result.Data);
    }
}
