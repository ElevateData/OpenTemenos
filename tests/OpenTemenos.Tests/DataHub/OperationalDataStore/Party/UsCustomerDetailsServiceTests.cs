﻿using DataHub.OperationalDataStore;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OpenTemenos.Tests.DataHub.OperationalDataStore.Party;

[TestClass]
public class UsCustomerDetailsServiceTests : CredentialManagement
{
    private readonly IPartyClient _client = new PartyClient(HttpClient);

}