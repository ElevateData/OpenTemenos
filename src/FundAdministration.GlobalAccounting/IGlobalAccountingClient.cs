namespace OpenTemenos.FundAdministrations.GlobalAccounting;

public interface IGlobalAccountingClient
{
    public IHoldingClient Holding { get; }
    public IOrderClient Order { get; }
    public IReferenceClient Reference { get; }
}