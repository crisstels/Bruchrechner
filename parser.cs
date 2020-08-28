using System;

namespace Bruchrechner
{
    partial class Main{

        public bool check_integer(int zahl){


            Type check = zahl.GetType();

            return check.Equals(typeof(int));

        }

    }
}