using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace ElastaCloud.DataBricks.Sdk.Model
{
   /// <summary>
   /// The result and lifecycle states of the run.
   /// </summary>
   public class RunState
   {
      /// <summary>
      /// A descriptive message for the current state.
      /// </summary>
      [JsonProperty("state_message")]
      public string Message { get; set; }

      /// <summary>
      /// 	A description of a run’s current location in the run lifecycle. This field is always avaialble in the response.
      /// </summary>
      [JsonProperty("life_cycle_state")]
      public RunLifecycleState RunLifecycleState { get; set; }

      /// <summary>
      /// The result state of the run.
      /// </summary>
      [JsonProperty("result_state")]
      public RunResultState RunResultState { get; set; }
   }
}