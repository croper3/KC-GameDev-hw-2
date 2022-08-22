using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class score_2 : MonoBehaviour
{
    public Text text;
    public int score = 0;
    

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "score")
        {
            score++;
            text.text = score.ToString();
        }
    }
}
