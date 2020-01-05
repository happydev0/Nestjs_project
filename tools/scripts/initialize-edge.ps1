param(
    [Parameter(Mandatory=$True)] [string] $edgeKey
)
Write-Host ""$script:edgeKey""
. {Invoke-WebRequest -useb https://aka.ms/iotedge-win} | Invoke-Expression; `
Initialize-IoTEdge -Manual -DeviceConnectionString "$script:edgeKey"
