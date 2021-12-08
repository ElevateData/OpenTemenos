using Microsoft.VisualStudio.TestTools.UnitTesting;
using Transact;

namespace OpenTemenos.Tests.Transact.Reference;

[TestClass]
public class BalanceTypesServiceTests : CredentialManagement
{
    private readonly IReferenceClient _client = new ReferenceClient(HttpClient);

    [TestMethod]
    public void GetBalanceTypesAsync()
    {
        var result = _client.BalanceTypesService.GetBalanceTypesAsync(null, null, null, null, null).Result;
        Assert.IsNotNull(result.Body);
    }
}