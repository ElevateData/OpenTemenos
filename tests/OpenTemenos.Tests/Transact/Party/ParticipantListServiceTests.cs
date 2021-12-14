using OpenTemenos.Transacts;

namespace OpenTemenos.Tests.Transact.Party;

[TestClass]
[TestCategory("Transact")]
public class ParticipantListServiceTests : CredentialManagement
{
    private readonly IPartyClient _client = new PartyClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    public void GetParticipantListAsync()
    {
        var result = _client.ParticipantListService.GetParticipantListAsync()
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }
}