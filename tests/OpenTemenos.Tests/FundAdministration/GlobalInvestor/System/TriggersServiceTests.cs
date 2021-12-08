using FundAdministration.GlobalInvestor;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OpenTemenos.Tests.FundAdministration.GlobalInvestor.System;

[TestClass]
public class TriggersServiceTests : CredentialManagement
{
    private readonly ISystemClient _client = new SystemClient(HttpClient);

}
