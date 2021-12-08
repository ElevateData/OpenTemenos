using DataHub.OperationalDataStore;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OpenTemenos.Tests.DataHub.OperationalDataStore.System;

[TestClass]
public class ServiceDetailsServiceTests : CredentialManagement
{
    private readonly ISystemClient _client = new SystemClient(HttpClient);

}