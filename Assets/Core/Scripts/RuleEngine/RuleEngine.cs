using System.Collections;
using System.Collections.Generic;
using ChessMaster.Core;
using UnityEngine;

public interface IMoveRule
{
    bool IsMoveValid(Board board, Cell from, Cell to);
}

public class PawnMoveRule : IMoveRule
{
    public bool IsMoveValid(Board board, Cell from, Cell to)
    {
        // Implement pawn-specific move validation logic here
        return false;
    }
}

public class KnightMoveRule : IMoveRule
{
    public bool IsMoveValid(Board board, Cell from, Cell to)
    {
        // Implement knight-specific move validation logic here
        return true;
    }
}

public class BishopMoveRule : IMoveRule
{
    public bool IsMoveValid(Board board, Cell from, Cell to)
    {
        // Implement bishop-specific move validation logic here
        return true;
    }
}

public class RookMoveRule : IMoveRule
{
    public bool IsMoveValid(Board board, Cell from, Cell to)
    {
        // Implement rook-specific move validation logic here
        return true;
    }
}

public class QueenMoveRule : IMoveRule
{
    public bool IsMoveValid(Board board, Cell from, Cell to)
    {
        // Implement queen-specific move validation logic here
        return true;
    }
}

public class KingMoveRule : IMoveRule
{
    public bool IsMoveValid(Board board, Cell from, Cell to)
    {
        // Implement king-specific move validation logic here
        return true;
    }
}

