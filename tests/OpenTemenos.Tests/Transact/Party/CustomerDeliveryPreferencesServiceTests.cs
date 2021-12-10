using Transact;
using Transact.Party.CustomerDeliveryPreferences;

namespace OpenTemenos.Tests.Transact.Party;

[TestClass, TestCategory("Transact")]
public class CustomerDeliveryPreferenceServiceTests : CredentialManagement
{
    private const string CustomerId = "100282";
    private readonly IPartyClient _client = new PartyClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    public void GetCustomerDeliveryPreferencesAsync()
    {
        var result = _client.CustomerDeliveryPreferenceService.GetCustomerDeliveryPreferencesAsync(CustomerId)
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
        var result = _client.CustomerDeliveryPreferenceService
            .CreateCustomerDeliveryPreferenceAsync(customerId, payload)
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
        var result = _client.CustomerDeliveryPreferenceService
            .UpdateCustomerDeliveryPreferenceAsync(customerId, payload)
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
        var result = _client.CustomerDeliveryPreferenceService
            .DeleteCustomerDeliveryPreferenceAsync(customerId, payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }
}