using System.Diagnostics;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Transact;

namespace OpenTemenos.Tests.Transact.Reference;

[TestClass]
public class UsBenOwnerTypesServiceTests : CredentialManagement
{
    private readonly IReferenceClient _client = new ReferenceClient(HttpClient);

    [TestMethod]
    public void GetUsBeneficialOwnerTypesAsync()
    {
        var result = _client.UsBenOwnerTypesService.GetUsBeneficialOwnerTypesAsync(null, null, null, null, null).Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"OwnershipRuleIds: {string.Join(",", result.Body.Select(c => c.OwnershipRuleId))}");
    }
}