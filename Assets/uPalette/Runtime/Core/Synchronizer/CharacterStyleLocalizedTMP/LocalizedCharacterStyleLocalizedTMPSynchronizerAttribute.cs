using System;

namespace uPalette.Runtime.Core.Synchronizer.CharacterStyleLocalizedTMP
{
    public sealed class CharacterStyleLocalizedTMPSynchronizerAttribute : ValueSynchronizerAttribute
    {
        public CharacterStyleLocalizedTMPSynchronizerAttribute(Type attachTargetType, string targetPropertyDisplayName)
            : base(typeof(Foundation.CharacterStyles.CharacterStyleLocalizedTMP), attachTargetType, targetPropertyDisplayName)
        {
        }
    }
}
