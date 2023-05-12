using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class IndicatorActivate : MonoBehaviour
{
    public KeyCode activate;
    public GameObject Indicator;
    public GameObject Bar;
    public GameObject GoldenFish;
    public GameObject Text;
    public bool coll;
    public bool bar;
    public bool fish;
    public bool dontupdate;
    public bool end;
    public Vector3 startpos1 = Vector3.zero;
    public Vector3 endpos1 = Vector3.one;
    public float speed = 0;
    private int i = 0;

    void OnTriggerEnter2D(Collider2D other1)
    {
        if (other1.CompareTag("Player"))
        {
            Text.SetActive(true);
            coll = true;
        }
    }

    void OnTriggerExit2D(Collider2D other1)
    {
        if (other1.CompareTag("Player"))
        {
            Text.SetActive(false);
            Indicator.SetActive(false);
            Bar.SetActive(false);
            GoldenFish.SetActive(false);
            bar = false;
            coll = false;
            i = 0;
        }
    }

    void Update()
    {
        if (Input.GetKey(activate) && (coll == true))
        {
            Text.SetActive(false);
            Indicator.SetActive(true);
            Bar.SetActive(true);
            GoldenFish.SetActive(true);
            bar = true;
        }
        if (bar == true)
        {
            i++;
            speed = 0.005f;
            Bar.transform.position = Vector3.Lerp(startpos1, endpos1, i * speed);
        }
        if (i > 199)
        {
            Indicator.SetActive(false);
            Bar.SetActive(false);
            GoldenFish.SetActive(false);
            coll = false;
            bar = false;
            i = 0;
        }
    }
}

