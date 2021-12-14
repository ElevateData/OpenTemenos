using OpenTemenos.Transacts;

namespace OpenTemenos.Tests.Transact.Holding;

[TestClass]
[TestCategory("Transact")]
public class ArrangementsProductLineServiceTests : CredentialManagement
{
    private const string ProductLine = "3";
    private readonly IHoldingClient _client = new HoldingClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    public void GetUnapprovedArrangementsDepositsAsync()
    {
        var result = _client.ArrangementForProductLineService.GetUnapprovedArrangementsDepositsAsync(ProductLine)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    public void GetUnapprovedArrangementsLoansAsync()
    {
        var result = _client.ArrangementForProductLineService.GetUnapprovedArrangementsLoansAsync(ProductLine)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    public void GetUnapprovedArrangementsAccountsAsync()
    {
        var result = _client.ArrangementForProductLineService.GetUnapprovedArrangementsAccountsAsync(ProductLine)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    public void GetAAPendingArrangementAccountsAsync()
    {
        var result = _client.ArrangementForProductLineService.GetAAPendingArrangementAccountsAsync(ProductLine)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    public void GetAAPendingArrangementDepositsAsync()
    {
        var result = _client.ArrangementForProductLineService.GetAAPendingArrangementDepositsAsync(ProductLine)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    public void GetAAPendingArrangementLoansAsync()
    {
        var result = _client.ArrangementForProductLineService.GetAAPendingArrangementLoansAsync(ProductLine)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    public void GetApprovedAccountsAsync()
    {
        var result = _client.ArrangementForProductLineService.GetApprovedAccountsAsync(ProductLine)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    public void GetApprovedDepositsAsync()
    {
        var result = _client.ArrangementForProductLineService.GetApprovedDepositsAsync(ProductLine)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    public void GetApprovedLoansAsync()
    {
        var result = _client.ArrangementForProductLineService.GetApprovedLoansAsync(ProductLine)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    public void GetClosedMaturedAccountsAsync()
    {
        var result = _client.ArrangementForProductLineService.GetClosedMaturedAccountsAsync(ProductLine)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    public void GetClosedMaturedDepositsAsync()
    {
        var result = _client.ArrangementForProductLineService.GetClosedMaturedDepositsAsync(ProductLine)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    public void GetClosedMaturedLendingAsync()
    {
        var result = _client.ArrangementForProductLineService.GetClosedMaturedLendingAsync(ProductLine)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    public void GetSimulatedAccountsAsync()
    {
        var result = _client.ArrangementForProductLineService.GetSimulatedAccountsAsync(ProductLine)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    public void GetSimulatedDepositsAsync()
    {
        var result = _client.ArrangementForProductLineService.GetSimulatedDepositsAsync(ProductLine)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    public void GetSimulatedLendingAsync()
    {
        var result = _client.ArrangementForProductLineService.GetSimulatedLendingAsync(ProductLine)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }
}