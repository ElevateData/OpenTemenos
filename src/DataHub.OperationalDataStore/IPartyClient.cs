using OpenTemenos.DataHubs.OperationalDataStore.Party.CustomerDetails;
using OpenTemenos.DataHubs.OperationalDataStore.Party.ExternalUserDetails;
using OpenTemenos.DataHubs.OperationalDataStore.Party.ParticipantLists;
using OpenTemenos.DataHubs.OperationalDataStore.Party.UsCustomerDetails;

namespace OpenTemenos.DataHubs.OperationalDataStore;

public interface IPartyClient
{
    public ICustomerDetailService CustomerDetailService { get; }
    public IExternalUserDetailService ExternalUserDetailService { get; }
    public IParticipantListService ParticipantListService { get; }
    public IUsCustomerDetailService UsModelBankCustomerDetailService { get; }
}