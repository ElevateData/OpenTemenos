using Transact;
using Transact.Reference.AccountOfficers;

namespace OpenTemenos.Tests.Transact.Reference;

[TestClass]
public class AccountOfficersServiceTests : CredentialManagement
{
    private const string AccountOfficerId = "1";
    private readonly IReferenceClient _client = new ReferenceClient(HttpClient){ ReadResponseAsString = true };

    [TestMethod]
    public void GetAccountOfficersAsync()
    {
        var result = _client.AccountOfficersService
            .GetAccountOfficersAsync(null, null, null, null, null, null, null, null).Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body.First())}");
    }

    [TestMethod]
    public void GetAccountOfficerDetailsAsync()
    {
        var result = _client.AccountOfficersService
            .GetAccountOfficerDetailsAsync(AccountOfficerId, null, null, null, null).Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("POST method")]
    public void CreateAccountOfficerDetailsAsync()
    {
        var accountOfficerId = string.Empty;
        var payload = new AccountOfficerDetails();
        var result = _client.AccountOfficersService
            .CreateAccountOfficerDetailsAsync(accountOfficerId, payload, null, null, null, null, null).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("PUT method")]
    public void UpdateAccountOfficerDetailsAsync()
    {
        var accountOfficerId = string.Empty;
        var payload = new AccountOfficerDetails();
        var result = _client.AccountOfficersService
            .UpdateAccountOfficerDetailsAsync(accountOfficerId, payload, null, null, null, null, null).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    public void GetAccountOfficerAlertSubscriptionAsync()
    {
        var result = _client.AccountOfficersService
            .GetAccountOfficerAlertSubscriptionAsync(AccountOfficerId, null, null, null, null).Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("POST method")]
    public void CreateAccountOfficerAlertSubscriptionAsync()
    {
        var accountOfficerId = string.Empty;
        var payload = new AccountOfficerAlertSubscription();
        var result = _client.AccountOfficersService
            .CreateAccountOfficerAlertSubscriptionAsync(accountOfficerId, payload, null, null, null, null, null).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("PUT method")]
    public void UpdateAccountOfficerAlertSubscriptionAsync()
    {
        var accountOfficerId = string.Empty;
        var payload = new AccountOfficerAlertSubscription();
        var result = _client.AccountOfficersService
            .UpdateAccountOfficerAlertSubscriptionAsync(accountOfficerId, payload, null, null, null, null, null).Result;
        Assert.IsNotNull(result.Body);
    }
}