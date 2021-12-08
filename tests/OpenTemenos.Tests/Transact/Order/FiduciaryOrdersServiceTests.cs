﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using Transact;

namespace OpenTemenos.Tests.Transact.Order;

[TestClass]
public class FiduciaryOrdersServiceTests : CredentialManagement
{
    private readonly IOrderClient _client = new OrderClient(HttpClient);

}