using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ss : MonoBehaviour
{
    public TextMeshProUGUI sss;
    public TextMeshProUGUI Game;
    PlayerControllerX b;


    // Start is called before the first frame update
    void Start()
    {
        sss.text = PlayerControllerX.score.ToString();
        b=GameObject.Find("Player").GetComponent<PlayerControllerX>();

    }

    // Update is called once per frame
    void Update()
    {
        sss.text = "score: " + PlayerControllerX.score.ToString();
        if (b.gameOver == true)
        {
            endgame();

        }

    }
    void endgame()
    {
        Game.text = "Game Over";
    }
    // Start is called before the first frame update
   

   
}
