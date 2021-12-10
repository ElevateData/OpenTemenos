using Transact;

namespace OpenTemenos.Tests.Transact.System;

[TestClass]
public class ExternalAccountingServiceTests : CredentialManagement
{
    private readonly ISystemClient _client = new SystemClient(HttpClient) { ReadResponseAsString = true };
}