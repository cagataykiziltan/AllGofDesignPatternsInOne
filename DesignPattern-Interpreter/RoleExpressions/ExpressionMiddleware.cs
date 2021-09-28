using System;
using System.Collections.Generic;

namespace InterpreterPattern.RoleExpressions
{
    public static class ExpressionMiddleware
    {
       public static List<RoleExpression> CreateExpressionTree(string formula)
        {
        
            var tree = new List<RoleExpression>();

            foreach (char role in formula)
            {
                if (role == 'A')
                    tree.Add(new ArchitectureExpression());
                else if (role == 'S')
                    tree.Add(new SeniorExpression());
                else if (role == 'D')
                    tree.Add(new DeveloperExpression());
                else if (role == 'C')
                    tree.Add(new ConsultantExpression());
            }
            return tree;
        }

        public static void RunExpression(Context context)
        {
            var expressionTree = CreateExpressionTree(context.Formula);

            foreach (RoleExpression expression in expressionTree)
            {
                expression.Interpret(context);
            }
          
            Console.WriteLine("Cost points for {0} {1}", context.Formula, context.TotalPoint);
        }
    }
}
