using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Amazon.Lambda.Core;
using LambdaAOP.Service;
using PostSharp.Patterns.Diagnostics;

// Assembly attribute to enable the Lambda function's JSON input to be converted into a .NET class.
[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.SystemTextJson.DefaultLambdaJsonSerializer))]

namespace LambdaAOP
{
    public class Function
    {
        
        public string FunctionHandler(string input, ILambdaContext context)
        {
            LoggingServices.DefaultBackend = new PostSharp.Patterns.Diagnostics.Backends.Console.ConsoleLoggingBackend();

            return new FinancialService().ObterCodigoBanco()?.ToUpper();
        }
    }
}
