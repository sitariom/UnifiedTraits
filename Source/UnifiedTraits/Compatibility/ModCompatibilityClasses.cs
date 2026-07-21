// Auto-generated compatibility classes with full field declarations for UnifiedTraits Reimagined
using System;
using System.Collections.Generic;

namespace AnimalBehaviours
{
    public class HediffCompProperties_Electrified : Verse.HediffCompProperties
    {
        public HediffCompProperties_Electrified()
        {
            this.compClass = typeof(Verse.HediffComp);
        }
        public object batteriesToAffect;
        public object electroChargeAmount;
        public object electroRadius;
        public object electroRate;
    }

    public class HediffCompProperties_Floating : Verse.HediffCompProperties
    {
        public HediffCompProperties_Floating()
        {
            this.compClass = typeof(Verse.HediffComp);
        }
    }

}

public class HediffCompProperties : Verse.HediffCompProperties
{
    public HediffCompProperties()
    {
        this.compClass = typeof(Verse.HediffComp);
    }
}

public class HediffCompProperties_Disappears : Verse.HediffCompProperties
{
    public HediffCompProperties_Disappears()
    {
        this.compClass = typeof(Verse.HediffComp);
    }
    public int disappearsAfterTicks;
    public bool showRemainingTime;
}

public class HediffCompProperties_DisappearsOnDeath : Verse.HediffCompProperties
{
    public HediffCompProperties_DisappearsOnDeath()
    {
        this.compClass = typeof(Verse.HediffComp);
    }
}

public class HediffCompProperties_Effecter : Verse.HediffCompProperties
{
    public HediffCompProperties_Effecter()
    {
        this.compClass = typeof(Verse.HediffComp);
    }
    public object stateEffecter;
}

public class HediffCompProperties_GiveAbility : Verse.HediffCompProperties
{
    public HediffCompProperties_GiveAbility()
    {
        this.compClass = typeof(Verse.HediffComp);
    }
    public object abilityDefs;
}

public class HediffCompProperties_Invisibility : Verse.HediffCompProperties
{
    public HediffCompProperties_Invisibility()
    {
        this.compClass = typeof(Verse.HediffComp);
    }
    public bool visibleToPlayer;
}

public class HediffCompProperties_KillAfterDays : Verse.HediffCompProperties
{
    public HediffCompProperties_KillAfterDays()
    {
        this.compClass = typeof(Verse.HediffComp);
    }
    public int days;
}

public class HediffCompProperties_SeverityFromEntropy : Verse.HediffCompProperties
{
    public HediffCompProperties_SeverityFromEntropy()
    {
        this.compClass = typeof(Verse.HediffComp);
    }
}

public class HediffCompProperties_SeverityPerDay : Verse.HediffCompProperties
{
    public HediffCompProperties_SeverityPerDay()
    {
        this.compClass = typeof(Verse.HediffComp);
    }
    public object severityPerDay;
    public object showDaysToRecover;
}

namespace HautsFramework
{
    public class CannotRemoveBionicsFrom : Verse.DefModExtension
    {
    }

    public class ConceitedTrait : Verse.DefModExtension
    {
    }

    public class ExciseTraitExempt : Verse.DefModExtension
    {
    }

    public class HediffCompProperties_AbilityCooldownModifier : Verse.HediffCompProperties
    {
        public HediffCompProperties_AbilityCooldownModifier()
        {
            this.compClass = typeof(Verse.HediffComp);
        }
        public object affectsAllAbilities;
        public object increasedCooldownRecovery;
    }

    public class HediffCompProperties_AnomalousActivitySeverity : Verse.HediffCompProperties
    {
        public HediffCompProperties_AnomalousActivitySeverity()
        {
            this.compClass = typeof(Verse.HediffComp);
        }
        public float defaultSeverity;
        public object severityAtEachLevel;
    }

    public class HediffCompProperties_AuraHediff : Verse.HediffCompProperties
    {
        public HediffCompProperties_AuraHediff()
        {
            this.compClass = typeof(Verse.HediffComp);
        }
        public bool affectsAllies;
        public bool affectsHostiles;
        public object affectsMechs;
        public bool affectsSelf;
        public object canToggleVisualization;
        public string color;
        public object disappearsWhileDowned;
        public object hediffs;
        public string mote;
        public float range;
        public object scanByPawnListerNotByGrid;
        public object visLabel;
        public object visTooltip;
        public object visTooltipFantasy;
    }

    public class HediffCompProperties_AuraThought : Verse.HediffCompProperties
    {
        public HediffCompProperties_AuraThought()
        {
            this.compClass = typeof(Verse.HediffComp);
        }
        public bool affectsAllies;
        public bool affectsHostiles;
        public bool affectsSelf;
        public string color;
        public object disappearsWhileDowned;
        public string mote;
        public float range;
        public object thoughts;
    }

