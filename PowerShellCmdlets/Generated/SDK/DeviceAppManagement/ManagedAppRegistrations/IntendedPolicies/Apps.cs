// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Retrieves &quot;microsoft.graph.managedMobileApp&quot; objects.</para>
    ///     <para type="description">GET ~/deviceAppManagement/managedAppRegistrations/{managedAppRegistrationId}/intendedPolicies/{intendedPolicyId}/{intendedPolicyODataType}/apps</para>
    ///     <para type="description">Retrieves &quot;microsoft.graph.managedMobileApp&quot; objects in the &quot;apps&quot; collection.</para>
    ///     <para type="description">List of apps to which the policy is deployed.</para>
    /// </summary>
    [Cmdlet("Get", "DeviceAppManagement_ManagedAppRegistrations_IntendedPolicies_Apps", DefaultParameterSetName = @"Search")]
    [ODataType("microsoft.graph.managedMobileApp")]
    [ResourceTypePropertyName("appODataType")]
    [ResourceIdPropertyName("appId")]
    [ResourceReference]
    public class Get_DeviceAppManagement_ManagedAppRegistrations_IntendedPolicies_Apps : GetOrSearchCmdlet
    {
        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.managedAppRegistration&quot; object in the &quot;managedAppRegistrations&quot; collection.</para>
        /// </summary>
        [Selectable]
        [IdParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.managedAppRegistration&quot; object in the &quot;managedAppRegistrations&quot; collection.")]
        public System.String managedAppRegistrationId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.managedAppPolicy&quot; object in the &quot;intendedPolicies&quot; collection.</para>
        /// </summary>
        [Selectable]
        [IdParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.managedAppPolicy&quot; object in the &quot;intendedPolicies&quot; collection.")]
        public System.String intendedPolicyId { get; set; }

        /// <summary>
        ///     <para type="description">A required type cast for referencing properties that exist only on certain types of &quot;microsoft.graph.managedAppPolicy&quot; objects.</para>
        /// </summary>
        [Selectable]
        [TypeCastParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required type cast for referencing properties that exist only on certain types of &quot;microsoft.graph.managedAppPolicy&quot; objects.")]
        public System.String intendedPolicyODataType { get; set; }

        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.managedMobileApp&quot; object in the &quot;apps&quot; collection.</para>
        /// </summary>
        [Selectable]
        [IdParameter]
        [Alias("id")]
        [ValidateNotNullOrEmpty]
        [Parameter(ParameterSetName = @"Get", ValueFromPipeline = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.managedMobileApp&quot; object in the &quot;apps&quot; collection.")]
        public System.String appId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;mobileAppIdentifier&quot; property, of type &quot;microsoft.graph.mobileAppIdentifier&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedMobileApp&quot; type.</para>
        ///     <para type="description">The identifier for an app with it&apos;s operating system type.</para>
        /// </summary>
        [ODataType("microsoft.graph.mobileAppIdentifier", "microsoft.graph.iosMobileAppIdentifier", "microsoft.graph.androidMobileAppIdentifier")]
        [Selectable]
        [Sortable]
        public System.Object mobileAppIdentifier { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;version&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedMobileApp&quot; type.</para>
        ///     <para type="description">Version of the entity.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String version { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"deviceAppManagement/managedAppRegistrations/{managedAppRegistrationId}/intendedPolicies/{intendedPolicyId}/{intendedPolicyODataType}/apps/{appId ?? string.Empty}";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Creates a &quot;microsoft.graph.managedMobileApp&quot; object.</para>
    ///     <para type="description">POST ~/deviceAppManagement/managedAppRegistrations/{managedAppRegistrationId}/intendedPolicies/{intendedPolicyId}/{intendedPolicyODataType}/apps</para>
    ///     <para type="description">Adds a &quot;microsoft.graph.managedMobileApp&quot; object to the &quot;apps&quot; collection.</para>
    ///     <para type="description">List of apps to which the policy is deployed.</para>
    /// </summary>
    [Cmdlet("New", "DeviceAppManagement_ManagedAppRegistrations_IntendedPolicies_Apps", ConfirmImpact = ConfirmImpact.Low, DefaultParameterSetName = @"microsoft.graph.managedMobileApp")]
    [ODataType("microsoft.graph.managedMobileApp")]
    [ResourceTypePropertyName("appODataType")]
    [ResourceIdPropertyName("appId")]
    [ResourceReference]
    public class New_DeviceAppManagement_ManagedAppRegistrations_IntendedPolicies_Apps : PostCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.managedMobileApp&quot; object in the &quot;apps&quot; collection.</para>
        /// </summary>
        [Selectable]
        [IdParameter]
        public System.String appId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.managedAppRegistration&quot; object in the &quot;managedAppRegistrations&quot; collection.</para>
        /// </summary>
        [Selectable]
        [IdParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.managedAppRegistration&quot; object in the &quot;managedAppRegistrations&quot; collection.")]
        public System.String managedAppRegistrationId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.managedAppPolicy&quot; object in the &quot;intendedPolicies&quot; collection.</para>
        /// </summary>
        [Selectable]
        [IdParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.managedAppPolicy&quot; object in the &quot;intendedPolicies&quot; collection.")]
        public System.String intendedPolicyId { get; set; }

        /// <summary>
        ///     <para type="description">A required type cast for referencing properties that exist only on certain types of &quot;microsoft.graph.managedAppPolicy&quot; objects.</para>
        /// </summary>
        [Selectable]
        [TypeCastParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required type cast for referencing properties that exist only on certain types of &quot;microsoft.graph.managedAppPolicy&quot; objects.")]
        public System.String intendedPolicyODataType { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;mobileAppIdentifier&quot; property, of type &quot;microsoft.graph.mobileAppIdentifier&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedMobileApp&quot; type.</para>
        ///     <para type="description">The identifier for an app with it&apos;s operating system type.</para>
        /// </summary>
        [ODataType("microsoft.graph.mobileAppIdentifier", "microsoft.graph.iosMobileAppIdentifier", "microsoft.graph.androidMobileAppIdentifier")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.managedMobileApp", HelpMessage = @"The &quot;mobileAppIdentifier&quot; property, of type &quot;microsoft.graph.mobileAppIdentifier&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;mobileAppIdentifier&quot; property, of type &quot;microsoft.graph.mobileAppIdentifier&quot;.")]
        public System.Object mobileAppIdentifier { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;version&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedMobileApp&quot; type.</para>
        ///     <para type="description">Version of the entity.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.managedMobileApp", HelpMessage = @"The &quot;version&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;version&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String version { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"deviceAppManagement/managedAppRegistrations/{managedAppRegistrationId}/intendedPolicies/{intendedPolicyId}/{intendedPolicyODataType}/apps/{appId}";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Updates a &quot;microsoft.graph.managedMobileApp&quot;.</para>
    ///     <para type="description">PATCH ~/deviceAppManagement/managedAppRegistrations/{managedAppRegistrationId}/intendedPolicies/{intendedPolicyId}/{intendedPolicyODataType}/apps</para>
    ///     <para type="description">Updates a &quot;microsoft.graph.managedMobileApp&quot; object in the &quot;apps&quot; collection.</para>
    ///     <para type="description">List of apps to which the policy is deployed.</para>
    /// </summary>
    [Cmdlet("Update", "DeviceAppManagement_ManagedAppRegistrations_IntendedPolicies_Apps", ConfirmImpact = ConfirmImpact.Medium, DefaultParameterSetName = @"microsoft.graph.managedMobileApp")]
    [ODataType("microsoft.graph.managedMobileApp")]
    [ResourceTypePropertyName("appODataType")]
    [ResourceIdPropertyName("appId")]
    public class Update_DeviceAppManagement_ManagedAppRegistrations_IntendedPolicies_Apps : PatchCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.managedMobileApp&quot; object in the &quot;apps&quot; collection.</para>
        /// </summary>
        [Selectable]
        [IdParameter]
        [Alias("id")]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.managedMobileApp&quot; object in the &quot;apps&quot; collection.")]
        public System.String appId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.managedAppRegistration&quot; object in the &quot;managedAppRegistrations&quot; collection.</para>
        /// </summary>
        [Selectable]
        [IdParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.managedAppRegistration&quot; object in the &quot;managedAppRegistrations&quot; collection.")]
        public System.String managedAppRegistrationId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.managedAppPolicy&quot; object in the &quot;intendedPolicies&quot; collection.</para>
        /// </summary>
        [Selectable]
        [IdParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.managedAppPolicy&quot; object in the &quot;intendedPolicies&quot; collection.")]
        public System.String intendedPolicyId { get; set; }

        /// <summary>
        ///     <para type="description">A required type cast for referencing properties that exist only on certain types of &quot;microsoft.graph.managedAppPolicy&quot; objects.</para>
        /// </summary>
        [Selectable]
        [TypeCastParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required type cast for referencing properties that exist only on certain types of &quot;microsoft.graph.managedAppPolicy&quot; objects.")]
        public System.String intendedPolicyODataType { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;mobileAppIdentifier&quot; property, of type &quot;microsoft.graph.mobileAppIdentifier&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedMobileApp&quot; type.</para>
        ///     <para type="description">The identifier for an app with it&apos;s operating system type.</para>
        /// </summary>
        [ODataType("microsoft.graph.mobileAppIdentifier", "microsoft.graph.iosMobileAppIdentifier", "microsoft.graph.androidMobileAppIdentifier")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.managedMobileApp", HelpMessage = @"The &quot;mobileAppIdentifier&quot; property, of type &quot;microsoft.graph.mobileAppIdentifier&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;mobileAppIdentifier&quot; property, of type &quot;microsoft.graph.mobileAppIdentifier&quot;.")]
        public System.Object mobileAppIdentifier { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;version&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedMobileApp&quot; type.</para>
        ///     <para type="description">Version of the entity.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.managedMobileApp", HelpMessage = @"The &quot;version&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;version&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String version { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"deviceAppManagement/managedAppRegistrations/{managedAppRegistrationId}/intendedPolicies/{intendedPolicyId}/{intendedPolicyODataType}/apps/{appId}";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Removes a &quot;microsoft.graph.managedMobileApp&quot; object.</para>
    ///     <para type="description">DELETE ~/deviceAppManagement/managedAppRegistrations/{managedAppRegistrationId}/intendedPolicies/{intendedPolicyId}/{intendedPolicyODataType}/apps/appId</para>
    ///     <para type="description">Removes a &quot;microsoft.graph.managedMobileApp&quot; object from the &quot;apps&quot; collection.</para>
    ///     <para type="description">List of apps to which the policy is deployed.</para>
    /// </summary>
    [Cmdlet("Remove", "DeviceAppManagement_ManagedAppRegistrations_IntendedPolicies_Apps", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.managedMobileApp")]
    [ResourceTypePropertyName("appODataType")]
    [ResourceIdPropertyName("appId")]
    public class Remove_DeviceAppManagement_ManagedAppRegistrations_IntendedPolicies_Apps : DeleteCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.managedMobileApp&quot; object in the &quot;apps&quot; collection.</para>
        /// </summary>
        [Selectable]
        [IdParameter]
        [Alias("id")]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipeline = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.managedMobileApp&quot; object in the &quot;apps&quot; collection.")]
        public System.String appId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.managedAppRegistration&quot; object in the &quot;managedAppRegistrations&quot; collection.</para>
        /// </summary>
        [Selectable]
        [IdParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.managedAppRegistration&quot; object in the &quot;managedAppRegistrations&quot; collection.")]
        public System.String managedAppRegistrationId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.managedAppPolicy&quot; object in the &quot;intendedPolicies&quot; collection.</para>
        /// </summary>
        [Selectable]
        [IdParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.managedAppPolicy&quot; object in the &quot;intendedPolicies&quot; collection.")]
        public System.String intendedPolicyId { get; set; }

        /// <summary>
        ///     <para type="description">A required type cast for referencing properties that exist only on certain types of &quot;microsoft.graph.managedAppPolicy&quot; objects.</para>
        /// </summary>
        [Selectable]
        [TypeCastParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required type cast for referencing properties that exist only on certain types of &quot;microsoft.graph.managedAppPolicy&quot; objects.")]
        public System.String intendedPolicyODataType { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"deviceAppManagement/managedAppRegistrations/{managedAppRegistrationId}/intendedPolicies/{intendedPolicyId}/{intendedPolicyODataType}/apps/{appId}";
        }
    }
}