using HarmonyLib;
using RimWorld;
using Verse;
using UnifiedTraits.Dynamic;
using UnifiedTraits.Synergies;

namespace UnifiedTraits.HarmonyPatches
{
    [HarmonyPatch(typeof(TraitSet), "GainTrait")]
    public static class Patch_TraitSet_GainTrait
    {
        [HarmonyPostfix]
        public static void Postfix(TraitSet __instance, Trait trait)
        {
            Pawn pawn = Traverse.Create(__instance).Field("pawn").GetValue<Pawn>();
            if (pawn == null || trait == null)
                return;

            var tracker = Current.Game?.GetComponent<PawnTraitTracker>();
            tracker?.OnTraitGained(pawn, trait);

            SynergyEvaluator.EvaluatePawnSynergies(pawn);
        }
    }

    [HarmonyPatch(typeof(TraitSet), "RemoveTrait")]
    public static class Patch_TraitSet_RemoveTrait
    {
        [HarmonyPostfix]
        public static void Postfix(TraitSet __instance, Trait trait)
        {
            Pawn pawn = Traverse.Create(__instance).Field("pawn").GetValue<Pawn>();
            if (pawn == null || trait == null)
                return;

            var tracker = Current.Game?.GetComponent<PawnTraitTracker>();
            tracker?.OnTraitLost(pawn, trait);

            SynergyEvaluator.EvaluatePawnSynergies(pawn);
        }
    }
}
