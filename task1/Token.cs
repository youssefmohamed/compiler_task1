﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    public enum TokenType
    {
        EndFile, Error,
        If, Then, Else, End, Repeat, Until, Read, Write, //Reserved Words
        ID, Num, Comment, //multicharacher tokens
        Assign, Equal, LessThan, Plus, Minus, Times, LeftParentheses, RightParentheses, SemiColon, Symbol //special symbols
    }

    public struct Token
    {
        public TokenType tokenType;
        public string name;
    }

    public struct Error 
    {
        public string desc;
        public int lineNumber;
    }

    public struct Comment 
    {
        public int lineNumber;
        public string comment;
    }

    public struct Symbol
    {
        public int lineNumber;
        public string symbol;
    }

    public struct State
    {
        public int val; 
        public bool isStart;
        public bool isFinal;
        public bool isError;
    }

    public struct Transition 
    {
        public int currState;
        public int nextState;
        public char val;
    }

}
