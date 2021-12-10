using System;
using Transact;

namespace OpenTemenos.Tests.Transact.Holding;

[TestClass]
public class CustomerArrangementsServiceTests : CredentialManagement
{
    private const string CustomerId = "";
    private readonly IHoldingClient _client = new HoldingClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    public void GetCustomerLoansAsync()
    {
        var result = _client.CustomerArrangementService
            .GetCustomerLoansAsync(CustomerId, null, null, null, null, null, null, null, null)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body.First())}");
    }

    [TestMethod]
    public void GetLoansAsync()
    {
        var result = _client.CustomerArrangementService
            .GetLoansAsync(null, null, null, null, null, null, null, null, null, null)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body.First())}");
    }

    [TestMethod]
    public void GetCustomerDepositsAsync()
    {
        var result = _client.CustomerArrangementService
            .GetCustomerDepositsAsync(CustomerId, null, null, null, null, null, null, null, null)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body.First())}");
    }

    [TestMethod]
    public void GetDepositsAsync()
    {
        var result = _client.CustomerArrangementService
            .GetDepositsAsync(null, null, null, null, null, null, null, null, null, null)
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
            .GetCustomerArrangementDetailsAsync(CustomerId, null, null, null, null, null, null, null, null)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body.First())}");
    }

    [TestMethod]
    public void GetCustomerExternalAsync()
    {
        var result = _client.CustomerArrangementService
            .GetCustomerExternalAsync(CustomerId, null, null, null, null, null, null, null, null)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body.First())}");
    }

    [TestMethod]
    public void GetCustomerClosedExternalAsync()
    {
        var result = _client.CustomerArrangementService.GetCustomerClosedExternalAsync(CustomerId, null, null, null,
                null, null, null, null, null, null, null, null, null, null)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body.First())}");
    }
}