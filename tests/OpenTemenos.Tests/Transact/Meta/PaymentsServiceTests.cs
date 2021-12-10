using Transact;

namespace OpenTemenos.Tests.Transact.Meta;

[TestClass]
public class PaymentsServiceTests : CredentialManagement
{
    private readonly IMetaClient _client = new MetaClient(HttpClient) { ReadResponseAsString = true };
}