    public class HediffCompProperties_BoredomAdjustment : Verse.HediffCompProperties
    {
        public HediffCompProperties_BoredomAdjustment()
        {
            this.compClass = typeof(Verse.HediffComp);
        }
        public object boredoms;
        public int ticks;
    }

    public class HediffCompProperties_BreakRiskSeverity : Verse.HediffCompProperties
    {
        public HediffCompProperties_BreakRiskSeverity()
        {
            this.compClass = typeof(Verse.HediffComp);
        }
        public object activeDuringMentalStates;
    }

    public class HediffCompProperties_ChangeAboveSeverity : Verse.HediffCompProperties
    {
        public HediffCompProperties_ChangeAboveSeverity()
        {
            this.compClass = typeof(Verse.HediffComp);
        }
        public object aboveThisSeverity;
        public object alternativeHediff;
    }

    public class HediffCompProperties_ChangeBelowSeverity : Verse.HediffCompProperties
    {
        public HediffCompProperties_ChangeBelowSeverity()
        {
            this.compClass = typeof(Verse.HediffComp);
        }
        public object alternativeHediff;
        public object atOrBelowThisSeverity;
    }

    public class HediffCompProperties_ChangeSeverityOnIngestion : Verse.HediffCompProperties
    {
        public HediffCompProperties_ChangeSeverityOnIngestion()
        {
            this.compClass = typeof(Verse.HediffComp);
        }
        public object severityPerNutritionIngested;
    }

    public class HediffCompProperties_ChangeSeverityOnVerbUse : Verse.HediffCompProperties
    {
        public HediffCompProperties_ChangeSeverityOnVerbUse()
        {
            this.compClass = typeof(Verse.HediffComp);
        }
        public object setSeverity;
        public object severityGainedOnUse;
    }

    public class HediffCompProperties_CreateThingsBySpendingSeverity : Verse.HediffCompProperties
    {
        public HediffCompProperties_CreateThingsBySpendingSeverity()
        {
            this.compClass = typeof(Verse.HediffComp);
        }
        public float severityToTrigger;
        public object spawnFleck1;
        public object spawnFleck2;
        public object spawnInOwnInventory;
        public object spawnRadius;
        public object spawnSound;
        public object spawnedThingAndCountPerTrigger;
    }

    public class HediffCompProperties_CureHediffsOnHit : Verse.HediffCompProperties
    {
        public HediffCompProperties_CureHediffsOnHit()
        {
            this.compClass = typeof(Verse.HediffComp);
        }
        public object appliedViaPsycasts;
        public float cellRange;
        public object hediffsToCure;
        public object victimScalar;
        public float worldTileRange;
    }

    public class HediffCompProperties_DamageNegation : Verse.HediffCompProperties
    {
        public HediffCompProperties_DamageNegation()
        {
            this.compClass = typeof(Verse.HediffComp);
        }
        public object chance;
        public object damageAdded;
        public float damageMultiplier;
        public object damageScalesSeverityLoss;
        public object fleckOnBlock;
        public object harmfulDamageTypesOnly;
        public object minSeverityToWork;
        public int priority;
        public object severityOnHit;
        public object soundOnBlock;
        public object throwDustPuffsOnBlock;
        public object unaffectedDamageTypes;
    }

    public class HediffCompProperties_DelayedResurrection : Verse.HediffCompProperties
    {
        public HediffCompProperties_DelayedResurrection()
        {
            this.compClass = typeof(Verse.HediffComp);
        }
        public object chance;
        public object onDeathMessage;
        public object onRezMessage;
        public object rareTickDelay;
        public object requiredTrait;
        public object shouldSendMessage;
        public object shouldTranslateOnDeath;
        public object shouldTranslateOnRez;
    }

    public class HediffCompProperties_ExtraDamageOnHit : Verse.HediffCompProperties
    {
        public HediffCompProperties_ExtraDamageOnHit()
        {
            this.compClass = typeof(Verse.HediffComp);
        }
        public object appliedViaAttacks;
        public object appliedViaPsycasts;
        public bool canAffectMechs;
        public float cellRange;
        public object damageScaling;
        public object entropyCostScaling;
        public object extraDamages;
        public object victimScalar;
        public float worldTileRange;
    }

    public class HediffCompProperties_ForcedByOtherProperty : Verse.HediffCompProperties
    {
        public HediffCompProperties_ForcedByOtherProperty()
        {
            this.compClass = typeof(Verse.HediffComp);
        }
        public object alternativeHediffs;
        public object forcingGenes;
        public object forcingTraits;
        public object returnAs;
    }

    public class HediffCompProperties_GasSeverity : Verse.HediffCompProperties
    {
        public HediffCompProperties_GasSeverity()
        {
            this.compClass = typeof(Verse.HediffComp);
        }
        public object gasTypes;
        public object perTickInGas;
        public object perTickNoGas;
        public object whileNotInGas;
    }

