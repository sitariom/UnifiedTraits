using System;
using System.Collections.Generic;
using RimWorld;
using Verse;
using UnifiedTraits.Core;

namespace UnifiedTraits.Dynamic
{
    public class PawnTraitTracker : GameComponent
    {
        private int tickCounter = 0;
        private const int CheckInterval = 1000; // Check every ~16 seconds of gameplay

        public PawnTraitTracker(Game game)
        {
        }

        public override void GameComponentTick()
        {
            base.GameComponentTick();
            
            var settings = UnifiedTraitsMod.Instance?.Settings;
            if (settings == null || !settings.EnableDynamicTraitEvolution)
                return;

            tickCounter++;
            if (tickCounter >= CheckInterval)
            {
                tickCounter = 0;
                EvaluatePawnTraits();
            }
        }

        private void EvaluatePawnTraits()
        {
            var maps = Find.Maps;
            if (maps == null || maps.Count == 0) return;

            foreach (var map in maps)
            {
                if (map.mapPawns == null) continue;

                var freeColonists = map.mapPawns.FreeColonists;
                if (freeColonists == null) continue;

                foreach (var pawn in freeColonists)
                {
                    if (pawn == null || !pawn.Spawned || pawn.Dead || pawn.story == null)
                        continue;

                    EvaluateIndividualPawn(pawn);
                }
            }
        }

        private void EvaluateIndividualPawn(Pawn pawn)
        {
            var settings = UnifiedTraitsMod.Instance.Settings;

            // Check mood-based trait progression
            if (pawn.needs?.mood != null)
            {
                float curMood = pawn.needs.mood.CurLevel;
                
                // Extremely low mood: risk of stress affliction / negative trait development
                if (curMood < 0.15f && settings.EnableStressAfflictionSystem)
                {
                    StressVirtueAfflictionHandler.TryTriggerStressAffliction(pawn);
                }
                // High mood & inspiration: possibility of virtue / positive trait progression
                else if (curMood > 0.85f && settings.EnableDynamicTraitEvolution)
                {
                    StressVirtueAfflictionHandler.TryTriggerVirtueProgression(pawn);
                }
            }
        }
    }
}
