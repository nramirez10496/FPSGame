using System.Collections;
using UnityEngine;

public class AmmoRefil : MonoBehaviour
{
    FPSController player;//player reference 

    public void RefillAmmo()
    {
        player.IncreaseAmmo(10);//increase ammo by 10 on player 
    }
    public void OnTriggerEnter(Collider other)//add observer  when near the refill station
    {
        player = other.GetComponent<FPSController>();//player is entering trigger 

        if (player != null)
        {
            player.OnInteract.AddListener(RefillAmmo);//adds refillammo as observer to the player pressing e
        }
    }

    public void OnTriggerExit(Collider other)//remove observer when not near the refill station cant refill
    {
        if (player!=null)
        {
            player.OnInteract.RemoveListener(RefillAmmo);//remove the observer
            player = null;//forget player when far
        }
    }




}
