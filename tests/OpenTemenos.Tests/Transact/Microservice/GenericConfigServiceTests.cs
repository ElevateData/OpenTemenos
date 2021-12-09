using Transact;

namespace OpenTemenos.Tests.Transact.Microservice;

[TestClass]
public class GenericConfigServiceTests : CredentialManagement
{
    private readonly IMicroserviceClient _client = new MicroserviceClient(HttpClient);
}