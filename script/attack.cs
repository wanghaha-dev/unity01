using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class attach : MonoBehaviour
{
    public GameObject prefab;
    public float lifetime = 1f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            // create gameObject
            GameObject go1 = Instantiate(prefab, Vector3.zero, Quaternion.identity);

            // destroy gameObject
            Destroy(go1, lifetime);
        }
    }
}