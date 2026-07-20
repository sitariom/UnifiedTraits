using HarmonyLib;
using RimWorld;
using Verse;
using UnifiedTraits.Core;

namespace UnifiedTraits.HarmonyPatches
{
    [HarmonyPatch(typeof(Pawn_InteractionsTracker), "FactionSocialOrCharacterOpinion")]
    public static class Patch_Pawn_InteractionsTracker
    {
        [HarmonyPostfix]
        public static void Postfix(Pawn ___pawn, Pawn recipient, ref int __result)
        {
            var settings = UnifiedTraitsMod.Instance?.Settings;
            if (settings == null || !settings.EnableSimsCK3Traits) return;

            if (___pawn?.story?.traits == null || recipient?.story?.traits == null) return;

            // Interações sociais influenciadas por traits do CK3 / Sims (ex: Evil, Ambitious, Kleptomaniac)
            if (___pawn.story.traits.HasTrait(DefDatabase<TraitDef>.GetNamedSilentFail("UT_Kind") ?? TraitDefOf.Kind))
            {
                __result += 5;
            }
        }
    }
}
