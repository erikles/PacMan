using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pacdot : MonoBehaviour
{
    public GameObject levelMenage;
    void OnTriggerEnter2D(Collider2D obj)
    {
        if (obj.CompareTag("Player"))
        {
            levelMenage.GetComponent<LevelMenage>().pontos++; 
            Destroy(gameObject); 
            GetComponent<AudioSource>().Play();
        }
       
           
    }

  
}
