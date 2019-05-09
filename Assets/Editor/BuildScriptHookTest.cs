using System.Collections;
using System.Collections.Generic;
using UnityEditor.AddressableAssets.Build;
using UnityEngine;
using UnityEditor;

public class BuildscriptHookTest
{
    [MenuItem("Blah/Blah")]
    static void NewMenuOption()
    {
        BuildScript.buildCompleted += OnBuildComplete;
    }

    static void OnBuildComplete(object result)
    {
        Debug.Log("BuildScript Complete");
        
//        var filePaths = result.FileRegistry.GetFilePaths();
//        foreach (var path in filePaths)
//        {
//            Debug.Log(path);
//        }
    }
}
