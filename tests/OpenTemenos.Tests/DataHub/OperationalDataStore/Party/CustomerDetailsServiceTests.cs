using DataHub.OperationalDataStore;

namespace OpenTemenos.Tests.DataHub.OperationalDataStore.Party;

[TestClass, TestCategory("DataHub.OperationalDataStore")]
public class CustomerDetailServiceTests : CredentialManagement
{
    private const string RecordId = "";
    private const string FromCustomerId = "100282";
    private const string CutomerId = "";
    private readonly IPartyClient _client = new PartyClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    public void GetCustomerKycDetailsAsync()
    {
        var result = _client.CustomerDetailService.GetCustomerKycDetailsAsync(RecordId).Result;
        Assert.IsNotNull(result.Data);
    }

    [TestMethod]
    public void GetCustomerKycListAsync()
    {
        var result = _client.CustomerDetailService.GetCustomerKycListAsync().Result;
        Assert.IsNotNull(result.Data);
    }

    [TestMethod]
    public void GetCustomerNoKycListAsync()
    {
        var result = _client.CustomerDetailService.GetCustomerNoKycListAsync().Result;
        Assert.IsNotNull(result.Data);
    }

    [TestMethod]
    public void GetCustomerForMDALAsync()
    {
        var result = _client.CustomerDetailService.GetCustomerForMDALAsync(RecordId).Result;
        Assert.IsNotNull(result.Data);
    }

    [TestMethod]
    public void GetCustomerRelationshipDetailsAsync()
    {
        var result = _client.CustomerDetailService.GetCustomerRelationshipDetailsAsync().Result;
        Assert.IsNotNull(result.Data);
    }

    [TestMethod]
    public void GetSecureMessagesForCustomerAsync()
    {
        var result = _client.CustomerDetailService
            .GetSecureMessagesForCustomerAsync(FromCustomerId).Result;
        Assert.IsNotNull(result.Data);
    }

    [TestMethod]
    public void GetSecureMessagesAsync()
    {
        var result = _client.CustomerDetailService.GetSecureMessagesAsync().Result;
        Assert.IsNotNull(result.Data);
    }

    [TestMethod]
    public void GetCustomerTravelNotificationsAsync()
    {
        var result = _client.CustomerDetailService.GetCustomerTravelNotificationsAsync(CutomerId).Result;
        Assert.IsNotNull(result.Data);
    }

    [TestMethod]
    public void GetProspectCustomersAsync()
    {
        var result = _client.CustomerDetailService.GetProspectCustomersAsync().Result;
        Assert.IsNotNull(result.Data);
    }

    [TestMethod]
    [Ignore("Invalid request object")]
    public void GetCustomerDeliveryPreferencesAsync()
    {
        var result = _client.CustomerDetailService.GetCustomerDeliveryPreferencesAsync(new object()).Result;
        Assert.IsNotNull(result.Data);
    }
}