using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class SettingControls : MonoBehaviour
{
    private bool _isFullScreen = false;
    public void FullScrennToggle()
    {
        _isFullScreen = !_isFullScreen;
        Screen.fullScreen = _isFullScreen;
    }

    public AudioMixer am;
    public void AudioVolume(float sliderValue)
    {
        am.SetFloat("masterVolume", sliderValue);
    }
    public void Quality(int q)
    {
        QualitySettings.SetQualityLevel(q);
    }

    Resolution[] rsl;
    List<string> resolutions;
    public Dropdown dropdown;

    public void Awake()
    {
        resolutions = new List<string>();
        rsl = Screen.resolutions;
        foreach (var i in rsl)
        {
            resolutions.Add(i.width + "x" + i.height);
        }
        dropdown.ClearOptions();
        dropdown.AddOptions(resolutions);
    }
    public void Resolution(int r)
    {
        Screen.SetResolution(rsl[r].width, rsl[r].height, _isFullScreen);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
