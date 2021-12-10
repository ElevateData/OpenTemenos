using System;
using Transact;

namespace OpenTemenos.Tests.Transact.Holding;

[TestClass]
[Ignore("All methods are flagged as obsolete")]
public class ArrangementsActivitiesServiceTests : CredentialManagement
{
    private const string ArrangementId = "";
    private readonly IHoldingClient _client = new HoldingClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    [Ignore("Obsolete")]
    [Obsolete("Flagged by Temenos")]
    public void GetArrangementActivityLogAsync()
    {
        var result = _client.ArrangementsActivityService.GetArrangementActivityLogAsync(ArrangementId)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }
}