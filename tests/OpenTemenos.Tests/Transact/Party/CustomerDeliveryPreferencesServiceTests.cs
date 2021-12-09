using Transact;

namespace OpenTemenos.Tests.Transact.Party;

[TestClass]
public class CustomerDeliveryPreferencesServiceTests : CredentialManagement
{
    private readonly IPartyClient _client = new PartyClient(HttpClient);
}