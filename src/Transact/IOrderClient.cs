﻿using Transact.Order.AccountTransfers;
using Transact.Order.CashManagementSweep;
using Transact.Order.CreditorReferences;
using Transact.Order.DerivativeOrders;
using Transact.Order.FiduciaryOrders;
using Transact.Order.ForexCustomerOrders;
using Transact.Order.IPOSecurityOrders;
using Transact.Order.OrderSimulations;
using Transact.Order.PaymentsConfiguration;
using Transact.Order.PositionTransferOrdersRequest;
using Transact.Order.PrivateEquityOrders;
using Transact.Order.SecurityOrders;
using Transact.Order.SecurityTransferOrders;
using Transact.Order.Sweeps;

namespace Transact;

public interface IOrderClient
{
    public IAccountTransfersService AccountFundTransferService { get; }
    //public ICashManagementBundlesService CashManagementBundleService { get; }
    public ICashManagementSweepService CashManagementSweepService { get; }
    public ICreditorReferencesService CreditorReferenceService { get; }
    public IDerivativeOrdersService DerivativeInstrumentOrderService { get; }
    public IFiduciaryOrdersService FiduciaryOrderService { get; }
    public IIPOSecurityOrdersService InitialPublicOfferingSecurityOrderService { get; }
    public ISweepsService AccountSweepService { get; }
    public IPrivateEquityOrdersService PrivateEquityOrderService { get; }
    public IPaymentsConfigurationService PaymentConfigurationService { get; }
    public ISecurityOrdersService SecurityOrderService { get; }
    public IOrderSimulationsService SecurityOrderSimulationService { get; }
    public IPositionTransferOrdersRequestService SecurityPositionTransferService { get; }
    public ISecurityTransferOrdersService SecurityTransferService { get; }
    public IForexCustomerOrdersService TreasuryForexOrderService { get; }
    //public IUsPaymentsService UsModelBankPaymentService { get; }


    //public IPaymentsConfigurationService PaymentsConfigurationService { get; }
}