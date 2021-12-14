using OpenTemenos.DataHubs.OperationalDataStore;

namespace OpenTemenos.Tests.DataHub.OperationalDataStore.Reference;

[TestClass]
[TestCategory("DataHub.OperationalDataStore")]
public class BeneficialOwnerRuleServiceTests : CredentialManagement
{
    private readonly IReferenceClient _client = new ReferenceClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    public void GetBeneficialOwnerRulesAsync()
    {
        var result = _client.UsModelBankBeneficialRoleService.GetBeneficialOwnerRulesAsync().Result;
        Assert.IsNotNull(result.Data);
    }
}