using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class ButtonPressed : MonoBehaviour
{
    [SerializeField] private string button;
    [SerializeField] private AudioSource downSound;
    [SerializeField] private AudioSource upSound;
    private Collider2D collider;
    private Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        collider = GetComponent<Collider2D>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(button)) {
            downSound.Play(0);
            animator.SetBool("Pressed", true);
        } else if (Input.GetKeyUp(button)) {
            upSound.Play(0);
            animator.SetBool("Pressed", false);
        }
    }
}
