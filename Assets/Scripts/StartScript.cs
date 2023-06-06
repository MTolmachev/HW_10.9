using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartScript : MonoBehaviour
{
    [SerializeField] bool isOnStart;
    [SerializeField] float force;

    private Vector3 startPos;

    private void Awake()
    {
        isOnStart = true;
        startPos = transform.position;
    }
    void Update()
    {
        if (isOnStart)
        {
            GetComponent<Rigidbody>().AddForce(Vector3.forward * force, ForceMode.Impulse);
            isOnStart = false;
        }
        else
        {
            GetComponent<Transform>().position = startPos;
        }

    }
}
