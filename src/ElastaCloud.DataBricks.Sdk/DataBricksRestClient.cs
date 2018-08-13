using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Refit;

namespace ElastaCloud.DataBricks.Sdk
{
   /// <summary>
   /// Public REST client
   /// </summary>
   public class DataBricksRestClient
   {
      private IDatabricksEndpoint _endpoint;

      /// <summary>
      /// Jobs API
      /// </summary>
      public DataBricksJobsRestClient Jobs { get; }

      /// <summary>
      /// Creates an instance
      /// </summary>
      public DataBricksRestClient(string baseUri, string authToken)
      {
         if (baseUri == null)
         {
            throw new ArgumentNullException(nameof(baseUri));
         }

         if (authToken == null)
         {
            throw new ArgumentNullException(nameof(authToken));
         }

         _endpoint = RestService.For<IDatabricksEndpoint>(
            new HttpClient(new AuthenticatedHttpClientHandler(authToken))
            {
               BaseAddress = new Uri(baseUri)
            },
            new RefitSettings
            {
               JsonSerializerSettings = new JsonSerializerSettings
               {
                  Converters = { new StringEnumConverter() },
                  NullValueHandling = NullValueHandling.Ignore
               }
            });

         Jobs = new DataBricksJobsRestClient(_endpoint);
      }

      private class AuthenticatedHttpClientHandler : HttpClientHandler
      {
         private readonly string _token;

         public AuthenticatedHttpClientHandler(string token)
         {
            _token = token;
         }

         protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
         {
            request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", _token);

            return await base.SendAsync(request, cancellationToken);
         }
      }
   }
}