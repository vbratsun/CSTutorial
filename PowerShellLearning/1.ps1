function CheckSite([string]$url)
{
$response = Invoke-WebRequest -Uri $url -Method Get -ContentType "application/json; charset=utf-8"
#$response | Out-Host
#$responseContent = $response.Content |Out-Host
$okResp = $response.StatusCode -eq "20"
if ($okResp -eq $false)
    {
        $response.StatusCode
        throw "warning:"+$response.StatusCode         
    }
$response.StatusCode|Out-Default
$response.Content|Out-Default
return "no worries"
}

$url = 'http://www.yura.com/'

CheckSite $url