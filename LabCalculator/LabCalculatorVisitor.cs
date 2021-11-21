using Antlr4.Runtime.Misc;
using System;

namespace LabCalculator
{
    class LabCalculatorVisitor : LabCalculatorBaseVisitor<double>
    {
        public double x = 0.0;


        public override double VisitCompileUnit([NotNull] LabCalculatorParser.CompileUnitContext context)
        {
            return Visit(context.expression());
        }

        public override double VisitOneParameterFunctionExpr([NotNull] LabCalculatorParser.OneParameterFunctionExprContext context)
        {
            double expresionVisitResult = Visit(context.expression());

            return context.oneParameterFunctionToken.Type switch
            {
                LabCalculatorLexer.SIN => Math.Sin(expresionVisitResult),
                LabCalculatorLexer.COS => Math.Cos(expresionVisitResult),
                LabCalculatorLexer.TG => Math.Tan(expresionVisitResult),
                LabCalculatorLexer.CTG => 1.0 / Math.Tan(expresionVisitResult),
                LabCalculatorLexer.EXP => Math.Exp(expresionVisitResult),
                LabCalculatorLexer.SQRT => HandleSqrt(expresionVisitResult),
                LabCalculatorLexer.ABSFUNC => Math.Abs(expresionVisitResult),
                _ => 0.0,
            };
        }

        public override double VisitTwoParameterFunctionExpr([NotNull] LabCalculatorParser.TwoParameterFunctionExprContext context)
        {
            double left = WalkLeft(context);
            double right = WalkRight(context);

            return context.twoParameterFunctionToken.Type switch
            {
                LabCalculatorLexer.POWFUNC => Math.Pow(left, right),
                _ => 0.0,
            };
        }
        public override double VisitParenthesizedExpr([NotNull] LabCalculatorParser.ParenthesizedExprContext context)
        {
            double expresionVisitResult = Visit(context.expression());

            return expresionVisitResult;
        }

        public override double VisitAbsoluteExpr([NotNull] LabCalculatorParser.AbsoluteExprContext context)
        {
            double expresionVisitResult = Visit(context.expression());

            return Math.Abs(expresionVisitResult);
        }

        public override double VisitExponentialExpr([NotNull] LabCalculatorParser.ExponentialExprContext context)
        {
            double left = WalkLeft(context);
            double right = WalkRight(context);

            return Math.Pow(left, right);
        }


        public override double VisitMultiplicativeExpr([NotNull] LabCalculatorParser.MultiplicativeExprContext context)
        {
            double left = WalkLeft(context);
            double right = WalkRight(context);

            return context.operatorToken.Type switch
            {
                LabCalculatorLexer.MULTIPLY => left * right,
                LabCalculatorLexer.DIVIDE => HandleDivide(left, right),
                _ => 0.0,
            };
        }

        public override double VisitAdditiveExpr([NotNull] LabCalculatorParser.AdditiveExprContext context)
        {
            double left = WalkLeft(context);
            double right = WalkRight(context);

            return context.operatorToken.Type switch
            {
                LabCalculatorLexer.ADD => left + right,
                LabCalculatorLexer.SUBTRACT => left - right,
                _ => 0.0,
            };
        }

        public override double VisitUnarySignExpr([NotNull] LabCalculatorParser.UnarySignExprContext context)
        {
            double expresionVisitResult = Visit(context.expression());

            return context.operatorToken.Type switch
            {
                LabCalculatorLexer.ADD => expresionVisitResult,
                LabCalculatorLexer.SUBTRACT => -expresionVisitResult,
                _ => 0.0,
            };
        }

        public override double VisitConstantExpr([NotNull] LabCalculatorParser.ConstantExprContext context)
        {
            return context.constantToken.Type switch
            {
                LabCalculatorLexer.E => Math.E,
                LabCalculatorLexer.PI => Math.PI,
                _ => 0.0,
            };
        }


        public override double VisitNumberExpr([NotNull] LabCalculatorParser.NumberExprContext context)
        {
            double result = double.Parse(context.GetText());

            return result;
        }

        public override double VisitIdentifierExpr([NotNull] LabCalculatorParser.IdentifierExprContext context)
        {
            return x;
        }

        private double WalkLeft([NotNull] LabCalculatorParser.ExpressionContext context)
        {
            return Visit(context.GetRuleContext<LabCalculatorParser.ExpressionContext>(0));
        }

        private double WalkRight([NotNull] LabCalculatorParser.ExpressionContext context)
        {
            return Visit(context.GetRuleContext<LabCalculatorParser.ExpressionContext>(1));
        }

        private double HandleSqrt(double value)
        {
            if (value < 0)
            {
                throw new ArgumentException("Sqrt from negative number");
            }
            else
            {
                return Math.Sqrt(value);
            }
        }

        private double HandleDivide(double devidend, double divisor)
        {
            if (Math.Abs(divisor) < double.Epsilon)
            {
                throw new ArgumentException("Divide by zero exception");
            }
            else
            {
                return devidend / divisor;
            }
        }
    }
}
