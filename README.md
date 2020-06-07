# About
Chat server as an practical simple OPC UA server sample in C# .NET Core Console App. This is based on samples of [UA-.NETStandard](https://github.com/OPCFoundation/UA-.NETStandard), but much simple and uses NuGet package of it.

|Node Name|Node Class|Description|
||||
|ChatLogs|Object|Subscribe ChatLogEventType of this node for getting posted messages as event.|
|Post|Method|Call this method to post a message.|
|PostCount|Variable|Increments when Post method is called.|

Specifying `-a` for command line parameter, the server accepts unknown client certificates for test purpose, same as official sample.

To compile an information model [design files](https://github.com/cactuaroid/OpcUaChatServer/tree/master/OpcUaChatServer.Server/OpcUa/Model/Design), run [build.bat](https://github.com/cactuaroid/OpcUaChatServer/blob/master/OpcUaChatServer.Server/OpcUa/Model/build.bat). This script requires [UA-ModelCompiler](https://github.com/OPCFoundation/UA-ModelCompiler). Clone it as well and build in 'Release'.

This application uses [MEF](https://docs.microsoft.com/en-us/dotnet/framework/mef/) as IoC container. `MefManager.Container.ComposeParts(this);` sets instances to the fields with `[Import]` attribute in the class.