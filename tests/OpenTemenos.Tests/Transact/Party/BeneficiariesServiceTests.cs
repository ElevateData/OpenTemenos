﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using Transact;

namespace OpenTemenos.Tests.Transact.Party;


[TestClass]
public class BeneficiariesServiceTests : CredentialManagement
{
    private readonly IPartyClient _client = new PartyClient(HttpClient);

}