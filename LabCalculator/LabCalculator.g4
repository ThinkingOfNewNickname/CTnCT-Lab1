grammar LabCalculator;

/*
* Parser Rules
*/

compileUnit: expression EOF;

expression:
	oneParameterFunctionToken = (SIN | COS | TG | CTG | EXP | SQRT | ABSFUNC) LPAREN expression RPAREN #OneParameterFunctionExpr
	| twoParameterFunctionToken = POWFUNC LPAREN expression COMMA expression RPAREN #TwoParameterFunctionExpr
	| LPAREN expression RPAREN #ParenthesizedExpr
	| ABSPAREN expression ABSPAREN #AbsoluteExpr
	| expression POWEXPR expression #ExponentialExpr
	| expression operatorToken = (MULTIPLY | DIVIDE) expression #MultiplicativeExpr
	| expression operatorToken = (ADD | SUBTRACT) expression #AdditiveExpr
	| operatorToken = (ADD | SUBTRACT) expression #UnarySignExpr
	| constantToken = (E | PI) #ConstantExpr
	| NUMBER #NumberExpr
	| IDENTIFIER #IdentifierExpr
	;

/*
* Lexer Rules
*/

POWEXPR: '^';

MULTIPLY: '*';
DIVIDE: '/';

SUBTRACT: '-';
ADD: '+';


SIN: 'sin';
COS: 'cos';
TG: 'tg';
CTG: 'ctg';

EXP: 'exp';
POWFUNC: 'pow';
SQRT: 'sqrt';

ABSFUNC: 'abs';


E: 'E';
PI: 'PI';

LPAREN: '(';
RPAREN: ')';

COMMA: ',';

ABSPAREN: '|';


NUMBER: INT('.' INT) ?;
IDENTIFIER: 'x';

INT: ('0'..'9') +;

WS:[ \t\r\n] ->channel(HIDDEN);
