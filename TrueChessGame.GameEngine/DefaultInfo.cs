﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrueChessGame
{
    public static class DefaultInfo
    {
        public static bool WhiteAsideRookIsUnMoved;

        public static bool WhiteHsideRookIsUnMoved;

        public static bool WhiteKingIsUnMoved;

        public static bool BlackAsideRookIsUnMoved;

        public static bool BlackHsideRookIsUnMoved;

        public static bool BlackKingIsUnMoved;

        public static int MovesWithoutPawnOrCapture;

        public static Square EnPassantPossibleCapture;

        public static bool WhiteEnPassantEndangered;

        public static bool BlackEnPassantEndangered;

        public static List<ChessBoard> GamePositions;

        //static DefaultInfo()
        //{
        //    WhiteAsideRookIsUnMoved = true;
        //    WhiteHsideRookIsUnMoved = true;
        //    BlackAsideRookIsUnMoved = true;
        //    BlackHsideRookIsUnMoved = true;
        //    WhiteKingIsUnMoved = true;
        //    BlackKingIsUnMoved = true;
        //    MovesWithoutPawnOrCapture = 0;
        //    EnPassantPossibleCapture = new Square();
        //    WhiteEnPassantEndangered = false;
        //    BlackEnPassantEndangered = false;
        //    GamePositions = new List<ChessBoard>();
        //}

        public static void SetDefaultValues()
        {
            WhiteAsideRookIsUnMoved = true;
            WhiteHsideRookIsUnMoved = true;
            BlackAsideRookIsUnMoved = true;
            BlackHsideRookIsUnMoved = true;
            WhiteKingIsUnMoved = true;
            BlackKingIsUnMoved = true;
            MovesWithoutPawnOrCapture = 0;
            EnPassantPossibleCapture = new Square();
            WhiteEnPassantEndangered = false;
            BlackEnPassantEndangered = false;
            GamePositions = new List<ChessBoard>();
        }
    }
}