using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace YOT
{
    public class AssemblyLoader
    {
        private Assembly assembly;

        /// <summary>
        /// Charge la dll passé en paramètre
        /// </summary>
        /// <param name="pathAssembly">Chemin de la DLL</param>
        /// <returns></returns>
        public bool loadAssembly(string pathAssembly) {
            try {
                if (string.IsNullOrEmpty(pathAssembly)) {
                    Console.WriteLine("Please enter a library path.");
                    return false;
                }
                if (!File.Exists(pathAssembly)) {
                    Console.WriteLine("This file doesn't exist. Please check your path.");
                    return false;
                }

                assembly = Assembly.LoadFrom(pathAssembly);
                return true;
            }
            catch (Exception exp) {
                Console.WriteLine("An error occured while loading assembly. \n Message : {0}", exp.Message);
                return false;
            }
        }

    }
}
