using Transact;

namespace OpenTemenos.Tests.Transact.Party;

[TestClass]
public class CustomersMiFIDServiceTests : CredentialManagement
{
    private readonly IPartyClient _client = new PartyClient(HttpClient){ ReadResponseAsString = true };
}