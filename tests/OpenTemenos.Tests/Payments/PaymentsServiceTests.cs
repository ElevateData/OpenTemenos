using OpenTemenos.Payments;
using OpenTemenos.Payments.Payments;

namespace OpenTemenos.Tests.Payments;

[TestClass]
[TestCategory("Payments")]
public class PaymentServiceTests : CredentialManagement
{
    private const string FromDate = "20200101";
    private const string Status = "Test";
    private readonly IPaymentClient _client = new PaymentClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    public void GetPaymentsStatusAsync()
    {
        var result = _client.PaymentExecutionService.GetPaymentsStatusAsync(FromDate, Status)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    public void GetPaymentFeesAndChargesAsync()
    {
        var result = _client.PaymentExecutionService.GetPaymentFeesAndChargesAsync()
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    public void GetAllPaymentsTransactionLogsAsync()
    {
        var result = _client.PaymentExecutionService.GetAllPaymentsTransactionLogsAsync()
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("POST method")]
    public void CreateBankInitiatedPaymentRecallAsync()
    {
        var payload = new BankInitiatedPaymentRecall();
        var result = _client.PaymentExecutionService.CreateBankInitiatedPaymentRecallAsync(payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("POST method")]
    public void CreateCustomerInitiatedPaymentRecallAsync()
    {
        var payload = new CustomerInitiatedPaymentRecall();
        var result = _client.PaymentExecutionService.CreateCustomerInitiatedPaymentRecallAsync(payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("PUT method")]
    public void UpdateResponseToPaymentRecallAsync()
    {
        var recallId = string.Empty;
        var payload = new ResponseToPaymentRecall();
        var result = _client.PaymentExecutionService.UpdateResponseToPaymentRecallAsync(recallId, payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("PUT method")]
    public void UpdatePaymentSentMessageAsync()
    {
        var sentMessageId = string.Empty;
        var payload = new PaymentSentMessage();
        var result = _client.PaymentExecutionService.UpdatePaymentSentMessageAsync(sentMessageId, payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    public void GetPaymentCancelReasonCodeAsync()
    {
        var result = _client.PaymentExecutionService.GetPaymentCancelReasonCodeAsync()
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }
}