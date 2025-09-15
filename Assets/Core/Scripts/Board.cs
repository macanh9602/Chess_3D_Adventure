using System.Collections;
using System.Collections.Generic;
using Sirenix.OdinInspector;
using UnityEngine;

namespace ChessMaster.Core
{
    public class Board : MonoBehaviour
    {
        [SerializeField] private Cell[,] cells = new Cell[8, 8];

        public bool IsCellEmpty(Cell cell)
        {
            return cell.OccupiedPiece == null;
        }
    }
}
