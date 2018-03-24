using DevOps.Build.AppVeyor.AzureStorageTableLedger;
using Microsoft.WindowsAzure.Storage.Table;
using System.Threading.Tasks;
using static DevOps.Build.AppVeyor.GetAzureTable.AzureTableGetter;

namespace DevOps.Build.AppVeyor.GetBuildRecord
{
    /// <summary>Function gets the given repository's build record from the Azure Storage Table AppVeyor build ledger</summary>
    public static class BuildRecordGetter
    {
        /// <summary>Returns the given repository's dependency string from the Azure Storage Table AppVeyor build ledger</summary>
        public static async Task<AppveyorBuildTable> GetBuildRecordAsync(string name, string version)
        {
            var operation = TableOperation.Retrieve<AppveyorBuildTable>(name, version); var table = await GetTable(); var result = await table.ExecuteAsync(operation); if (result?.Result == null) return null; return (AppveyorBuildTable)result.Result;
        }
    }
}
