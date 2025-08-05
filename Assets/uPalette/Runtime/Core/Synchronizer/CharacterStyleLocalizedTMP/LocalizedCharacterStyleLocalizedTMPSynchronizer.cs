using UnityEngine;
using UnityEngine.Localization.PropertyVariants;
using uPalette.Runtime.Core.Model;

namespace uPalette.Runtime.Core.Synchronizer.CharacterStyleLocalizedTMP
{
    public abstract class CharacterStyleLocalizedTMPSynchronizer : ValueSynchronizer<Foundation.CharacterStyles.CharacterStyleLocalizedTMP>
    {
        [SerializeField] private CharacterStyleLocalizedTMPEntryId _entryId = new CharacterStyleLocalizedTMPEntryId();

        public override EntryId EntryId => _entryId;
        
        internal override Palette<Foundation.CharacterStyles.CharacterStyleLocalizedTMP> GetPalette(PaletteStore store)
        {
            return store.CharacterStyleLocalizedTMPPalette;
        }
    }

    public abstract class CharacterStyleLocalizedTMPSynchronizer<T> : CharacterStyleLocalizedTMPSynchronizer where T : Component
    {
        [SerializeField] [HideInInspector] private T _tmpComponent;
        [SerializeField] [HideInInspector] private GameObjectLocalizer _localizerComponent;

        protected T TMPComponent
        {
            get
            {
                if (_tmpComponent == null)
                {
                    _tmpComponent = GetComponent<T>();
                }

                return _tmpComponent;
            }
        }
        
        protected GameObjectLocalizer LocalizerComponent
        {
            get
            {
                if (_localizerComponent == null)
                {
                    _localizerComponent = GetComponent<GameObjectLocalizer>();
                }

                return _localizerComponent;
            }
        }
    }
}
