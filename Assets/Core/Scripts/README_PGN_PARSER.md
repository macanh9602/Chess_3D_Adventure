# Chess PGN Parser - Usage Guide

## Overview

This implementation provides complete functionality to generate chess boards from algebraic notation strings (PGN format) as requested. The example sequence `d4 d5 c4 e6 Nc3 Nf6 Bg5 Be7 cxd5 exd5 e3 Bf5 Bd3 Bxd3 Qxd3 c6 Nge2 Nbd7 f3 O-O h4 h6 Bf4 Re8 g4 Nf8 g5 hxg5 hxg5 N6h7 O-O-O Bxg5 Rdg1 Bxf4 Nxf4 Qe7 Kd2 Nf6 Rg2 g6 Nxg6 Nxg6 f4 Ne4+ Nxe4 dxe4 Qe2 Qb4+ Kc2 Qb5 Qg4 Qd3+ Kc1 Qxe3+ Kb1 Qd3+ Ka1 Qxd4` is fully supported.

## How to Use

### Method 1: GameManager API (Recommended)

```csharp
using ChessMaster.Core;

// Create a game manager instance
GameManager gameManager = new GameManager();

// Generate board from PGN string
string moveSequence = "d4 d5 c4 e6 Nc3 Nf6 Bg5 Be7 cxd5 exd5 e3 Bf5";
gameManager.GenerateBoardFromPGN(moveSequence);

// Get visual representation of the board
string boardVisualization = gameManager.GetBoardVisualization();
Debug.Log(boardVisualization);

// Access individual pieces
Piece pieceAtD4 = gameManager.Board.GetCell(3, 3).OccupiedPiece; // d4 = (3,3)
if (pieceAtD4 != null)
{
    Debug.Log($"Piece at d4: {pieceAtD4.Type} ({pieceAtD4.Color})");
}
```

### Method 2: BoardRenderer Integration

In the Unity Inspector:

1. Add the `BoardRenderer` component to a GameObject
2. Set `usePGN = true` 
3. Enter your PGN moves in the `pgnMoves` text area:
   ```
   d4 d5 c4 e6 Nc3 Nf6 Bg5 Be7 cxd5 exd5 e3 Bf5 Bd3 Bxd3 Qxd3 c6
   ```
4. Run the scene - the board will automatically generate with pieces placed according to the moves

### Method 3: Direct Parser Usage

```csharp
using ChessMaster.Core;

// Create board and parser
Board board = new Board();
AlgebraicNotationParser parser = new AlgebraicNotationParser(board);

// Parse and apply moves
string moves = "d4 d5 c4 e6 Nc3 Nf6";
parser.ParseAndApplyMoves(moves);

// Access the board directly
for (int x = 0; x < 8; x++)
{
    for (int y = 0; y < 8; y++)
    {
        Piece piece = board.Cells[x, y].OccupiedPiece;
        if (piece != null)
        {
            Debug.Log($"Piece at ({x},{y}): {piece.Type} ({piece.Color})");
        }
    }
}
```

## Supported Notation

### Basic Moves
- `d4` - Pawn to d4
- `Nf3` - Knight to f3  
- `Bb5` - Bishop to b5
- `Qd8` - Queen to d8
- `Kf1` - King to f1
- `Ra1` - Rook to a1

### Captures
- `cxd5` - Pawn on c-file captures on d5
- `Bxf7` - Bishop captures on f7
- `Qxd8` - Queen captures on d8

### Castling
- `O-O` - King-side castling
- `O-O-O` - Queen-side castling

### Disambiguation
- `Nbd7` - Knight from b-file to d7
- `R1a3` - Rook from 1st rank to a3
- `Nge2` - Knight from g-file to e2

### Check/Checkmate
- `Qh5+` - Queen to h5 with check
- `Rd8#` - Rook to d8 with checkmate

## Coordinate System

The implementation uses a standard coordinate system:
- `a1` = Array position `(0, 0)` = Bottom-left corner
- `h1` = Array position `(7, 0)` = Bottom-right corner  
- `a8` = Array position `(0, 7)` = Top-left corner
- `h8` = Array position `(7, 7)` = Top-right corner

## Board Visualization Format

The `GetBoardVisualization()` method returns a string like:

```
   a b c d e f g h
8: r n b q k b n r
7: p p p p . p p p
6: . . . . p . . .
5: . . . p . . . .
4: . . P P . . . .
3: . . N . . . . .
2: P P . . P P P P
1: R N B Q K B N R
```

Where:
- Uppercase letters = White pieces (P=Pawn, R=Rook, N=Knight, B=Bishop, Q=Queen, K=King)
- Lowercase letters = Black pieces (p=pawn, r=rook, n=knight, b=bishop, q=queen, k=king)  
- `.` = Empty square

## Testing

Run the included test:

```csharp
// Add PGNParserTest component to a GameObject
PGNParserTest test = gameObject.AddComponent<PGNParserTest>();

// Or call directly in code
test.TestPGNParser();
```

This will test both simple and complex move sequences and output the results to the Unity console.

## Files Added/Modified

- `Assets/Core/Scripts/AlgebraicNotationParser.cs` (NEW)
- `Assets/Core/Scripts/GameManager.cs` (MODIFIED - added PGN methods)
- `Assets/Core/Scripts/View/BoardRenderer.cs` (MODIFIED - added PGN support)  
- `Assets/Core/Scripts/PGNParserTest.cs` (NEW)

The implementation maintains full compatibility with existing code while adding the requested PGN parsing functionality.