# 🛡️ Unified Traits Reimagined (RimWorld 1.5 & 1.6)

[![RimWorld Supported Versions](https://img.shields.io/badge/RimWorld-1.5%20%7C%201.6-brightgreen.svg)](https://rimworldgame.com/)
[![License](https://img.shields.io/badge/License-MIT-blue.svg)](LICENSE)
[![Build Status](https://img.shields.io/badge/Build-Passing-success.svg)]()

**Unified Traits Reimagined** é a unificação completa, reimplementada do zero e otimizada de **16 mods populares de traits do RimWorld**. 

Em vez de carregar múltiplos mods com sobreposição de patches, erros de log e arquivos duplicados, este mod traz uma **arquitetura limpa em C#**, mais de **730+ TraitDefs normalizados**, **640+ ThoughtDefs**, **550+ HediffDefs** e um **Engine de Evolução Dinâmica de Traits**.

---

## 🌟 Principais Recursos

- ⚙️ **Painel de Configurações no Jogo (Mod Settings UI)**:
  - Ative ou desative individualmente módulos temáticos (Fallout, Darkest Dungeon, Heróis/Deuses, CK3, The Sims, Sinergias).
  - Ajuste a velocidade da evolução dinâmica de traits e frequências de estresse.

- 🧬 **Engine de Evolução Dinâmica (`UnifiedTraits.Dynamic`)**:
  - Colonos podem ganhar, evoluir ou perder traits com base em eventos de vida, estresse extremo, resiliência e relacionamentos.
  - Sistema de aflições e virtudes estilo Darkest Dungeon disparado por quebras mentais e estados emocionais críticos.

- ⚔️ **Sinergias de Traits (`UnifiedTraits.Synergies`)**:
  - Avaliador periódico otimizado em C# (sem impacto no FPS) que concede modificadores integrados quando colonos possuem combinações complementares de traits.

- 🌐 **Compatibilidade Multiversão & DLCs**:
  - Suporte nativo ao **RimWorld 1.5 e 1.6**.
  - Integração graciosa com todas as expansões DLC (Biotech, Royalty, Ideology, Anomaly).
  - Suporte total de localização em **Português (PT-BR)** e **Inglês**.

---

## 🛠️ Requisitos de Instalação

### Requisitos Obrigatórios
1. **RimWorld** (Versão 1.5 ou 1.6)
2. **Harmony** (`brrainz.harmony`)

### Instalação Manual
1. Baixe o pacote da release mais recente (`UnifiedTraits_v1.0.0.zip`).
2. Extraia o conteúdo diretamente no seu diretório `RimWorld/Mods/`.
3. Ative o mod **Harmony** no topo da lista de carregamento do RimWorld, seguido de **Unified Traits Reimagined**.

---

## 📂 Estrutura do Projeto

```text
UnifiedTraits/
├── About/
│   └── About.xml                       # Manifesto do RimWorld 1.5/1.6
├── LoadFolders.xml                     # Mapeamento multiversão 1.5 e 1.6
├── 1.5/ & 1.6/
│   ├── Assemblies/
│   │   └── UnifiedTraits.dll            # Biblioteca C# compilada (.NET SDK)
│   ├── Defs/
│   │   ├── TraitDefs/                  # 732 TraitDefs normalizados (prefixo UT_)
│   │   ├── ThoughtDefs/                # 649 ThoughtDefs
│   │   ├── HediffDefs/                 # 554 HediffDefs
│   │   ├── MentalStateDefs/            # 30 MentalStateDefs
│   │   └── StatDefs/                   # 8 StatDefs
│   └── Languages/                      # Localização PT-BR e EN
└── Source/                             # Código Fonte C#
```

---

## 📜 Licença

Distribuído sob a licença MIT. Consulte `LICENSE` para obter mais detalhes.
