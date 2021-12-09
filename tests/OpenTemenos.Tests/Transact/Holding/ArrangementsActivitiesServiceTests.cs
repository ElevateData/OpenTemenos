using Transact;

namespace OpenTemenos.Tests.Transact.Holding;

[TestClass]
[Ignore("All methods are flagged as obsolete")]
public class ArrangementsActivitiesServiceTests : CredentialManagement
{
    private const string ArrangementId = "";
    private readonly IHoldingClient _client = new HoldingClient(HttpClient){ ReadResponseAsString = true };

    [TestMethod]
    [Ignore("Obsolete")]
    [global::System.Obsolete("Flagged by Temenos")]
    public void GetArrangementActivityLogAsync()
    {
        var result = _client.ArrangementsActivityService.GetArrangementActivityLogAsync(ArrangementId, null, null, null,
                null, null, null, null, null, null, null, null)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }
}