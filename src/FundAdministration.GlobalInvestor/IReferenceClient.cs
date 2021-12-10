using FundAdministration.GlobalInvestor.Reference.Cities;
using FundAdministration.GlobalInvestor.Reference.CountryHolidays;
using FundAdministration.GlobalInvestor.Reference.CurrencyHolidays;
using FundAdministration.GlobalInvestor.Reference.Messages;

namespace FundAdministration.GlobalInvestor;

public interface IReferenceClient
{
    public ICountryHolidayService CountryHolidayService { get; }
    public ICurrencyHolidayService CurrencyHolidayService { get; }
    public IMessageService MessageService { get; }
    public ICityService TownService { get; }
}
