using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashingLight : MonoBehaviour
{
    // The light we will turn on and off
    Light light_to_flash;

    // The amount of time the light spends in each state
    float flash_speed = 2f;

    // The timer we will be using to keep track of when state changes need to occur
    float current_time_in_state;

    // Start is called before the first frame update
    void Start()
    {
        light_to_flash = GetComponent<Light>();
    }

    void FixedUpdate()
    {
        current_time_in_state += Time.deltaTime;

        if(current_time_in_state > flash_speed)
        {
            // Set to new state
            current_time_in_state = 0;
            light_to_flash.enabled = !light_to_flash.enabled;
        }
    }
}
