using Antlr4.Runtime;
using Antlr4.Runtime.Misc;
using System;

namespace LabCalculator
{
    class ThrowExceptionErrorListener : BaseErrorListener, IAntlrErrorListener<int>
    {
        public override void SyntaxError([NotNull] IRecognizer recognizer, [Nullable] IToken offendingSymbol, int line, int charPositionInLine, [NotNull] string msg, [Nullable] RecognitionException e)
        {
            throw new Exception(string.Format("[Line: {0}, Char Position In Line: {1}] " + msg, line, charPositionInLine), e);
        }

        public void SyntaxError([NotNull] IRecognizer recognizer, [Nullable] int offendingSymbol, int line, int charPositionInLine, [NotNull] string msg, [Nullable] RecognitionException e)
        {
            throw new Exception(string.Format("[Line: {0}, Char Position In Line: {1}] " + msg, line, charPositionInLine), e);
        }
    }
}
