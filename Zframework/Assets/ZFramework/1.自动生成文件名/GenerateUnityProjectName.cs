using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace ZFramework
{
    public class GenerateUnityProjectName
    {
        [MenuItem("ZFramework/1.生成 UnityPackage 名字")]
        private static void MenuClicked()
        {
            Debug.Log("ZFramework_"+DateTime.Now.ToString("yyyyMMdd_HH"));
        }
    }
}

