using DataHub.OperationalDataStore;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OpenTemenos.Tests.DataHub.OperationalDataStore.Reference;

[TestClass]
public class BeneficialOwnerRulesServiceTests : CredentialManagement
{
    private readonly IReferenceClient _client = new ReferenceClient(HttpClient);

    [TestMethod]
    public void GetBeneficialOwnerRulesAsync()
    {
        var result = _client.UsModelBankBeneficialRoleService.GetBeneficialOwnerRulesAsync().Result;
        Assert.IsNotNull(result.Data);
    }
}