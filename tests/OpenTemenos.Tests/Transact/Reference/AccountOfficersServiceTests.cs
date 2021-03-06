using Transact;
using Transact.Reference.AccountOfficers;

namespace OpenTemenos.Tests.Transact.Reference;

[TestClass, TestCategory("Transact")]
public class AccountOfficerServiceTests : CredentialManagement
{
    private const string AccountOfficerId = "1";
    private readonly IReferenceClient _client = new ReferenceClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    public void GetAccountOfficersAsync()
    {
        var result = _client.AccountOfficerService
            .GetAccountOfficersAsync().Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body.First())}");
    }

    [TestMethod]
    public void GetAccountOfficerDetailsAsync()
    {
        var result = _client.AccountOfficerService
            .GetAccountOfficerDetailsAsync(AccountOfficerId).Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("POST method")]
    public void CreateAccountOfficerDetailsAsync()
    {
        var accountOfficerId = string.Empty;
        var payload = new AccountOfficerDetails();
        var result = _client.AccountOfficerService
            .CreateAccountOfficerDetailsAsync(accountOfficerId, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("PUT method")]
    public void UpdateAccountOfficerDetailsAsync()
    {
        var accountOfficerId = string.Empty;
        var payload = new AccountOfficerDetails();
        var result = _client.AccountOfficerService
            .UpdateAccountOfficerDetailsAsync(accountOfficerId, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    public void GetAccountOfficerAlertSubscriptionAsync()
    {
        var result = _client.AccountOfficerService
            .GetAccountOfficerAlertSubscriptionAsync(AccountOfficerId).Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("POST method")]
    public void CreateAccountOfficerAlertSubscriptionAsync()
    {
        var accountOfficerId = string.Empty;
        var payload = new AccountOfficerAlertSubscription();
        var result = _client.AccountOfficerService
            .CreateAccountOfficerAlertSubscriptionAsync(accountOfficerId, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("PUT method")]
    public void UpdateAccountOfficerAlertSubscriptionAsync()
    {
        var accountOfficerId = string.Empty;
        var payload = new AccountOfficerAlertSubscription();
        var result = _client.AccountOfficerService
            .UpdateAccountOfficerAlertSubscriptionAsync(accountOfficerId, payload).Result;
        Assert.IsNotNull(result.Body);
    }
}