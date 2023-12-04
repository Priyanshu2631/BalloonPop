using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class BalloonControl : MonoBehaviour
{
    public float upSpeed;
    int s=0;

    AudioSource audioSource;
    public TextMeshProUGUI scoreText;

    private void Awake(){
        audioSource=GetComponent<AudioSource>();
    }
    

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y>7f){
            //SceneManager.LoadScene("Game");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            scoreText.text="Game Over";
        }
    }
    private void FixedUpdate(){
        transform.Translate(0,upSpeed,0);
    }

    private void OnMouseDown(){
        s++;
        scoreText.text=s.ToString();

        audioSource.Play();
        ResetPosition();
    }

    private void ResetPosition(){
        float randomX=Random.Range(-2.5f,2.5f);
        transform.position=new Vector2(randomX,-7f);
    }
}
