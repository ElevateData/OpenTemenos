using Transact;
using Transact.Holding.Accounts;

namespace OpenTemenos.Tests.Transact.Holding;

[TestClass]
public class AccountsServiceTests : CredentialManagement
{
    private const string AccountId = "101125";
    private const string BookingDate = "20201209";
    private const string CurrencyId = "USD";
    private const string ValueDate = "20201209";
    private const string AccountCompany = "";
    private const string PaymentCurrency = "";
    private const string AccountSwitch = "";
    private const string BeneficialCustomer = "";
    private const string ContractBalanceId = "";
    private readonly IHoldingClient _client = new HoldingClient(HttpClient){ ReadResponseAsString = true };

    [TestMethod]
    public void GetPackageStatementAsync()
    {
        var result = _client.AccountManagementService.GetAccountClosureAsync(AccountId, null, null, null, null)
            .Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("PUT method")]
    public void UpdateAccountClosureAsync()
    {
        var accountId = string.Empty;
        var payload = new AccountClosure();
        var result = _client.AccountManagementService
            .UpdateAccountClosureAsync(accountId, payload, null, null, null, null, null).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    public void GetAccountTransactionsAsync()
    {
        var result = _client.AccountManagementService.GetAccountTransactionsAsync(AccountId, null, null, null, null,
                null, null, null, null, null, null, null, null, null, null)
            .Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    public void GetAccountCardsAsync()
    {
        var result = _client.AccountManagementService.GetAccountCardsAsync(AccountId, null, null, null, null, null,
                null, null, null, null, null, null, null)
            .Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    public void GetAccountBalanceTodayAsync()
    {
        var result = _client.AccountManagementService.GetAccountBalanceTodayAsync(null, null, null, null, null, null,
                null, null, null, null, null, null, null)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body.First())}");
    }

    [TestMethod]
    public void GetAccountBalanceMovementAsync()
    {
        var result = _client.AccountManagementService
            .GetAccountBalanceMovementAsync(AccountId, BookingDate, null, null, null, null, null, null, null, null)
            .Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    public void GetAccountEmergencyBlockAsync()
    {
        var result = _client.AccountManagementService
            .GetAccountEmergencyBlockAsync(AccountId, null, null, null, null, null, null, null, null)
            .Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("PUT method")]
    public void UpdateAccountEmergencyBlockAsync()
    {
        var accountId = string.Empty;
        var payload = new AccountEmergencyBlock();
        var result = _client.AccountManagementService
            .UpdateAccountEmergencyBlockAsync(accountId, payload, null, null, null, null, null).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    public void GetAccountFundsAuthStatusAsync()
    {
        var result = _client.AccountManagementService
            .GetAccountFundsAuthStatusAsync(AccountId, null, null, null, null, null, null, null, null)
            .Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("PUT method")]
    public void UpdateAccountFundsAuthStatusAsync()
    {
        var accountId = string.Empty;
        var payload = new AccountFundsAuthStatus();
        var result = _client.AccountManagementService
            .UpdateAccountFundsAuthStatusAsync(accountId, payload, null, null, null, null, null).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("POST method")]
    public void CreateFundsDiversionAsync()
    {
        var accountId = string.Empty;
        var payload = new FundsDiversion();
        var result = _client.AccountManagementService
            .CreateFundsDiversionAsync(accountId, payload, null, null, null, null, null).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("PUT method")]
    public void UpdateFundsDiversionAsync()
    {
        var accountId = string.Empty;
        var payload = new FundsDiversion();
        var result = _client.AccountManagementService
            .UpdateFundsDiversionAsync(accountId, payload, null, null, null, null, null).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    public void GetNostroForwardBalancesAsync()
    {
        var result = _client.AccountManagementService
            .GetNostroForwardBalancesAsync(ValueDate, null, null, null, null, null, null, null, null, null, null)
            .Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    public void GetNostroBalancesAsync()
    {
        var result = _client.AccountManagementService
            .GetNostroBalancesAsync(CurrencyId, null, null, null, null, null, null, null, null, null)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body.First())}");
    }

    [TestMethod]
    public void GetNostroCurrencyPositionsAsync()
    {
        var result = _client.AccountManagementService
            .GetNostroCurrencyPositionsAsync(CurrencyId, null, null, null, null, null, null, null, null)
            .Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    public void GetNostroPositionsAsync()
    {
        var result = _client.AccountManagementService
            .GetNostroPositionsAsync(CurrencyId, null, null, null, null, null, null, null, null, null)
            .Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    public void GetReservedFundsAsync()
    {
        var result = _client.AccountManagementService.GetReservedFundsAsync(null, null, null, null, null, null, null,
                null, null, null, null, null, null)
            .Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    public void GetAccountDetailsAsync()
    {
        var result = _client.AccountManagementService
            .GetAccountDetailsAsync(AccountId, null, null, null, null, null, null, null, null)
            .Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    public void GetActiveProxyIdentifierAsync()
    {
        var result = _client.AccountManagementService
            .GetActiveProxyIdentifierAsync(null, null, null, null, null, null, null, null, null, null, null, null)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body.First())}");
    }

    [TestMethod]
    [Ignore("POST method")]
    public void CreateProxyIdentifierAsync()
    {
        var payload = new ProxyIdentifier();
        var result = _client.AccountManagementService.CreateProxyIdentifierAsync(payload, null, null, null, null, null)
            .Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("PUT method")]
    public void UpdateProxyIdentifierAsync()
    {
        var proxyIdentifierId = string.Empty;
        var payload = new ProxyIdentifier1();
        var result = _client.AccountManagementService
            .UpdateProxyIdentifierAsync(proxyIdentifierId, payload, null, null, null, null, null)
            .Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    public void GetAccountPaymentDetailsAsync()
    {
        var result = _client.AccountManagementService.GetAccountPaymentDetailsAsync(AccountId, AccountCompany,
                PaymentCurrency, AccountSwitch, BeneficialCustomer, null, null, null, null, null, null, null, null)
            .Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    public void GetAccountsAsync()
    {
        var result = _client.AccountManagementService.GetAccountsAsync(null, null, null, null, null, null, null, null,
                null, null, null, null, null, null)
            .Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    public void GetContractBalancesAsync()
    {
        var result = _client.AccountManagementService
            .GetContractBalancesAsync(ContractBalanceId, null, null, null, null, null, null, null, null)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body.First())}");
    }

    [TestMethod]
    [Ignore("PUT method")]
    public void UpdateSynchronizationErrorAsync()
    {
        var accountId = string.Empty;
        var payload = new SynchronizationError();
        var result = _client.AccountManagementService
            .UpdateSynchronizationErrorAsync(accountId, payload, null, null, null, null, null)
            .Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    public void GetExpiringAccountSwitchesAsync()
    {
        var result = _client.AccountManagementService
            .GetExpiringAccountSwitchesAsync(AccountId, null, null, null, null, null, null, null, null, null, null)
            .Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    public void GetAccountSwitchDetailsAsync()
    {
        var result = _client.AccountManagementService
            .GetAccountSwitchDetailsAsync(AccountId, null, null, null, null, null, null, null, null, null)
            .Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("PUT method")]
    public void UpdateAccountSwitchDetailsAsync()
    {
        var accountId = string.Empty;
        var payload = new AccountSwitchDetails();
        var result = _client.AccountManagementService
            .UpdateAccountSwitchDetailsAsync(accountId, payload, null, null, null, null, null)
            .Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    public void GetAccountSwitchPaymentDetailsAsync()
    {
        var result = _client.AccountManagementService
            .GetAccountSwitchPaymentDetailsAsync(AccountId, null, null, null, null, null, null, null, null)
            .Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("PUT method")]
    public void ApproveAccountClosureAsync()
    {
        var accountId = string.Empty;
        var result = _client.AccountManagementService.ApproveAccountClosureAsync(accountId, null, null, null, null)
            .Result;
        Assert.IsNotNull(result.Body);
    }
}