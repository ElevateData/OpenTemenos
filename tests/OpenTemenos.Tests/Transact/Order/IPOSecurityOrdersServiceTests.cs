﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using Transact;

namespace OpenTemenos.Tests.Transact.Order;

[TestClass]
public class IPOSecurityOrdersServiceTests : CredentialManagement
{
    private readonly IOrderClient _client = new OrderClient(HttpClient);

}