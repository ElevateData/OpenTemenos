using Microsoft.VisualStudio.TestTools.UnitTesting;
using Transact;

namespace OpenTemenos.Tests.Transact.System;

[TestClass]
public class CloudServiceElasticityServiceTests : CredentialManagement
{
    private readonly ISystemClient _client = new SystemClient(HttpClient);

}