    public class HediffCompProperties_GeneticResourceModifiers : Verse.HediffCompProperties
    {
        public HediffCompProperties_GeneticResourceModifiers()
        {
            this.compClass = typeof(Verse.HediffComp);
        }
        public object drainRateFactors;
        public object maxResourceOffsets;
    }

    public class HediffCompProperties_GiveScalingDurationHediff : Verse.HediffCompProperties
    {
        public HediffCompProperties_GiveScalingDurationHediff()
        {
            this.compClass = typeof(Verse.HediffComp);
        }
        public object durationScalar;
        public object hediffDef;
        public object skipIfAlreadyExists;
    }

    public class HediffCompProperties_GiveThoughtsRandomly : Verse.HediffCompProperties
    {
        public HediffCompProperties_GiveThoughtsRandomly()
        {
            this.compClass = typeof(Verse.HediffComp);
        }
        public object mtbDays;
        public object thoughtDefs;
    }

    public class HediffCompProperties_GiveTrait : Verse.HediffCompProperties
    {
        public HediffCompProperties_GiveTrait()
        {
            this.compClass = typeof(Verse.HediffComp);
        }
        public object traitDef;
        public object traitDegree;
    }

    public class HediffCompProperties_IdeoCertaintySeverity : Verse.HediffCompProperties
    {
        public HediffCompProperties_IdeoCertaintySeverity()
        {
            this.compClass = typeof(Verse.HediffComp);
        }
        public object changesToThisOnApostasy;
        public object removeOnApostasy;
    }

    public class HediffCompProperties_InflictHediffOnHit : Verse.HediffCompProperties
    {
        public HediffCompProperties_InflictHediffOnHit()
        {
            this.compClass = typeof(Verse.HediffComp);
        }
        public object appliedViaAttacks;
        public object appliedViaPsycasts;
        public float baseSeverity;
        public bool canAffectFriendlies;
        public bool canAffectMechs;
        public float cellRange;
        public object damageScaling;
        public object hediff;
        public object localizedToHitPart;
        public object victimScalar;
        public float worldTileRange;
    }

    public class HediffCompProperties_InspireOnHit : Verse.HediffCompProperties
    {
        public HediffCompProperties_InspireOnHit()
        {
            this.compClass = typeof(Verse.HediffComp);
        }
        public object appliedViaPsycasts;
        public bool canAffectAnimals;
        public object canAffectHostiles;
        public bool canAffectMechs;
        public float cellRange;
        public object chance;
        public object victimChanceScalar;
        public float worldTileRange;
    }

    public class HediffCompProperties_LightingSeverity : Verse.HediffCompProperties
    {
        public HediffCompProperties_LightingSeverity()
        {
            this.compClass = typeof(Verse.HediffComp);
        }
        public object plusInitialSeverity;
    }

    public class HediffCompProperties_MeditationSeverity : Verse.HediffCompProperties
    {
        public HediffCompProperties_MeditationSeverity()
        {
            this.compClass = typeof(Verse.HediffComp);
        }
        public object medFocusSpeedMatters;
        public object perMeditationTick;
        public object perNotMedTick;
        public object whileNotMeditating;
    }

    public class HediffCompProperties_MoteConditional : Verse.HediffCompProperties
    {
        public HediffCompProperties_MoteConditional()
        {
            this.compClass = typeof(Verse.HediffComp);
        }
        public string mote;
        public object scale;
    }

    public class HediffCompProperties_OnCaravanSeverity : Verse.HediffCompProperties
    {
        public HediffCompProperties_OnCaravanSeverity()
        {
            this.compClass = typeof(Verse.HediffComp);
        }
        public object perOnCaravanTick;
        public object whileInMap;
    }

    public class HediffCompProperties_PhylumMorphsHediff : Verse.HediffCompProperties
    {
        public HediffCompProperties_PhylumMorphsHediff()
        {
            this.compClass = typeof(Verse.HediffComp);
        }
        public object hediffIfEntity;
        public object hediffIfMutant;
    }

    public class HediffCompProperties_PlanetLayerSeverity : Verse.HediffCompProperties
    {
        public HediffCompProperties_PlanetLayerSeverity()
        {
            this.compClass = typeof(Verse.HediffComp);
        }
        public float defaultSeverity;
        public object setToInSpace;
    }

    public class HediffCompProperties_PsyfocusSeverity : Verse.HediffCompProperties
    {
        public HediffCompProperties_PsyfocusSeverity()
        {
            this.compClass = typeof(Verse.HediffComp);
        }
    }

    public class HediffCompProperties_PsyfocusSpentTracker : Verse.HediffCompProperties
    {
        public HediffCompProperties_PsyfocusSpentTracker()
        {
            this.compClass = typeof(Verse.HediffComp);
        }
        public object severityPerPsyfocus;
    }

    public class HediffCompProperties_RelationDependentSeverity : Verse.HediffCompProperties
    {
        public HediffCompProperties_RelationDependentSeverity()
        {
            this.compClass = typeof(Verse.HediffComp);
        }
        public object countNegativeRelations;
    }

