#
# Cloud Governance Api
# Contact: support@avepoint.com
#

<#
GroupMembershipItem<PSCustomObject>
#>

function New-GroupMembershipItem {
    [CmdletBinding()]
    Param (
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${LoginName},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${DisplayName},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${Action}
    )

    Process {
        'Creating PSCustomObject: Cloud.Governance.Client => GroupMembershipItem' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        
        $PSO = [PSCustomObject]@{
            "LoginName" = ${LoginName}
            "DisplayName" = ${DisplayName}
            "Action" = ${Action}
        }

        return $PSO
    }
}

<#
GroupMembershipItem<PSCustomObject>
#>
function ConvertFrom-JsonToGroupMembershipItem {
    Param(
        [AllowEmptyString()]
        [string]$Json
    )

    Process {
        'Converting JSON to PSCustomObject: Cloud.Governance.Client => GroupMembershipItem' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $JsonParameters = ConvertFrom-Json -InputObject $Json

        # check if Json contains properties not defined in GroupMembershipItem
        $AllProperties = $("LoginName", "DisplayName", "Action")
        foreach ($name in $JsonParameters.PsObject.Properties.Name) {
            if (!($AllProperties.Contains($name))) {
                throw "Error! JSON key '$name' not found in the properties: $($AllProperties)"
            }
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "LoginName"))) { #optional property not found
            $LoginName = $null
        } else {
            $LoginName = $JsonParameters.PSobject.Properties["LoginName"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "DisplayName"))) { #optional property not found
            $DisplayName = $null
        } else {
            $DisplayName = $JsonParameters.PSobject.Properties["DisplayName"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Action"))) { #optional property not found
            $Action = $null
        } else {
            $Action = $JsonParameters.PSobject.Properties["Action"].value
        }

        $PSO = [PSCustomObject]@{
            "LoginName" = ${LoginName}
            "DisplayName" = ${DisplayName}
            "Action" = ${Action}
        }

        return $PSO
    }

}

