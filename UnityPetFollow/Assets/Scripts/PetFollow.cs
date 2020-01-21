using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PetFollow : MonoBehaviour
{

    private Transform player;
    public float speed = 1.5f;
    public Transform target;

    private void Start()
    {
        player = GameObject.Find("野蠻人").GetComponent<Transform>();
    }

    /*private void LateUpdate()
    {
        Follow();
    }*/

    private void FixedUpdate()
    {
        Follow();
    }
    private void Follow() 
    {
        Vector3 posP = player.position;
        Vector3 posC = transform.position;

        posP.z += -5;

        transform.position = Vector3.Lerp(posC, posP, 0.3f * Time.deltaTime * speed);
        transform.LookAt(target);
    }

}
