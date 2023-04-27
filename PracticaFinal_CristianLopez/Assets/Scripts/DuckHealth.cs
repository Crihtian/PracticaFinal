using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;


public class DuckHealth : MonoBehaviour
{
    [SerializeField] private int duckHits;

    private Animator duckAnimation;


    Score score;

    private void Awake()
    {
        duckAnimation = GetComponentInChildren<Animator>();
        score = FindAnyObjectByType<Score>();
    }

    private void OnMouseDown()
    {
        duckHits--;
        score.AddPoints();
        if (duckHits <= 0)
        {
            duckAnimation.SetTrigger("death");        
            Destroy(gameObject, 3);
        }
        
    }

    

}
