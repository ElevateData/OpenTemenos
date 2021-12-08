using FundAdministration.GlobalAccounting.Holding.EosCashCompensation;
using FundAdministration.GlobalAccounting.Holding.EosMultipleSecurity;
using FundAdministration.GlobalAccounting.Holding.EosNewSecurityWithoutCash;
using FundAdministration.GlobalAccounting.Holding.EosSameSecurity;
using FundAdministration.GlobalAccounting.Holding.ExchangeOfNewSecurityWithCashInflow;
using FundAdministration.GlobalAccounting.Holding.ExchangeOfNewSecurityWithCashOutflow;

namespace FundAdministration.GlobalAccounting;

public interface IExchangeOfSecurity
{
    public IExchangeOfNewSecurityWithCashOutflowService NewSecurityWithCashOutflowService { get; }
    public IExchangeOfNewSecurityWithCashInflowService NewSecurityWithCashInflowService { get; }
    public IEosNewSecurityWithoutCashService NewSecurityWithoutCashCompensationService { get; }
    public IEosCashCompensationService NewSecurityWithCashCompensationService { get; }
    public IEosSameSecurityService SameSecurityService { get; }
    public IEosMultipleSecurityService MultipleSecurityService { get; }

}
