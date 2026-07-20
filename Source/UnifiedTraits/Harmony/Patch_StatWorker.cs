using HarmonyLib;
using RimWorld;
using Verse;
using UnifiedTraits.Core;

namespace UnifiedTraits.HarmonyPatches
{
    [HarmonyPatch(typeof(StatWorker), "GetValueUnfinalized")]
    public static class Patch_StatWorker
    {
        [HarmonyPostfix]
        public static void Postfix(StatWorker __instance, StatRequest req, ref float __result, bool applyBases = true)
        {
            if (!req.HasThing || !(req.Thing is Pawn pawn) || pawn.story?.traits == null)
                return;

            var settings = UnifiedTraitsMod.Instance?.Settings;
            if (settings == null) return;

            if (!settings.EnableBasicTraits && !settings.EnableHeroicTraits)
                return;

            StatDef stat = Traverse.Create(__instance).Field("stat").GetValue<StatDef>();
            if (stat == null) return;

            var traits = pawn.story.traits.allTraits;
            for (int i = 0; i < traits.Count; i++)
            {
                var trait = traits[i];
                if (trait.def.defName.StartsWith("UT_"))
                {
                    if (settings.EnableHeroicTraits && trait.def.defName.Contains("Hero"))
                    {
                        if (stat == StatDefOf.MoveSpeed)
                        {
                            __result += 0.25f;
                        }
                        else if (stat == StatDefOf.GlobalLearningFactor)
                        {
                            __result *= 1.15f;
                        }
                    }
                }
            }
        }
    }
}
