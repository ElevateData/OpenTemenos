using Transact;
using Transact.Holding.Alerts;

namespace OpenTemenos.Tests.Transact.Holding;

[TestClass]
public class AlertsServiceTests : CredentialManagement
{
    private const string ArrangementId = "1";
    private const string AccountId = "101125";
    private readonly IHoldingClient _client = new HoldingClient(HttpClient){ ReadResponseAsString = true };

    [TestMethod]
    public void GetPackageStatementAsync()
    {
        var result = _client.ArrangementAccountAlertService.GetSubscribedAlertsAsync(ArrangementId, null, null, null,
                null, null, null, null, null, null, null, null)
            .Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    public void GetEligibleEventsAsync()
    {
        var result = _client.ArrangementAccountAlertService
            .GetEligibleEventsAsync(AccountId, null, null, null, null, null, null, null, null)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body.First())}");
    }

    [TestMethod]
    public void GetExternalSubscribersAlertRequestsAsync()
    {
        var result = _client.ArrangementAccountAlertService.GetExternalSubscribersAlertRequestsAsync(null, null, null,
                null, null, null, null, null, null, null, null, null, null)
            .Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("POST method")]
    public void CreateAlertSubscriptionAsync()
    {
        var payload = new AlertSubscription();
        var result = _client.ArrangementAccountAlertService
            .CreateAlertSubscriptionAsync(payload, null, null, null, null, null)
            .Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("PUT method")]
    public void UpdateAlertSubscriptionAsync()
    {
        var alertRequestId = string.Empty;
        var payload = new AlertSubscription();
        var result = _client.ArrangementAccountAlertService
            .UpdateAlertSubscriptionAsync(alertRequestId, payload, null, null, null, null, null)
            .Result;
        Assert.IsNotNull(result.Body);
    }
}