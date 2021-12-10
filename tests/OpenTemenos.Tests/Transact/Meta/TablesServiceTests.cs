using Transact;

namespace OpenTemenos.Tests.Transact.Meta;

[TestClass]
public class TablesServiceTests : CredentialManagement
{
    private readonly IMetaClient _client = new MetaClient(HttpClient) { ReadResponseAsString = true };
}