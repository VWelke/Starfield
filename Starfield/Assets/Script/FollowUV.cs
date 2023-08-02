using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowUV : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame

    public float parallax = 2f; 

    void Update()
    {
        

        MeshRenderer mr = GetComponent<MeshRenderer>();
        Material mat = mr.material;
        Vector2 offset = mat.mainTextureOffset;
        offset.x = transform.position.x/ transform.localScale.x/ parallax;
        offset.y = transform.position.y/ transform.localScale.y/ parallax;
        mat.mainTextureOffset = offset;

    }
}