    public class HediffCompProperties_SeverityDeterminesVisibility : Verse.HediffCompProperties
    {
        public HediffCompProperties_SeverityDeterminesVisibility()
        {
            this.compClass = typeof(Verse.HediffComp);
        }
        public object invisibleWithin;
    }

    public class HediffCompProperties_SeverityDuringSpecificMentalStates : Verse.HediffCompProperties
    {
        public HediffCompProperties_SeverityDuringSpecificMentalStates()
        {
            this.compClass = typeof(Verse.HediffComp);
        }
        public object anyMentalState;
        public object mentalStates;
        public object severityInState;
    }

    public class HediffCompProperties_SkillAdjustment : Verse.HediffCompProperties
    {
        public HediffCompProperties_SkillAdjustment()
        {
            this.compClass = typeof(Verse.HediffComp);
        }
        public object affectedSkills;
        public object affectsAptitudes;
        public object minLevel;
        public object nullifyingTraits;
        public object skillAdjustment;
        public object statMultiplier;
        public int ticks;
    }

    public class HediffCompProperties_SkillLevelSeverity : Verse.HediffCompProperties
    {
        public HediffCompProperties_SkillLevelSeverity()
        {
            this.compClass = typeof(Verse.HediffComp);
        }
        public object skills;
    }

    public class HediffCompProperties_StunOnHit : Verse.HediffCompProperties
    {
        public HediffCompProperties_StunOnHit()
        {
            this.compClass = typeof(Verse.HediffComp);
        }
        public object appliedViaAttacks;
        public object appliedViaPsycasts;
        public float cellRange;
        public object chance;
        public object minDmgToTrigger;
        public object stunTicksRange;
        public object victimScalar;
        public float worldTileRange;
    }

    public class HediffCompProperties_TemperatureLevelSeverity : Verse.HediffCompProperties
    {
        public HediffCompProperties_TemperatureLevelSeverity()
        {
            this.compClass = typeof(Verse.HediffComp);
        }
        public object changePerTick;
        public object perTempAbove;
        public object perTempBelow;
        public object zeroSeverityAt;
    }

    public class HediffCompProperties_WaterImmersionSeverity : Verse.HediffCompProperties
    {
        public HediffCompProperties_WaterImmersionSeverity()
        {
            this.compClass = typeof(Verse.HediffComp);
        }
        public object baseSeverityCaravan;
        public object rainCountsFor;
        public object severityPerCaravanRiverSize;
    }

    public class HediffCompProperties_WindLevelSeverity : Verse.HediffCompProperties
    {
        public HediffCompProperties_WindLevelSeverity()
        {
            this.compClass = typeof(Verse.HediffComp);
        }
        public object worksEnclosedSpace;
        public object worldMapValue;
    }

    public class NoEMPReaction : Verse.DefModExtension
    {
    }

    public class TraitGrantedStuff : Verse.DefModExtension
    {
        public object forcedBodyTypes;
        public object grantedAbilities;
        public object grantedHediffs;
        public bool hediffsToBrain;
        public object otherHediffsToRemoveOnRemoval;
        public object prisonerResolveFactor;
    }

    public class UnaffectedByDarkness : Verse.DefModExtension
    {
    }

}

namespace HautsTraits
{
    public class HediffCompProperties_ColinWallis : Verse.HediffCompProperties
    {
        public HediffCompProperties_ColinWallis()
        {
            this.compClass = typeof(Verse.HediffComp);
        }
        public object hediffPerClass;
    }

    public class HediffCompProperties_FastHealPermanentWounds : Verse.HediffCompProperties
    {
        public HediffCompProperties_FastHealPermanentWounds()
        {
            this.compClass = typeof(Verse.HediffComp);
        }
    }

    public class HediffCompProperties_IdeoMajoritySeverity : Verse.HediffCompProperties
    {
        public HediffCompProperties_IdeoMajoritySeverity()
        {
            this.compClass = typeof(Verse.HediffComp);
        }
        public object severityWhileInMajority;
        public object severityWhileInMinority;
    }

    public class HediffCompProperties_ManchurianCandidacy : Verse.HediffCompProperties
    {
        public HediffCompProperties_ManchurianCandidacy()
        {
            this.compClass = typeof(Verse.HediffComp);
        }
        public object chance;
        public object faction;
        public object onFactionChangeMessage;
        public object periodicity;
        public float range;
    }

    public class HediffCompProperties_Oneiromancy : Verse.HediffCompProperties
    {
        public HediffCompProperties_Oneiromancy()
        {
            this.compClass = typeof(Verse.HediffComp);
        }
        public object inspirationChancePerStack;
        public object inspireString;
        public object maxInspirationChance;
        public object numStacksToTrigger;
        public object thought;
        public object ticksPerStack;
    }

