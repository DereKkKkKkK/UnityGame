using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Outside_Fishing : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D ChangeScene)
    {
        ChangeScene.transform.position = new Vector3(5.25f, -6.91f, 0);
        SceneManager.LoadScene(2);
    }
}
