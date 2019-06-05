using UnityEditor;
using UnityEngine;

namespace ZFramework
{
    public class CopyText2Clipboard : MonoBehaviour
    {
        #if UNITY_EDITOR
            [MenuItem("ZFramework/0.复制文本到剪切板")]
        #endif
        private static void MenuClicked()
        {
            GUIUtility.systemCopyBuffer = "复制的文本";
        }
    }
}
