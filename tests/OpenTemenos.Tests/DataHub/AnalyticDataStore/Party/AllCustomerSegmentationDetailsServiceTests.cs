using DataHub.AnalyticDataStore;

namespace OpenTemenos.Tests.DataHub.AnalyticDataStore.Party;

[TestClass]
[TestCategory("DataHub.AnalyticDataStore")]
public class AllCustomerSegmentationDetailServiceTests : CredentialManagement
{
    private readonly IPartyClient _client = new PartyClient(HttpClient) { ReadResponseAsString = true };


    [TestMethod]
    public void GetAllCustomerSegmentationDetailsAsync()
    {
        var result = _client.CustomerSegmentationService.GetAllCustomerSegmentationDetailsAsync().Result;
        Assert.IsNotNull(result.Data);
    }
}