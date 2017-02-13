This project has adopted the [Microsoft Open Source Code of Conduct](https://opensource.microsoft.com/codeofconduct/). For more information see the [Code of Conduct FAQ](https://opensource.microsoft.com/codeofconduct/faq/) or contact [opencode@microsoft.com](mailto:opencode@microsoft.com) with any additional questions or comments

# OPC UA Client Module for the Azure IoT Gateway SDK
This reference implementation demonstrates how the Azure IoT Gateway SDK can be used to connect to existing OPC UA servers and send JSON encoded telemetry data from these servers in OPC UA "Pub/Sub" format (using a JSON payload) to Azure IoT Hub. All transport protocols supported by the Gateway SDK can be used, i.e. HTTPS, AMQP and MQTT. The transport is selected in the transport setting in gateway_config.JSON.

This module uses the OPC Foundations's OPC UA reference stack and therefore licensing restrictions apply. Visit http://opcfoundation.github.io/UA-.NETStandardLibrary/ for OPC UA documentation and licensing terms.

## Operating System Compatibility
Since this reference implementation is written for .NET, Windows 7, 8, 8.1 & 10 are supported right now. Once the Gateway SDK supports .NET Standard, so will this module and then Linux will also be supported.

## Directory Structure

### /binding
This folder contains the native entry point required for the Gateway SDK (main.c).

### Root Directory
This folder contains the C# OPC UA module source file (Module.cs), the gateway configuration file (gateway_config.json) and the OPC UA gateway module configuration file (Opc.Ua.Client.SampleModule.Config.xml).

## Configuring the Module
The OPC UA server endpoints the module should connect to and the list of OPC UA nodes for each endpoint that should be published to Azure IoT Hub can be configured in the **ListOfPublishedNodes** section of the **Opc.Ua.Client.SampleModule.Config.xml** configuration file. The **Current Server Time** node (node ID 2258) is specified as an example.

Also, in the gateway_config.json, configure the name of IoT Hub you want to send the telemetry to (JSON field "IoTHubName") and the IoT Hub device ID and shared access key to use (JSON field "args").

## Building and Running the Module
Simply open the solution file in Visual Studio and build it. Make sure you specify the gateway_config.json as a command line parameter, set the debugger type to Mixed and set the working directory to $(OutDir) before debugging.

## Updating NuGet Packages
There are manual steps required after updating the OPC UA or Gateway SDK NuGet packages:
1. When updating the OPC UA NuGet packages, you need to re-add the new reference to the updated OPC UA DLLs in the Opc.Ua.Client.Module project as Visual Studio doesn't do that automatically for .Net Standard assemblies in .Net Framework projects.
2. When updating the Gateway SDK NuGet package, you need to update the path in the post-build copy command for the Gateway SDK DLLs in the dotnet_binding_sample project.
