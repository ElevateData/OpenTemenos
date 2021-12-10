using Transact;
using Transact.Party.Beneficiaries;

namespace OpenTemenos.Tests.Transact.Party;

[TestClass]
public class BeneficiariesServiceTests : CredentialManagement
{
    private const string CustomerId = "100282";
    private readonly IPartyClient _client = new PartyClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    [Ignore("PUT method")]
    public void UpdateBeneficiaryAsync()
    {
        var beneficiaryId = string.Empty;
        var payload = new Beneficiary();
            var result = _client.BeneficiariesService.UpdateBeneficiaryAsync(beneficiaryId, payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("DELETE method")]
    public void DeleteBeneficiaryAsync()
    {
        var beneficiaryId = string.Empty;
        var payload = new BeneficiaryDelete();
        var result = _client.BeneficiariesService.DeleteBeneficiaryAsync(beneficiaryId, payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("POST method")]
    public void CreateBeneficiaryAsync()
    {
        var payload = new Beneficiary();
        var result = _client.BeneficiariesService.CreateBeneficiaryAsync(payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("PUT method")]
    public void ApproveBeneficiaryAsync()
    {
        var beneficiaryId = string.Empty;
        var result = _client.BeneficiariesService.ApproveBeneficiaryAsync(beneficiaryId)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("DELETE method")]
    public void RejectBeneficiaryAsync()
    {
        var beneficiaryId = string.Empty;
        var payload = new BeneficiaryDelete();
        var result = _client.BeneficiariesService.RejectBeneficiaryAsync(beneficiaryId, payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    public void GetCustomerBeneficiaryAsync()
    {
        var result = _client.BeneficiariesService.GetCustomerBeneficiaryAsync(CustomerId)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    public void GetCustomerBeneficiariesAsync()
    {
        var result = _client.BeneficiariesService.GetCustomerBeneficiariesAsync(CustomerId)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }
}