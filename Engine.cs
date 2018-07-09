using System;
using System.Collections.Generic;
using System.Text;

namespace Randomizer
{
    public interface Engine
    {
        /// <summary>
        /// Returns the amount of diferent modules the Engine has
        /// </summary>
        /// <returns>int</returns>
        int moduleCount();

        /// <summary>
        /// Returns all the names of the modules in a string format
        /// </summary>
        /// <returns></returns>
        string moduleList();

        /// <summary>
        /// Returns a string to show how to use the program
        /// and its commands
        /// </summary>
        /// <returns></returns>
        string help();

        /// <summary>
        /// Main loop of the engine
        /// </summary>
        void mainLoop();
        
    }
}
