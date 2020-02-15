namespace S3.Platform.D365
{

	[System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "9.0.0.9154")]
	public partial class OrganizationServiceContext1 : Microsoft.Xrm.Sdk.Client.OrganizationServiceContext
	{
		
		/// <summary>
		/// Constructor.
		/// </summary>
		public OrganizationServiceContext1(Microsoft.Xrm.Sdk.IOrganizationService service) : 
				base(service)
		{
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="S3.Platform.D365.Account"/> entities.
		/// </summary>
		public System.Linq.IQueryable<S3.Platform.D365.Account> AccountSet
		{
			get
			{
				return this.CreateQuery<S3.Platform.D365.Account>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="S3.Platform.D365.BusinessUnit"/> entities.
		/// </summary>
		public System.Linq.IQueryable<S3.Platform.D365.BusinessUnit> BusinessUnitSet
		{
			get
			{
				return this.CreateQuery<S3.Platform.D365.BusinessUnit>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="S3.Platform.D365.Contact"/> entities.
		/// </summary>
		public System.Linq.IQueryable<S3.Platform.D365.Contact> ContactSet
		{
			get
			{
				return this.CreateQuery<S3.Platform.D365.Contact>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="S3.Platform.D365.CustomerAddress"/> entities.
		/// </summary>
		public System.Linq.IQueryable<S3.Platform.D365.CustomerAddress> CustomerAddressSet
		{
			get
			{
				return this.CreateQuery<S3.Platform.D365.CustomerAddress>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="S3.Platform.D365.ccllc_agent"/> entities.
		/// </summary>
		public System.Linq.IQueryable<S3.Platform.D365.ccllc_agent> ccllc_agentSet
		{
			get
			{
				return this.CreateQuery<S3.Platform.D365.ccllc_agent>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="S3.Platform.D365.ccllc_agentauthorizedcustomer"/> entities.
		/// </summary>
		public System.Linq.IQueryable<S3.Platform.D365.ccllc_agentauthorizedcustomer> ccllc_agentauthorizedcustomerSet
		{
			get
			{
				return this.CreateQuery<S3.Platform.D365.ccllc_agentauthorizedcustomer>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="S3.Platform.D365.ccllc_agentprohibitedcustomer"/> entities.
		/// </summary>
		public System.Linq.IQueryable<S3.Platform.D365.ccllc_agentprohibitedcustomer> ccllc_agentprohibitedcustomerSet
		{
			get
			{
				return this.CreateQuery<S3.Platform.D365.ccllc_agentprohibitedcustomer>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="S3.Platform.D365.ccllc_agentrole"/> entities.
		/// </summary>
		public System.Linq.IQueryable<S3.Platform.D365.ccllc_agentrole> ccllc_agentroleSet
		{
			get
			{
				return this.CreateQuery<S3.Platform.D365.ccllc_agentrole>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="S3.Platform.D365.ccllc_channel"/> entities.
		/// </summary>
		public System.Linq.IQueryable<S3.Platform.D365.ccllc_channel> ccllc_channelSet
		{
			get
			{
				return this.CreateQuery<S3.Platform.D365.ccllc_channel>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="S3.Platform.D365.ccllc_device"/> entities.
		/// </summary>
		public System.Linq.IQueryable<S3.Platform.D365.ccllc_device> ccllc_deviceSet
		{
			get
			{
				return this.CreateQuery<S3.Platform.D365.ccllc_device>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="S3.Platform.D365.ccllc_evaluatortype"/> entities.
		/// </summary>
		public System.Linq.IQueryable<S3.Platform.D365.ccllc_evaluatortype> ccllc_evaluatortypeSet
		{
			get
			{
				return this.CreateQuery<S3.Platform.D365.ccllc_evaluatortype>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="S3.Platform.D365.ccllc_location"/> entities.
		/// </summary>
		public System.Linq.IQueryable<S3.Platform.D365.ccllc_location> ccllc_locationSet
		{
			get
			{
				return this.CreateQuery<S3.Platform.D365.ccllc_location>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="S3.Platform.D365.ccllc_partner"/> entities.
		/// </summary>
		public System.Linq.IQueryable<S3.Platform.D365.ccllc_partner> ccllc_partnerSet
		{
			get
			{
				return this.CreateQuery<S3.Platform.D365.ccllc_partner>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="S3.Platform.D365.ccllc_partnerworker"/> entities.
		/// </summary>
		public System.Linq.IQueryable<S3.Platform.D365.ccllc_partnerworker> ccllc_partnerworkerSet
		{
			get
			{
				return this.CreateQuery<S3.Platform.D365.ccllc_partnerworker>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="S3.Platform.D365.ccllc_role"/> entities.
		/// </summary>
		public System.Linq.IQueryable<S3.Platform.D365.ccllc_role> ccllc_roleSet
		{
			get
			{
				return this.CreateQuery<S3.Platform.D365.ccllc_role>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="S3.Platform.D365.ccllc_worksession"/> entities.
		/// </summary>
		public System.Linq.IQueryable<S3.Platform.D365.ccllc_worksession> ccllc_worksessionSet
		{
			get
			{
				return this.CreateQuery<S3.Platform.D365.ccllc_worksession>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="S3.Platform.D365.SystemUser"/> entities.
		/// </summary>
		public System.Linq.IQueryable<S3.Platform.D365.SystemUser> SystemUserSet
		{
			get
			{
				return this.CreateQuery<S3.Platform.D365.SystemUser>();
			}
		}
	}
}
