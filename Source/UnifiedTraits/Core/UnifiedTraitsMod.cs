using UnityEngine;
using Verse;
using UnifiedTraits.HarmonyPatches;

namespace UnifiedTraits.Core
{
    public class UnifiedTraitsMod : Mod
    {
        public static UnifiedTraitsMod Instance { get; private set; } = null!;
        public UnifiedTraitsSettings Settings { get; private set; }

        public UnifiedTraitsMod(ModContentPack content) : base(content)
        {
            Instance = this;
            Settings = GetSettings<UnifiedTraitsSettings>();
            
            // Log Initialization
            Log.Message("[UnifiedTraits] Mod Reimagined carregado com sucesso. Inicializando patches do Harmony...");
            HarmonyInit.Init();
        }

        public override string SettingsCategory()
        {
            return "Unified Traits Reimagined";
        }

        public override void DoSettingsWindowContents(Rect inRect)
        {
            base.DoSettingsWindowContents(inRect);
            Settings.DoSettingsWindowContents(inRect);
        }
    }
}
