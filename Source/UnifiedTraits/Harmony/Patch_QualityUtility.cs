using HarmonyLib;
using RimWorld;
using Verse;
using UnifiedTraits.Core;

namespace UnifiedTraits.HarmonyPatches
{
    [HarmonyPatch(typeof(QualityUtility), "GenerateQualityCreatedByPawn", new[] { typeof(int), typeof(bool) })]
    public static class Patch_QualityUtility
    {
        [HarmonyPostfix]
        public static void Postfix(int relevantSkillLevel, bool inspired, ref QualityCategory __result)
        {
            var settings = UnifiedTraitsMod.Instance?.Settings;
            if (settings == null) return;

            if (!settings.EnableBasicTraits && !settings.EnableHeroicTraits)
                return;

            // Se o nível da habilidade do artesão for alto (>= 14) ou sob inspiração
            if (relevantSkillLevel >= 14 && __result < QualityCategory.Legendary && Rand.Value < 0.20f)
            {
                __result = (QualityCategory)((int)__result + 1);
            }
        }
    }
}
