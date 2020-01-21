using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEditor.AddressableAssets.Build;
using UnityEditor.AddressableAssets.Settings;
using UnityEngine;

public class FileRegistryTest : MonoBehaviour
{
    [MenuItem("Assets/Test File Registry")]
    public static void ToggleSimulationMode()
    {
        Debug.Log("Hey");

        BuildScript.buildCompleted += result =>
        {
            foreach (var path in result.FileRegistry.GetFilePaths())
            {
                Debug.Log(path);
            }
        };
        
        AddressableAssetSettings.BuildPlayerContent();
    }
}
