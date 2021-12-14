using OpenTemenos.FundAdministrations.GlobalInvestor.Reference.Cities;
using OpenTemenos.FundAdministrations.GlobalInvestor.Reference.CountryHolidays;
using OpenTemenos.FundAdministrations.GlobalInvestor.Reference.CurrencyHolidays;
using OpenTemenos.FundAdministrations.GlobalInvestor.Reference.Messages;

namespace OpenTemenos.FundAdministrations.GlobalInvestor;

public interface IReferenceClient
{
    public ICountryHolidayService CountryHolidayService { get; }
    public ICurrencyHolidayService CurrencyHolidayService { get; }
    public IMessageService MessageService { get; }
    public ICityService TownService { get; }
}