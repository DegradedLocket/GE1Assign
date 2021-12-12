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
        TrackPieceData nextPiece = null;

        TrackPieceData.Direction nextDir = TrackPieceData.Direction.North;

        switch (prevPiece.endDir)
        {
            case TrackPieceData.Direction.North:
                nextDir = TrackPieceData.Direction.South;
                spawnPos = spawnPos + new Vector3(0f, 0, prevPiece.pieceSize.y);
                break;
            case TrackPieceData.Direction.South:
                nextDir = TrackPieceData.Direction.North;
                spawnPos = spawnPos + new Vector3(0, 0, -prevPiece.pieceSize.y);
                break;
            case TrackPieceData.Direction.East:
                nextDir = TrackPieceData.Direction.West;
                spawnPos = spawnPos + new Vector3(prevPiece.pieceSize.x, 0, 0);
                break;
            case TrackPieceData.Direction.West:
                nextDir = TrackPieceData.Direction.East;
                spawnPos = spawnPos + new Vector3(-prevPiece.pieceSize.x, 0, 0);
                break;
            default:
                break;
        }
    }

    void SpawnPiece()
    {
        TrackPieceData trackToSpawn = GetNextPiece();

        GameObject objFromTrack = trackToSpawn.levelPieces[Random.Range(0, trackToSpawn.levelPieces.Length)];
        prevPiece = trackToSpawn;

        Instantiate(objFromTrack, spawnPos + spawnOrg, Quaterion.identity);
    }

    public void UpdateSpawnOrg(Vector3 orgDelta)
    {
        spawnOrg = spawnOrg + orgDelta;
    }
}
