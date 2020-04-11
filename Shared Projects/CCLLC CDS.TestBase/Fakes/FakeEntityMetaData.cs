using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Metadata;
using System;


namespace CCLLC.CDS.Test.Fakes
{
    public class FakeEntityMetadata : MetadataBase
    {
        public FakeEntityMetadata() : base()
        { }

        public OneToManyRelationshipMetadata[] OneToManyRelationships { get; private set; }

        public OneToManyRelationshipMetadata[] ManyToOneRelationships { get; private set; }

        public ManyToManyRelationshipMetadata[] ManyToManyRelationships { get; }

        public string LogicalName { get; set; }

        public bool? IsQuickCreateEnabled { get; set; }

        public bool? IsReadingPaneEnabled { get; set; }

        public string MobileOfflineFilters { get; set; }

        public int? DaysSinceRecordLastModified { get; set; }

        public BooleanManagedProperty IsOfflineInMobileClient { get; set; }

        public BooleanManagedProperty IsReadOnlyInMobileClient { get; set; }

        public BooleanManagedProperty IsVisibleInMobileClient { get; set; }

        public BooleanManagedProperty IsVisibleInMobile { get; set; }

        public bool? IsValidForAdvancedFind { get; }

        public bool? IsEnabledForTrace { get; }

        public bool? IsEnabledForCharts { get; }

        public bool? IsManaged { get; }

        public BooleanManagedProperty IsMailMergeEnabled { get; set; }

        public bool? IsIntersect { get; }

        public bool? IsImportable { get; }

        public BooleanManagedProperty CanChangeTrackingBeEnabled { get; set; }

        public bool? ChangeTrackingEnabled { get; set; }

        public int? ObjectTypeCode { get; }

        public bool? IsOptimisticConcurrencyEnabled { get; }

        public OwnershipTypes? OwnershipType { get; set; }

        public string PrimaryImageAttribute { get; }

        public bool? HasActivities { get; set; }

        public bool? HasNotes { get; set; }

        public bool? IsLogicalEntity { get; }

        public bool? UsesBusinessDataLabelTable { get; set; }

        public bool? IsPrivate { get; }

        public bool? IsEnabledForExternalChannels { get; set; }

        public string EntitySetName { get; set; }

        public string CollectionSchemaName { get; }

        public string ExternalCollectionName { get; set; }

        public string LogicalCollectionName { get; set; }

        public EntityKeyMetadata[] Keys { get; }

        public string EntityColor { get; set; }

        public string ExternalName { get; set; }

        public bool? EnforceStateTransitions { get; }

        public bool? IsStateModelAware { get; }

        public string IntroducedVersion { get; }


        public string ReportViewName { get; }

        public string RecurrenceBaseEntityLogicalName { get; }

        public SecurityPrivilegeMetadata[] Privileges { get; }

        public string PrimaryIdAttribute { get; }

        public string PrimaryNameAttribute { get; }

        public BooleanManagedProperty CanChangeHierarchicalRelationship { get; set; }

        public BooleanManagedProperty CanModifyAdditionalSettings { get; set; }

        public bool? SyncToExternalSearchIndex { get; set; }

        public bool? IsActivity { get; set; }

        public bool? AutoCreateAccessTeams { get; set; }

        public Guid? DataSourceId { get; set; }

        public Guid? DataProviderId { get; set; }

        public bool? IsMSTeamsIntegrationEnabled { get; set; }

        public bool? IsDocumentRecommendationsEnabled { get; set; }

        public bool? IsBPFEntity { get; set; }

        public bool? IsSLAEnabled { get; set; }

        public bool? IsKnowledgeManagementEnabled { get; set; }

        public bool? IsInteractionCentricEnabled { get; set; }

        public bool? IsOneNoteIntegrationEnabled { get; set; }

        public bool? IsDocumentManagementEnabled { get; set; }

        public string EntityHelpUrl { get; set; }

        public bool? EntityHelpUrlEnabled { get; set; }

        public Label DisplayName { get; set; }

        public Label DisplayCollectionName { get; set; }

        public Label Description { get; set; }

        public bool? CanTriggerWorkflow { get; }

        public bool? AutoRouteToOwnerQueue { get; set; }

        public AttributeMetadata[] Attributes { get; set; }

        public int? ActivityTypeMask { get; set; }

        public bool? IsActivityParty { get; set; }

        public BooleanManagedProperty IsAuditEnabled { get; set; }

        public bool? IsAvailableOffline { get; set; }

        public bool? IsChildEntity { get; }

        public BooleanManagedProperty CanEnableSyncToExternalSearchIndex { get; set; }

        public BooleanManagedProperty CanBeInCustomEntityAssociation { get; }

        public BooleanManagedProperty CanBeInManyToMany { get; }


        public BooleanManagedProperty CanBeRelatedEntityInRelationship { get; }

        public BooleanManagedProperty CanCreateCharts { get; set; }

        public BooleanManagedProperty CanCreateViews { get; set; }

        public BooleanManagedProperty CanCreateForms { get; set; }

        public BooleanManagedProperty CanCreateAttributes { get; set; }

        public BooleanManagedProperty IsDuplicateDetectionEnabled { get; set; }

        public bool? HasFeedback { get; set; }

        public BooleanManagedProperty IsMappable { get; set; }

        public BooleanManagedProperty IsCustomizable { get; set; }

        public bool? IsBusinessProcessEnabled { get; set; }

        public bool? IsCustomEntity { get; }

        public string IconVectorName { get; set; }

        public string IconSmallName { get; set; }

        public string IconMediumName { get; set; }

        public string IconLargeName { get; set; }

        public BooleanManagedProperty IsConnectionsEnabled { get; set; }

        public BooleanManagedProperty IsValidForQueue { get; set; }

        public bool? IsAIRUpdated { get; }

        public BooleanManagedProperty IsRenameable { get; set; }

        public bool? IsSolutionAware { get; set; }
    }
}


