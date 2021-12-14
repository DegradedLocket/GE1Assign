using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "TrackPieceData")]
public class TrackPieceData : ScriptableObject
{
    public enum Direction
    {
        Straight, Left, Right
    }

    public Vector2 pieceSize = new Vector2(10f,10f);

    public GameObject[] levelPieces;
    public Direction dir;
    
}
