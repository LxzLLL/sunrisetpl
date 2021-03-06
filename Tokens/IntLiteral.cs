﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Igs.Hcms.Volt.Tokens
{
    internal class IntLiteral : Expression {
        private int _value;

        public IntLiteral(int line , int col , int value) : base(TokenKind.Integer , line , col)
        {
            _value = value;
        }

        public int Value { get { return _value; } }

    }
}
