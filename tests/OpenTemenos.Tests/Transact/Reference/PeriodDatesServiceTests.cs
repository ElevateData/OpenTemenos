using System.Diagnostics;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Transact;

namespace OpenTemenos.Tests.Transact.Reference;

[TestClass]
public class PeriodDatesServiceTests : CredentialManagement
{
    private readonly IReferenceClient _client = new ReferenceClient(HttpClient);
    private const string CurrencyOrPair = "";

    [TestMethod]
    public void GetPeriodDatesAsync()
    {
        var result = _client.PeriodDatesService.GetPeriodDatesAsync(CurrencyOrPair, null, null, null, null, null, null, null, null).Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"BicId: {result.Body.First().Date}");
    }
}