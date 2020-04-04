using System;
using System.Collections.Generic;
using System.Text;
using ParseOTron.Tokens;

namespace ParseOTron.FrontEnd
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="TI">The Expression tree you are parsing to</typeparam>
    /// <typeparam name="TT">The Token type you are using</typeparam>
    public abstract class Expression<TT,TI>
    {

        /// <summary>
        /// The internal expression tree
        /// </summary>
        public TI InternalExpression { get; set; }

        /// <summary>
        /// The last Tokens in post fix form
        /// </summary>
        public List<IToken<TT>> Tokens { get; set; }

        public string OriginalExpression { get; }


        protected Expression(string expr)
        {
            OriginalExpression = expr;
            Construct(expr);
        }

        protected virtual void Construct(string expr)
        {
            Tokens = Tokenize();
            InternalExpression = Parse(Tokens);
        }

        protected abstract List<IToken<TT>> Tokenize();

        protected abstract TI Parse(List<IToken<TT>> tokens);

        protected abstract int Precedence(IToken<TT> token);

        protected abstract bool IsOperator(IToken<TT> token);






    }
}
