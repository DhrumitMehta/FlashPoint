using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cheetahMovement : MonoBehaviour
{
    public CharacterController2D controller;
    public Animator anim;
    public float runspeed;
    private float horizontalmove;
    public float startTime = 5f;

    // Start is called before the first frame update
    void Start()
    {
        horizontalmove = runspeed;
    }

    void FixedUpdate()
    {
        if (startTime > -1)
        {
            startTime -= Time.deltaTime;
        }
        if (startTime < 0)
        {
            controller.Move(horizontalmove * Time.deltaTime, false);
            anim.SetBool("isRunning", true);
        }
    }
}
