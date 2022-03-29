using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace MathsLibrary
{
    public class MathsOperations : IMathsOperations
    {
        //Implementation des methodes de MathsOperations
        public int add(int a, int b)
        {
            return a + b;
        }

        public int multiply(int a, int b)
        {
            return (a * b);
        }

        public int substract(int a, int b)
        {
            return a - b;
        }



    }
}
