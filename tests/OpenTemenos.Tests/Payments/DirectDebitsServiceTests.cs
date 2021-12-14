using OpenTemenos.Payments;
using OpenTemenos.Payments.DirectDebit;

namespace OpenTemenos.Tests.Payments;

[TestClass]
[TestCategory("Payments")]
public class DirectDebitServiceTests : CredentialManagement
{
    private readonly IPaymentClient _client = new PaymentClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    public void GetAccountDirectDebitsAsync()
    {
        var result = _client.DirectDebitManagementService.GetAccountDirectDebitsAsync()
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("POST method")]
    public void CreateDirectDebitsAsync()
    {
        var directDebitId = string.Empty;
        var payload = new DirectDebits();
        var result = _client.DirectDebitManagementService.CreateDirectDebitsAsync(directDebitId, payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("PUT method")]
    public void UpdateDirectDebitsAsync()
    {
        var directDebitId = string.Empty;
        var payload = new DirectDebits();
        var result = _client.DirectDebitManagementService.UpdateDirectDebitsAsync(directDebitId, payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    public void GetRejectedCollectionsAsync()
    {
        var result = _client.DirectDebitManagementService.GetRejectedCollectionsAsync()
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    public void GetDebtorDirectDebitMandatesAsync()
    {
        var result = _client.DirectDebitManagementService.GetDebtorDirectDebitMandatesAsync()
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("PUT method")]
    public void UpdateDebtorDirectDebitMandatesAsync()
    {
        var directDebitId = string.Empty;
        var payload = new DebtorDirectDebitMandates();
        var result = _client.DirectDebitManagementService.UpdateDebtorDirectDebitMandatesAsync(directDebitId, payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("PUT method")]
    public void CancelDebtorDirectDebitMandatesAsync()
    {
        var directDebitId = string.Empty;
        var payload = new DebtorDirectDebitMandates1();
        var result = _client.DirectDebitManagementService.CancelDebtorDirectDebitMandatesAsync(directDebitId, payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }
}