using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class House_Outside : MonoBehaviour
{
    private float timer = 1.0f;
    public GameObject player;

    void OnTriggerEnter2D(Collider2D ChangeScene)
    {
        player.GetComponent<Renderer>().material.color.a = 0f;
        SceneManager.LoadScene(0);
        if (timer <= 0)
        {
            ChangeScene.transform.position = new Vector3(-5.45f, 5.04f, 0);
            player.GetComponent<Renderer>().material.color.a = 1.0f;
        }
    }

    void Update()
    {
        timer -= Time.deltaTime;
    }
}

