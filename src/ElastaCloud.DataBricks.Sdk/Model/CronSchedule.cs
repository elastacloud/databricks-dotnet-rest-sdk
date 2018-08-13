using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace ElastaCloud.DataBricks.Sdk.Model
{
   /// <summary>
   /// Cron schedule
   /// </summary>
   public class CronSchedule
   {
      /// <summary>
      /// A cron expression using quartz syntax that describes the schedule for a job.See Quartz for details.This field is required.
      /// </summary>
      [JsonProperty("quartz_cron_expression")]
      public string QuartzCronExpression { get; set; }

      /// <summary>
      /// A Java timezone id. The schedule for a job will be resolved with respect to this timezone. See Java TimeZone for details. This field is required.
      /// </summary>
      [JsonProperty("timezone_id")]
      public string TimezoneId { get; set; }
   }
}
