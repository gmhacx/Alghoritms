﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HaffmanCode
{
    class Node
    {
       
        public char? Symbol { get; set; }     
        public int Frequency { get; set; }
        public Node Right { get; set; }
        public Node Left { get; set; }
        public bool IsLeaf => Left == null && Right == null;

        public List<bool> Traverse(char symbol, List<bool> data)
        {
            if (Right == null && Left == null)
            {
                return symbol.Equals(Symbol) ? data : null;
            }
           
            List<bool> left = null;
            List<bool> right = null;
            if (Left != null)
            {
                var leftPath = new List<bool>(data) {false};
            
                left = Left.Traverse(symbol, leftPath);
            }
            if (Right != null)
            {
                var rightPath = new List<bool>(data) {true};

                right = Right.Traverse(symbol, rightPath);
            }
            return left ?? right;
        }
    }
}
