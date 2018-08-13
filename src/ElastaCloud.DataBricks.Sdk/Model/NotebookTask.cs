using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace ElastaCloud.DataBricks.Sdk.Model
{
   /// <summary>
   /// Notebook task
   /// </summary>
   public class NotebookTask
   {
      /// <summary>
      /// The absolute path of the notebook to be run in the Databricks Workspace. This path must begin with a slash. Relative paths will be supported in the future. This field is required.
      /// </summary>
      [JsonProperty("notebook_path")]
      public string Path { get; set; }

      /// <summary>
      /// Base parameters to be used for each run of this job. If the run is initiated by a call to run-now with parameters specified, the two parameters maps will be merged. If the same key is specified in base_parameters and in run-now, the value from run-now will be used.
      /// If the notebook takes a parameter that is not specified in the job’s base_parameters or the run-now override parameters, the default value from the notebook will be used.
      /// These parameters can be retrieved in a notebook by using dbutils.widgets.get().
      /// </summary>
      [JsonProperty("base_parameters")]
      public ParamPair[] Parameters { get; set; }
   }
}