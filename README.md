# STAF.LLMEval sample

Testing non-deterministic LLM output with brittle string-equality asserts does not scale. STAF.LLMEval gives you pluggable metrics, LLM-as-judge, and RAG groundedness checks that run in CI.

This repository is a small public consumer of the published NuGet package. It is separate from the library source so NuGet can list it under GitHub repositories that use [STAF.LLMEval](https://www.nuget.org/packages/STAF.LLMEval).

```xml
<PackageReference Include="STAF.LLMEval" Version="2.2.0" />
```

Pinned to **2.2.0**, the latest release on NuGet that restores on its own. Published 3.x packages depend on `STAF.LLMEval.Core`, which is not on nuget.org yet, so a 3.2.1 reference does not restore. Bump this version after 3.3.0 and its dependencies are published.

The smoke tests use zero-key direct checks only: exact match, keyword overlap, and TF-IDF semantic similarity. No API key is required.

```bash
dotnet test
```

Library source and the full API: [sooraj171/LLMEval](https://github.com/sooraj171/LLMEval).
