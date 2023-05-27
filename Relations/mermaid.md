``` mermaid
graph LR
    A[Men] -- Mom --> B[Mother]    
    A -- Spouse --> S1[Wife]
    subgraph mom side relativives
    B -- Mom --> C[Grandma]
    C -- Spouse --> D[Grandpa]
    C -- son --> E(uncle)
    C -- daughter --> F(aunt)
    end
    subgraph Dad side relativives
    B -- Spouse --> D1[Father]
    D1 -- Mom --> D2[Grandma]
    D2 -- Spouse --> D3[Grandpa]
    D2 -- son --> D4(uncle)
    D2 -- daughter --> D5(aunt)
    end
    subgraph Spouse side relativives
    S1 -- Mom --> S2[Mother-in-law]
    S2 -- Spouse --> S3[Father-in-law]
    S2 -- son --> S4(brother-in-law)
    S2 -- daughter --> S5(sister=in-law)
    end
    subgraph Family
    A -- Son  --> F1[Son]
    S1 -- Son --> F1[Son]
    A -- daughter  --> F2[Daughter]
    S1 -- daughter  --> F2[Daughter]
    end
