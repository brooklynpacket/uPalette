using System;
using TMPro;
using UnityEngine;
using UnityEngine.Localization;
using UnityEngine.Localization.Tables;

namespace uPalette.Runtime.Foundation.CharacterStyles
{
    [Serializable]
    public struct CharacterStyleLocalizedTMP
    {
        /*public TableReference fontTableReference;
        public TableEntryReference  fontItemReference;
        public TableReference materialTableReference;
        public TableEntryReference materialItemReference;*/
        
        public LocalizedAsset<TMP_FontAsset> fontAsset;
        public LocalizedAsset<Material> fontMaterial;
        
        public FontStyles fontStyle;
        public float fontSize;
        public bool enableAutoSizing;

        // For backward compatibility.
        // Synchronize "Auto Size Options" of TextMesh Pro.
        [SerializeField] internal bool enableAutoSizeOptions;

        public float fontSizeMin;
        public float fontSizeMax;
        public float characterWidthAdjustment;
        public float lineSpacingAdjustment;
        public float characterSpacing;
        public float wordSpacing;
        public float lineSpacing;
        public float paragraphSpacing;

        public static CharacterStyleLocalizedTMP Default
        {
            get
            {
                return new CharacterStyleLocalizedTMP
                {
                    /*
                    fontTableReference = null,
                    fontItemReference = null,
                    materialTableReference = null,
                    materialItemReference = null,
                    */
                    
                    fontAsset = null,
                    fontMaterial = null,
                    
                    fontStyle = 0,
                    enableAutoSizing = false,
                    fontSize = TMP_Settings.defaultFontSize,
                    enableAutoSizeOptions = true,
                    fontSizeMin = TMP_Settings.defaultFontSize * TMP_Settings.defaultTextAutoSizingMinRatio,
                    fontSizeMax = TMP_Settings.defaultFontSize * TMP_Settings.defaultTextAutoSizingMaxRatio,
                    characterWidthAdjustment = 0.0f,
                    lineSpacingAdjustment = 0.0f,
                    characterSpacing = 0.0f,
                    wordSpacing = 0.0f,
                    lineSpacing = 0.0f,
                    paragraphSpacing = 0.0f,
                };
            }
        }
    }
}
