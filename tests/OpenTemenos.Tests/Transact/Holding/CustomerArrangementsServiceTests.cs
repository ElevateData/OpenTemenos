using System;
using Transact;

namespace OpenTemenos.Tests.Transact.Holding;

[TestClass, TestCategory("Transact")]
public class CustomerArrangementServiceTests : CredentialManagement
{
    private const string CustomerId = "100282";
    private readonly IHoldingClient _client = new HoldingClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    public void GetCustomerLoansAsync()
    {
        var result = _client.CustomerArrangementService
            .GetCustomerLoansAsync(CustomerId)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body.First())}");
    }

    [TestMethod]
    public void GetLoansAsync()
    {
        var result = _client.CustomerArrangementService
            .GetLoansAsync()
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body.First())}");
    }

    [TestMethod]
    public void GetCustomerDepositsAsync()
    {
        var result = _client.CustomerArrangementService
            .GetCustomerDepositsAsync(CustomerId)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body.First())}");
    }

    [TestMethod]
    public void GetDepositsAsync()
    {
        var result = _client.CustomerArrangementService
            .GetDepositsAsync()
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body.First())}");
    }

    [TestMethod]
    [Ignore("Obsolete")]
    [Obsolete("Flagged by Temenos")]
    public void GetCustomerArrangementDetailsAsync()
    {
        var result = _client.CustomerArrangementService
            .GetCustomerArrangementDetailsAsync(CustomerId)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body.First())}");
    }

    [TestMethod]
    public void GetCustomerExternalAsync()
    {
        var result = _client.CustomerArrangementService
            .GetCustomerExternalAsync(CustomerId)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body.First())}");
    }

    [TestMethod]
    public void GetCustomerClosedExternalAsync()
    {
        var result = _client.CustomerArrangementService.GetCustomerClosedExternalAsync(CustomerId)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body.First())}");
    }
}