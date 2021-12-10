using Transact;

namespace OpenTemenos.Tests.Transact.System;

[TestClass]
public class DocumentRequiredServiceTests : CredentialManagement
{
    private readonly ISystemClient _client = new SystemClient(HttpClient) { ReadResponseAsString = true };
}