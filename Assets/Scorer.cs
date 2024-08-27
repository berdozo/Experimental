using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour
{
    int hits;

    private void OnCollisionEnter(Collision other){

        
        hits++;
        Debug.Log("Score = "+ hits);
    }
}
