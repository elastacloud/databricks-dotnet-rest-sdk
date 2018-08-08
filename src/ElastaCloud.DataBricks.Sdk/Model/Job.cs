using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace ElastaCloud.DataBricks.Sdk.Model
{
   public class Job
   {
      [JsonProperty("job_id")]
      public long Id { get; set; }

      [JsonProperty("creator_user_name")]
      public string CreatedBy { get; set; }

      [JsonProperty("created_time")]
      public long CreatedTimeMillis { get; set; }

      [JsonIgnore]
      public DateTimeOffset CreatedTime
      {
         get => DateTimeOffset.MinValue;
      }
   }
}