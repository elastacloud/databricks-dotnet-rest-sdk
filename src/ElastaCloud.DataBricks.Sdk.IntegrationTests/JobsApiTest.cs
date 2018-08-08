using System;
using System.Threading.Tasks;
using ElastaCloud.DataBricks.Sdk.Model;
using Xunit;

namespace ElastaCloud.DataBricks.Sdk.IntegrationTests
{
   public class JobsApiTest : ApiTest
   {
      [Fact]
      public async Task List_all_jobs()
      {
         Job[] all = await Client.Jobs.GetAllAsync();
      }

      [Fact]
      public async Task List_runs()
      {
         Run[] runs = await Client.Jobs.GetRunsAsync();
      }
   }
}