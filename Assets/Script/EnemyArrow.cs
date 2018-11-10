﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyArrow : MonoBehaviour
{

    public float velocity;
    private GameObject player;
    private Vector3 playerDir;

    // Use this for initialization
    void Start()
    {
        player = GameObject.Find("Player");
        playerDir = player.transform.position - transform.position;


    }

    // Update is called once per frame
    void Update()
    {

        transform.rotation = Quaternion.Euler(0, 0, Mathf.Atan2(playerDir.y, playerDir.x) * Mathf.Rad2Deg - 90);
        transform.Translate(Vector3.Normalize(playerDir) * Time.deltaTime * velocity, Space.World);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Obstacle"))
        {
            Destroy(this.gameObject);
        }

    }
}