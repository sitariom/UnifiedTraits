# Changelog — Unified Traits Reimagined

Todas as alterações notáveis neste projeto serão documentadas neste arquivo.

O formato é baseado em [Keep a Changelog](https://keepachangelog.com/pt-BR/1.0.0/),
e este projeto adere ao [Semantic Versioning](https://semver.org/lang/pt-BR/).

---

## [1.0.0] - 2026-07-20

### Adicionado (Added)
- **Lançamento Inicial da Reimplementação Unificada**:
  - Consolidação e reimplementação do zero dos 16 mods do repositório original.
  - Inclusão de **732 TraitDefs**, **649 ThoughtDefs**, **554 HediffDefs**, **30 MentalStateDefs** e **8 StatDefs**.
  - Normalização universal com prefixo `UT_` para prevenção total de colisões de `defName`.
- **Painel de Opções (Mod Settings UI)**:
  - Classe `UnifiedTraitsSettings` permitindo toggles de ativamento/desativamento de temas (Fallout, Darkest Dungeon, Heróis/Deuses, CK3, Sims, Sinergias).
  - Sliders para controle do multiplicador de velocidade da evolução dinâmica de traits.
- **Engine C# de Evolução Dinâmica (`UnifiedTraits.Dynamic`)**:
  - `PawnTraitTracker` GameComponent para rastreamento de eventos e estados emocionais em tempo de execução.
  - `StressVirtueAfflictionHandler` para virtudes e aflições dinâmicas disparadas por estresse e quebras mentais estilo Darkest Dungeon.
- **Sinergias de Traits (`UnifiedTraits.Synergies`)**:
  - `SynergyEvaluator` para conceder modificadores e hediffs aos colonos quando possuem combinações de traits compatíveis.
- **Patches do Harmony (`UnifiedTraits.HarmonyPatches`)**:
  - Patches cirúrgicos em `Pawn_InteractionsTracker` (interações sociais CK3/Sims) e `MentalBreakWorker` (aflições de estresse).
- **Suporte Multiversão & Localização**:
  - Estrutura `LoadFolders.xml` com suporte nativo ao **RimWorld 1.5 e 1.6**.
  - Suporte completo aos idiomas **Português (PT-BR)** e **Inglês**.

### Alterado (Changed)
- Substituição de dezenas de bibliotecas fragmentadas por uma única DLL compilada em C# 11 (.NET Framework 4.8) sem avisos ou erros.
