using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class House_Outside : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D ChangeScene)
    {
        SceneManager.LoadScene(1);
        ChangeScene.transform.position = new Vector3(-5.45f, 5.04f, 0);
    }
}

