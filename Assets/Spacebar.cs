using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spacebar : MonoBehaviour
{
    [SerializeField] private string button;
    private Collider2D collider;
    private Animator animator;
    private Vector3 startpos;

    // Start is called before the first frame update
    void Start()
    {
        collider = GetComponent<Collider2D>();
        animator = GetComponent<Animator>();
        startpos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(button)) {
            animator.SetBool("Pressed", true);
        } else if (Input.GetKeyUp(button)) {
            animator.SetBool("Pressed", false);
            transform.position = startpos;
        }
    }
}
