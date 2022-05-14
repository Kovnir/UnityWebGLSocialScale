using UnityEditor.Build;
using UnityEditor.Build.Reporting;

//https://forum.unity.com/threads/case-1412113-builderror-osx-12-3-and-unity-2020-3-constant-build-errors.1255419/
public class MacOsBuildRepairStep : IPreprocessBuildWithReport
{
    public int callbackOrder => 1;
 
    public void OnPreprocessBuild(BuildReport report)
    {
        System.Environment.SetEnvironmentVariable("EMSDK_PYTHON", "/Library/Frameworks/Python.framework/Versions/2.7/bin/python");
    }
}