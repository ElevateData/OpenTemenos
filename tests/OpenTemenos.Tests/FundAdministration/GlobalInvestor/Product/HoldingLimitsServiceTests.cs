﻿using FundAdministration.GlobalInvestor;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OpenTemenos.Tests.FundAdministration.GlobalInvestor.Product;

[TestClass]
public class HoldingLimitsServiceTests : CredentialManagement
{
    private readonly IProductClient _client = new ProductClient(HttpClient);

}