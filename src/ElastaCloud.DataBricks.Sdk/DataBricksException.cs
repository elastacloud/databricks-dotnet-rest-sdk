using System;
using System.Collections.Generic;
using System.Text;

namespace ElastaCloud.DataBricks.Sdk
{
   public class DataBricksException : Exception
   {
      public DataBricksException(string errorCode, string message) : base(message)
      {
         ErrorCode = errorCode;
      }

      public string ErrorCode { get; }
   }
}
