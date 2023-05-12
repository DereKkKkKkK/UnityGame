using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Fishing_Outside : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D ChangeScene)
    {
        ChangeScene.transform.position = new Vector3(9.61f, 8.04f, 0);
        SceneManager.LoadScene(1);
    }
}