    public class HediffCompProperties_SuperSpreader : Verse.HediffCompProperties
    {
        public HediffCompProperties_SuperSpreader()
        {
            this.compClass = typeof(Verse.HediffComp);
        }
        public object mtbDays;
    }

    public class HediffCompProperties_WhyAreYouRunning : Verse.HediffCompProperties
    {
        public HediffCompProperties_WhyAreYouRunning()
        {
            this.compClass = typeof(Verse.HediffComp);
        }
        public object mentalState;
        public object triggeringJobs;
    }

    public class PersoneuroformatterScrambler : Verse.DefModExtension
    {
    }

    public class SpecificPNFChargeCost : Verse.DefModExtension
    {
        public object chargeCosts;
    }

    public class SuperPsychicTrait : Verse.DefModExtension
    {
        public string category;
        public string descKey;
        public string descKeyFantasy;
    }

}

namespace HautsTraitsRoyalty
{
    public class BloodRainImmune : Verse.DefModExtension
    {
    }

    public class GrantSkipPsycast : Verse.DefModExtension
    {
    }

    public class GrantWordPsycast : Verse.DefModExtension
    {
    }

    public class HediffCompProperties_AndItsMyOwnHeart : Verse.HediffCompProperties
    {
        public HediffCompProperties_AndItsMyOwnHeart()
        {
            this.compClass = typeof(Verse.HediffComp);
        }
        public object appliedViaAttacks;
        public object appliedViaPsycasts;
        public bool canAffectFriendlies;
        public float cellRange;
        public object extraDamages;
        public object hediffsToRemoveSelf;
        public object victimScalar;
        public float worldTileRange;
    }

    public class HediffCompProperties_AnimalImmunity : Verse.HediffCompProperties
    {
        public HediffCompProperties_AnimalImmunity()
        {
            this.compClass = typeof(Verse.HediffComp);
        }
        public float damageMultiplier;
        public int priority;
    }

    public class HediffCompProperties_Astrology : Verse.HediffCompProperties
    {
        public HediffCompProperties_Astrology()
        {
            this.compClass = typeof(Verse.HediffComp);
        }
        public object boredoms;
        public object likelihood;
        public int ticks;
    }

    public class HediffCompProperties_AuraAllelopathy : Verse.HediffCompProperties
    {
        public HediffCompProperties_AuraAllelopathy()
        {
            this.compClass = typeof(Verse.HediffComp);
        }
        public bool affectsAllies;
        public bool affectsHostiles;
        public string color;
        public object damage;
        public object damageType;
        public object lifeLeech;
        public string mote;
        public object psyfocusLeech;
        public float range;
    }

    public class HediffCompProperties_AuraLadybug : Verse.HediffCompProperties
    {
        public HediffCompProperties_AuraLadybug()
        {
            this.compClass = typeof(Verse.HediffComp);
        }
        public bool affectsAllies;
        public bool affectsHostiles;
        public string color;
        public object exemptFilthTypes;
        public object hediffs;
        public string mote;
        public float range;
    }

    public class HediffCompProperties_AuraMeerkat : Verse.HediffCompProperties
    {
        public HediffCompProperties_AuraMeerkat()
        {
            this.compClass = typeof(Verse.HediffComp);
        }
        public bool affectsAllies;
        public bool affectsHostiles;
        public string color;
        public object hediffs;
        public string mote;
        public float range;
    }

    public class HediffCompProperties_AuraOofOuchOwie : Verse.HediffCompProperties
    {
        public HediffCompProperties_AuraOofOuchOwie()
        {
            this.compClass = typeof(Verse.HediffComp);
        }
        public bool affectsAllies;
        public bool affectsHostiles;
        public bool affectsSelf;
        public string color;
        public object hediffFoe;
        public object hediffs;
        public string mote;
        public float range;
    }

    public class HediffCompProperties_AuraPtar : Verse.HediffCompProperties
    {
        public HediffCompProperties_AuraPtar()
        {
            this.compClass = typeof(Verse.HediffComp);
        }
        public bool affectsAllies;
        public bool affectsHostiles;
        public string color;
        public object hediffBad;
        public object hediffGood;
        public object maxBadSeverity;
        public object minGoodSeverity;
        public string mote;
        public float range;
    }

    public class HediffCompProperties_AuraTerror : Verse.HediffCompProperties
    {
        public HediffCompProperties_AuraTerror()
        {
            this.compClass = typeof(Verse.HediffComp);
        }
        public bool affectsAllies;
        public bool affectsHostiles;
        public bool affectsSelf;
        public object baseFleeChance;
        public string color;
        public object fleeChanceScalar;
        public object fleeDuration;
        public object fleeRange;
        public string iconPath;
        public object mapwideThought;
        public object maxFleeChance;
        public string mote;
        public float range;
        public object tickPeriodicity;
    }

    public class HediffCompProperties_BigBrain : Verse.HediffCompProperties
    {
        public HediffCompProperties_BigBrain()
        {
            this.compClass = typeof(Verse.HediffComp);
        }
        public object allButPsyfocusScalar;
        public object darkKnowledgePerHour;
        public object psyfocusPerHour;
        public object researchPerHour;
        public object skillPerHour;
    }

