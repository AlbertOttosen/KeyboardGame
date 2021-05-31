using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoodScript : MonoBehaviour
{
    [SerializeField] private float speed;
    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate() {
        rb.velocity = new Vector3(speed, rb.velocity.y, 0);
    }
}
