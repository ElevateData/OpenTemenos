using Transact;
using Transact.Holding.DerivativesOptions;

namespace OpenTemenos.Tests.Transact.Holding;

[TestClass]
public class DerivativesOptionsServiceTests : CredentialManagement
{
    private readonly IHoldingClient _client = new HoldingClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    public void GetSellOptionTradesAsync()
    {
        var result = _client.DerivativeInstrumentOperationService.GetSellOptionTradesAsync(null, null, null, null, null,
                null, null, null, null, null, null, null, null, null)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body.First())}");
    }

    [TestMethod]
    [Ignore("POST method")]
    public void CreateManualAssignOptionTradesAsync()
    {
        var payload = new ManualAssignOptionTrades();
        var result = _client.DerivativeInstrumentOperationService
            .CreateManualAssignOptionTradesAsync(payload, null, null, null)
            .Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    public void GetBuyOptionTradesAsync()
    {
        var result = _client.DerivativeInstrumentOperationService.GetBuyOptionTradesAsync(null, null, null, null, null,
                null, null, null, null, null, null, null, null, null)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body.First())}");
    }

    [TestMethod]
    [Ignore("POST method")]
    public void CreateManualExerciseOptionTradesAsync()
    {
        var payload = new ManualExerciseOptionTrades();
        var result = _client.DerivativeInstrumentOperationService
            .CreateManualExerciseOptionTradesAsync(payload, null, null, null)
            .Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    public void GetActiveOptionTradesAsync()
    {
        var result = _client.DerivativeInstrumentOperationService.GetActiveOptionTradesAsync(null, null, null, null,
                null, null, null, null, null, null, null, null, null, null)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body.First())}");
    }

    [TestMethod]
    [Ignore("POST method")]
    public void CreateManualExpireOptionTradesAsync()
    {
        var payload = new ManualExpireOptionTrades();
        var result = _client.DerivativeInstrumentOperationService
            .CreateManualExpireOptionTradesAsync(payload, null, null, null)
            .Result;
        Assert.IsNotNull(result.Body);
    }
}