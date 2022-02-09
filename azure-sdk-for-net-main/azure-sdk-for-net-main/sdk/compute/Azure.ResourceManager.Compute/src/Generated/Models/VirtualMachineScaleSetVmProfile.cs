// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> Describes a virtual machine scale set virtual machine profile. </summary>
    public partial class VirtualMachineScaleSetVmProfile
    {
        /// <summary> Initializes a new instance of VirtualMachineScaleSetVmProfile. </summary>
        public VirtualMachineScaleSetVmProfile()
        {
        }

        /// <summary> Initializes a new instance of VirtualMachineScaleSetVmProfile. </summary>
        /// <param name="osProfile"> Specifies the operating system settings for the virtual machines in the scale set. </param>
        /// <param name="storageProfile"> Specifies the storage settings for the virtual machine disks. </param>
        /// <param name="networkProfile"> Specifies properties of the network interfaces of the virtual machines in the scale set. </param>
        /// <param name="securityProfile"> Specifies the Security related profile settings for the virtual machines in the scale set. </param>
        /// <param name="diagnosticsProfile"> Specifies the boot diagnostic settings state. &lt;br&gt;&lt;br&gt;Minimum api-version: 2015-06-15. </param>
        /// <param name="extensionProfile"> Specifies a collection of settings for extensions installed on virtual machines in the scale set. </param>
        /// <param name="licenseType"> Specifies that the image or disk that is being used was licensed on-premises. &lt;br&gt;&lt;br&gt; Possible values for Windows Server operating system are: &lt;br&gt;&lt;br&gt; Windows_Client &lt;br&gt;&lt;br&gt; Windows_Server &lt;br&gt;&lt;br&gt; Possible values for Linux Server operating system are: &lt;br&gt;&lt;br&gt; RHEL_BYOS (for RHEL) &lt;br&gt;&lt;br&gt; SLES_BYOS (for SUSE) &lt;br&gt;&lt;br&gt; For more information, see [Azure Hybrid Use Benefit for Windows Server](https://docs.microsoft.com/azure/virtual-machines/windows/hybrid-use-benefit-licensing) &lt;br&gt;&lt;br&gt; [Azure Hybrid Use Benefit for Linux Server](https://docs.microsoft.com/azure/virtual-machines/linux/azure-hybrid-benefit-linux) &lt;br&gt;&lt;br&gt; Minimum api-version: 2015-06-15. </param>
        /// <param name="priority"> Specifies the priority for the virtual machines in the scale set. &lt;br&gt;&lt;br&gt;Minimum api-version: 2017-10-30-preview. </param>
        /// <param name="evictionPolicy"> Specifies the eviction policy for the Azure Spot virtual machine and Azure Spot scale set. &lt;br&gt;&lt;br&gt;For Azure Spot virtual machines, both &apos;Deallocate&apos; and &apos;Delete&apos; are supported and the minimum api-version is 2019-03-01. &lt;br&gt;&lt;br&gt;For Azure Spot scale sets, both &apos;Deallocate&apos; and &apos;Delete&apos; are supported and the minimum api-version is 2017-10-30-preview. </param>
        /// <param name="billingProfile"> Specifies the billing related details of a Azure Spot VMSS. &lt;br&gt;&lt;br&gt;Minimum api-version: 2019-03-01. </param>
        /// <param name="scheduledEventsProfile"> Specifies Scheduled Event related configurations. </param>
        /// <param name="userData"> UserData for the virtual machines in the scale set, which must be base-64 encoded. Customer should not pass any secrets in here. &lt;br&gt;&lt;br&gt;Minimum api-version: 2021-03-01. </param>
        /// <param name="capacityReservation"> Specifies the capacity reservation related details of a scale set. &lt;br&gt;&lt;br&gt;Minimum api-version: 2021-04-01. </param>
        /// <param name="applicationProfile"> Specifies the gallery applications that should be made available to the VM/VMSS. </param>
        internal VirtualMachineScaleSetVmProfile(VirtualMachineScaleSetOSProfile osProfile, VirtualMachineScaleSetStorageProfile storageProfile, VirtualMachineScaleSetNetworkProfile networkProfile, SecurityProfile securityProfile, DiagnosticsProfile diagnosticsProfile, VirtualMachineScaleSetExtensionProfile extensionProfile, string licenseType, VirtualMachinePriorityTypes? priority, VirtualMachineEvictionPolicyTypes? evictionPolicy, BillingProfile billingProfile, ScheduledEventsProfile scheduledEventsProfile, string userData, CapacityReservationProfile capacityReservation, ApplicationProfile applicationProfile)
        {
            OsProfile = osProfile;
            StorageProfile = storageProfile;
            NetworkProfile = networkProfile;
            SecurityProfile = securityProfile;
            DiagnosticsProfile = diagnosticsProfile;
            ExtensionProfile = extensionProfile;
            LicenseType = licenseType;
            Priority = priority;
            EvictionPolicy = evictionPolicy;
            BillingProfile = billingProfile;
            ScheduledEventsProfile = scheduledEventsProfile;
            UserData = userData;
            CapacityReservation = capacityReservation;
            ApplicationProfile = applicationProfile;
        }

        /// <summary> Specifies the operating system settings for the virtual machines in the scale set. </summary>
        public VirtualMachineScaleSetOSProfile OsProfile { get; set; }
        /// <summary> Specifies the storage settings for the virtual machine disks. </summary>
        public VirtualMachineScaleSetStorageProfile StorageProfile { get; set; }
        /// <summary> Specifies properties of the network interfaces of the virtual machines in the scale set. </summary>
        public VirtualMachineScaleSetNetworkProfile NetworkProfile { get; set; }
        /// <summary> Specifies the Security related profile settings for the virtual machines in the scale set. </summary>
        public SecurityProfile SecurityProfile { get; set; }
        /// <summary> Specifies the boot diagnostic settings state. &lt;br&gt;&lt;br&gt;Minimum api-version: 2015-06-15. </summary>
        public DiagnosticsProfile DiagnosticsProfile { get; set; }
        /// <summary> Specifies a collection of settings for extensions installed on virtual machines in the scale set. </summary>
        public VirtualMachineScaleSetExtensionProfile ExtensionProfile { get; set; }
        /// <summary> Specifies that the image or disk that is being used was licensed on-premises. &lt;br&gt;&lt;br&gt; Possible values for Windows Server operating system are: &lt;br&gt;&lt;br&gt; Windows_Client &lt;br&gt;&lt;br&gt; Windows_Server &lt;br&gt;&lt;br&gt; Possible values for Linux Server operating system are: &lt;br&gt;&lt;br&gt; RHEL_BYOS (for RHEL) &lt;br&gt;&lt;br&gt; SLES_BYOS (for SUSE) &lt;br&gt;&lt;br&gt; For more information, see [Azure Hybrid Use Benefit for Windows Server](https://docs.microsoft.com/azure/virtual-machines/windows/hybrid-use-benefit-licensing) &lt;br&gt;&lt;br&gt; [Azure Hybrid Use Benefit for Linux Server](https://docs.microsoft.com/azure/virtual-machines/linux/azure-hybrid-benefit-linux) &lt;br&gt;&lt;br&gt; Minimum api-version: 2015-06-15. </summary>
        public string LicenseType { get; set; }
        /// <summary> Specifies the priority for the virtual machines in the scale set. &lt;br&gt;&lt;br&gt;Minimum api-version: 2017-10-30-preview. </summary>
        public VirtualMachinePriorityTypes? Priority { get; set; }
        /// <summary> Specifies the eviction policy for the Azure Spot virtual machine and Azure Spot scale set. &lt;br&gt;&lt;br&gt;For Azure Spot virtual machines, both &apos;Deallocate&apos; and &apos;Delete&apos; are supported and the minimum api-version is 2019-03-01. &lt;br&gt;&lt;br&gt;For Azure Spot scale sets, both &apos;Deallocate&apos; and &apos;Delete&apos; are supported and the minimum api-version is 2017-10-30-preview. </summary>
        public VirtualMachineEvictionPolicyTypes? EvictionPolicy { get; set; }
        /// <summary> Specifies the billing related details of a Azure Spot VMSS. &lt;br&gt;&lt;br&gt;Minimum api-version: 2019-03-01. </summary>
        public BillingProfile BillingProfile { get; set; }
        /// <summary> Specifies Scheduled Event related configurations. </summary>
        public ScheduledEventsProfile ScheduledEventsProfile { get; set; }
        /// <summary> UserData for the virtual machines in the scale set, which must be base-64 encoded. Customer should not pass any secrets in here. &lt;br&gt;&lt;br&gt;Minimum api-version: 2021-03-01. </summary>
        public string UserData { get; set; }
        /// <summary> Specifies the capacity reservation related details of a scale set. &lt;br&gt;&lt;br&gt;Minimum api-version: 2021-04-01. </summary>
        public CapacityReservationProfile CapacityReservation { get; set; }
        /// <summary> Specifies the gallery applications that should be made available to the VM/VMSS. </summary>
        public ApplicationProfile ApplicationProfile { get; set; }
    }
}