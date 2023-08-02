using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Simple_Planet : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    float speed = 5f;

    void Update()
    {
        transform.Translate ( new Vector3(
        Input.GetAxis("Horizontal") * speed,
        Input.GetAxis("Vertical") * speed,0
        )* Time.deltaTime);

    }
}
