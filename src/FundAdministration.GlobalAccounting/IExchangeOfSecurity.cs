using OpenTemenos.FundAdministrations.GlobalAccounting.Holding.EosCashCompensations;
using OpenTemenos.FundAdministrations.GlobalAccounting.Holding.EosMultipleSecurities;
using OpenTemenos.FundAdministrations.GlobalAccounting.Holding.EosNewSecurityWithoutCash;
using OpenTemenos.FundAdministrations.GlobalAccounting.Holding.EosSameSecurities;
using OpenTemenos.FundAdministrations.GlobalAccounting.Holding.ExchangeOfNewSecurityWithCashInflows;
using OpenTemenos.FundAdministrations.GlobalAccounting.Holding.ExchangeOfNewSecurityWithCashOutflows;

namespace OpenTemenos.FundAdministrations.GlobalAccounting;

public interface IExchangeOfSecurity
{
    public IExchangeOfNewSecurityWithCashOutflowService NewSecurityWithCashOutflowService { get; }
    public IExchangeOfNewSecurityWithCashInflowService NewSecurityWithCashInflowService { get; }
    public IEosNewSecurityWithoutCashService NewSecurityWithoutCashCompensationService { get; }
    public IEosCashCompensationService NewSecurityWithCashCompensationService { get; }
    public IEosSameSecurityService SameSecurityService { get; }
    public IEosMultipleSecurityService MultipleSecurityService { get; }
}