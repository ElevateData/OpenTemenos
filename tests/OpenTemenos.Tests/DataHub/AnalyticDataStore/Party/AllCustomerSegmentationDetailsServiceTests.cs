using DataHub.AnalyticDataStore;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OpenTemenos.Tests.DataHub.AnalyticDataStore.Party;


[TestClass]
public class AllCustomerSegmentationDetailsServiceTests : CredentialManagement
{
    private readonly IPartyClient _client = new PartyClient(HttpClient);


    [TestMethod]
    public void GetAllCustomerSegmentationDetailsAsync()
    {
        var result = _client.CustomerSegmentationService.GetAllCustomerSegmentationDetailsAsync(null, null).Result;
        Assert.IsNotNull(result.Data);
    }
}
