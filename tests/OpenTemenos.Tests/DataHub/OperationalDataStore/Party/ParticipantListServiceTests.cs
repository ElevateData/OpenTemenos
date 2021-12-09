using DataHub.OperationalDataStore;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OpenTemenos.Tests.DataHub.OperationalDataStore.Party;

[TestClass]
public class ParticipantListServiceTests : CredentialManagement
{
    private readonly IPartyClient _client = new PartyClient(HttpClient);


    [TestMethod]
    public void GetParticipantListAsync()
    {
        var result = _client.ParticipantListService.GetParticipantListAsync(null, null, null).Result;
        Assert.IsNotNull(result.Data);
    }
}