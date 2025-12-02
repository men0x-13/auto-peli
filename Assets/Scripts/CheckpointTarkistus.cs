using UnityEngine;

public class CheckpointTarkistus : MonoBehaviour
{

    public int checkpointCount = 4;

    public bool[] visited;
    private int visitedCount;

    public int laps = -1;

    public void Awake()
    {
        ResetLap();
    }

    public void ResetLap()
    {
        visited = new bool[checkpointCount];
        visitedCount = 0;
        laps++;
    }

    public void MarkVisited(int index)
    {
        if (!visited[index])
        {
            visited[index] = true;
            visitedCount++;
        }
    }

    public bool CanWin()
    {
        if (checkpointCount == visitedCount)
        {
            return true;
        }
        return false;
    }
    

}