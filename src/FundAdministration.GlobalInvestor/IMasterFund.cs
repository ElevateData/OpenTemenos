using FundAdministration.GlobalInvestor.Product.MinDivPayments;
using FundAdministration.GlobalInvestor.Product.Security;
using FundAdministration.GlobalInvestor.Product.SecurityDesc;
using FundAdministration.GlobalInvestor.Product.ShareValues;

namespace FundAdministration.GlobalInvestor;

public interface IMasterFund
{
    //public IMasterFundsService MasterFundService { get; }
    public ISecurityDescService SecurityDescriptionService { get; }
    public IShareValuesService ShareValueService { get; }
    public IMinDivPaymentsService MinDividendPaymentService { get; }
    public ISecurityService SecurityService { get; }
}
