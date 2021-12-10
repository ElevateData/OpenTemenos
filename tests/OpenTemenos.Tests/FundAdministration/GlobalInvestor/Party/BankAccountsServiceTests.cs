﻿using FundAdministration.GlobalInvestor;
using FundAdministration.GlobalInvestor.Party.BankAccounts;

namespace OpenTemenos.Tests.FundAdministration.GlobalInvestor.Party;

[TestClass]
public class BankAccountsServiceTests : CredentialManagement
{
    private const string InternalId = "1";
    private readonly IPartyClient _client = new PartyClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    [Ignore("POST method")]
    public void PostBankAccountsByParentAsync()
    {
        var payload = new _0Payload();
        var result = _client.BankAccountService.PostbankaccountsByParentAsync(null, null, null, null, null, payload)
            .Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("POST method")]
    public void PostBankAccountsAsync()
    {
        var payload = new _0Payload();
        var result = _client.BankAccountService.PostbankaccountsAsync(null, null, null, null, null, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("PUT method")]
    public void PutBankAccountsAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.BankAccountService.PutbankaccountsAsync(null, null, null, null, null, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("DELETE method")]
    public void DeleteBankAccountsAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.BankAccountService.DeletebankaccountsAsync(null, null, null, null, null, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    public void GetBankAccountsByInternalIdAsync()
    {
        var result = _client.BankAccountService
            .GetbankaccountsByInternalIdAsync(null, null, null, null, null, null, null, null, null, null, InternalId)
            .Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("PUT method")]
    public void PutBankAccountsByIdAsync()
    {
        var internalId = string.Empty;
        var payload = new _0Payload();
        var result = _client.BankAccountService
            .PutbankaccountsByIdAsync(null, null, null, null, null, internalId, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("DELETE method")]
    public void DeleteBankAccountsByIdAsync()
    {
        var internalId = string.Empty;
        var payload = new _0Payload();
        var result = _client.BankAccountService
            .DeletebankaccountsByIdAsync(null, null, null, null, null, internalId, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("POST method")]
    public void PostBankAccountsByParentProdAsync()
    {
        var payload = new _0Payload();
        var result = _client.BankAccountService.PostbankaccountsByParentProdAsync(null, null, null, null, null, payload)
            .Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("POST method")]
    public void PostBankAccountsProdAsync()
    {
        var payload = new _0Payload();
        var result = _client.BankAccountService.PostbankaccountsProdAsync(null, null, null, null, null, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("PUT method")]
    public void PutBankAccountsProdAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.BankAccountService.PutbankaccountsProdAsync(null, null, null, null, null, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("DELETE method")]
    public void DeleteBankAccountsProdAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.BankAccountService.DeletebankaccountsProdAsync(null, null, null, null, null, payload)
            .Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    public void GetBankAccountsByInternalIdProdAsync()
    {
        var result = _client.BankAccountService
            .GetbankaccountsByInternalIdProdAsync(null, null, null, null, null, null, null, null, null, null,
                InternalId).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("PUT method")]
    public void PutBankAccountsByIdProdAsync()
    {
        var internalId = string.Empty;
        var payload = new _0Payload();
        var result = _client.BankAccountService
            .PutbankaccountsByIdProdAsync(null, null, null, null, null, internalId, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("DELETE method")]
    public void DeleteBankAccountsByIdProdAsync()
    {
        var internalId = string.Empty;
        var payload = new _0Payload();
        var result = _client.BankAccountService
            .DeletebankaccountsByIdProdAsync(null, null, null, null, null, internalId, payload).Result;
        Assert.IsNotNull(result.Body);
    }
}