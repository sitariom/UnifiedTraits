using HarmonyLib;
using RimWorld;
using Verse;
using UnifiedTraits.Core;

namespace UnifiedTraits.HarmonyPatches
{
    [HarmonyPatch(typeof(Pawn_SkillTracker), "Learn")]
    public static class Patch_Pawn_SkillTracker
    {
        [HarmonyPrefix]
        public static void Prefix(Pawn_SkillTracker __instance, SkillDef sDef, ref float xp, bool direct = false)
        {
            Pawn pawn = Traverse.Create(__instance).Field("pawn").GetValue<Pawn>();

            if (xp <= 0f || pawn?.story?.traits == null)
                return;

            var settings = UnifiedTraitsMod.Instance?.Settings;
            if (settings == null || !settings.EnableDynamicTraitEvolution)
                return;

            var traits = pawn.story.traits.allTraits;
            for (int i = 0; i < traits.Count; i++)
            {
                var trait = traits[i];
                if (trait.def.defName == "UT_VSIE_FastLearner" || trait.def.defName == "UT_FT_IdiotSavant")
                {
                    xp *= 1.25f;
                }
            }
        }
    }
}
