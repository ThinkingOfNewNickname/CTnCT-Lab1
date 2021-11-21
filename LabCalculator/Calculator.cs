using Antlr4.Runtime;
using System;

namespace LabCalculator
{
    public static class Calculator
    {
        public static bool Evaluate(string expression, double x, out double result, out string errorMessage)
        {
            try
            {
                LabCalculatorLexer lexer = new(new AntlrInputStream(expression));

                lexer.RemoveErrorListeners();
                lexer.AddErrorListener(new ThrowExceptionErrorListener());

                CommonTokenStream tokens = new(lexer);
                LabCalculatorParser parser = new(tokens);

                parser.RemoveErrorListeners();
                parser.AddErrorListener(new ThrowExceptionErrorListener());

                LabCalculatorParser.CompileUnitContext tree = parser.compileUnit();
                LabCalculatorVisitor visitor = new();

                visitor.x = x;

                result = visitor.Visit(tree);
                errorMessage = "";

                return true;
            }
            catch (Exception e)
            {
                result = 0.0;
                errorMessage = e.Message;

                return false;
            }
        }
    }
}
