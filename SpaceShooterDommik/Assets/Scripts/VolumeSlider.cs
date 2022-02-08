using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class VolumeSlider : MonoBehaviour
{
  public Slider volumeSlider;
  public TMP_Text volumeText;   

  void Start()
  {
    volumeSlider.value = PlayerPrefs.GetFloat("musicVolume", 1);
  }

  public void Volume()
  {
    AudioListener.volume = volumeSlider.value;
  }
  public void SaveVolume()
  {
    PlayerPrefs.SetFloat("musicVolume", volumeSlider.value);
    SceneManager.LoadScene("Game");

  }
  void Update()
  {
    volumeText.text = volumeSlider.value.ToString("F2");
  }
}
