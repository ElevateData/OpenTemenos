﻿using FundAdministration.GlobalInvestor;
using FundAdministration.GlobalInvestor.Product.FundGroupCutoff;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OpenTemenos.Tests.FundAdministration.GlobalInvestor.Product;

[TestClass]
public class FundGroupCutoffServiceTests : CredentialManagement
{
    private readonly IProductClient _client = new ProductClient(HttpClient);

    [TestMethod, Ignore("POST method")]
    public void PostCutoffByGroupAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.CutoffByFundGroupService.PostCutoffByGroupAsync(null, null, null, null, null, payload).Result;
        Assert.IsNotNull(result.Body);
    }
}