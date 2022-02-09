// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> Describes a virtual machine scale set storage profile. </summary>
    public partial class VirtualMachineScaleSetStorageProfile
    {
        /// <summary> Initializes a new instance of VirtualMachineScaleSetStorageProfile. </summary>
        public VirtualMachineScaleSetStorageProfile()
        {
            DataDisks = new ChangeTrackingList<VirtualMachineScaleSetDataDisk>();
        }

        /// <summary> Initializes a new instance of VirtualMachineScaleSetStorageProfile. </summary>
        /// <param name="imageReference"> Specifies information about the image to use. You can specify information about platform images, marketplace images, or virtual machine images. This element is required when you want to use a platform image, marketplace image, or virtual machine image, but is not used in other creation operations. </param>
        /// <param name="oSDisk"> Specifies information about the operating system disk used by the virtual machines in the scale set. &lt;br&gt;&lt;br&gt; For more information about disks, see [About disks and VHDs for Azure virtual machines](https://docs.microsoft.com/azure/virtual-machines/managed-disks-overview). </param>
        /// <param name="dataDisks"> Specifies the parameters that are used to add data disks to the virtual machines in the scale set. &lt;br&gt;&lt;br&gt; For more information about disks, see [About disks and VHDs for Azure virtual machines](https://docs.microsoft.com/azure/virtual-machines/managed-disks-overview). </param>
        internal VirtualMachineScaleSetStorageProfile(ImageReference imageReference, VirtualMachineScaleSetOSDisk oSDisk, IList<VirtualMachineScaleSetDataDisk> dataDisks)
        {
            ImageReference = imageReference;
            OSDisk = oSDisk;
            DataDisks = dataDisks;
        }

        /// <summary> Specifies information about the image to use. You can specify information about platform images, marketplace images, or virtual machine images. This element is required when you want to use a platform image, marketplace image, or virtual machine image, but is not used in other creation operations. </summary>
        public ImageReference ImageReference { get; set; }
        /// <summary> Specifies information about the operating system disk used by the virtual machines in the scale set. &lt;br&gt;&lt;br&gt; For more information about disks, see [About disks and VHDs for Azure virtual machines](https://docs.microsoft.com/azure/virtual-machines/managed-disks-overview). </summary>
        public VirtualMachineScaleSetOSDisk OSDisk { get; set; }
        /// <summary> Specifies the parameters that are used to add data disks to the virtual machines in the scale set. &lt;br&gt;&lt;br&gt; For more information about disks, see [About disks and VHDs for Azure virtual machines](https://docs.microsoft.com/azure/virtual-machines/managed-disks-overview). </summary>
        public IList<VirtualMachineScaleSetDataDisk> DataDisks { get; }
    }
}