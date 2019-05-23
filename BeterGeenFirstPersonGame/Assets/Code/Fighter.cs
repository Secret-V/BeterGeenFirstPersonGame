﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fighter : MonoBehaviour
{
    public enum PlayerType
    {
        Player1,
        Player2
    }

    public PlayerType player;

    public float jumpForce = 10.0f;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(WaitToStart());
    }

    // Update is called once per frame
    void Update()
    {
        if(player == PlayerType.Player1)
        {
            if(Input.GetKeyDown(KeyCode.Space))
            {
                Jump();
            } 
        }
        else if(player == PlayerType.Player2)
        {
            if(Input.GetKeyDown(KeyCode.RightShift))
            {
                Jump();
            }
        }
    }

    private void Jump()
    {
        GetComponent<Rigidbody>().AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
    }

    IEnumerator WaitToStart()
    {
        yield return new WaitForSeconds(2.0f);
    }
}