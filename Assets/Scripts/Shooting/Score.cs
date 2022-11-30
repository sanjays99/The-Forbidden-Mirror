using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Score : MonoBehaviour

{
    [SerializeField] Transform player;
    [SerializeField] Text scoreText;
    
    int score=0;
    
    public void scoreupd()
    {
         score++;
         scoreText.text = score.ToString();
        
    }

}