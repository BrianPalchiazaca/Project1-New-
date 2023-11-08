using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    public ZombieMovement ZomMove;
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Enemies")
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Destroy(other.gameObject);
                //ZomMove.Damaged();
                Debug.Log("Ow");
            }
            Debug.Log("Hello");
        }
    }
}

