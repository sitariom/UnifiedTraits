using UnityEngine;
using Verse;

namespace UnifiedTraits.Core
{
    public class UnifiedTraitsSettings : ModSettings
    {
        // Category Toggles
        public bool EnableBasicTraits = true;
        public bool EnableSynergisticTraits = true;
        public bool EnableFalloutTraits = true;
        public bool EnableDarkestDungeonTraits = true;
        public bool EnableSimsCK3Traits = true;
        public bool EnableHeroicTraits = true;
        
        // Mechanics Toggles
        public bool EnableDynamicTraitEvolution = true;
        public float TraitEvolutionRateMultiplier = 1.0f;
        public bool EnableStressAfflictionSystem = true;
        public bool EnableTraitSynergyTicks = true;

        public override void ExposeData()
        {
            base.ExposeData();
            Scribe_Values.Look(ref EnableBasicTraits, "EnableBasicTraits", true);
            Scribe_Values.Look(ref EnableSynergisticTraits, "EnableSynergisticTraits", true);
            Scribe_Values.Look(ref EnableFalloutTraits, "EnableFalloutTraits", true);
            Scribe_Values.Look(ref EnableDarkestDungeonTraits, "EnableDarkestDungeonTraits", true);
            Scribe_Values.Look(ref EnableSimsCK3Traits, "EnableSimsCK3Traits", true);
            Scribe_Values.Look(ref EnableHeroicTraits, "EnableHeroicTraits", true);

            Scribe_Values.Look(ref EnableDynamicTraitEvolution, "EnableDynamicTraitEvolution", true);
            Scribe_Values.Look(ref TraitEvolutionRateMultiplier, "TraitEvolutionRateMultiplier", 1.0f);
            Scribe_Values.Look(ref EnableStressAfflictionSystem, "EnableStressAfflictionSystem", true);
            Scribe_Values.Look(ref EnableTraitSynergyTicks, "EnableTraitSynergyTicks", true);
        }

        public void DoSettingsWindowContents(Rect inRect)
        {
            Listing_Standard listing = new Listing_Standard();
            listing.Begin(inRect);

            listing.Label("Categorias de Traits Ativas");
            listing.GapLine();

            listing.CheckboxLabeled("Traits Básicos e Gerais (Basic & General)", ref EnableBasicTraits);
            listing.CheckboxLabeled("Traits de Sinergia (Synergistic Traits)", ref EnableSynergisticTraits);
            listing.CheckboxLabeled("Traits do Universo Fallout (S.P.E.C.I.A.L.)", ref EnableFalloutTraits);
            listing.CheckboxLabeled("Traits de Darkest Dungeon (Virtudes & Aflições)", ref EnableDarkestDungeonTraits);
            listing.CheckboxLabeled("Traits de Personalidade & Social (CK3 & The Sims)", ref EnableSimsCK3Traits);
            listing.CheckboxLabeled("Traits Heróicos & Lendários (Heroes + Gods)", ref EnableHeroicTraits);

            listing.Gap();
            listing.Label("Sistemas Dinâmicos e Mecânicas");
            listing.GapLine();

            listing.CheckboxLabeled("Evolução Dinâmica de Traits por Eventos de Vida", ref EnableDynamicTraitEvolution);
            if (EnableDynamicTraitEvolution)
            {
                listing.Label($"Multiplicador de Velocidade de Evolução: {TraitEvolutionRateMultiplier:F1}x");
                TraitEvolutionRateMultiplier = listing.Slider(TraitEvolutionRateMultiplier, 0.1f, 3.0f);
            }

            listing.CheckboxLabeled("Sistema de Aflições e Virtudes por Estresse Extremo", ref EnableStressAfflictionSystem);
            listing.CheckboxLabeled("Cálculo Periódico de Sinergias de Traits em Pawns", ref EnableTraitSynergyTicks);

            listing.End();
        }
    }
}
