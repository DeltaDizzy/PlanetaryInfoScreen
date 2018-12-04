using KSP.IO;
using System;
using System.Runtime.InteropServices;
using UnityEngine;
using Object = System.Object;

namespace PlanetaryInfoScreen
{
    public class PrintFile : MonoBehaviour
    {
        public static string PrintDir
        {
            get
            {
                return KSPUtil.ApplicationRootPath + "PluginData/" + typeof(PrintFile).Assembly.GetName().Name + "/";
            }
        }

        //full path
        TextWriter printStream = null;

        //print
        public void Write(Object o)
        {
            if (printStream == null)
                return;

            printStream.WriteLine("Information About" + InfoBody.bodyName);
            printStream.WriteLine("======================================");
            printStream.WriteLine("");
        }

        public PrintFile([Optional] string fileName)
        {
            SetFilename(fileName);
        }

        public void SetFilename(string fileName)
        {

        }
    }
}
