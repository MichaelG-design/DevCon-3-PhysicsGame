using UnityEngine;

public class Respawn : MonoBehaviour
{
    public Transform respawnPoint;

    private void OnTriggerEnter(Collider other)
    {
        CharacterController cc = other.GetComponentInChildren<CharacterController>();

        if (cc != null)
        {
            cc.enabled = false;

            Transform playerBody = cc.transform;
            playerBody.position = respawnPoint.position;

            cc.enabled = true;

            Debug.Log("Respawn Works👅👅👅");
        }
    }
}
