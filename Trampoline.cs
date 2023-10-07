using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trampoline : MonoBehaviour
{

    Rigidbody2D rb;

    public int jumpPower;
    public bool isTouch;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (isTouch == true)
        {
            rb.velocity = Vector2.up * jumpPower;
            isTouch = false;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "trampoline")//In the Unity game you need to make your trampoline tag "trampoline".()
        {
            isTouch = true;//When you click on the trampoline in Unity, there is a tag in the upper right corner, you can change it from there.
        }
    }
}
