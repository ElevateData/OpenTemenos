﻿using Transact;

namespace OpenTemenos.Tests.Transact.Holding;

[TestClass]
public class ForexUtilizationsServiceTests : CredentialManagement
{
    private readonly IHoldingClient _client = new HoldingClient(HttpClient);
}