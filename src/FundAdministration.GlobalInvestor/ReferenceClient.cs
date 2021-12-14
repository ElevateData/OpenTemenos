using OpenTemenos.FundAdministrations.GlobalInvestor.Reference;
using OpenTemenos.FundAdministrations.GlobalInvestor.Reference.Cities;
using OpenTemenos.FundAdministrations.GlobalInvestor.Reference.CountryHolidays;
using OpenTemenos.FundAdministrations.GlobalInvestor.Reference.CurrencyHolidays;
using OpenTemenos.FundAdministrations.GlobalInvestor.Reference.Messages;
using OpenTemenos.Shared.Data;

namespace OpenTemenos.FundAdministrations.GlobalInvestor;

public class ReferenceClient : IReferenceClient
{
    private readonly HttpClient _httpClient;

    public ReferenceClient(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public string BaseUrl { get; set; } = DefaultConfig.BaseUrl;
    public bool ReadResponseAsString { get; set; } = DefaultConfig.ReadResponseAsString;

    public ICityService TownService => new CityService(_httpClient)
        { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public ICountryHolidayService CountryHolidayService => new CountryHolidayService(_httpClient)
        { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public ICurrencyHolidayService CurrencyHolidayService => new CurrencyHolidayService(_httpClient)
        { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IMessageService MessageService => new MessageService(_httpClient)
        { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
}