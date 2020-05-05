using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Messages;
using Microsoft.Xrm.Sdk.Metadata;

namespace CCLLC.BTF.Process.CDS
{
    public static class OrgServiceExtensions
    {
        public static AttributeMetadata[] GetAttributeMetadataForEntity(this IOrganizationService orgService, string recordType)
        {
            RetrieveEntityRequest retrieveEntityRequest = new RetrieveEntityRequest()
            {
                LogicalName = recordType,
                EntityFilters = EntityFilters.Attributes
            };

            var retrieveEntityResponse = (RetrieveEntityResponse)orgService.Execute(retrieveEntityRequest);

            return retrieveEntityResponse.EntityMetadata.Attributes;
        }
       
    }
}
