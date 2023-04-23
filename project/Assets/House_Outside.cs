using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class House_Outside : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D ChangeScene)
    {
        ChangeScene.transform.position = new Vector3(-5.5f, 5.1f, 0);
        SceneManager.LoadScene(0);
    }
}

