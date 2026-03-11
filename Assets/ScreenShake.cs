using UnityEngine;
using Cinemachine;
using UnityEngine.Events;


public class ScreenShake : MonoBehaviour
{

    [SerializeField] CinemachineVirtualCamera vcam;//camera
    


    public void StartShake()
    {
        vcam.GetCinemachineComponent<CinemachineBasicMultiChannelPerlin>().m_AmplitudeGain = 10;//shake with 10 amp
        Invoke(nameof(EndShake), .2f);//call endskake after .2 secons
    }

    public void EndShake()
    {
        vcam.GetCinemachineComponent<CinemachineBasicMultiChannelPerlin>().m_AmplitudeGain = 0;//stop shaking
    }


   

}
