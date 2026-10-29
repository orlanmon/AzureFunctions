using System.IO;
using System.Threading.Tasks;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;

namespace AzureBlobStorageTriggerFunction;

public class Function_BlobTrigger
{
    private readonly ILogger<Function_BlobTrigger> _logger;

    public Function_BlobTrigger(ILogger<Function_BlobTrigger> logger)
    {
        _logger = logger;
    }

    [Function(nameof(Function_BlobTrigger))]
    public async Task Run([BlobTrigger("%AzureStorageContainer%/{name}", Connection = "AzureWebJobsStorage")] Stream stream, string name)
    {
        // Trigger on Files Uploaded to Azure Storage with the specified AzureStorageContainer 

        using var blobStreamReader = new StreamReader(stream);
        var content = await blobStreamReader.ReadToEndAsync();


        _logger.LogInformation("C# Blob trigger function Processed blob\n Name: {name} \n Data: {content}", name, content);
    }
}