# Selection From Menu

```mermaid

sequenceDiagram

actor Player

Player->>Console: 1. Completes a game session
Console-->>Console: 2. Calculates score
Console->>Console: 3. Updates the player's score and stores it
Console->>Player: 4. Displays the player's updated score

```
