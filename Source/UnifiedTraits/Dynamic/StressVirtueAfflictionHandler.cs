using System.Linq;
using RimWorld;
using Verse;
using UnifiedTraits.Core;

namespace UnifiedTraits.Dynamic
{
    public static class StressVirtueAfflictionHandler
    {
        public static void TryTriggerStressAffliction(Pawn pawn)
        {
            if (pawn?.story?.traits == null) return;

            // Simple chance roll scaled by settings
            float chance = 0.02f * UnifiedTraitsMod.Instance.Settings.TraitEvolutionRateMultiplier;
            if (Rand.Value > chance) return;

            // Find dark / affliction trait defs dynamically
            var afflictionTraits = DefDatabase<TraitDef>.AllDefs
                .Where(t => t.defName.StartsWith("UT_") && (t.defName.Contains("Paranoid") || t.defName.Contains("Irrational") || t.defName.Contains("Abusive") || t.defName.Contains("Anxious")))
                .ToList();

            if (afflictionTraits.Count > 0)
            {
                var chosenTrait = afflictionTraits.RandomElement();
                if (!pawn.story.traits.HasTrait(chosenTrait))
                {
                    Trait newTrait = new Trait(chosenTrait, 0, forced: true);
                    pawn.story.traits.GainTrait(newTrait);
                    string traitLabel = newTrait.LabelCap;
                    Messages.Message("UnifiedTraits.Message.AfflictionGained".Translate(pawn.LabelShort, traitLabel), pawn, MessageTypeDefOf.NegativeEvent);
                }
            }
        }

        public static void TryTriggerVirtueProgression(Pawn pawn)
        {
            if (pawn?.story?.traits == null) return;

            float chance = 0.01f * UnifiedTraitsMod.Instance.Settings.TraitEvolutionRateMultiplier;
            if (Rand.Value > chance) return;

            var virtueTraits = DefDatabase<TraitDef>.AllDefs
                .Where(t => t.defName.StartsWith("UT_") && (t.defName.Contains("Courageous") || t.defName.Contains("Stalwart") || t.defName.Contains("Focused") || t.defName.Contains("Vigorous")))
                .ToList();

            if (virtueTraits.Count > 0)
            {
                var chosenTrait = virtueTraits.RandomElement();
                if (!pawn.story.traits.HasTrait(chosenTrait))
                {
                    Trait newTrait = new Trait(chosenTrait, 0, forced: true);
                    pawn.story.traits.GainTrait(newTrait);
                    string traitLabel = newTrait.LabelCap;
                    Messages.Message("UnifiedTraits.Message.VirtueGained".Translate(pawn.LabelShort, traitLabel), pawn, MessageTypeDefOf.PositiveEvent);
                }
            }
        }
    }
}
