


YouTube Tutorial Video

https://www.youtube.com/watch?v=J65HAPz04-g


Create Storage Account

Select Resource Group

Under Containers create one to many containers/folder under that storage account.

Access Keys - copy connection string, will be needed to Azure Function Blog Trigger.


Azure Storage Connection:

https://aka.ms/dotnet-core-applaunch?framework=Microsoft.NETCore.App&framework_version=8.0.33&arch=x64&rid=win-x64&os=win10


host.json

Turn on informational logging

 "logging": {
    "logLevel": {
      "default": "Information",
      "Function": "Information"
    }
  }




Publishing

Using Visual Studio (Windows)

Ideal for .NET developers who want a quick, guided GUI experience.
1. Open Publish Wizard: Right-click your Azure Functions project in the Solution Explorer and select Publish.
2. Select Target: For the target, choose Azure, then select Azure Function App (Windows) or Azure Function App (Linux) based on your hosting setup.
3. Select App Instance: Choose your Azure subscription, resource group, and the specific Function App name you created in the portal. Click Finish to generate a publishing profile.
4. Publish: On the summary screen, click the prominent Publish button in the top right. Visual Studio will build, package, and upload your project files.



Note unlike and App Services an Azure Function is automatically assigned a System Managed ID!   

Under Azure Function:   Settings -> Indentity Note System Assigned Managed Identity.  This is in Entra ID 

Note unlike App Services you do not have to connect an Application Insight Resource to an Azure Function.  App Insights Automatically Provided

