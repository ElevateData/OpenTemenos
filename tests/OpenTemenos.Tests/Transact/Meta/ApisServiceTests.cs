using Transact;

namespace OpenTemenos.Tests.Transact.Meta;

[TestClass]
public class ApisServiceTests : CredentialManagement
{
    private readonly IMetaClient _client = new MetaClient(HttpClient);
}