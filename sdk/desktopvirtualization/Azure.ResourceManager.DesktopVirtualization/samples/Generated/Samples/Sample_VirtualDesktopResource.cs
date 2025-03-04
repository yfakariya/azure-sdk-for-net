// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager;
using Azure.ResourceManager.DesktopVirtualization;
using Azure.ResourceManager.DesktopVirtualization.Models;

namespace Azure.ResourceManager.DesktopVirtualization.Samples
{
    public partial class Sample_VirtualDesktopResource
    {
        // Desktop_Get
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_DesktopGet()
        {
            // Generated from example definition: specification/desktopvirtualization/resource-manager/Microsoft.DesktopVirtualization/stable/2023-09-05/examples/Desktop_Get.json
            // this example is just showing the usage of "Desktops_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this VirtualDesktopResource created on azure
            // for more information of creating VirtualDesktopResource, please refer to the document of VirtualDesktopResource
            string subscriptionId = "daefabc0-95b4-48b3-b645-8a753a63c4fa";
            string resourceGroupName = "resourceGroup1";
            string applicationGroupName = "applicationGroup1";
            string desktopName = "SessionDesktop";
            ResourceIdentifier virtualDesktopResourceId = VirtualDesktopResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, applicationGroupName, desktopName);
            VirtualDesktopResource virtualDesktop = client.GetVirtualDesktopResource(virtualDesktopResourceId);

            // invoke the operation
            VirtualDesktopResource result = await virtualDesktop.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            VirtualDesktopData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Desktop_Update
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_DesktopUpdate()
        {
            // Generated from example definition: specification/desktopvirtualization/resource-manager/Microsoft.DesktopVirtualization/stable/2023-09-05/examples/Desktop_Update.json
            // this example is just showing the usage of "Desktops_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this VirtualDesktopResource created on azure
            // for more information of creating VirtualDesktopResource, please refer to the document of VirtualDesktopResource
            string subscriptionId = "daefabc0-95b4-48b3-b645-8a753a63c4fa";
            string resourceGroupName = "resourceGroup1";
            string applicationGroupName = "applicationGroup1";
            string desktopName = "SessionDesktop";
            ResourceIdentifier virtualDesktopResourceId = VirtualDesktopResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, applicationGroupName, desktopName);
            VirtualDesktopResource virtualDesktop = client.GetVirtualDesktopResource(virtualDesktopResourceId);

            // invoke the operation
            VirtualDesktopPatch patch = new VirtualDesktopPatch()
            {
                Description = "des1",
                FriendlyName = "friendly",
            };
            VirtualDesktopResource result = await virtualDesktop.UpdateAsync(patch);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            VirtualDesktopData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
