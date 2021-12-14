using OpenTemenos.FundAdministrations.GlobalAccounting;
using OpenTemenos.FundAdministrations.GlobalAccounting.Reference.InterestRateTypes;

namespace OpenTemenos.Tests.FundAdministration.GlobalAccounting.Reference;

[TestClass]
[TestCategory("FundAdministration/GlobalAccounting")]
public class InterestRateTypeServiceTests : CredentialManagement
{
    private readonly IReferenceClient _client = new ReferenceClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    [Ignore("POST method")]
    public void CreateInterestRateTypeAsync()
    {
        var body = new _0BULKPayload();
        var result = _client.InterestRateTypeService.CreateInterestRateTypeAsync(body)
            .Result;
        Assert.IsNotNull(result.Body);
    }
}