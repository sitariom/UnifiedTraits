using HarmonyLib;
using RimWorld;
using Verse;
using UnifiedTraits.Core;

namespace UnifiedTraits.HarmonyPatches
{
    [HarmonyPatch(typeof(QualityUtility), "GenerateQualityCreatedByPawn", new[] { typeof(Pawn), typeof(SkillDef) })]
    public static class Patch_QualityUtility
    {
        [HarmonyPostfix]
        public static void Postfix(Pawn pawn, SkillDef relevantSkill, ref QualityCategory __result)
        {
            if (pawn?.story?.traits == null)
                return;

            var settings = UnifiedTraitsMod.Instance?.Settings;
            if (settings == null) return;

            if (!settings.EnableBasicTraits && !settings.EnableHeroicTraits)
                return;

            var traits = pawn.story.traits.allTraits;
            for (int i = 0; i < traits.Count; i++)
            {
                var trait = traits[i];
                if (trait.def.defName == "UT_VTE_MasterCraftsman" || trait.def.defName == "UT_HeroicPerfectionist")
                {
                    if (__result < QualityCategory.Legendary && Rand.Value < 0.25f)
                    {
                        __result = (QualityCategory)((int)__result + 1);
                    }
                }
            }
        }
    }
}
