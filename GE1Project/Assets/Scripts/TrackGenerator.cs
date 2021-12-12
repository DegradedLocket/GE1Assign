using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrackGenerator : MonoBehaviour
{

    public TrackPieceData[] trackPieceData;
    public TrackPieceData firstPiece;

    private TrackPieceData prevPiece;

    public Vector3 spawnOrg;

    private Vector3 spawnPos;
    // Start is called before the first frame update
    void Start()
    {
        prevPiece = firstPiece;

        for (int i = 0; i < length; i++)
        {
            //spawn track
        }
    }


    // Update is called once per frame
    void Update()
    {
        
    }

    //select which piece will come next
    TrackPieceData GetNextPiece()
    {
        List<TrackPieceData> eligbleTrackPiece = new List<TrackPieceData>();

        TrackPieceData.Direction nextDir = TrackPieceData.Direction.North;

        switch (prevPiece.endDir)
        {
            case TrackPieceData.Direction.North:
            case TrackPieceData.Direction.South:
            case TrackPieceData.Direction.East:
            case TrackPieceData.Direction.West:
            default:
        }
    }
}
