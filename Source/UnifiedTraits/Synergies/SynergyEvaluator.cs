using System.Collections.Generic;
using System.Linq;
using RimWorld;
using Verse;
using UnifiedTraits.Core;

namespace UnifiedTraits.Synergies
{
    public static class SynergyEvaluator
    {
        public static void EvaluatePawnSynergies(Pawn pawn)
        {
            if (pawn?.story?.traits == null || pawn.health?.hediffSet == null) return;
            
            var settings = UnifiedTraitsMod.Instance?.Settings;
            if (settings == null || !settings.EnableTraitSynergyTicks) return;

            var allTraits = pawn.story.traits.allTraits;
            if (allTraits == null || allTraits.Count < 2) return;

            // Synergy Check Example: Multiple Combat / Martial Traits
            bool hasCombatSynergy = allTraits.Count(t => t.def.defName.Contains("Shooter") || t.def.defName.Contains("Brawler") || t.def.defName.Contains("Hero") || t.def.defName.Contains("Warrior")) >= 2;

            if (hasCombatSynergy)
            {
                ApplySynergyHediff(pawn, "UT_CombatSynergyBuff");
            }
        }

        private static void ApplySynergyHediff(Pawn pawn, string hediffDefName)
        {
            HediffDef def = DefDatabase<HediffDef>.GetNamedSilentFail(hediffDefName);
            if (def != null && !pawn.health.hediffSet.HasHediff(def))
            {
                pawn.health.AddHediff(def);
            }
        }
    }
}
