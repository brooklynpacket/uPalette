using UnityEditor.IMGUI.Controls;
using UnityEngine;
using uPalette.Editor.Foundation.CharacterStyles;
using uPalette.Runtime.Foundation.CharacterStyles;

namespace uPalette.Editor.Core.PaletteEditor
{
    internal sealed class CharacterStyleLocalizedTMPPaletteEditorTreeView : PaletteEditorTreeView<CharacterStyleLocalizedTMP>
    {
        public CharacterStyleLocalizedTMPPaletteEditorTreeView(TreeViewState state) : base(state)
        {
        }

        protected override CharacterStyleLocalizedTMP DrawValueField(Rect rect, CharacterStyleLocalizedTMP value)
        {
            return CharacterStyleLocalizedTMPEditorGUILayout.DrawField(rect, value);
        }
    }
}
