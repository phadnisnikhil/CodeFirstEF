﻿namespace CodeFirstEF
{

    public abstract class AbsCalculator
    {
        public abstract int Add(int a, int b);
        public abstract int Subtract(int a, int b);
        public abstract int Multiply(int a, int b);
        public abstract int Divide(int a, int b);
    }

    public class Calculator : AbsCalculator
    {



        public override int Add(int a, int b)
        {
            return a + b;
        }
        public override int Subtract(int a, int b)
        {
            return a - b;
        }
        public override int Multiply(int a, int b)
        {
            return a * b;
        }
        public override int  Divide(int a, int b)
        {
            return a / b;
        }   
    }
}
