using Verse;

namespace UnifiedTraits.Core
{
    [StaticConstructorOnStartup]
    public static class UnifiedTraitsStartupLogger
    {
        static UnifiedTraitsStartupLogger()
        {
            Log.Message("[UnifiedTraits] Unified Traits Reimagined finalizou o carregamento de inicialização com sucesso. Todas as mecânicas, sinergias e traits estão ativas.");
        }
    }
}
