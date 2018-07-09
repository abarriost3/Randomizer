using System;
using System.Collections.Generic;
using System.Text;

namespace Randomizer
{
    public abstract class ModuleTemplate : Module
    {
        /// <summary>
        /// Name of the module and how it will be called
        /// </summary>
        protected string name = "";

        /// <summary>
        /// Description about that module
        /// </summary>
        protected string description = "";

        public string getModuleName()
        {
            return name;
        }

        public string getModuleDescription()
        {
            return description;
        }
    }
}
