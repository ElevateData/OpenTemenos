using DataHub.OperationalDataStore;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OpenTemenos.Tests.DataHub.OperationalDataStore.Reference;

[TestClass]
public class FdicDepositClassCodeListServiceTests : CredentialManagement
{
    private readonly IReferenceClient _client = new ReferenceClient(HttpClient);

    [TestMethod]
    public void GetFdicDepositClassCodeListAsync()
    {
        var result = _client.UsModelBankFdicSubClassificationCodeService.GetFdicDepositClassCodeListAsync(null).Result;
        Assert.IsNotNull(result.Data);
    }
}