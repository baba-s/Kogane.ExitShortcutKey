#if UNITY_EDITOR_WIN

using UnityEditor;
using UnityEditor.ShortcutManagement;
using UnityEngine;

namespace Kogane.Internal
{
    internal static class ExitShortcutKey
    {
        [Shortcut( "Kogane/Exit", KeyCode.Q, ShortcutModifiers.Action )]
        private static void Exit()
        {
            EditorApplication.Exit( 0 );
        }
    }
}

#endif