using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControls : MonoBehaviour
{
    [Header("Default Movement Speed")]
    publc float moveSpeed = 600f;
    float movement = 0f
    void Start()
    {
     Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
     movement = Input.GetAxisRaw("Horizontal");
    }
}
