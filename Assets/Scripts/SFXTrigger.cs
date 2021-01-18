using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SFXTrigger : MonoBehaviour
{
    // We need this bool to stop the trigger from playing again since we cant just destroy (I thin)
    private bool has_played_clip = false;
    [SerializeField] private AudioClip sfx_audio_clip = null;
    [SerializeField] private AudioSource audio_source_to_play_from = null;

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            if(!has_played_clip)
            {

            }

            audio_source_to_play_from.clip = sfx_audio_clip;
            audio_source_to_play_from.Play();

            Destroy(gameObject);
        }
    }
}
