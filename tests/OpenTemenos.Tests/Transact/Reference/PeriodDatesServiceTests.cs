using Transact;

namespace OpenTemenos.Tests.Transact.Reference;

[TestClass, TestCategory("Transact")]
public class PeriodDateServiceTests : CredentialManagement
{
    private const string CurrencyOrPair = "";
    private readonly IReferenceClient _client = new ReferenceClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    public void GetPeriodDatesAsync()
    {
        var result = _client.PeriodDateService
            .GetPeriodDatesAsync(CurrencyOrPair).Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body.First())}");
    }
}