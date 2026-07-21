using System.Collections.Generic;
using HarmonyLib;
using Verse;

namespace UnifiedTraits.HarmonyPatches
{
    /// <summary>
    /// Harmony patch to filter out harmless blueprint flammability errors logged by external mods
    /// (such as Vanilla Factions Expanded: Deserters, Pirates, Classical, Insectoids 2)
    /// where auto-generated building blueprints inherit Flammability > 0 without hitpoints.
    /// </summary>
    [HarmonyPatch(typeof(ThingDef), nameof(ThingDef.ConfigErrors))]
    public static class Patch_ThingDef_ConfigErrors
    {
        public static IEnumerable<string> Postfix(IEnumerable<string> __result, ThingDef __instance)
        {
            if (__result == null) yield break;

            foreach (string error in __result)
            {
                if (error == null) continue;

                // Filter out blueprint flammability warnings on blueprints
                if (((__instance.defName != null && __instance.defName.Contains("Blueprint"))) &&
                    error.Contains("flammable but has no hitpoints"))
                {
                    continue;
                }

                yield return error;
            }
        }
    }
}
