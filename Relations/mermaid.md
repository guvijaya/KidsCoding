::: mermaid
graph LR
    A[Me] -- Parent --> B[Mother]
    A -- Parent --> C[Father]
    B -- Spouse --> C
    B -- Child --> D[Sibling]
    C -- Child --> D
    D -- Spouse --> E[Sister-in-law]
    D -- Child --> F[Niece/Nephew]
    A -- Spouse --> G[Partner]
    G -- Child --> H[Child]
