using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BgmManager : MonoBehaviour
{
    AudioSource audioSource;
    [SerializeField]
    AudioClip[] audioClip;
    private int test;
    // がんだーら参上!

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();

    }

    private void Update()
    {
        // シーンごとに鳴らすSEを制限
        switch (SceneManager.GetActiveScene().name)
        {
            case "TitleScene":
                break;
            case "Main":
                if (Input.GetKeyDown(KeyCode.A))
                {
                    test += 1;
                    BgmPlay(test);

                }

                if (test > 1)
                {
                    test = -1;
                }
                break;
        }
        
    }

    
    public void BgmPlay(int number)
    {
        audioSource.clip = audioClip[number];
        audioSource.Play();
    }

    public void StopBgm()
    {
        audioSource.Stop();
    }
}
