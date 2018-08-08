using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace ElastaCloud.DataBricks.Sdk.Model
{
   public class Run
   {
      /// <summary>
      /// The canonical identifier of the run. This id is unique across all runs of all jobs.
      /// </summary>
      [JsonProperty("run_id")]
      public long Id { get; set; }

      /// <summary>
      /// The canonical identifier of the job that contains this run.
      /// </summary>
      [JsonProperty("job_id")]
      public long JobId { get; set; }

      /// <summary>
      /// The creator user name. This field won’t be included in the response if the user has already been deleted.
      /// </summary>
      [JsonProperty("creator_user_name")]
      public string CreatedBy { get; set; }

      /// <summary>
      /// The sequence number of this run among all runs of the job. This value starts at 1.
      /// </summary>
      [JsonProperty("number_in_job")]
      public long NumberInJob { get; set; }

      /// <summary>
      /// 	If this run is a retry of a prior run attempt, this field contains the run_id of the original attempt; otherwise, it is the same as the run_id.
      /// </summary>
      [JsonProperty("original_attempt_run_id")]
      public long OriginalAttemptRunId { get; set; }

      /// <summary>
      /// The result and lifecycle states of the run.
      /// </summary>
      [JsonProperty("state")]
      public RunState RunState { get; set; }

      //todo: schedule

      //todo: task

      //todo: cluster_spec

      //todo: cluster_instance

      //todo: overriding_parameters

      /// <summary>
      /// The time at which this run was started in epoch milliseconds (milliseconds since 1/1/1970 UTC). Note that this may not be the time when the job task starts executing, for example, if the job is scheduled to run on a new cluster, this is the time the cluster creation call is issued.
      /// </summary>
      [JsonProperty("start_time")]
      public long StartUnixTime { get; set; }

      /// <summary>
      /// The time it took to set up the cluster in milliseconds. For runs that run on new clusters this is the cluster creation time, for runs that run on existing clusters this time should be very short.
      /// </summary>
      [JsonProperty("setup_duration")]
      public long SetupDurationMs { get; set; }

      /// <summary>
      /// The time in milliseconds it took to execute the commands in the jar or notebook until they completed, failed, timed out, were cancelled, or encountered an unexpected error.
      /// </summary>
      [JsonProperty("execution_duration")]
      public long ExecutionDurationMs { get; set; }

      /// <summary>
      /// The time in milliseconds it took to terminate the cluster and clean up any intermediary results, etc. Note that the total duration of the run is the sum of the setup_duration, the execution_duration and the cleanup_duration.
      /// </summary>
      [JsonProperty("cleanup_duration")]
      public long CleanupDurationMs { get; set; }

      //todo: trigger
   }
}
