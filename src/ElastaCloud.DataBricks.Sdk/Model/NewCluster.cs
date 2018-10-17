using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace ElastaCloud.DataBricks.Sdk.Model
{
   /// <summary>
   /// Describes a new cluster
   /// </summary>
   public class NewCluster
   {
      /// <summary>
      /// If num_workers, number of worker nodes that this cluster should have. A cluster has one Spark Driver and num_workers Executors for a total of num_workers + 1 Spark nodes.
      /// </summary>
      /// <remarks>
      /// When reading the properties of a cluster, this field reflects the desired number of workers rather than the actual current number of workers.For instance, if a cluster is resized from 5 to 10 workers, this field will immediately be updated to reflect the target size of 10 workers, whereas the workers listed in spark_info will gradually increase from 5 to 10 as the new nodes are provisioned.
      /// </remarks>
      [JsonProperty("num_workers")]
      public int NumWorkers { get; set; }

      /// <summary>
      /// The Spark version of the cluster. A list of available Spark versions can be retrieved by using the Spark Versions API call. This field is required.
      /// </summary>
      [JsonProperty("spark_version")]
      public string SparkVersion { get; set; }

      /// <summary>
      /// This field encodes, through a single value, the resources available to each of the Spark nodes in this cluster. For example, the Spark nodes can be provisioned and optimized for memory or compute intensive workloads A list of available node types can be retrieved by using the List Node Types API call. This field is required.
      /// </summary>
      [JsonProperty("node_type_id")]
      public string NodeTypeId { get; set; }

      /// <summary>
      /// this field reflects the desired number of workers rather than the actual current number of workers. For instance, if a cluster is resized from 5 to 10 workers, this field will immediately be updated to reflect the target size of 10 workers, whereas the workers listed in spark_info will gradually increase from 5 to 10 as the new nodes are provisioned.
      /// </summary>
      [JsonProperty("autoscale")]
      public Autoscale Autoscale { get; set; }
   }
}
