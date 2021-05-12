using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class view : MonoBehaviour
{
    
    public float speed = 10;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        float value = Input.GetAxis("Horizontal");
        transform.Rotate(Vector3.up * value * speed * Time.deltaTime);
    }
}
