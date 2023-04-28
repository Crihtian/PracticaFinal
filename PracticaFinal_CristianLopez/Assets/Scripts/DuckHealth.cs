using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;


public class DuckHealth : MonoBehaviour
{
    [SerializeField] private int duckHits;

    private Animator duckAnimation;
    private Collider2D hitBox;

    private SoundManager soundManager;
    [SerializeField] private int sonido;
    



    Score score;

    private void Awake()
    {
        hitBox = GetComponent<Collider2D>();
        duckAnimation = GetComponentInChildren<Animator>();
        score = FindAnyObjectByType<Score>();
        soundManager = FindObjectOfType<SoundManager>();
    }

    private void OnMouseDown()
    {
        duckHits--;
        score.AddPoints();
        if (duckHits <= 0)
        {
            duckAnimation.SetTrigger("death");
            soundManager.AudioChoose(sonido ,0.6f);
            Destroy(hitBox);
            Destroy(gameObject, 3);
        }

    }



}
