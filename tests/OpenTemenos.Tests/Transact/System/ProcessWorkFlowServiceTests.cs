﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using Transact;

namespace OpenTemenos.Tests.Transact.System;

[TestClass]
public class ProcessWorkFlowServiceTests : CredentialManagement
{
    private readonly ISystemClient _client = new SystemClient(HttpClient);

}