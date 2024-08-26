#if UNITY_IOS
using UnityEngine;
using UnityEditor;
using UnityEditor.Callbacks;
using UnityEditor.iOS.Xcode;
using System.Diagnostics;
using System;
using System.Linq;
using System.IO;

namespace OpenCVForUnity.Editor
{
    public class OpenCVForUnityIOSBuildPostprocessor : MonoBehaviour
    {

        [PostProcessBuild]
        public static void OnPostprocessBuild(BuildTarget buildTarget, string path)
        {
            if (buildTarget == BuildTarget.iOS)
            {
                string opencvFrameworkPath = Directory.GetDirectories(path, "opencv2.framework", SearchOption.AllDirectories).FirstOrDefault();
                if (string.IsNullOrEmpty(opencvFrameworkPath))
                    throw new System.Exception("Can't find opencv2.framework");

                string opencvLibraryPath = Directory.GetFiles(path, "libopencvforunity.a", SearchOption.AllDirectories).FirstOrDefault();
                if (string.IsNullOrEmpty(opencvLibraryPath))
                    throw new System.Exception("Can't find libopencvforunity.a");

                //Remove the architecture for the simulator.
                if (PlayerSettings.iOS.sdkVersion == iOSSdkVersion.DeviceSDK)
                {
#if UNITY_EDITOR_OSX
                    RemoveSimulatorArchitectures(Path.GetDirectoryName(opencvFrameworkPath), "opencv2.framework/opencv2");
                    RemoveSimulatorArchitectures(Path.GetDirectoryName(opencvLibraryPath), "libopencvforunity.a");
#else
                    UnityEngine.Debug.LogError("The RemoveSimulatorArchitectures() method fails when outputting an Xcode project in UnityEditor on non-macOS.\nBefore outputting the Xcode project, please execute the following command on macOS.\n\n//remove x86_64 architectures.\nlipo - remove x86_64 opencv2.framework / opencv2 - o opencv2.framework / opencv2\n//check the architectures.\nlipo - info opencv2.framework / opencv2\n\n//remove x86_64 architectures.\nlipo - remove x86_64 libopencvforunity.a - o libopencvforunity.a\n//check the architectures.\nlipo - info libopencvforunity.a\n");
#endif
                }

                //Set opencv2.framework to Embedded Binaries.
                string projPath = PBXProject.GetPBXProjectPath(path);

                PBXProject proj = new PBXProject();
                proj.ReadFromString(System.IO.File.ReadAllText(projPath));

                string target = proj.GetUnityFrameworkTargetGuid();

                File.WriteAllText(projPath, proj.WriteToString());

                //Check if the Target minimum iOS Version is set to 11.0 or higher.
                if ((int)Convert.ToDecimal(PlayerSettings.iOS.targetOSVersionString) < 11)
                {
                    UnityEngine.Debug.LogError("Please set Target minimum iOS Version to 11.0 or higher.");
                }
            }
        }

        /// <summary>
        /// Removes the simulator architectures.
        /// </summary>
        /// <param name="workingDirectory">Working directory.</param>
        /// <param name="filePath">File path.</param>
        private static void RemoveSimulatorArchitectures(string workingDirectory, string filePath)
        {
            if (!IsSimulatorArchitectures(workingDirectory, filePath)) return;

            Process process = new Process();
            process.StartInfo.FileName = "/bin/bash";
            process.StartInfo.WorkingDirectory = workingDirectory;

            process.StartInfo.Arguments = "-c \" ";

            process.StartInfo.Arguments += "lipo -remove x86_64 " + filePath + " -o " + filePath + ";";
            process.StartInfo.Arguments += "lipo -info " + filePath + ";";

            process.StartInfo.Arguments += " \"";

            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.RedirectStandardError = true;

            process.Start();

            string output = process.StandardOutput.ReadToEnd();
            string error = process.StandardError.ReadToEnd();

            process.WaitForExit();
            process.Close();

            if (string.IsNullOrEmpty(error))
            {
                UnityEngine.Debug.Log("Success RemoveSimulatorArchitectures() : " + output);
            }
            else
            {
                UnityEngine.Debug.LogError("Error RemoveSimulatorArchitectures() : " + error);
            }
        }

        /// <summary>
        /// Whether the file contains the simulator architectures?
        /// </summary>
        /// <param name="workingDirectory">Working directory.</param>
        /// <param name="filePath">File path.</param>
        private static bool IsSimulatorArchitectures(string workingDirectory, string filePath)
        {
            Process process = new Process();
            process.StartInfo.FileName = "/bin/bash";
            process.StartInfo.WorkingDirectory = workingDirectory;

            process.StartInfo.Arguments = "-c \" ";

            process.StartInfo.Arguments += "lipo -archs " + filePath + ";";

            process.StartInfo.Arguments += " \"";

            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.RedirectStandardError = true;

            process.Start();

            string output = process.StandardOutput.ReadToEnd();
            string error = process.StandardError.ReadToEnd();

            process.WaitForExit();
            process.Close();

            //if (string.IsNullOrEmpty(error))
            //{
            //    UnityEngine.Debug.Log("Success IsSimulatorArchitectures() : " + output);                
            //}
            //else
            //{
            //    UnityEngine.Debug.LogError("Error IsSimulatorArchitectures() : " + error);
            //    return false;
            //}

            return output.Contains("x86_64");
        }
    }
}
#endif
