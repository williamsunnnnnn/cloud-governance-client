#
# Cloud Governance Api
# Contact: support@avepoint.com
#

<#
UpdatableApiUser<PSCustomObject>
#>

function New-UpdatableApiUser {
    [CmdletBinding()]
    Param (
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${Email},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${JobTitle},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${TenantId},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${PeopleFilterProfileId},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${UserType},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${Id},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${LoginName},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${IsExternalUser},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${DisplayName},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${IsGroup}
    )

    Process {
        'Creating PSCustomObject: Cloud.Governance.Client => UpdatableApiUser' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        
        $PSO = [PSCustomObject]@{
            "Email" = ${Email}
            "JobTitle" = ${JobTitle}
            "TenantId" = ${TenantId}
            "PeopleFilterProfileId" = ${PeopleFilterProfileId}
            "UserType" = ${UserType}
            "Id" = ${Id}
            "LoginName" = ${LoginName}
            "IsExternalUser" = ${IsExternalUser}
            "DisplayName" = ${DisplayName}
            "IsGroup" = ${IsGroup}
        }

        return $PSO
    }
}

<#
UpdatableApiUser<PSCustomObject>
#>
function ConvertFrom-JsonToUpdatableApiUser {
    Param(
        [AllowEmptyString()]
        [string]$Json
    )

    Process {
        'Converting JSON to PSCustomObject: Cloud.Governance.Client => UpdatableApiUser' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $JsonParameters = ConvertFrom-Json -InputObject $Json

        # check if Json contains properties not defined in UpdatableApiUser
        $AllProperties = $("Email", "JobTitle", "TenantId", "PeopleFilterProfileId", "UserType", "Id", "LoginName", "IsExternalUser", "DisplayName", "IsGroup", "IsLocalUser", "PhysicalDeliveryOfficeName", "IsValid", "AdditionalData")
        foreach ($name in $JsonParameters.PsObject.Properties.Name) {
            if (!($AllProperties.Contains($name))) {
                throw "Error! JSON key '$name' not found in the properties: $($AllProperties)"
            }
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Email"))) { #optional property not found
            $Email = $null
        } else {
            $Email = $JsonParameters.PSobject.Properties["Email"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "JobTitle"))) { #optional property not found
            $JobTitle = $null
        } else {
            $JobTitle = $JsonParameters.PSobject.Properties["JobTitle"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "TenantId"))) { #optional property not found
            $TenantId = $null
        } else {
            $TenantId = $JsonParameters.PSobject.Properties["TenantId"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "PeopleFilterProfileId"))) { #optional property not found
            $PeopleFilterProfileId = $null
        } else {
            $PeopleFilterProfileId = $JsonParameters.PSobject.Properties["PeopleFilterProfileId"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "UserType"))) { #optional property not found
            $UserType = $null
        } else {
            $UserType = $JsonParameters.PSobject.Properties["UserType"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Id"))) { #optional property not found
            $Id = $null
        } else {
            $Id = $JsonParameters.PSobject.Properties["Id"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "LoginName"))) { #optional property not found
            $LoginName = $null
        } else {
            $LoginName = $JsonParameters.PSobject.Properties["LoginName"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "IsExternalUser"))) { #optional property not found
            $IsExternalUser = $null
        } else {
            $IsExternalUser = $JsonParameters.PSobject.Properties["IsExternalUser"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "DisplayName"))) { #optional property not found
            $DisplayName = $null
        } else {
            $DisplayName = $JsonParameters.PSobject.Properties["DisplayName"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "IsGroup"))) { #optional property not found
            $IsGroup = $null
        } else {
            $IsGroup = $JsonParameters.PSobject.Properties["IsGroup"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "IsLocalUser"))) { #optional property not found
            $IsLocalUser = $null
        } else {
            $IsLocalUser = $JsonParameters.PSobject.Properties["IsLocalUser"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "PhysicalDeliveryOfficeName"))) { #optional property not found
            $PhysicalDeliveryOfficeName = $null
        } else {
            $PhysicalDeliveryOfficeName = $JsonParameters.PSobject.Properties["PhysicalDeliveryOfficeName"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "IsValid"))) { #optional property not found
            $IsValid = $null
        } else {
            $IsValid = $JsonParameters.PSobject.Properties["IsValid"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "AdditionalData"))) { #optional property not found
            $AdditionalData = $null
        } else {
            $AdditionalData = $JsonParameters.PSobject.Properties["AdditionalData"].value
        }

        $PSO = [PSCustomObject]@{
            "Email" = ${Email}
            "JobTitle" = ${JobTitle}
            "TenantId" = ${TenantId}
            "PeopleFilterProfileId" = ${PeopleFilterProfileId}
            "UserType" = ${UserType}
            "Id" = ${Id}
            "LoginName" = ${LoginName}
            "IsExternalUser" = ${IsExternalUser}
            "DisplayName" = ${DisplayName}
            "IsGroup" = ${IsGroup}
            "IsLocalUser" = ${IsLocalUser}
            "PhysicalDeliveryOfficeName" = ${PhysicalDeliveryOfficeName}
            "IsValid" = ${IsValid}
            "AdditionalData" = ${AdditionalData}
        }

        return $PSO
    }

}

