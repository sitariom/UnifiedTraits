using RimWorld;
using Verse;

namespace UnifiedTraits.Definitions
{
    [DefOf]
    public static class UnifiedTraitsDefOf
    {
        static UnifiedTraitsDefOf()
        {
            DefOfHelper.EnsureInitializedInCtor(typeof(UnifiedTraitsDefOf));
        }

        // DefOf placeholders que serão vinculados aos TraitDefs e HediffDefs durante a Fase 2/3
    }
}
