using Transact;

namespace OpenTemenos.Tests.Transact.Microservice;

[TestClass]
public class MeteringServiceTests : CredentialManagement
{
    private readonly IMicroserviceClient _client = new MicroserviceClient(HttpClient) { ReadResponseAsString = true };
}