using System.Diagnostics;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Transact;

namespace OpenTemenos.Tests.Transact.Reference;

[TestClass]
public class CollateralClassificationsServiceTests : CredentialManagement
{
    private readonly IReferenceClient _client = new ReferenceClient(HttpClient);
    private const string CollateralTypeId = "1";

    [TestMethod]
    public void GetCollateralTypesAsync()
    {
        var result = _client.CollateralClassificationsService.GetCollateralTypesAsync(null, null, null, null, null, null, null, null).Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"CollateralTypeIds: {string.Join(",", result.Body.First().CollateralTypeIds?.Select(i => i.CollateralTypeId)!)}");
    }
    [TestMethod]
    public void GetCollateralSubTypesAsync()
    {
        var result = _client.CollateralClassificationsService.GetCollateralSubTypesAsync(CollateralTypeId, null, null, null, null, null, null, null).Result;
        Assert.IsNotNull(result.Body);
    }
}