using HarmonyLib;
using RimWorld;
using Verse;
using UnifiedTraits.Core;

namespace UnifiedTraits.HarmonyPatches
{
    [HarmonyPatch(typeof(Pawn_RelationsTracker), "OpinionOf")]
    public static class Patch_Pawn_RelationsTracker
    {
        [HarmonyPostfix]
        public static void Postfix(Pawn_RelationsTracker __instance, Pawn other, ref int __result)
        {
            Pawn pawn = Traverse.Create(__instance).Field("pawn").GetValue<Pawn>();
            if (pawn?.story?.traits == null || other?.story?.traits == null) return;

            var settings = UnifiedTraitsMod.Instance?.Settings;
            if (settings == null || !settings.EnableSimsCK3Traits) return;

            // Interações sociais influenciadas por traits do CK3 / Sims
            if (pawn.story.traits.HasTrait(DefDatabase<TraitDef>.GetNamedSilentFail("UT_Kind") ?? TraitDefOf.Kind))
            {
                __result += 5;
            }
        }
    }
}
