using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.TextCore.Text;

public class contol : MonoBehaviour
{
    // Start is called before the first frame update
    private CharacterController controller;
    public float speed = 5.0f;
    
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        
        Vector3 vec = new Vector3(horizontal, 0, vertical);
        controller.Move( vec * speed * Time.deltaTime);
    }
}
