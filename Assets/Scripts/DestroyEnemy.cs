using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class DestroyEnemy : MonoBehaviour
{
    private TextManager Score;
    private GameOver gameOver;
    private MoveToPlayer isDead;
    private Animator anim;
    private TextManager Lives;
    private AudioSource deathSound;
    private MoveToPlayer a;

    // Start is called before the first frame update
    void Start()
    {
        Score = FindObjectOfType<TextManager>();
        gameOver = FindObjectOfType<GameOver>();
        isDead = FindObjectOfType<MoveToPlayer>();
        anim = GetComponent<Animator>();
        deathSound = GetComponent<AudioSource>();
        a = FindObjectOfType<MoveToPlayer>();
    }
    // Update is called once per frame
    void Update()
    {
        isDead = this.gameObject.GetComponent<MoveToPlayer>();
           
    }
     private void OnTriggerEnter(Collider other)
     {
        if (isDead.isDead2 == false && other.tag == "Toiletpapper" )
        {
            Score.Score++;
            deathSound.Play();
            
        }
        if (other.tag == "Toiletpapper")
        {
            isDead.isDead2 = true;
            anim.SetTrigger("Dead");
            Destroy(gameObject, 10);
            Destroy(other.gameObject);
           



        }

        else if (other.tag == "Player")
        {
            if (isDead.isDead2 == false && isDead.spawnProtection == false)
            {
                Time.timeScale = 0;
                gameOver.isGameOver = true;
            }
            

        }
        
        
     }
    
    
        
    
}
