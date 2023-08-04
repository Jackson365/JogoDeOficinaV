using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


    public class GameController : MonoBehaviour
    {
        public Text healthText;
        
        
    public static GameController instance;


    // Start is called before the first frame update
    void Start()
    {
        instance = this;
    }

    public void UpdateScore(int value)
       {
           score += value;
           scoreText.text = score.ToString();
           
           PlayerPrefs.SetInt("score", score + totalScore);
       }
       
       public void UpdateLives(int value)
       {
           healthText.text = "x " + value.ToString();
       }
}
