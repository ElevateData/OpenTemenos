using Transact;

namespace OpenTemenos.Tests.Transact.Microservice;

[TestClass]
public class EntitlementServiceTests : CredentialManagement
{
    private readonly IMicroserviceClient _client = new MicroserviceClient(HttpClient){ ReadResponseAsString = true };
}