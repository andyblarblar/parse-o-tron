using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using ParseOTron.FrontEnd;
using ParseOTron.Tokens;

namespace ParseOTron.Implimentations
{
    public class AlgebraicExpression : Expression<Token, LambdaExpression>
    {
        protected override bool IsOperator(IToken<Token> token)
        {
            throw new NotImplementedException();
        }

        protected override LambdaExpression Parse(List<IToken<Token>> tokens)
        {
            throw new NotImplementedException();
        }

        protected override int Precedence(IToken<Token> token)
        {
            throw new NotImplementedException();
        }

        protected override List<IToken<Token>> Tokenize()
        {
            throw new NotImplementedException();
        }

        public AlgebraicExpression(string expr) : base(expr)
        {
        }

    }
}
