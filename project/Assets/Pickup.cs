using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    private Inventory inventory;
    public GameObject slotButton;
    public KeyCode take;
    public bool coll;
    public bool press;

    private void Start()
    {
        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            coll = true;
            if ((coll == true) && (press == true))
            {
                for (int i = 0; i < inventory.slots.Length; i++)
                {
                    if (inventory.isFull[i] == false)
                    {
                        inventory.isFull[i] = true;
                        Instantiate(slotButton, inventory.slots[i].transform);
                        gameObject.SetActive(false);
                        break;
                    }
                }
            }
        }
    }

    private void Update()
    {
        if (coll == true)
        {
            if (Input.GetKeyDown(take))
            {
                press = true;
            }
        }

        if (inventory.isFull[1] == true)
        {
            Destroy(GameObject.Find("Attention"));
            Destroy(GameObject.Find("exit-block"));
            Destroy(GameObject.Find("FishingRod"));
            Destroy(GameObject.Find("Bucket"));
        }
    }
}
