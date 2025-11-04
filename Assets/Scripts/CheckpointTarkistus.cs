using UnityEngine;

public class CheckpointTarkistus : MonoBehaviour
{

    public int checkpointCount = 4;

    public bool[] visited;
    private int visitedCount;

    public void Awake()
    {
        ResetLap();
    }

    public void ResetLap()
    {
        visited = new bool[checkpointCount];
        visitedCount++;
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