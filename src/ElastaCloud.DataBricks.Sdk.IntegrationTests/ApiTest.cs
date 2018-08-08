using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ElastaCloud.DataBricks.Sdk.IntegrationTests
{
   public class ApiTest
   {
      private DataBricksRestClient _restClient;

      protected DataBricksRestClient Client
      {
         get
         {
            if(_restClient == null)
            {
               _restClient = new DataBricksRestClient("https://northeurope.azuredatabricks.net", File.ReadAllText("c:\\tmp\\dbt.txt"));
            }

            return _restClient;
         }
      }
   }
}