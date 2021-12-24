/****************************************************************************
 * Copyleft (L) 2021 CENG - All Rights Not Reserved
 * You may use, distribute and modify this code.
 ****************************************************************************/

/**
 * @file Util.cs
 * @author Utku Oruc
 * @date 21 December 2021
 *
 * @brief <b> Util.cs </b>
 *
 * HW-4 Sample Lib Functions
 *
 * @see http://bilgisayar.mmf.erdogan.edu.tr/en/
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