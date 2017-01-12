/*

   Copyright 2017 Esri

   Licensed under the Apache License, Version 2.0 (the "License");
   you may not use this file except in compliance with the License.
   You may obtain a copy of the License at

       http://www.apache.org/licenses/LICENSE-2.0

   Unless required by applicable law or agreed to in writing, software
   distributed under the License is distributed on an "AS IS" BASIS,
   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.

   See the License for the specific language governing permissions and
   limitations under the License.

*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivingAtlasOfTheWorld.Common {
    /// <summary>
    /// Class represents extensions to the System.string class
    /// </summary>
    public static class StringExtensions {
        /// <summary>
        /// Returns whether the string is empty
        /// </summary>
        /// <param name="theString"></param>
        /// <returns>True if the string is empty</returns>
        public static bool IsEmpty(this string theString) {
            return (theString == null || theString.Length == 0);
        }
    }
}
