﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using Transact;

namespace OpenTemenos.Tests.Transact.Meta;

[TestClass]
public class UserAdministrationInternalServiceTests : CredentialManagement
{
    private readonly IMetaClient _client = new MetaClient(HttpClient);

}