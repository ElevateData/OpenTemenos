﻿using System.Diagnostics;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Transact;

namespace OpenTemenos.Tests.Transact.Reference;

[TestClass]
public class PortfolioAccountsServiceTests : CredentialManagement
{
    private readonly IReferenceClient _client = new ReferenceClient(HttpClient);
    private const string PortfolioId = "";

    [TestMethod]
    public void GetPortfolioAccountsAsync()
    {
        var result = _client.PortfolioAccountsService.GetPortfolioAccountsAsync(PortfolioId, null, null, null, null, null, null).Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"AccountId: {result.Body.First().AccountId}");
    }
}