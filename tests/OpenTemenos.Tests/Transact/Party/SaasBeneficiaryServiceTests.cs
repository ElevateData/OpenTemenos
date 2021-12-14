using OpenTemenos.Transacts;
using OpenTemenos.Transacts.Party.SaasBeneficiaries;

namespace OpenTemenos.Tests.Transact.Party;

[TestClass]
[TestCategory("Transact")]
public class SaasBeneficiaryServiceTests : CredentialManagement
{
    private const string BeneficiaryId = "1";
    private readonly IPartyClient _client = new PartyClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    [Ignore("POST method")]
    public void CreatePaymentsBeneficiaryAsync()
    {
        var payload = new PaymentsBeneficiary();
        var result = _client.SaasBeneficiaryService.CreatePaymentsBeneficiaryAsync(payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    public void GetBeneficiaryAsync()
    {
        var result = _client.SaasBeneficiaryService.GetBeneficiaryAsync(BeneficiaryId)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("PUT method")]
    public void UpdatePaymentsBeneficiaryAsync()
    {
        var beneficiaryId = string.Empty;
        var payload = new PaymentsBeneficiary();
        var result = _client.SaasBeneficiaryService.UpdatePaymentsBeneficiaryAsync(beneficiaryId, payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("DELETE method")]
    public void DeletePaymentsBeneficiaryAsync()
    {
        var beneficiaryId = string.Empty;
        var payload = new PaymentsBeneficiaryDelete();
        var result = _client.SaasBeneficiaryService.DeletePaymentsBeneficiaryAsync(beneficiaryId, payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"{MethodBase.GetCurrentMethod()?.Name}: {JsonSerializer.Serialize(result.Body)}");
    }
}