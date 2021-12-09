using Transact;
using Transact.Reference.RoundingRule;

namespace OpenTemenos.Tests.Transact.Reference;

[TestClass]
public class RoundingRuleServiceTests : CredentialManagement
{
    private const string RuleId = "";
    private readonly IReferenceClient _client = new ReferenceClient(HttpClient);


    [TestMethod]
    public void GetRoundingRuleDetailsAsync()
    {
        var result = _client.RoundingRuleService.GetRoundingRuleDetailsAsync(RuleId, null, null, null, null).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("POST method")]
    public void CreateRoundingRuleDetailsAsync()
    {
        var ruleId = string.Empty;
        var payload = new RoundingRuleDetails();
        var result = _client.RoundingRuleService
            .CreateRoundingRuleDetailsAsync(ruleId, payload, null, null, null, null, null).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("PUT method")]
    public void UpdateRoundingRuleDetailsAsync()
    {
        var ruleId = string.Empty;
        var payload = new RoundingRuleDetails();
        var result = _client.RoundingRuleService
            .UpdateRoundingRuleDetailsAsync(ruleId, payload, null, null, null, null, null).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("DELETE method")]
    public void DeleteRoundingRuleDetailsAsync()
    {
        var ruleId = string.Empty;
        var payload = new RoundingRuleDetailsDelete();
        var result = _client.RoundingRuleService
            .DeleteRoundingRuleDetailsAsync(ruleId, payload, null, null, null, null, null).Result;
        Assert.IsNotNull(result.Body);
    }
}