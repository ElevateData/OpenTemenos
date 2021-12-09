using System.Linq;
using Transact;

namespace OpenTemenos.Tests.Transact.Reference;

[TestClass]
public class ChequeTypesServiceTests : CredentialManagement
{
    private readonly IReferenceClient _client = new ReferenceClient(HttpClient);

    [TestMethod]
    public void GetChequeTypesAsync()
    {
        var result = _client.ChequeTypesService
            .GetChequeTypesAsync(null, null, null, null, null, null, null, null, null).Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body.First())}");
    }
}