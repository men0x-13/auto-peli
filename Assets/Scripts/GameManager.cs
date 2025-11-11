using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{

    public static GameManager Instance;

    public TextMeshProUGUI lapText;
    [SerializeField] private CheckpointTarkistus playerCheckpointCT;

    void Awake()
    {
        if (Instance != null && Instance != this) { Destroy(gameObject); return; }
        Instance = this;
        DontDestroyOnLoad(gameObject);
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        lapText.text = "lap: " + playerCheckpointCT.laps.ToString() + "/3";
    }
}
