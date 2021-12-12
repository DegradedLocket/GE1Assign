using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrackPieceData : MonoBehaviour
{
    enum Direction
    {
        North, South, East, West
    }

    public Vector2 pieceSize = new Vector2(10f,10f);
    
    public GameObject[] levelPieces;
    public Direction startDir;
    public Direction endDir;
}