    public class HediffCompProperties_CarrionSpawn : Verse.HediffCompProperties
    {
        public HediffCompProperties_CarrionSpawn()
        {
            this.compClass = typeof(Verse.HediffComp);
        }
        public object humanlikeChance;
        public object setToOwnFaction;
        public float severityToTrigger;
        public object spawnFleck1;
        public object spawnFleck2;
        public object spawnRadius;
        public object spawnSound;
    }

    public class HediffCompProperties_Chanshi : Verse.HediffCompProperties
    {
        public HediffCompProperties_Chanshi()
        {
            this.compClass = typeof(Verse.HediffComp);
        }
        public object drugAddictionSatisfaction;
        public object needsSatisfied;
        public object periodicity;
        public object satisfiesDrugAddictions;
    }

    public class HediffCompProperties_DamageNegationWraith : Verse.HediffCompProperties
    {
        public HediffCompProperties_DamageNegationWraith()
        {
            this.compClass = typeof(Verse.HediffComp);
        }
        public object fleckOnBlock;
        public int priority;
        public object severityOnHit;
        public object throwDustPuffsOnBlock;
    }

    public class HediffCompProperties_Egregoria : Verse.HediffCompProperties
    {
        public HediffCompProperties_Egregoria()
        {
            this.compClass = typeof(Verse.HediffComp);
        }
        public object periodicity;
        public object severityPerTotalPsylinkLevels;
    }

    public class HediffCompProperties_GlassSquid : Verse.HediffCompProperties
    {
        public HediffCompProperties_GlassSquid()
        {
            this.compClass = typeof(Verse.HediffComp);
        }
        public object healPerSeverity;
        public object rainCountsFor;
        public object severityPerCaravanRiverSize;
    }

    public class HediffCompProperties_HealPermanentWoundsPsyScaling : Verse.HediffCompProperties
    {
        public HediffCompProperties_HealPermanentWoundsPsyScaling()
        {
            this.compClass = typeof(Verse.HediffComp);
        }
        public object ticksToHeal;
    }

    public class HediffCompProperties_InASwaddle : Verse.HediffCompProperties
    {
        public HediffCompProperties_InASwaddle()
        {
            this.compClass = typeof(Verse.HediffComp);
        }
        public float severityToTrigger;
    }

    public class HediffCompProperties_InflictTranscendence : Verse.HediffCompProperties
    {
        public HediffCompProperties_InflictTranscendence()
        {
            this.compClass = typeof(Verse.HediffComp);
        }
        public object MTBDays;
    }

    public class HediffCompProperties_KaboomBaby : Verse.HediffCompProperties
    {
        public HediffCompProperties_KaboomBaby()
        {
            this.compClass = typeof(Verse.HediffComp);
        }
        public object appliedViaPsycasts;
        public float baseSeverity;
        public bool canAffectFriendlies;
        public float cellRange;
        public object explosionDmg;
        public object explosionPeriodicity;
        public object explosionRadius;
        public object explosionType;
        public object hediff;
        public object localizedToHitPart;
        public object victimScalar;
        public float worldTileRange;
    }

    public class HediffCompProperties_KopiLuwak : Verse.HediffCompProperties
    {
        public HediffCompProperties_KopiLuwak()
        {
            this.compClass = typeof(Verse.HediffComp);
        }
        public float severityToTrigger;
        public object spawnFleck1;
        public object spawnFleck2;
        public object spawnInOwnInventory;
        public object spawnRadius;
        public object spawnSound;
        public object spawnedThingAndCountPerTrigger;
    }

    public class HediffCompProperties_Kudzu : Verse.HediffCompProperties
    {
        public HediffCompProperties_Kudzu()
        {
            this.compClass = typeof(Verse.HediffComp);
        }
        public bool affectsAllies;
        public bool affectsHostiles;
        public object bonusPlantGrowth;
        public string color;
        public object hediffs;
        public string mote;
        public float range;
    }

    public class HediffCompProperties_LPMastery : Verse.HediffCompProperties
    {
        public HediffCompProperties_LPMastery()
        {
            this.compClass = typeof(Verse.HediffComp);
        }
        public int psylinkLevel;
        public int skillLevel;
    }

    public class HediffCompProperties_LeWokisme : Verse.HediffCompProperties
    {
        public HediffCompProperties_LeWokisme()
        {
            this.compClass = typeof(Verse.HediffComp);
        }
        public object forcingTraits;
        public object newAwakeningPeriodicity;
    }

    public class HediffCompProperties_Leghorn : Verse.HediffCompProperties
    {
        public HediffCompProperties_Leghorn()
        {
            this.compClass = typeof(Verse.HediffComp);
        }
        public object forcingTraits;
        public string mealDef;
    }

