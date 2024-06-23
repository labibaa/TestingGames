using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComponentInteraction : MonoBehaviour
{
    public float interactionDistance = 2f;
    public KeyCode interactKey = KeyCode.E;
    private Transform player;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    private void Update()
    {
        if (Input.GetKeyDown(interactKey))
        {
            CheckForComponents();
        }
    }

    void CheckForComponents()
    {
        Collider[] hitColliders = Physics.OverlapSphere(player.position, interactionDistance);
        foreach (var hitCollider in hitColliders)
        {
            if (hitCollider.CompareTag("Component"))
            {
                ComponentManager.instance.CollectComponent(hitCollider.gameObject);
                break;
            }
        }
    }
}

