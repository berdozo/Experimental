using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    MeshRenderer MeshRenderer;
    Rigidbody rigid;
    [SerializeField] float timePassed = 10f;

    // Start is called before the first frame update
    void Start()
    {
        MeshRenderer = GetComponent<MeshRenderer>();
        rigid = GetComponent<Rigidbody>();
        MeshRenderer.enabled=false;
    }

    // Update is called once per frame
    void Update()
    {

        if(Time.time>timePassed){
            MeshRenderer.enabled=true;
            rigid.useGravity=true;
        }

    }
}
