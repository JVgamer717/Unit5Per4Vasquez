using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.UI;

public class DifficultyButton : MonoBehaviour
{
    private Button button;
    private GameManger gameManger;
    public int difficulty;
    // Start is called before the first frame update
    void Start()
    {

        button = GetComponent<Button>();
        gameManger = GameObject.Find("GameManager").GetComponent<GameManger>();

        button.onClick.AddListener(SetDifficulty);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SetDifficulty()
    {
        Debug.Log(gameObject.name + "was clicked");
        gameManger.StartGame(difficulty);
    }
}
