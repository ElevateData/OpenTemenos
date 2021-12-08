using FundAdministration.GlobalInvestor.Reference.Cities;
using FundAdministration.GlobalInvestor.Reference.CountryHolidays;
using FundAdministration.GlobalInvestor.Reference.CurrencyHolidays;
using FundAdministration.GlobalInvestor.Reference.Messages;

namespace FundAdministration.GlobalInvestor;

public interface IReferenceClient
{
    public ICountryHolidaysService CountryHolidayService { get; }
    public ICurrencyHolidaysService CurrencyHolidayService { get; }
    public IMessagesService MessageService { get; }
    public ICitiesService TownService { get; }
}
