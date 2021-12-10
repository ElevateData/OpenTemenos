using FundAdministration.GlobalAccounting.Holding.EosCashCompensations;
using FundAdministration.GlobalAccounting.Holding.EosMultipleSecurities;
using FundAdministration.GlobalAccounting.Holding.EosNewSecurityWithoutCash;
using FundAdministration.GlobalAccounting.Holding.EosSameSecurities;
using FundAdministration.GlobalAccounting.Holding.ExchangeOfNewSecurityWithCashInflows;
using FundAdministration.GlobalAccounting.Holding.ExchangeOfNewSecurityWithCashOutflows;

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
