using DataHub.OperationalDataStore;

namespace OpenTemenos.Tests.DataHub.OperationalDataStore.Party;

[TestClass]
public class CustomerDetailsServiceTests : CredentialManagement
{
    private const string RecordId = "";
    private const string FromCustomerId = "";
    private const string CutomerId = "";
    private readonly IPartyClient _client = new PartyClient(HttpClient);

    [TestMethod]
    public void GetCustomerKycDetailsAsync()
    {
        var result = _client.CustomerDetailService.GetCustomerKycDetailsAsync(RecordId).Result;
        Assert.IsNotNull(result.Data);
    }

    [TestMethod]
    public void GetCustomerKycListAsync()
    {
        var result = _client.CustomerDetailService.GetCustomerKycListAsync(null).Result;
        Assert.IsNotNull(result.Data);
    }

    [TestMethod]
    public void GetCustomerNoKycListAsync()
    {
        var result = _client.CustomerDetailService.GetCustomerNoKycListAsync(null).Result;
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
        var result = _client.CustomerDetailService.GetCustomerRelationshipDetailsAsync(null, null, null, null).Result;
        Assert.IsNotNull(result.Data);
    }

    [TestMethod]
    public void GetSecureMessagesForCustomerAsync()
    {
        var result = _client.CustomerDetailService
            .GetSecureMessagesForCustomerAsync(FromCustomerId, null, null, null, null).Result;
        Assert.IsNotNull(result.Data);
    }

    [TestMethod]
    public void GetSecureMessagesAsync()
    {
        var result = _client.CustomerDetailService.GetSecureMessagesAsync(null, null, null, null, null).Result;
        Assert.IsNotNull(result.Data);
    }

    [TestMethod]
    public void GetCustomerTravelNotificationsAsync()
    {
        var result = _client.CustomerDetailService.GetCustomerTravelNotificationsAsync(CutomerId, null, null).Result;
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
        var result = _client.CustomerDetailService.GetCustomerDeliveryPreferencesAsync(new object(), null).Result;
        Assert.IsNotNull(result.Data);
    }
}