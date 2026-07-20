using HarmonyLib;
using Verse;
using Verse.AI;
using UnifiedTraits.Core;
using UnifiedTraits.Dynamic;

namespace UnifiedTraits.HarmonyPatches
{
    [HarmonyPatch(typeof(MentalBreakWorker), "TryStart")]
    public static class Patch_MentalBreakWorker
    {
        [HarmonyPrefix]
        public static void Prefix(Pawn pawn, string reason, bool causedByMood)
        {
            var settings = UnifiedTraitsMod.Instance?.Settings;
            if (settings == null || !settings.EnableStressAfflictionSystem) return;

            if (causedByMood && pawn != null)
            {
                // Dispara a tentativa de aflição de estresse quando ocorre uma quebra mental
                StressVirtueAfflictionHandler.TryTriggerStressAffliction(pawn);
            }
        }
    }
}
