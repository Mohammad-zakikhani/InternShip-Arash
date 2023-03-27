using UnityEngine;
using UnityEngine.UI;

public class SetVolume : MonoBehaviour
{
    public Slider slider;

    public void Volume()
    {
        AudioListener.volume = slider.value;
    }
}
