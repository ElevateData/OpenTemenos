using DataHub.OperationalDataStore;

namespace OpenTemenos.Tests.DataHub.OperationalDataStore.Reference;

[TestClass]
public class BeneficialOwnerRulesServiceTests : CredentialManagement
{
    private readonly IReferenceClient _client = new ReferenceClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    public void GetBeneficialOwnerRulesAsync()
    {
        var result = _client.UsModelBankBeneficialRoleService.GetBeneficialOwnerRulesAsync().Result;
        Assert.IsNotNull(result.Data);
    }
}