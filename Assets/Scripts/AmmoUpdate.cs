using UnityEngine;
using TMPro;
using UnityEngine.Events;



public class AmmoUpdate : MonoBehaviour
{
    [SerializeField] TMP_Text AmmoCurrent;//ammo text

    public void UpdateText(int ammo)
    {
        AmmoCurrent.text = ammo.ToString();//convert ammmo int to string and change display message
    }
}
