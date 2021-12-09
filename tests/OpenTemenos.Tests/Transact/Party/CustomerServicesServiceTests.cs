using Transact;

namespace OpenTemenos.Tests.Transact.Party;

[TestClass]
public class CustomerServicesServiceTests : CredentialManagement
{
    private readonly IPartyClient _client = new PartyClient(HttpClient);
}