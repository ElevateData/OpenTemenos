﻿using DataHub.OperationalDataStore;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OpenTemenos.Tests.DataHub.OperationalDataStore.Product;

[TestClass]
public class ProductConditionDetailsServiceTests : CredentialManagement
{
    private readonly IProductClient _client = new ProductClient(HttpClient);

}