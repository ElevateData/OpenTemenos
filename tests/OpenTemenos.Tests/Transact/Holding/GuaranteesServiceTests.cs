using Transact;
using Transact.Holding.Guarantees;

namespace OpenTemenos.Tests.Transact.Holding;

[TestClass]
public class GuaranteesServiceTests : CredentialManagement
{
    private const string ClauseId = "";
    private const string CustomerId = "";
    private const string GuaranteeId = "";
    private const string RequestId = "";
    private readonly IHoldingClient _client = new HoldingClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    public void GetClauseAsync()
    {
        var result = _client.GuaranteeService.GetClauseAsync(ClauseId, null, null, null, null)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("POST method")]
    public void CreateClauseAsync()
    {
        var clauseId = string.Empty;
        var payload = new Clause();
        var result = _client.GuaranteeService.CreateClauseAsync(clauseId, payload, null, null, null, null, null)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("PUT method")]
    public void UpdateClauseAsync()
    {
        var clauseId = string.Empty;
        var payload = new Clause();
        var result = _client.GuaranteeService.UpdateClauseAsync(clauseId, payload, null, null, null, null, null)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("DELETE method")]
    public void DeleteClauseAsync()
    {
        var clauseId = string.Empty;
        var payload = new ClauseDelete();
        var result = _client.GuaranteeService.DeleteClauseAsync(clauseId, payload, null, null, null, null, null)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    public void GetGuaranteeIssuanceRequestsAsync()
    {
        var result = _client.GuaranteeService
            .GetGuaranteeIssuanceRequestsAsync(null, null, null, null, null, null, null, null, null, null, null)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("POST method")]
    public void CreateIbRequestAsync()
    {
        var payload = new IbRequest();
        var result = _client.GuaranteeService.CreateIbRequestAsync(payload, null, null, null, null, null)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    public void GetIbRequestAsync()
    {
        var result = _client.GuaranteeService.GetIbRequestAsync(RequestId, null, null, null, null)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("PUT method")]
    public void UpdateIbRequestAsync()
    {
        var requestId = string.Empty;
        var payload = new IbRequest();
        var result = _client.GuaranteeService.UpdateIbRequestAsync(requestId, payload, null, null, null, null, null)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("DELETE method")]
    public void DeleteIbRequestAsync()
    {
        var requestId = string.Empty;
        var payload = new IbRequestDelete();
        var result = _client.GuaranteeService.DeleteIbRequestAsync(requestId, payload, null, null, null, null, null)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("PUT method")]
    public void ApproveGuaranteeAsync()
    {
        var requestId = string.Empty;
        var result = _client.GuaranteeService.ApproveGuaranteeAsync(requestId, null, null, null, null)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("PUT method")]
    public void RejectGuaranteeAsync()
    {
        var requestId = string.Empty;
        var result = _client.GuaranteeService.RejectGuaranteeAsync(requestId, null, null, null, null, null, null)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    public void GetReceivedGuaranteeHistoryAsync()
    {
        var result = _client.GuaranteeService
            .GetReceivedGuaranteeHistoryAsync(GuaranteeId, null, null, null, null, null, null, null, null)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    public void GetGuaranteeClausesAsync()
    {
        var result = _client.GuaranteeService
            .GetGuaranteeClausesAsync(null, null, null, null, null, null, null, null, null, null)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    public void GetReceivedGuaranteesAmendmentsAsync()
    {
        var result = _client.GuaranteeService
            .GetReceivedGuaranteesAmendmentsAsync(null, null, null, null, null, null, null, null, null, null, null)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    public void GetClaimInvocationHistoryAsync()
    {
        var result = _client.GuaranteeService
            .GetClaimInvocationHistoryAsync(GuaranteeId, null, null, null, null, null, null, null, null)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    public void GetReceivedGuaranteeClaimsAsync()
    {
        var result = _client.GuaranteeService
            .GetReceivedGuaranteeClaimsAsync(null, null, null, null, null, null, null, null, null)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    public void GetGuaranteeAmendmentsAsync()
    {
        var result = _client.GuaranteeService
            .GetGuaranteeAmendmentsAsync(null, null, null, null, null, null, null, null, null)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    public void GetIssuedGuaranteesAsync()
    {
        var result = _client.GuaranteeService
            .GetIssuedGuaranteesAsync(null, null, null, null, null, null, null, null, null)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    public void GetGuaranteeLimitsAsync()
    {
        var result = _client.GuaranteeService
            .GetClaimInvocationHistoryAsync(null, null, null, null, null, null, null, null, null)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    public void GetIssuedGuaranteeClaimsAsync()
    {
        var result = _client.GuaranteeService
            .GetIssuedGuaranteeClaimsAsync(null, null, null, null, null, null, null, null)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    public void GetGuaranteesAsync()
    {
        var result = _client.GuaranteeService
            .GetGuaranteesAsync(null, null, null, null, null, null, null, null, null, null, null, null)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("POST method")]
    public void CreateGuaranteeGenericAsync()
    {
        var payload = new GuaranteeGeneric();
        var result = _client.GuaranteeService.CreateGuaranteeGenericAsync(payload, null, null, null, null, null)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    public void GetGuaranteesOutstandingsAsync()
    {
        var result = _client.GuaranteeService.GetGuaranteesOutstandingsAsync(CustomerId, null, null, null, null, null,
                null, null, null, null, null, null, null)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    public void GetGuaranteeExpiringWithDateAsync()
    {
        var result = _client.GuaranteeService.GetGuaranteeExpiringWithDateAsync(CustomerId, null, null, null, null,
                null, null, null, null, null, null, null, null, null)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    public void GetClaimOutstandingUnderGuaranteesAsync()
    {
        var result = _client.GuaranteeService.GetClaimOutstandingUnderGuaranteesAsync(CustomerId, null, null, null,
                null, null, null, null, null, null, null, null)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    public void GetGuaranteesReversedAsync()
    {
        var result = _client.GuaranteeService.GetGuaranteesReversedAsync(CustomerId, null, null, null, null, null, null,
                null, null, null, null, null, null)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    public void GetClaimsPaidUnderGuaranteeAsync()
    {
        var result = _client.GuaranteeService
            .GetClaimsPaidUnderGuaranteeAsync(GuaranteeId, null, null, null, null, null, null, null, null, null)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    public void GetOutstandingShippingGuaranteesAsync()
    {
        var result = _client.GuaranteeService.GetOutstandingShippingGuaranteesAsync(GuaranteeId, null, null, null, null,
                null, null, null, null, null, null)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    public void GetOutstandingReceivedGuaranteesAsync()
    {
        var result = _client.GuaranteeService.GetOutstandingReceivedGuaranteesAsync(CustomerId, null, null, null, null,
                null, null, null, null, null, null, null, null)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("POST method")]
    public void CreateGuaranteesPerformanceBondAsync()
    {
        var payload = new GuaranteesPerformanceBond();
        var result = _client.GuaranteeService
            .CreateGuaranteesPerformanceBondAsync(payload, null, null, null, null, null)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("POST method")]
    public void CreateGuaranteesStandbyLCAsync()
    {
        var payload = new GuaranteesStandbyLC();
        var result = _client.GuaranteeService.CreateGuaranteesStandbyLCAsync(payload, null, null, null, null, null)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("POST method")]
    public void CreateShippingGuaranteeUnderLCAsync()
    {
        var payload = new ShippingGuaranteeUnderLC();
        var result = _client.GuaranteeService.CreateShippingGuaranteeUnderLCAsync(payload, null, null, null, null, null)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("POST method")]
    public void CreateShippingGuaranteeUnderCollectionAsync()
    {
        var payload = new ShippingGuaranteeUnderCollection();
        var result = _client.GuaranteeService
            .CreateShippingGuaranteeUnderCollectionAsync(payload, null, null, null, null, null)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("PUT method")]
    public void UpdateGuaranteesAmendmentAsync()
    {
        var guaranteeId = string.Empty;
        var payload = new GuaranteesAmendment();
        var result = _client.GuaranteeService
            .UpdateGuaranteesAmendmentAsync(guaranteeId, payload, null, null, null, null, null)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("PUT method")]
    public void UpdateGuaranteesRejectionAsync()
    {
        var guaranteeId = string.Empty;
        var payload = new GuaranteesRejection();
        var result = _client.GuaranteeService
            .UpdateGuaranteesRejectionAsync(guaranteeId, payload, null, null, null, null, null)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    public void GetInvocationPaidOrCancelledAsync()
    {
        var result = _client.GuaranteeService.GetInvocationPaidOrCancelledAsync(GuaranteeId, null, null, null, null,
                null, null, null, null, null, null, null, null, null, null, null, null)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("POST method")]
    public void CreateGuarnteeBidBondAsync()
    {
        var payload = new GuarnteeBidBond();
        var result = _client.GuaranteeService.CreateGuarnteeBidBondAsync(payload, null, null, null, null, null)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }
}