using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PleyerMove : MonoBehaviour
{
    Rigidbody PlayerRigidbody;
    [SerializeField] float PlayerMoveSpeed = 5;
    // Start is called before the first frame update
    void Start()
    {
        PlayerRigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.W))
        {
            transform.position += PlayerMoveSpeed * transform.forward * Time.deltaTime;
        }
        if(Input.GetKey(KeyCode.S)) 
        {
            transform.position -= PlayerMoveSpeed * transform.forward * Time.deltaTime;
        }
        if(Input.GetKey(KeyCode.D))
        {
            transform.position += PlayerMoveSpeed * transform.right * Time.deltaTime;
        }
        if(Input.GetKey(KeyCode.A))
        {
            transform.position -= PlayerMoveSpeed * transform.right * Time.deltaTime;
        }
    }
}
