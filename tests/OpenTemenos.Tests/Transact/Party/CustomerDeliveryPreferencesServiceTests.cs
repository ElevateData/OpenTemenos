using Transact;
using Transact.Party.CustomerDeliveryPreferences;

namespace OpenTemenos.Tests.Transact.Party;

[TestClass]
public class CustomerDeliveryPreferencesServiceTests : CredentialManagement
{
    private const string CustomerId = "100282";
    private readonly IPartyClient _client = new PartyClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    public void GetCustomerDeliveryPreferencesAsync()
    {
        var result = _client.CustomerDeliveryPreferencesService.GetCustomerDeliveryPreferencesAsync(CustomerId)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("POST method")]
    public void CreateCustomerDeliveryPreferenceAsync()
    {
        var customerId = string.Empty;
        var payload = new CustomerDeliveryPreference();
        var result = _client.CustomerDeliveryPreferencesService.CreateCustomerDeliveryPreferenceAsync(customerId, payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("PUT method")]
    public void UpdateCustomerDeliveryPreferenceAsync()
    {
        var customerId = string.Empty;
        var payload = new CustomerDeliveryPreference();
        var result = _client.CustomerDeliveryPreferencesService.UpdateCustomerDeliveryPreferenceAsync(customerId, payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("DELETE method")]
    public void DeleteCustomerDeliveryPreferenceAsync()
    {
        var customerId = string.Empty;
        var payload = new CustomerDeliveryPreferenceDelete();
        var result = _client.CustomerDeliveryPreferencesService.DeleteCustomerDeliveryPreferenceAsync(customerId, payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }
}