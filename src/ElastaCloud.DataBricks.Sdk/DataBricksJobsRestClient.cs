using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ElastaCloud.DataBricks.Sdk.Model;

namespace ElastaCloud.DataBricks.Sdk
{
   /// <summary>
   /// Public REST client
   /// </summary>
   public class DataBricksJobsRestClient
   {
      private readonly IDatabricksEndpoint _endpoint;

      internal DataBricksJobsRestClient(IDatabricksEndpoint endpoint)
      {
         _endpoint = endpoint;
      }

      /// <summary>
      /// Lists all jobs - https://docs.azuredatabricks.net/api/latest/jobs.html#list
      /// </summary>
      public async Task<Job[]> GetAllAsync()
      {
         JobsResponse response = await _endpoint.GetAllJobs();

         return null;
      }

      /// <summary>
      /// Lists runs from most recently started to least - https://docs.azuredatabricks.net/api/latest/jobs.html#runs-list
      /// </summary>
      /// <returns></returns>
      public async Task<Run[]> GetRunsAsync()
      {
         RunsResponse response = await _endpoint.GetAllRuns();

         return response.Runs;
      }

      public async Task<Run> GetRunAsync(long runId)
      {
         return await _endpoint.GetRun(runId);
      }

      /// <summary>
      /// Submits a new run and returns the run ID.
      /// </summary>
      /// <param name="run"></param>
      /// <returns></returns>
      public async Task<long> SubmitRunAsync(NewRun run)
      {
         SubmitRunResponse response = await _endpoint.SubmitRun(run);

         return response.RunId;
      }
   }
}