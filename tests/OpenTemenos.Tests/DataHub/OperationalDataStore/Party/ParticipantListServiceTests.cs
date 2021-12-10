using DataHub.OperationalDataStore;

namespace OpenTemenos.Tests.DataHub.OperationalDataStore.Party;

[TestClass, TestCategory("DataHub.OperationalDataStore")]
public class ParticipantListServiceTests : CredentialManagement
{
    private readonly IPartyClient _client = new PartyClient(HttpClient) { ReadResponseAsString = true };


    [TestMethod]
    public void GetParticipantListAsync()
    {
        var result = _client.ParticipantListService.GetParticipantListAsync().Result;
        Assert.IsNotNull(result.Data);
    }
}