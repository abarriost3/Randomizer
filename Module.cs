using System;
using System.Collections.Generic;
using System.Text;

namespace Randomizer
{
    public interface Module
    {
        /// <summary>
        /// Gets the name of that module
        /// </summary>
        /// <returns>string</returns>
        string getModuleName();

        /// <summary>
        /// Gets the description of what the module does
        /// </summary>
        /// <returns>string</returns>
        string getModuleDescription();
    }
}
