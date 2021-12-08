﻿using System.Diagnostics;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Transact;
using Transact.Reference.TransactionCodesServices;

namespace OpenTemenos.Tests.Transact.Reference;

[TestClass]
public class TransactionCodesServicesServiceTests : CredentialManagement
{
    private readonly IReferenceClient _client = new ReferenceClient(HttpClient);
    private const string TransactionCode = "1";

    [TestMethod]
    public void GetTransactionCodeAsync()
    {
        var result = _client.TransactionCodesServicesService.GetTransactionCodeAsync(TransactionCode, null, null, null, null).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod, Ignore("POST method")]
    public void CreateTransactionCodeAsync()
    {
        var transactionCode = string.Empty;
        var payload = new TransactionCode();
        var result = _client.TransactionCodesServicesService.CreateTransactionCodeAsync(transactionCode,  payload, null, null, null, null, null).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod, Ignore("PUT method")]
    public void UpdateTransactionCodeAsync()
    {
        var transactionCode = string.Empty;
        var payload = new TransactionCode();
        var result = _client.TransactionCodesServicesService.UpdateTransactionCodeAsync(transactionCode, payload, null, null, null, null, null).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    public void GetTransactionCodeListAsync()
    {
        var result = _client.TransactionCodesServicesService.GetTransactionCodeListAsync(null, null, null, null, null, null, null, null, null).Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"TransactionCode: {result.Body.First().TransactionCode}");
    }
}