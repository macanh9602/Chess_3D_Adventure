using System.Collections;
using System.Collections.Generic;
using Sirenix.OdinInspector;
using UnityEngine;

namespace ChessMaster.Core
{
    public class Board : MonoBehaviour
    {
        public const int Size = 8;
        [SerializeField] private Cell[,] cells = new Cell[8, 8];
        public Cell[,] Cells => cells;
        public Board()
        {
            for (int x = 0; x < Size; x++)
            {
                for (int y = 0; y < Size; y++)
                {
                    cells[x, y] = new Cell(x, y);
                }
            }
        }

        public Cell GetCell(int x, int y)
        {
            if (x < 0 || x >= Size || y < 0 || y >= Size) return null;
            return cells[x, y];
        }
    }
}
