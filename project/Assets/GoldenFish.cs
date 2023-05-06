using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoldenFish : MonoBehaviour
{
    public KeyCode interact;
    public GameObject ItemFish;
    public GameObject Indicator;
    public GameObject Bar;
    public GameObject GoldenFish1;
    public GameObject activator;
    public bool fish;
    public bool end;

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "bar")
        {
            fish = true;
        }
    }

    void OnTriggerExit2D(Collider2D col)
    {
        if (col.tag == "bar")
        {
            fish = false;
        }
    }

    void Update()
    {
        if (Input.GetKey(interact) && (fish == true))
        {
            ItemFish.SetActive(true);
        }
    }
}
