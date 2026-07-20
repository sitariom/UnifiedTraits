# Changelog — Unified Traits Reimagined

Todas as alterações notáveis neste projeto serão documentadas neste arquivo.

O formato é baseado em [Keep a Changelog](https://keepachangelog.com/pt-BR/1.0.0/),
e este projeto adere ao [Semantic Versioning](https://semver.org/lang/pt-BR/).

---

## [1.1.0] - 2026-07-20

### Adicionado (Added)
- **Camada de Compatibilidade Completa de Namespaces C#**:
  - Implementadas **314 classes C#** customizadas dentro de `Source/UnifiedTraits/Compatibility/ModCompatibilityClasses.cs`.
  - Cobertura integral de todos os `workerClass`, `stateClass`, `compClass` e atributos `Class` dos namespaces originais (`VanillaTraitsExpanded`, `HautsTraits`, `HautsFramework`, `HautsTraitsRoyalty`, `More_Traits`, `SimsTraits`, `MoloyTraits`, `TraitsPlus`, `Gewen_AdditionalTraits`, `TraitTracker`).
- **Inclusão de MentalBreakDefs Nativos**:
  - Adicionado `MentalBreakDefs_UnifiedTraits.xml` em `1.5/` e `1.6/` definindo `MentalBreakDef`s para quebras mentais e aflições dinâmicas (`UT_VTE_TechnophobeTantrum`, `UT_VTE_PanicFreezing`, `UT_VTE_Kleptomaniac`, `UT_BOT_ClaustrophobicBreak`, `UT_HVT_HumanityBreak`).
- **Expansão de Patches Harmony (`UnifiedTraits.HarmonyPatches`)**:
  - Adicionados `Patch_StatWorker`, `Patch_Pawn_HealthTracker`, `Patch_Pawn_SkillTracker`, `Patch_QualityUtility` e `Patch_TraitSet`.

### Corrigido (Fixed)
- **Resolução de Cross-References XML**:
  - Resoluções completas em `<conflictingTraits>`, `<requiredTraits>`, `<nullifyingTraits>` e `<theOnlyAllowedMentalBreaks>`.
- **Normalização da Sintaxe `<skillGains>`**:
  - Substituição da estrutura invalida `<li><key>Skill</key><value>+Val</value></li>` pela sintaxe oficial de dicionário RimWorld `<SkillName>Val</SkillName>`.
- **Estatísticas Vanilla**:
  - Substituição de `HungerRateMultiplier` por `HungerRateFactor`.

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
