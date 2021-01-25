using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float hiz;


    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject,6.5f);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position += Vector3.left * hiz * Time.deltaTime;
    }
}
