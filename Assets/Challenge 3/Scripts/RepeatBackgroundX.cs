using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class RepeatBackgroundX : MonoBehaviour
{
    private Vector3 startPos;
    private float repeatWidth;
    private PlayerControllerX player;
    float speed = 15f;
    private void Start()
    {
        startPos = transform.position; // Establish the default starting position 
        repeatWidth = GetComponent<BoxCollider>().size.x / 2; // Set repeat width to half of the background
        player = GameObject.Find("Player").GetComponent<PlayerControllerX>();
    }

    private void Update()
    {
       if(player.gameOver==false)
            transform.Translate(Vector3.left * speed * Time.deltaTime);
            if (transform.position.x < startPos.x - repeatWidth)
            {
                transform.position = startPos;
            }
        
        
        
        // If background moves left by its repeat width, move it back to start position
        
    }

 
}


