using HarmonyLib;
using Verse;
using UnifiedTraits.Core;

namespace UnifiedTraits.HarmonyPatches
{
    [HarmonyPatch(typeof(Pawn_HealthTracker), "PreApplyDamage")]
    public static class Patch_Pawn_HealthTracker
    {
        [HarmonyPrefix]
        public static bool Prefix(Pawn_HealthTracker __instance, ref DamageInfo dinfo, out bool absorbed)
        {
            absorbed = false;
            Pawn pawn = Traverse.Create(__instance).Field("pawn").GetValue<Pawn>();

            if (pawn?.story?.traits == null)
                return true;

            var settings = UnifiedTraitsMod.Instance?.Settings;
            if (settings == null) return true;

            if (!settings.EnableHeroicTraits && !settings.EnableFalloutTraits)
                return true;

            var traits = pawn.story.traits.allTraits;
            for (int i = 0; i < traits.Count; i++)
            {
                var trait = traits[i];
                if (trait.def.defName == "UT_HeroicResilience" || trait.def.defName == "UT_FT_IronStomach")
                {
                    dinfo.SetAmount(dinfo.Amount * 0.85f);
                }
            }

            return true;
        }
    }
}
