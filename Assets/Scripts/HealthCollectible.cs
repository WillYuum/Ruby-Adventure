using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthCollectible : MonoBehaviour
{

    public AudioClip collectedClip;
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D other)
    {
        RubyController controller = other.GetComponent<RubyController>();

        if(controller != null)
        {
            if(controller.health < controller.maxHealth)
            {
                controller.changeHealth(1);
                Destroy(this.gameObject);

                controller.PlaySound(collectedClip);
            }
        }
    }
}
