using System.Linq;
using Transact;

namespace OpenTemenos.Tests.Transact.Reference;

[TestClass]
public class UsCustomerSuffixServiceTests : CredentialManagement
{
    private readonly IReferenceClient _client = new ReferenceClient(HttpClient);

    [TestMethod]
    public void GetUsSuffixListAsync()
    {
        var result = _client.UsCustomerSuffixService.GetUsSuffixListAsync(null, null, null, null, null).Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body.First())}");
    }
}