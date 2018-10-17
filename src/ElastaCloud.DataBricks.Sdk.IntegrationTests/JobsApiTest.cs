using System;
using System.Collections.Generic;
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

      [Fact]
      public async Task Submit_run_to_new_cluster()
      {
         var newRun = new NewRun
         {
            NewCluster = new NewCluster
            {
               NumWorkers = 4,
               SparkVersion = "3.4.x-scala2.11",
               NodeTypeId = "Standard_D3_v2"
            },
            Libraries = new List<Dictionary<string, string>>
            {
               new Dictionary<string, string>
               {
                  ["jar"] = "dbfs:/FileStore/jars/1796537b_8feb_43d1_bf5e_9236672fd184-dataquality.jar"
               }
            },
            NotebookTask = new NotebookTask
            {
               Path = "/hello",
               Parameters = new[] { new ParamPair("key1", "value1"), new ParamPair("key2", "value2") }
            }
         };

         long runId = await Client.Jobs.SubmitRunAsync(newRun);

         Run run = await Client.Jobs.GetRunAsync(runId);
         Assert.NotNull(run);
      }

      [Fact]
      public async Task Submit_run_to_existing_cluster()
      {
         var newRun = new NewRun
         {
            ExistingClusterId = "1",
            /*Libraries = new List<Dictionary<string, string>>
            {
               new Dictionary<string, string>
               {
                  ["jar"] = "dbfs:/FileStore/jars/1796537b_8feb_43d1_bf5e_9236672fd184-dataquality.jar"
               }
            },*/
            NotebookTask = new NotebookTask
            {
               Path = "/hello",
               Parameters = new[] { new ParamPair("key1", "value1"), new ParamPair("key2", "value2") }
            }
         };

         long runId = await Client.Jobs.SubmitRunAsync(newRun);

         Run run = await Client.Jobs.GetRunAsync(runId);
         Assert.NotNull(run);
      }

      [Fact]
      public async Task Submit_run_to_new__autoscale_cluster()
      {
         var newRun = new NewRun
         {
            NewCluster = new NewCluster
            {
               Autoscale = new Autoscale()
               {
                  MinWorkers = 2,
                  MaxWorkers = 4
               },
               SparkVersion = "3.4.x-scala2.11",
               NodeTypeId = "Standard_D3_v2"
            },
            Libraries = new List<Dictionary<string, string>>
            {
               new Dictionary<string, string>
               {
                  ["jar"] = "dbfs:/FileStore/jars/1796537b_8feb_43d1_bf5e_9236672fd184-dataquality.jar"
               }
            },
            NotebookTask = new NotebookTask
            {
               Path = "/BounceTest/BounceTest",
              // Parameters = new[] { }
            }
         };

         long runId = await Client.Jobs.SubmitRunAsync(newRun);

         Run run = await Client.Jobs.GetRunAsync(runId);
         Assert.NotNull(run);
      }
   }
}