using Transact;

namespace OpenTemenos.Tests.Transact.Microservice;

[TestClass]
public class TraceabilityServiceTests : CredentialManagement
{
    private readonly IMicroserviceClient _client = new MicroserviceClient(HttpClient){ ReadResponseAsString = true };
}