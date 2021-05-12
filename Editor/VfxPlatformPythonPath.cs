using System;
using System.IO;
using UnityEditor;
using UnityEditor.Scripting.Python;
using UnityEngine;

namespace Editor
{
    [InitializeOnLoad]
    public class VfxPlatformPythonPath 
    {
        static VfxPlatformPythonPath()
        {
            String pythonPath = Path
                .GetFullPath("Packages/com.cpredmann.python.vfxplatform/lib~/python3.7/site-packages")
                .Replace(@"\", @"/");
            PythonRunner.RunString($"import sys\nif '{pythonPath}' not in sys.path:\n\tsys.path.append('{pythonPath}')");
        }
    }
}
