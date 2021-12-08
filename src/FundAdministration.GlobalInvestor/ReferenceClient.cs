using FundAdministration.GlobalInvestor.Reference;
using FundAdministration.GlobalInvestor.Reference.Cities;
using FundAdministration.GlobalInvestor.Reference.CountryHolidays;
using FundAdministration.GlobalInvestor.Reference.CurrencyHolidays;
using FundAdministration.GlobalInvestor.Reference.Messages;

namespace FundAdministration.GlobalInvestor;

public class ReferenceClient : IReferenceClient
{
    private readonly HttpClient _httpClient;
    private readonly string _baseUrl = "https://api.temenos.com/IRISgi/multifonds/api/v1.0.0";
    public ReferenceClient(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public ICitiesService TownService => new CitiesService(_httpClient) { BaseUrl = _baseUrl };

    public ICountryHolidaysService CountryHolidayService => new CountryHolidaysService(_httpClient) { BaseUrl = _baseUrl };
    public ICurrencyHolidaysService CurrencyHolidayService => new CurrencyHolidaysService(_httpClient) { BaseUrl = _baseUrl };
    public IMessagesService MessageService => new MessagesService(_httpClient) { BaseUrl = _baseUrl };
}
