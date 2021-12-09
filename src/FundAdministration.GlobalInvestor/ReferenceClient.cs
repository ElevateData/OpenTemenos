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
    public ReferenceClient(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public ICitiesService TownService => new CitiesService(_httpClient) { BaseUrl = BaseUrl };

    public ICountryHolidaysService CountryHolidayService => new CountryHolidaysService(_httpClient) { BaseUrl = BaseUrl };
    public ICurrencyHolidaysService CurrencyHolidayService => new CurrencyHolidaysService(_httpClient) { BaseUrl = BaseUrl };
    public IMessagesService MessageService => new MessagesService(_httpClient) { BaseUrl = BaseUrl };
}
