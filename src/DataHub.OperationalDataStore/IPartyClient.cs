using DataHub.OperationalDataStore.Party.CustomerDetails;
using DataHub.OperationalDataStore.Party.ExternalUserDetails;
using DataHub.OperationalDataStore.Party.ParticipantLists;
using DataHub.OperationalDataStore.Party.UsCustomerDetails;

namespace DataHub.OperationalDataStore;

public interface IPartyClient
{
    public ICustomerDetailService CustomerDetailService { get; }
    public IExternalUserDetailService ExternalUserDetailService { get; }
    public IParticipantListService ParticipantListService { get; }
    public IUsCustomerDetailService UsModelBankCustomerDetailService { get; }
}