    public class HediffCompProperties_ManaBarrier : Verse.HediffCompProperties
    {
        public HediffCompProperties_ManaBarrier()
        {
            this.compClass = typeof(Verse.HediffComp);
        }
        public object contributingTraits;
        public float damageMultiplier;
        public object fleckOnBlock;
        public int priority;
        public object unaffectedDamageTypes;
    }

    public class HediffCompProperties_MaybeGrantPsylink : Verse.HediffCompProperties
    {
        public HediffCompProperties_MaybeGrantPsylink()
        {
            this.compClass = typeof(Verse.HediffComp);
        }
        public object count;
        public object failLetterLabel;
        public object failLetterText;
        public object failureHediff;
        public object killLetterLabel;
        public object killLetterText;
        public object succeedLetterLabel;
        public object succeedLetterText;
    }

    public class HediffCompProperties_Mosquito : Verse.HediffCompProperties
    {
        public HediffCompProperties_Mosquito()
        {
            this.compClass = typeof(Verse.HediffComp);
        }
        public object appliedViaPsycasts;
        public float baseSeverity;
        public bool canAffectMechs;
        public object canOnlyIncreaseSeverityUpTo;
        public float cellRange;
        public object hediff;
        public object hemogenGainEfficiency;
        public object lifestealEfficiency;
        public object localizedToHitPart;
        public object psyfocusCostScaling;
        public float worldTileRange;
    }

    public class HediffCompProperties_MoteTranscendent : Verse.HediffCompProperties
    {
        public HediffCompProperties_MoteTranscendent()
        {
            this.compClass = typeof(Verse.HediffComp);
        }
        public string mote;
        public object mustBeTranscendent;
        public object scale;
        public object validRange;
    }

    public class HediffCompProperties_MutantImmunity : Verse.HediffCompProperties
    {
        public HediffCompProperties_MutantImmunity()
        {
            this.compClass = typeof(Verse.HediffComp);
        }
        public float damageMultiplier;
        public int priority;
    }

    public class HediffCompProperties_NeuralHeatShield : Verse.HediffCompProperties
    {
        public HediffCompProperties_NeuralHeatShield()
        {
            this.compClass = typeof(Verse.HediffComp);
        }
        public string color;
        public object displayUnderSeverity;
        public object drawSize;
    }

    public class HediffCompProperties_Oxpeck : Verse.HediffCompProperties
    {
        public HediffCompProperties_Oxpeck()
        {
            this.compClass = typeof(Verse.HediffComp);
        }
        public object appliedViaPsycasts;
        public float baseSeverity;
        public bool canAffectAnimals;
        public bool canAffectEntities;
        public bool canAffectHumanlikes;
        public bool canAffectMechs;
        public bool canAffectMutants;
        public float cellRange;
        public object hediffMean;
        public object hediffNice;
        public object tameMTBcurve;
        public object tameMTBdaysBase;
    }

    public class HediffCompProperties_PitohuiPurgeOnHit : Verse.HediffCompProperties
    {
        public HediffCompProperties_PitohuiPurgeOnHit()
        {
            this.compClass = typeof(Verse.HediffComp);
        }
        public object appliedViaPsycasts;
        public float cellRange;
        public object hediffsToCure;
        public object severityLostOnCure;
        public object totallyRemoveOnCure;
        public object victimScalar;
        public float worldTileRange;
    }

    public class HediffCompProperties_PsiDisruptor : Verse.HediffCompProperties
    {
        public HediffCompProperties_PsiDisruptor()
        {
            this.compClass = typeof(Verse.HediffComp);
        }
        public bool affectsHostiles;
        public bool affectsSelf;
        public string color;
        public string mote;
        public float range;
        public object scanByPawnListerNotByGrid;
    }

    public class HediffCompProperties_PsiEmitter : Verse.HediffCompProperties
    {
        public HediffCompProperties_PsiEmitter()
        {
            this.compClass = typeof(Verse.HediffComp);
        }
        public float severityToTrigger;
        public object spawnInOwnInventory;
        public object spawnRadius;
        public object spawnedThingAndCountPerTrigger;
    }

    public class HediffCompProperties_PsychicWisdom : Verse.HediffCompProperties
    {
        public HediffCompProperties_PsychicWisdom()
        {
            this.compClass = typeof(Verse.HediffComp);
        }
        public object chanceToAwaken;
    }

    public class HediffCompProperties_PupilOfTheGrave : Verse.HediffCompProperties
    {
        public HediffCompProperties_PupilOfTheGrave()
        {
            this.compClass = typeof(Verse.HediffComp);
        }
        public object corpseSearchRadius;
        public float damageMultiplier;
        public object fleckOnBlock;
        public int priority;
        public object throwDustPuffsOnBlock;
    }

