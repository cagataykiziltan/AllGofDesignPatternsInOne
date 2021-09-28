namespace InterpreterPattern.RoleExpressions
{
    public class ArchitectureExpression : RoleExpression
    {
        public override void Interpret(Context context)
        {
            if (context.Formula.Contains("A"))
            {
                context.TotalPoint += 5;
            }
        }
    }

    //TerminalExpression
    public class ConsultantExpression : RoleExpression
    {
        public override void Interpret(Context context)
        {
            if (context.Formula.Contains("C"))
                context.TotalPoint += 10;
        }
    }

    // TerminalExpression
    public class SeniorExpression : RoleExpression
    {
        public override void Interpret(Context context)
        {
            if (context.Formula.Contains("S"))
                context.TotalPoint += 15;
        }
    }

   //TerminalExpression
   public class DeveloperExpression : RoleExpression
    {
        public override void Interpret(Context context)
        {
            if (context.Formula.Contains("D"))
                context.TotalPoint += 20;
        }
    }
}
