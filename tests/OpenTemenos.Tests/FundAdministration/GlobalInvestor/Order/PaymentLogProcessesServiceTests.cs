﻿using FundAdministration.GlobalInvestor;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OpenTemenos.Tests.FundAdministration.GlobalInvestor.Order;

[TestClass]
public class PaymentLogProcessesServiceTests : CredentialManagement
{
    private readonly IOrderClient _client = new OrderClient(HttpClient);

}