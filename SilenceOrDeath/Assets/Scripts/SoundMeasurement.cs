using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class SoundMeasurement : MonoBehaviour
{
	private AudioSource[] allAudioSources;
    private AudioClip recordedClip;
    private AudioSource playerAudioSource;
    public Slider audioVolumeSlider; 

    private void Start()
    {
        // 모든 AudioSource 컴포넌트를 찾습니다.
        allAudioSources = FindObjectsOfType<AudioSource>();

        // 배경음 소리를 구분할 AudioSource를 찾습니다.
        foreach (var audioSource in allAudioSources)
        {
            // 배경음은 Loop 속성이 true일 가능성이 높습니다.
            if (audioSource.loop)
            {
                // 배경음 소리를 구분하기 위해 해당 AudioSource를 비활성화합니다.
                audioSource.enabled = false;
            }
            else if (audioSource.CompareTag("Player")) // 플레이어가 내는 소리를 구분하기 위해 Player 태그를 사용합니다.
            {
                playerAudioSource = audioSource;
            }
        }

        // 마이크로폰을 초기화합니다.
        InitMicrophone();
    }

    private void Update()
    {
        // 플레이어가 내는 소리 측정
        float[] micData = new float[recordedClip.samples * recordedClip.channels];
        recordedClip.GetData(micData, 0);

        float rms = 0f;
        foreach (float sample in micData)
        {
            rms += sample * sample;
        }
        rms = Mathf.Sqrt(rms / (micData.Length * 2));

        // 측정한 플레이어 소리 정보를 출력하거나 활용할 수 있습니다.
        Debug.Log($"Player Sound RMS: {rms}");

       

        // 측정한 플레이어 소리 정보를 Slider에 표현합니다.
        if (audioVolumeSlider != null)
        {
            audioVolumeSlider.value = rms;
        }
    }

    private void InitMicrophone()
    {
        // 마이크로폰을 초기화하고 플레이어 소리를 녹음합니다.
        string microphone = Microphone.devices[0]; // 첫 번째 마이크로폰을 사용합니다. 필요에 따라 변경할 수 있습니다.
        recordedClip = Microphone.Start(microphone, true, 10, AudioSettings.outputSampleRate);
    }

     // Inspector에서 Slider UI를 연결할 변수


}

