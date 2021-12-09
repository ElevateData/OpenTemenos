using DataHub.OperationalDataStore;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OpenTemenos.Tests.DataHub.OperationalDataStore.Reference;

[TestClass]
public class BankBICDetailsServiceTests : CredentialManagement
{
    private readonly IReferenceClient _client = new ReferenceClient(HttpClient);

    [TestMethod]
    public void GetBankBICDetailsAsync()
    {
        var result = _client.SwiftBankCodeService.GetBankBICDetailsAsync(null, null).Result;
        Assert.IsNotNull(result.Data);
    }
}