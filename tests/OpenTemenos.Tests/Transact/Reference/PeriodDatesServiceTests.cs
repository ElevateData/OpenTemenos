using Transact;

namespace OpenTemenos.Tests.Transact.Reference;

[TestClass]
public class PeriodDatesServiceTests : CredentialManagement
{
    private const string CurrencyOrPair = "";
    private readonly IReferenceClient _client = new ReferenceClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    public void GetPeriodDatesAsync()
    {
        var result = _client.PeriodDatesService
            .GetPeriodDatesAsync(CurrencyOrPair, null, null, null, null, null, null, null, null).Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body.First())}");
    }
}