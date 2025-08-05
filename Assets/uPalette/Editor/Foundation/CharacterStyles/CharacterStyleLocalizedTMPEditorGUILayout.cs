﻿using System.Collections.Generic;
using TMPro;
using UnityEditor;
using UnityEngine;
using uPalette.Runtime.Foundation.CharacterStyles;

namespace uPalette.Editor.Foundation.CharacterStyles
{
    public static class CharacterStyleLocalizedTMPEditorGUILayout
    {
        private static readonly Dictionary<int, CharacterStyleLocalizedTMP> _changedValues =
            new Dictionary<int, CharacterStyleLocalizedTMP>();

        public static CharacterStyleLocalizedTMP DrawField(Rect rect, CharacterStyleLocalizedTMP value)
        {
            var controlId = GUIUtility.GetControlID(FocusType.Passive);
            var previewGuiStyle = new GUIStyle(EditorStyles.label);
            var fontName = "(Default)";
            //TODO?  Is need?
            /*if (value.font != null)
            {
                previewGuiStyle.font = value.font.sourceFontFile;
                fontName = value.font.name;
            }*/

            previewGuiStyle.fontStyle = FontStylesToFontStyle(value.fontStyle);
            previewGuiStyle.fontSize = 14;
            previewGuiStyle.richText = true;
            var previewRect = rect;
            previewRect.xMin += 4;
            previewRect.width = 26;
            var textRect = rect;
            textRect.xMin += 30;

            var previewLabel = "Ag";
            if ((value.fontStyle & FontStyles.LowerCase) != 0)
                previewLabel = "ag";
            else if ((value.fontStyle & FontStyles.UpperCase) != 0)
                previewLabel = "AG";
            else if ((value.fontStyle & FontStyles.SmallCaps) != 0)
                previewLabel = "A<size=11>G</size>";

            if (GUI.Button(rect, string.Empty, EditorStyles.objectField))
            {
                var characterStyleLocalizedTMPEditor = CharacterStyleLocalizedTMPEditor.Open(value);
                characterStyleLocalizedTMPEditor.OnValueChanged += characterStyle =>
                {
                    _changedValues[controlId] = characterStyle;

                    // The value has changed, but the focus is still on the CharacterStyleEditor.
                    // In order to return the updated CharacterStyleField value, the GUI that calls it needs to be repainted.
                    // To do this, repaint all the windows.
                    foreach (var window in Resources.FindObjectsOfTypeAll<EditorWindow>())
                        window.Repaint();
                };
            }

            if ((value.fontStyle & FontStyles.Underline) != 0)
            {
                var underLineRect = previewRect;
                underLineRect.y += underLineRect.height - 4;
                underLineRect.height = 1;
                underLineRect.width -= 4;
                EditorGUI.DrawRect(underLineRect, GUI.skin.label.normal.textColor);
            }

            EditorGUI.LabelField(previewRect, previewLabel, previewGuiStyle);

            //TODO:  Hmm.
            /*// マテリアル情報を含む表示
            var displayText = $"{fontName} - {value.fontSize}pt";
            if (value.fontSharedMaterial != null)
                displayText += $" [{value.fontSharedMaterial.name}]";
            else if (value.font != null && value.font.material != null)
                // デフォルトマテリアルを使用していることを明示
                displayText += " [Default Material]";
            EditorGUI.LabelField(textRect, displayText);*/

            if ((value.fontStyle & FontStyles.Strikethrough) != 0)
            {
                var strikethroughLineRect = previewRect;
                strikethroughLineRect.y += strikethroughLineRect.height / 2;
                strikethroughLineRect.height = 1;
                strikethroughLineRect.width -= 4;
                EditorGUI.DrawRect(strikethroughLineRect, GUI.skin.label.normal.textColor);
            }

            if (_changedValues.TryGetValue(controlId, out var changedValue))
            {
                GUI.changed = true;
                value = changedValue;
                _changedValues.Remove(controlId);
            }

            return value;
        }

        private static FontStyle FontStylesToFontStyle(FontStyles styles)
        {
            if ((styles & FontStyles.Bold) != 0 && (styles & FontStyles.Italic) != 0)
                return FontStyle.BoldAndItalic;

            if ((styles & FontStyles.Bold) != 0)
                return FontStyle.Bold;

            if ((styles & FontStyles.Italic) != 0)
                return FontStyle.Italic;

            return FontStyle.Normal;
        }
    }
}
