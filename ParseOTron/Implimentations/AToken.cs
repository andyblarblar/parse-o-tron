using System;
using System.Collections.Generic;
using System.Text;

namespace ParseOTron.Implimentations
{
    public enum AToken
    {
        Variable,  // x
        Plus,      // +
        Minus,     // -
        Multiplier,// *
        Divider,   // /
        LeftScope, // (
        RightScope,// )
        Function,  // foo()
        Exponentiator,// ^
    }

    public struct Token : Tokens.IToken<AToken>
    {
        public AToken TokenType { get; set; }

        public string RawToken { get; set; }

        public override string ToString()
        {
           return ToString();
        }


    }

}
