using Transact;
using Transact.Party.TravelNotifications;

namespace OpenTemenos.Tests.Transact.Party;

[TestClass]
public class TravelNotificationsServiceTests : CredentialManagement
{
    private const string CustomerId = "100282";
    private readonly IPartyClient _client = new PartyClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    [Ignore("PUT method")]
    public void UpdateTravelNotificationAsync()
    {
        var travelNotificationId = string.Empty;
        var payload = new TravelNotification();
        var result = _client.TravelNotificationsService.UpdateTravelNotificationAsync(travelNotificationId, payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("DELETE method")]
    public void DeleteTravelNotificationAsync()
    {
        var travelNotificationId = string.Empty;
        var payload = new TravelNotificationDelete();
        var result = _client.TravelNotificationsService.DeleteTravelNotificationAsync(travelNotificationId, payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("POST method")]
    public void CreateTravelNotificationAsync()
    {
        var payload = new TravelNotification();
        var result = _client.TravelNotificationsService.CreateTravelNotificationAsync(payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("POST method")]
    public void GetCustomerTravelNotificationsAsync()
    {
        var result = _client.TravelNotificationsService.GetCustomerTravelNotificationsAsync(CustomerId)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }
}