using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Outside_House : MonoBehaviour
{    
    private void OnTriggerEnter2D(Collider2D ChangeScene)
    {
        ChangeScene.transform.position = new Vector4(-0.512f, -3.18f, 0);
        SceneManager.LoadScene(1);
    }
}
