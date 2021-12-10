using FundAdministration.GlobalAccounting;
using FundAdministration.GlobalAccounting.Reference.InterestRateType;

namespace OpenTemenos.Tests.FundAdministration.GlobalAccounting.Reference;

[TestClass]
public class InterestRateTypeServiceTests : CredentialManagement
{
    private readonly IReferenceClient _client = new ReferenceClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    [Ignore("POST method")]
    public void CreateInterestRateTypeAsync()
    {
        var body = new _0BULKPayload();
        var result = _client.InterestRateTypeService.CreateInterestRateTypeAsync(null, null, null, null, null, body)
            .Result;
        Assert.IsNotNull(result.Body);
    }
}