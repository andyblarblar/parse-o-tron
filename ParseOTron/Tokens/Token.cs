using System;
using System.Collections.Generic;
using System.Text;

namespace ParseOTron.Tokens
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T">The internal token type</typeparam>
    public interface IToken<T>
    {
        public T TokenType { get; set; }

        public string RawToken { get; set; }

        public string ToString()
        {
            return RawToken ?? "";
        }

    }
}
