using System;
using uPalette.Runtime.Foundation.CharacterStyles;

namespace uPalette.Runtime.Core.Model
{
    [Serializable]
    public sealed class CharacterStyleLocalizedTMPPalette : Palette<CharacterStyleLocalizedTMP>
    {
        protected override CharacterStyleLocalizedTMP GetDefaultValue()
        {
            return CharacterStyleLocalizedTMP.Default;
        }
    }
}
