using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TriggerManager : MonoBehaviour
{
    [SerializeField] public TMP_Text collectableAmount;
    [SerializeField] public Transform respawnPoint;
    public int amountOfCollectables = 0;

    private CharacterController controller;
    private void Start()
    {
        controller = GetComponent<CharacterController>();
    }
    void Update()
    {
        collectableAmount.text = amountOfCollectables.ToString();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Collectable")
        {
            amountOfCollectables++;
            Destroy(other.gameObject);
        }

        if (other.gameObject.tag == "Death")
        {
            Debug.Log("Enters Death Trigger");
            controller.enabled = false;
            gameObject.transform.position = respawnPoint.transform.position;
            controller.enabled = true;
        }
    }
}
