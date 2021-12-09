using System.Diagnostics;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Transact;

namespace OpenTemenos.Tests.Transact.Reference;

[TestClass]
public class UsFdicClassCodesServiceTests : CredentialManagement
{
    private readonly IReferenceClient _client = new ReferenceClient(HttpClient);

    [TestMethod]
    public void GetFdicClassCodeAsync()
    {
        var result = _client.UsFdicClassCodesService.GetFdicClassCodeAsync(null, null, null, null, null, null).Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"FdicDepositClassCode: {result.Body.First().FdicDepositClassCode}");
        Debug.WriteLine($@"FdicDepositClassType: {result.Body.First().FdicDepositClassType}");
    }
}