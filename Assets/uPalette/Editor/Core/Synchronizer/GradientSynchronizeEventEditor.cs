using UnityEditor;
using UnityEngine;
using uPalette.Runtime.Core.Synchronizer.CharacterStyleLocalizedTMP;

namespace uPalette.Editor.Core.Synchronizer
{
    [CustomEditor(typeof(CharacterStyleLocalizedTMPSynchronizeEvent), true)]
    public sealed class GradientSynchronizeEventEditor : ValueSynchronizeEventEditor<Gradient>
    {
    }
}
