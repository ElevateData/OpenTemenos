﻿using FundAdministration.GlobalInvestor;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OpenTemenos.Tests.FundAdministration.GlobalInvestor.Party;

[TestClass]
public class FatcaCrsSubStatusesServiceTests : CredentialManagement
{
    private readonly IPartyClient _client = new PartyClient(HttpClient);

}