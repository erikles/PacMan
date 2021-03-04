using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelMenage : MonoBehaviour
{
   public int pontos;
   public Text pontosT;

   void Update(){
       pontosT.text = pontos.ToString();
   }
}
