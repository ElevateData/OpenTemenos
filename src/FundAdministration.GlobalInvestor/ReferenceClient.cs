using FundAdministration.GlobalInvestor.Reference;
using FundAdministration.GlobalInvestor.Reference.Cities;
using FundAdministration.GlobalInvestor.Reference.CountryHolidays;
using FundAdministration.GlobalInvestor.Reference.CurrencyHolidays;
using FundAdministration.GlobalInvestor.Reference.Messages;

namespace FundAdministration.GlobalInvestor;

public class ReferenceClient : IReferenceClient
{
    private readonly HttpClient _httpClient;
    public string BaseUrl { get; set; } = Shared.Data.DefaultConfig.BaseUrl;
    public bool ReadResponseAsString { get; set; } = Shared.Data.DefaultConfig.ReadResponseAsString;
    public ReferenceClient(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public ICityService TownService => new CityService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public ICountryHolidayService CountryHolidayService => new CountryHolidayService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public ICurrencyHolidayService CurrencyHolidayService => new CurrencyHolidayService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public IMessageService MessageService => new MessageService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
}
