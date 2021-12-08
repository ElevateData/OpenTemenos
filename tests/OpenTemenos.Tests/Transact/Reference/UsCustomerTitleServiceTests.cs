﻿using System.Diagnostics;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Transact;

namespace OpenTemenos.Tests.Transact.Reference;

[TestClass]
public class UsCustomerTitleServiceTests : CredentialManagement
{
    private readonly IReferenceClient _client = new ReferenceClient(HttpClient);

    [TestMethod]
    public void GetUsCustomerTitlesAsync()
    {
        var result = _client.UsCustomerTitleService.GetUsCustomerTitlesAsync(null, null, null, null, null).Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Title: {result.Body.First().Title}");
    }
}