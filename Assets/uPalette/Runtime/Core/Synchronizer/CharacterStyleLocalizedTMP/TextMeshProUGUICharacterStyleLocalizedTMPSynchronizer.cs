using TMPro;
using UnityEngine;
using UnityEngine.Localization;
using UnityEngine.Localization.PropertyVariants;
using UnityEngine.Localization.PropertyVariants.TrackedObjects;
using UnityEngine.Localization.PropertyVariants.TrackedProperties;
using UnityEngine.Localization.Tables;

namespace uPalette.Runtime.Core.Synchronizer.CharacterStyleLocalizedTMP
{
    [RequireComponent(typeof(TextMeshProUGUI))]
    [RequireComponent(typeof(GameObjectLocalizer))]
    [CharacterStyleLocalizedTMP.CharacterStyleLocalizedTMPSynchronizer(typeof(TextMeshProUGUI), "Character Style")]
    public sealed class TextMeshProUGUICharacterStyleLocalizedTMPSynchronizer : CharacterStyleLocalizedTMP.CharacterStyleLocalizedTMPSynchronizer<TextMeshProUGUI>
    {
        protected internal override Foundation.CharacterStyles.CharacterStyleLocalizedTMP GetValue()
        { 
            var trackedText = LocalizerComponent.GetTrackedObject<TrackedUGuiGraphic>(TMPComponent);
            var fontVariant = trackedText.GetTrackedProperty<LocalizedAssetProperty>("m_fontAsset");
            var materialVariant = trackedText.GetTrackedProperty<LocalizedAssetProperty>("m_sharedMaterial");

            return new Foundation.CharacterStyles.CharacterStyleLocalizedTMP
            {
                fontAsset = (LocalizedAsset<TMP_FontAsset>)fontVariant.LocalizedObject,
                fontMaterial = (LocalizedAsset<Material>)materialVariant.LocalizedObject,
                fontStyle = TMPComponent.fontStyle,
                enableAutoSizing = TMPComponent.enableAutoSizing,
                fontSize = TMPComponent.fontSize,
                fontSizeMin = TMPComponent.fontSizeMin,
                fontSizeMax = TMPComponent.fontSizeMax,
                characterWidthAdjustment = TMPComponent.characterWidthAdjustment,
                lineSpacingAdjustment = TMPComponent.lineSpacingAdjustment,
                characterSpacing = TMPComponent.characterSpacing,
                wordSpacing = TMPComponent.wordSpacing,
                lineSpacing = TMPComponent.lineSpacing,
                paragraphSpacing = TMPComponent.paragraphSpacing
            };
        }

        protected internal override void SetValue(Foundation.CharacterStyles.CharacterStyleLocalizedTMP value)
        {
            var trackedText = LocalizerComponent.GetTrackedObject<TrackedUGuiGraphic>(TMPComponent);
            var fontVariant = trackedText.GetTrackedProperty<LocalizedAssetProperty>("m_fontAsset");
            var materialVariant = trackedText.GetTrackedProperty<LocalizedAssetProperty>("m_sharedMaterial");
            
            fontVariant.LocalizedObject = value.fontAsset;
            materialVariant.LocalizedObject = value.fontMaterial;
            
            TMPComponent.fontStyle = value.fontStyle;
            TMPComponent.enableAutoSizing = value.enableAutoSizing;
            TMPComponent.fontSize = value.fontSize;
            if (value.enableAutoSizeOptions)
            {
                TMPComponent.fontSizeMin = value.fontSizeMin;
                TMPComponent.fontSizeMax = value.fontSizeMax;
                TMPComponent.characterWidthAdjustment = value.characterWidthAdjustment;
                TMPComponent.lineSpacingAdjustment = value.lineSpacingAdjustment;
            }
            TMPComponent.characterSpacing = value.characterSpacing;
            TMPComponent.wordSpacing = value.wordSpacing;
            TMPComponent.lineSpacing = value.lineSpacing;
            TMPComponent.paragraphSpacing = value.paragraphSpacing;

            /*// マテリアルの設定
            if (value.fontSharedMaterial != null)
                TMPComponent.fontSharedMaterial = value.fontSharedMaterial;
            else if (value.font != null)
                // マテリアルが指定されていない場合は、フォントアセットのデフォルトマテリアルを使用
                TMPComponent.fontSharedMaterial = value.font.material;*/
        }
    }
}
