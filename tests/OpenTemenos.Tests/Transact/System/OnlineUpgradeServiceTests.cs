﻿using Transact;

namespace OpenTemenos.Tests.Transact.System;

[TestClass]
public class OnlineUpgradeServiceTests : CredentialManagement
{
    private readonly ISystemClient _client = new SystemClient(HttpClient);
}