using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace ElastaCloud.DataBricks.Sdk.Model
{
   /// <summary>
   /// The result state of the run.
   /// </summary>
   [JsonConverter(typeof(StringEnumConverter))]
   public enum RunResultState
   {
      /// <summary>
      /// The task completed successfully.
      /// </summary>
      [EnumMember(Value = "SUCCESS")]
      Success,

      /// <summary>
      /// The task completed with an error.
      /// </summary>
      [EnumMember(Value = "FAILED")]
      Failed,

      /// <summary>
      /// The run was stopped after reaching the timeout.
      /// </summary>
      [EnumMember(Value = "TIMEDOUT")]
      TimedOut,

      /// <summary>
      /// The run was canceled at user request.
      /// </summary>
      [EnumMember(Value = "CANCELLED")]
      Cancelled
   }
}