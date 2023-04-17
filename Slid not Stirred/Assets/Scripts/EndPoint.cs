using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndPoint : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other) {
        if(FindObjectOfType<PlayerController2>().GetHealth() == 0){
          FindObjectOfType<GameManager>().Lose();  
        }
        else{
            FindObjectOfType<GameManager>().Win();
        }
        FindObjectOfType<GameManager>().Restart();
    }
}
