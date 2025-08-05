using System;
using UnityEditor.IMGUI.Controls;
using uPalette.Runtime.Foundation.CharacterStyles;

namespace uPalette.Editor.Core.PaletteEditor
{
    [Serializable]
    internal sealed class CharacterStyleLocalizedTMPPaletteEditorWindowContentsView
        : PaletteEditorWindowContentsView<CharacterStyleLocalizedTMP>
    {
        protected override PaletteEditorTreeView<CharacterStyleLocalizedTMP> CreateTreeView(TreeViewState state)
        {
            return new CharacterStyleLocalizedTMPPaletteEditorTreeView(state);
        }
    }
}
