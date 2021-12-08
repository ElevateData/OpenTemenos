using System.Diagnostics;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Transact;

namespace OpenTemenos.Tests.Transact.Reference;

[TestClass]
public class ProductServiceTests : CredentialManagement
{
    private readonly IReferenceClient _client = new ReferenceClient(HttpClient);
    private const string RuleId = "";

    [TestMethod]
    public void GetPeriodicRuleAsync()
    {
        var result = _client.ProductService.GetPeriodicRuleAsync(RuleId, null, null, null, null, null, null, null).Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"PeriodicRule: {result.Body.First().PeriodicRule}");
    }
}