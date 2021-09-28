using InterpreterPattern.RoleExpressions;
using System;


namespace InterpreterPattern
{
 
    // Client
    class Program
    {    
        static void Main(string[] args)
        {
            Console.WriteLine("Architecture = 5, Consultant=10, Senior=15,Developer=20\n");
          
            Context context = new Context { Formula = "ACSSDDDD" };
            ExpressionMiddleware.RunExpression(context);

            context = new Context { Formula = "CSDD" };
            ExpressionMiddleware.RunExpression(context);
     
            context = new Context { Formula = "SD" };
            ExpressionMiddleware.RunExpression(context);
        }
    }
}
