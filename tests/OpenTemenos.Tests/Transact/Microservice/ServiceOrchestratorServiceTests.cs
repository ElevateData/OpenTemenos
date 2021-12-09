using Transact;

namespace OpenTemenos.Tests.Transact.Microservice;

[TestClass]
public class ServiceOrchestratorServiceTests : CredentialManagement
{
    private readonly IMicroserviceClient _client = new MicroserviceClient(HttpClient);
}