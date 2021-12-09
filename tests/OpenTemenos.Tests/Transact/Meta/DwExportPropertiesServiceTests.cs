using Transact;

namespace OpenTemenos.Tests.Transact.Meta;

[TestClass]
public class DwExportPropertiesServiceTests : CredentialManagement
{
    private readonly IMetaClient _client = new MetaClient(HttpClient){ ReadResponseAsString = true };
}