// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Text.Json;
using Azure.Core;

namespace Azure.Analytics.Synapse.AccessControl
{
    public partial class CheckAccessDecision
    {
        internal static CheckAccessDecision DeserializeCheckAccessDecision(JsonElement element)
        {
            Optional<string> accessDecision = default;
            Optional<string> actionId = default;
            Optional<RoleAssignmentDetails> roleAssignment = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("accessDecision"))
                {
                    accessDecision = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("actionId"))
                {
                    actionId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("roleAssignment"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    roleAssignment = RoleAssignmentDetails.DeserializeRoleAssignmentDetails(property.Value);
                    continue;
                }
            }
            return new CheckAccessDecision(accessDecision.Value, actionId.Value, roleAssignment.Value);
        }
    }
}
