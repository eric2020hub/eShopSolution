using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Utilities.Exceptions
{
    public class EShopException : Exception
    {
        public EShopException()
        {

        }
        public EShopException(string massage) : base(massage)
        {

        }

        public EShopException(string massage, Exception inner) : base(massage, inner)
        {

        }
    }
}
