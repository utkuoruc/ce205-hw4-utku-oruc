/**
  * @file Util.cs
  * @author Utku ORUC
  * @date 20 November 2021
  *
  *
  */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CE205_HW3
{
    public class Util
    {
        /**
		*
			@name  GetNodeLetter
			@brief \b Copy string
			convert int value + 65 to string
            for example, 0 is A. and so forth
		**/
        public static string GetNodeLetter(int index)
        {
            return Convert.ToChar(65 + index).ToString();
        }
    }
}