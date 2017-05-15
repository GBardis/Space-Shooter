using UnityEngine;
using System.Collections;

public class Mover : MonoBehaviour
{

    private Rigidbody rb;
    public float speed;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f, 0.0f, 1.0f) * speed;
    }
}
