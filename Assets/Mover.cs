using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] float movementSpeed = 10f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        

        float xVector = Input.GetAxis("Horizontal")*Time.deltaTime*movementSpeed;
        float zVector = Input.GetAxis("Vertical")*Time.deltaTime*movementSpeed;

        transform.Translate(xVector,0,zVector);
    }
}
                                                  