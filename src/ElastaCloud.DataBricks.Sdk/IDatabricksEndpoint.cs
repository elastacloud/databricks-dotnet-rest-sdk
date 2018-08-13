using System;
using System.Threading.Tasks;
using ElastaCloud.DataBricks.Sdk.Model;
using Newtonsoft.Json;
using Refit;

namespace ElastaCloud.DataBricks.Sdk
{
   interface IDatabricksEndpoint
   {
      [Get("/api/2.0/jobs/list")]
      Task<JobsResponse> GetAllJobs();

      [Get("/api/2.0/jobs/runs/list")]
      Task<RunsResponse> GetAllRuns();

      [Get("/api/2.0/jobs/runs/get")]
      Task<Run> GetRun([AliasAs("run_id")] long runId);

      [Post("/api/2.0/jobs/runs/submit")]
      Task<SubmitRunResponse> SubmitRun([Body] NewRun newRun);
   }

   #region [ Wrappers ]

   class JobsResponse
   {
      [JsonProperty("jobs")]
      public Job[] Jobs { get; set; }
   }

   class RunsResponse
   {
      [JsonProperty("runs")]
      public Run[] Runs { get; set; }

      [JsonProperty("has_more")]
      public bool HasMore { get; set; }
   }

   class SubmitRunResponse
   {
      [JsonProperty("run_id")]
      public long RunId { get; set; }
   }

   #endregion
}