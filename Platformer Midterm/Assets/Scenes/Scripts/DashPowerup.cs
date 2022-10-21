using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DashPowerup : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.CompareTag("Player")) {
            PublicVars.canDash = true;
            Destroy(this.gameObject);
        }
    }
}
