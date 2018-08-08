using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace ElastaCloud.DataBricks.Sdk.Model
{
   /// <summary>
   /// The life cycle state of a run
   /// </summary>
   [JsonConverter(typeof(StringEnumConverter))]
   public enum RunLifecycleState
   {
      /// <summary>
      /// The run has been triggered. If there is not already an active run of the same job, the cluster and execution context are being prepared. If there is already an active run of the same job, the run will immediately transition into a SKIPPED state without preparing any resources.
      /// </summary>
      [EnumMember(Value = "PENDING")]
      Pending,

      /// <summary>
      /// The task of this run is currently being executed.
      /// </summary>
      [EnumMember(Value = "RUNNING")]
      Running,

      /// <summary>
      /// The task of this run has completed, and the cluster and execution context are being cleaned up.
      /// </summary>
      [EnumMember(Value = "TERMINATING")]
      Terminating,

      /// <summary>
      /// The task of this run has completed, and the cluster and execution context have been cleaned up. This state is terminal.
      /// </summary>
      [EnumMember(Value = "TERMINATED")]
      Terminated,

      /// <summary>
      /// 	This run was aborted because a previous run of the same job was already active. This state is terminal.
      /// </summary>
      [EnumMember(Value = "SKIPPED")]
      Skipped,

      /// <summary>
      /// An exceptional state that indicates a failure in the Jobs service, such as network failure over a long period. If a run on a new cluster ends in an INTERNAL_ERROR state, the Jobs service will terminate the cluster as soon as possible. This state is terminal.
      /// </summary>
      [EnumMember(Value = "INTERNAL_ERROR")]
      InternalError
   }
}
