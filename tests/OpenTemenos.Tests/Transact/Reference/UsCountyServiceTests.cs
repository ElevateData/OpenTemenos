using System.Diagnostics;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Transact;

namespace OpenTemenos.Tests.Transact.Reference;

[TestClass]
public class UsCountyServiceTests : CredentialManagement
{
    private readonly IReferenceClient _client = new ReferenceClient(HttpClient);
    private const string StateId = "HI";

    [TestMethod]
    public void GetUsCountyListAsync()
    {
        var result = _client.UsCountyService.GetUsCountyListAsync(StateId, null, null, null, null, null).Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"CountyNames: {string.Join(",", result.Body.SelectMany(b => b.CountyNames!).SelectMany(c => c.CountyId!).Select(c => c))}");
    }
}