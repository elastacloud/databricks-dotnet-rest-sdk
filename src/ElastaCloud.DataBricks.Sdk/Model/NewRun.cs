using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace ElastaCloud.DataBricks.Sdk.Model
{
   /// <summary>
   /// Description for creating a new run
   /// </summary>
   public class NewRun
   {
      /// <summary>
      /// If existing_cluster_id is set, the id of an existing cluster that will be used for all runs of this job. Please note that when running jobs on an existing cluster, you may need to manually restart the cluster if it stops responding. We suggest running jobs on new clusters for greater reliability.
      /// </summary>
      [JsonProperty("existing_cluster_id")]
      public string ExistingClusterId { get; set; }

      /// <summary>
      /// If new_cluster, a description of a cluster that will be created for each run.
      /// </summary>
      [JsonProperty("new_cluster")]
      public NewCluster NewCluster { get; set; }

      /// <summary>
      /// If notebook_task, indicates that this job should run a notebook. This field may not be specified in conjunction with spark_jar_task.
      /// </summary>
      [JsonProperty("notebook_task")]
      public NotebookTask NotebookTask { get; set; }
      
      /// <summary>
      /// An optional name for the run. The default value is Untitled.
      /// </summary>
      [JsonProperty("run_name")]
      public string Name { get; set; }

      /// <summary>
      /// An optional list of libraries to be installed on the cluster that will execute the job. The default value is an empty list.
      /// see https://docs.azuredatabricks.net/api/latest/libraries.html#managedlibrarieslibrary
      /// </summary>
      [JsonProperty("libraries")]
      public List<Dictionary<string, string>> Libraries { get; set; }

      /// <summary>
      /// An optional timeout applied to each run of this job. The default behavior is to have no timeout.
      /// </summary>
      [JsonProperty("timeout_seconds")]
      public int TimeoutSeconds { get; set; }
   }
}
