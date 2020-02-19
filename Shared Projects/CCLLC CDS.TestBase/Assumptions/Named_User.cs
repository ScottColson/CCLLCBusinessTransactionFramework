using System.Linq;
using DLaB.Xrm;
using DLaB.Xrm.Test.Assumptions;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;
using TestProxy;

namespace CCLLC.CDS.Test.Assumptions
{
    // ReSharper disable once InconsistentNaming
    public class Named_User : EntityDataAssumptionBaseAttribute, IAssumptionEntityType<Named_User, SystemUser>
    {
        protected override Entity RetrieveEntity(IOrganizationService service)
        {
            return service.RetrieveMultiple(
                new QueryExpression
                {
                    EntityName = "systemuser",
                    ColumnSet = new ColumnSet("systemuserid","fullname"),
                    Criteria = new FilterExpression
                    {
                        Conditions =
                        {
                            new ConditionExpression("fullname",ConditionOperator.Equal,"Scott Colson")
                        }
                    }
                }).Entities.FirstOrDefault();
        }
    }
}