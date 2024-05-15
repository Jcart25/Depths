using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    private Vector3 offset = new Vector3(4f, 1f, -10f);
    private Vector3 revoffset = new Vector3(-4f, 1f, -10f);
    private float smoothTime = 0.25f;
    private Vector3 velocity = Vector3.zero;
    //public GameObject player;
    //private Vector3 playerPosition;

    [SerializeField] private Transform target;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 targetPosition = target.position + offset;
        if (Input.GetKey(KeyCode.RightArrow))
        {
            targetPosition = target.position + offset;
        }

        else if (Input.GetKey(KeyCode.LeftArrow) || (Input.GetKey(KeyCode.A)))
        {
            targetPosition = target.position + revoffset;
        }

        /*
        else
        {
            targetPosition = target.position + offset;
        }
        */


        //Vector3 targetPosition = target.position + offset;

        transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref velocity, smoothTime);

        /*
        if (player.transform.localScale.x < 0f)
        {
            transform.position = Vector3.SmoothDamp(transform.position - offset, targetPosition, ref velocity, smoothTime);
        }
        */
    }
}