    public class HediffCompProperties_Scarab : Verse.HediffCompProperties
    {
        public HediffCompProperties_Scarab()
        {
            this.compClass = typeof(Verse.HediffComp);
        }
        public object fleckOnBlock;
        public object percentNeuralHeatOnHit;
        public int priority;
        public object severityOnHit;
        public object switchToOnBreak;
        public object throwDustPuffsOnBlock;
    }

    public class HediffCompProperties_SkillCopier : Verse.HediffCompProperties
    {
        public HediffCompProperties_SkillCopier()
        {
            this.compClass = typeof(Verse.HediffComp);
        }
        public bool affectsAllies;
        public bool affectsHostiles;
        public object baseXPgainPerPeriod;
        public string color;
        public object effectScalar;
        public string mote;
        public float range;
        public object tickPeriodicity;
    }

    public class HediffCompProperties_Sylar : Verse.HediffCompProperties
    {
        public HediffCompProperties_Sylar()
        {
            this.compClass = typeof(Verse.HediffComp);
        }
        public object forcingTraits;
    }

    public class HediffCompProperties_TMN : Verse.HediffCompProperties
    {
        public HediffCompProperties_TMN()
        {
            this.compClass = typeof(Verse.HediffComp);
        }
        public object harmfulDamageTypesOnly;
        public object hediffSelf;
        public int priority;
    }

    public class HediffCompProperties_TechnopathicControl : Verse.HediffCompProperties
    {
        public HediffCompProperties_TechnopathicControl()
        {
            this.compClass = typeof(Verse.HediffComp);
        }
        public object appliedViaPsycasts;
        public float baseSeverity;
        public bool canAffectAnimals;
        public bool canAffectHumanlikes;
        public float cellRange;
        public object chancesPerWeight;
        public object hediff;
        public float worldTileRange;
    }

    public class HediffCompProperties_ThoughtsInChaos : Verse.HediffCompProperties
    {
        public HediffCompProperties_ThoughtsInChaos()
        {
            this.compClass = typeof(Verse.HediffComp);
        }
        public object appliedViaPsycasts;
        public bool canAffectFriendlies;
        public float cellRange;
        public object chance;
        public object chanceCap;
        public object chancePerVictimPsylink;
        public object mbList;
        public object psylinkChanceMin;
        public object victimChanceScalar;
        public float worldTileRange;
    }

    public class HediffCompProperties_Transcendenceinator : Verse.HediffCompProperties
    {
        public HediffCompProperties_Transcendenceinator()
        {
            this.compClass = typeof(Verse.HediffComp);
        }
        public object aboutTransingStrings;
        public object aboutTransingStringsMonolithRequired;
        public object severityPerPsyfocus;
        public object ticksToReset;
    }

    public class HediffCompProperties_WithATasteOfYourLips : Verse.HediffCompProperties
    {
        public HediffCompProperties_WithATasteOfYourLips()
        {
            this.compClass = typeof(Verse.HediffComp);
        }
        public object baseHediffSeverity;
        public object baseRetaliationDamage;
        public object baseRetaliationDamageFactor;
        public object chanceToDoDamage;
        public object chanceToInflictHediff;
        public object damageScaleWithDamage;
        public object hediff;
        public object hediffResistStat;
        public object hediffScaleWithBodySize;
        public object hediffScaleWithDamage;
        public object hitInstigatorRegardlessOfRange;
        public int priority;
        public float range;
        public object retaliationDamageDef;
        public object vfxCooldownTicks;
        public object visualEffect;
    }

    public class RemovedOnAwakening : Verse.DefModExtension
    {
        public object awakenChance;
    }

    public class VerbCompProperties_StandPower : Verse.DefModExtension
    {
        public string compClass;
        public object hediff;
        public object text;
    }

}

namespace MVCF.Comps
{
    public class HediffCompProperties_ExtendedVerbGiver : Verse.HediffCompProperties
    {
        public HediffCompProperties_ExtendedVerbGiver()
        {
            this.compClass = typeof(Verse.HediffComp);
        }
        public object verbProps;
        public object verbs;
    }

}

namespace MVCF.VerbComps
{
    public class VerbCompProperties_Turret : Verse.DefModExtension
    {
        public string compClass;
        public bool invisible;
        public object uniqueTargets;
    }

}

namespace More_Traits.ModExtensions
{
    public class BOT_HediffExtension : Verse.DefModExtension
    {
        public object stageColors;
        public object traitDef;
    }

    public class BOT_MentalStateExtension : Verse.AI.MentalState
    {
        public object traitDef;
    }

    public class BOT_TraitExtension : Verse.DefModExtension
    {
        public object hediffDef;
    }

}

namespace TraitTracker
{
    public class TraitCompProperties_SocialInteraction : Verse.DefModExtension
    {
        public object chance;
        public object checkInterval;
        public object interaction;
    }

}

namespace VFECore
{
    public class HediffCompProperties_Targeting : Verse.HediffCompProperties
    {
        public HediffCompProperties_Targeting()
        {
            this.compClass = typeof(Verse.HediffComp);
        }
        public bool neverMiss;
    }

}
