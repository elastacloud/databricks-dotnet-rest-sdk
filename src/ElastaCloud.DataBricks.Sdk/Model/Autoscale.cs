using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace ElastaCloud.DataBricks.Sdk.Model
{
   /// <summary>
   /// Describes autoscale parameters
   /// </summary>
   public class Autoscale
   {
      /// <summary>
      /// Minimum number of workers
      /// </summary>
      [JsonProperty("min_workers")]
      public int MinWorkers { get; set; }

      /// <summary>
      /// Maximum number of workers
      /// </summary>
      [JsonProperty("max_workers")]
      public int MaxWorkers { get; set; }
   }
}
