function Parse-PersonXml {
    param(
        [Parameter(Mandatory)]
        [string]$XmlString
    )

    [xml]$xml = $XmlString
    $ns = New-Object System.Xml.XmlNamespaceManager($xml.NameTable)
    $ns.AddNamespace("p", "http://com///v4")

    $props = $xml.SelectSingleNode("//p:properties", $ns)

    function Get-Val($node, $xpath) {
        if (-not $node) { return $null }
        $found = $node.SelectSingleNode($xpath, $ns)
        if ($found) { return $found.InnerText.Trim() }
        return $null
    }

    function Get-Tel($person, $type) {
        if (-not $person) { return $null }
        $tel = $person.SelectSingleNode("p:tel[@teltype='$type']", $ns)
        if ($tel) { return $tel.InnerText.Trim() }
        return $null
    }

    $results = @()

    foreach ($person in $xml.SelectNodes("//p:person", $ns)) {

        $obj = [PSCustomObject]@{
            # Properties (shared)
            DateTime       = Get-Val $props "p:datetime"
            DataSource     = Get-Val $props "p:datasource"
            Comments       = Get-Val $props "p:comments"
            Type           = Get-Val $props "p:type"
            TimeframeStart = Get-Val $props "p:timeframe/p:start"
            TimeframeEnd   = Get-Val $props "p:timeframe/p:end"

            # Identity
            Source         = Get-Val $person "p:sourcedid/p:source"
            SourceId       = Get-Val $person "p:sourcedid/p:id"
            UserIdGUID     = Get-Val $person "p:userid[@useridtype='GUID']"
            UserIdPID      = Get-Val $person "p:userid[@useridtype='PID']"

            # Name
            FullName       = Get-Val $person "p:name/p:fn"
            FamilyName     = Get-Val $person "p:name/p:n/p:family"
            GivenName      = Get-Val $person "p:name/p:n/p:given"

            # Demographics
            Gender         = Get-Val $person "p:demographics/p:gender"
            BirthDay       = Get-Val $person "p:demographics/p:bday"

            # Email
            EmailHome        = Get-Val $person "p:emailhome"
            EmailWorkSchool  = Get-Val $person "p:emailworkschool"
            EmailWorkSchool2 = Get-Val $person "p:emailworkschool2"

            # Telephone
            TelVoice       = Get-Tel $person "Voice"
            TelMobile      = Get-Tel $person "Mobile"
            TelWork        = Get-Tel $person "Work"

            # Address
            ExtAdd         = Get-Val $person "p:adr/p:extadd"
            Street         = Get-Val $person "p:adr/p:street"
            Locality       = Get-Val $person "p:adr/p:locality"
            PostalCode     = Get-Val $person "p:adr/p:pcode"

            # Extension
            Privacy             = Get-Val $person "p:extension/p:privacy"
            GeographicKeyCode   = Get-Val $person "p:extension/p:geographickeycode"
            MunicipalityCode    = Get-Val $person "p:extension/p:municipalitycode"
            MunicipalityName    = Get-Val $person "p:extension/p:municipalityname"
            Timestamp           = Get-Val $person "p:extension/p:timestamp"
            Status              = Get-Val $person "p:extension/p:status"

            # Children
            Children            = @(foreach ($child in $person.SelectNodes("p:extension/p:children/p:child", $ns)) {
                [PSCustomObject]@{
                    Type      = $child.GetAttribute("type")
                    UserIdPID = (Get-Val $child "p:userid[@useridtype='PID']")
                }
            })

            # Extra Attributes
            AttributeId              = Get-Val $person "p:extraattribute/p:attributeid"
            Service                  = Get-Val $person "p:extraattribute/p:service"
            EduPersonPersistentId    = Get-Val $person "p:extraattribute/p:eduPersonPersistentId"
            EduPersonPrincipalName   = Get-Val $person "p:extraattribute/p:eduPersonPrincipalName"
            EduPersonUniqueId        = Get-Val $person "p:extraattribute/p:eduPersonUniqueId"
        }

        $results += $obj
    }

    return $results
}
