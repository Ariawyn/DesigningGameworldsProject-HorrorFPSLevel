using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VaultOpenTrigger : MonoBehaviour
{
    // So we can access the vault we need to animate, set in inspector
    [SerializeField] private Animator vault_to_open = null;

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            // Play vault open animation and destroy self
            vault_to_open.Play("VaultOpen", 0, 0.0f);
            Destroy(gameObject);
        }
    }
}
