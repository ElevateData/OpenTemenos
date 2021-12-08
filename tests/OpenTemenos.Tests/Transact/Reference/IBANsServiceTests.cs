using System.Diagnostics;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Transact;

namespace OpenTemenos.Tests.Transact.Reference;

[TestClass]
public class IBANsServiceTests : CredentialManagement
{
    private readonly IReferenceClient _client = new ReferenceClient(HttpClient);
    private readonly string IbanId = "";
    private readonly string AccountId = "";
    private readonly string BankId = "";
    private readonly string CountryId = "US";

    [TestMethod]
    public void GetBICfromIBANAsync()
    {
        var result = _client.IBANsService.GetBICfromIBANAsync(IbanId, null, null, null, null, null, null, null).Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"BicId: {result.Body.First().BicId}");
    }

    [TestMethod]
    public void GetIBANDetailsAsync()
    {
        var result = _client.IBANsService.GetIBANDetailsAsync(IbanId, null, null, null, null, null, null, null).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    public void GetIBANFromBBANAsync()
    {
        var result = _client.IBANsService.GetIBANFromBBANAsync(IbanId, CountryId, null, null, null, null, null, null, null).Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Iban: {result.Body.First().Iban}");
    }

    [TestMethod]
    public void GetIBANNumberGeneratedAsync()
    {
        var result = _client.IBANsService.GetIBANNumberGeneratedAsync(AccountId, BankId, null, CountryId, null, null, null, null, null, null, null).Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Iban: {result.Body.First().Iban}");
    }

    [TestMethod]
    public void GetIBANStructureAsync()
    {
        var result = _client.IBANsService.GetIBANStructureAsync(CountryId, null, null, null, null, null, null, null).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    public void ValidateIBANAsync()
    {
        var result = _client.IBANsService.ValidateIBANAsync(IbanId, null, null, null, null, null, null, null).Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Iban: {result.Body.First().Iban}");
    }
}