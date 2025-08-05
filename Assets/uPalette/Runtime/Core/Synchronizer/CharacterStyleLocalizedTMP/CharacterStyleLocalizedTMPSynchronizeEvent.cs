using UnityEngine;
using uPalette.Runtime.Core.Model;

namespace uPalette.Runtime.Core.Synchronizer.CharacterStyleLocalizedTMP
{
    public sealed class
        CharacterStyleLocalizedTMPSynchronizeEvent : ValueSynchronizeEvent<Foundation.CharacterStyles.CharacterStyleLocalizedTMP>
    {
        [SerializeField] private CharacterStyleLocalizedTMPEntryId _entryId = new CharacterStyleLocalizedTMPEntryId();

        public override EntryId EntryId => _entryId;

        internal override Palette<Foundation.CharacterStyles.CharacterStyleLocalizedTMP> GetPalette(PaletteStore store)
        {
            return store.CharacterStyleLocalizedTMPPalette;
        }
    }
}
