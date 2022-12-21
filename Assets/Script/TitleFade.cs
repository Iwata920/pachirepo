using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TitleFade : MonoBehaviour
{
    [SerializeField] private float _fadeSpeed;

    private GameObject fadeInObj;
    private GameObject fadeOutObj;
    [SerializeField] Image fadeInImage;
    [SerializeField] Image fadeOutImage;
    [SerializeField] GameObject TitleObj;
    [SerializeField] GameObject DemoObj;
    FadeManager fadeManager;

    private void Start()
    {
        fadeInObj = GameObject.FindGameObjectWithTag("FadeIN");
        fadeOutObj = GameObject.FindGameObjectWithTag("FadeOut");
        fadeInImage = fadeInObj.GetComponent<Image>();
        fadeManager = GetComponent<FadeManager>();
    }

    public IEnumerator StartFadeOut()
    {
        // �^�C�g����ʂ̃t�F�C�h�A�E�g
        for (int i = 255; i > 0; i--)
        {
            fadeInImage.color = fadeInImage.color + new Color32(0, 0, 0, 1);
            yield return new WaitForSeconds(_fadeSpeed / 2);
        }

        // �x����ʂ�\��
        TitleObj.SetActive(false);
        DemoObj.SetActive(true);

        // �t�F�C�h�A�E�g�����C���V�[���֑J��
        for (int i = 255; i > 0; i--)
        {
            fadeInImage.color = fadeInImage.color - new Color32(0, 0, 0, 1);
            yield return new WaitForSeconds(_fadeSpeed / 2.5f);
        }

        yield return new WaitForSeconds(2.5f);
        fadeManager.LoadScene("Main", 1.0f);

    }

}
