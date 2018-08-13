using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace ElastaCloud.DataBricks.Sdk.Model
{
   /// <summary>
   /// Key-value pair
   /// </summary>
   public class ParamPair
   {
      public ParamPair()
      {

      }

      public ParamPair(string key, string value)
      {
         this.Key = key;
         this.Value = value;
      }

      /// <summary>
      /// Named parameter, can be passed to dbutils.widgets.get() to retrieve the corresponding value.
      /// </summary>
      [JsonProperty("key")]
      public string Key { get; set; }

      /// <summary>
      /// Value of named parameter, returned by calls to dbutils.widgets.get() in notebooks.
      /// </summary>
      [JsonProperty("value")]
      public string Value { get; set; }
   }
}