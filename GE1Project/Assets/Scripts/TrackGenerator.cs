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

    private Vector3 spawnRot;
    private Quaternion spawnRotQ;

    //num of pieces to spawn when game starts
    public int initSpawn = 10;
    // Start is called before the first frame update
    void Start()
    {
        prevPiece = firstPiece;

        spawnOrg = spawnPos;

        for (int i = 0; i < initSpawn; i++)
        {
            SpawnPiece();
        }
    }


    // Update is called once per frame
    void Update()
    {
         if (Input.GetKeyDown(KeyCode.T))
        {
            SpawnPiece();
        }
    }

    //select which piece will come next
    TrackPieceData GetNextPiece()
    {
        List<TrackPieceData.Direction> eligbleTrackPiece = new List<TrackPieceData.Direction>();
        TrackPieceData nextPiece = null;

        TrackPieceData.Direction nextDir = TrackPieceData.Direction.Straight;

        switch (prevPiece.dir)
        {
            case TrackPieceData.Direction.Straight:
                //nextDir = TrackPieceData.Direction.South;
                eligbleTrackPiece.Add(TrackPieceData.Direction.Left);
                eligbleTrackPiece.Add(TrackPieceData.Direction.Right);
                eligbleTrackPiece.Add(TrackPieceData.Direction.Left);

                spawnPos = spawnPos + new Vector3(20, 0, 0);
                spawnRot = spawnRot + new Vector3(0,0,0);
                break;
            case TrackPieceData.Direction.Left:
                //nextDir = TrackPieceData.Direction.North;
                eligbleTrackPiece.Add(TrackPieceData.Direction.Right);
                eligbleTrackPiece.Add(TrackPieceData.Direction.Straight);
                
                spawnPos = spawnPos + new Vector3(0, 0, 20);

                spawnRot = spawnRot + new Vector3(0,-90,0);
                break;
            case TrackPieceData.Direction.Right:
                //nextDir = TrackPieceData.Direction.West;
                eligbleTrackPiece.Add(TrackPieceData.Direction.Left);
                eligbleTrackPiece.Add(TrackPieceData.Direction.Straight);

                spawnPos = spawnPos + new Vector3(0, 0, -20);
                spawnRot = spawnRot +  new Vector3(0,90,0);
                break;
            /*case TrackPieceData.Direction.West:
                nextDir = TrackPieceData.Direction.East;
                spawnPos = spawnPos + new Vector3(-prevPiece.pieceSize.x, 0, 0);
                break;*/
            default:
                break;
        }

        

        nextDir = eligbleTrackPiece[Random.Range(0, eligbleTrackPiece.Count)];

        for (int i = 0; i < trackPieceData.Length; i++)
        {
            if(trackPieceData[i].dir == nextDir)
            {
                nextPiece = trackPieceData[i];
            }
        }

        return nextPiece;
    }

    void SpawnPiece()
    {
        TrackPieceData trackToSpawn = GetNextPiece();

        GameObject objFromTrack = trackToSpawn.levelPieces[Random.Range(0, trackToSpawn.levelPieces.Length)];
        prevPiece = trackToSpawn;

        spawnRotQ = Quaternion.Euler(spawnRot);

        Instantiate(objFromTrack, spawnPos + spawnOrg, spawnRotQ);
    }

    public void UpdateSpawnOrg(Vector3 orgDelta)
    {
        
        spawnOrg = spawnOrg + orgDelta;
    }
}
