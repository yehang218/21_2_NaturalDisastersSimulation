using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class cshPointer2 : MonoBehaviour
{
    public Image LoadingBar;
    private bool IsOn;
    private float barTime = 0.0f;
    private int num = -1;

    // Start is called before the first frame update
    void Start()
    {
        num = -1;
        IsOn = false;
        LoadingBar.fillAmount = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (IsOn)
        {
            if (barTime < 1.0f)
            {
                barTime += Time.deltaTime;
            }

            LoadingBar.fillAmount = barTime / 1.0f;

        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }

        //팝업창 열려있음
        if (num == -1 && GameObject.Find("atGaze").transform.Find("button").tag == "button")
        {
            if (LoadingBar.fillAmount == 1.0f)
            {
                //팝업창 닫고 3번 열기
                Debug.Log("PopUp 삭제");
                GameObject.Find("atGaze").transform.Find("PopUp").gameObject.SetActive(false);
                GameObject.Find("atGaze").transform.Find("button").gameObject.SetActive(false);
                GameObject.Find("atGaze").transform.Find("texts").gameObject.SetActive(false);

                LoadingBar.fillAmount = 0;
                num = 0;
            }
        }

        //1번 열려있음
        if (num == 0 && GameObject.Find("atGaze").transform.Find("1Earth").tag == "4water")
        {
            if (LoadingBar.fillAmount == 1.0f)
            {
               
                Debug.Log("1번 삭제");
                GameObject.Find("atGaze").transform.Find("1PopUp").gameObject.SetActive(true);
                GameObject.Find("atGaze").transform.Find("1button").gameObject.SetActive(true);
                GameObject.Find("atGaze").transform.Find("1texts").gameObject.SetActive(true);

                GameObject.Find("atGaze").transform.Find("1Earth").gameObject.SetActive(false);
                LoadingBar.fillAmount = 0;
                num = 1;
            }
        }

        else if (num == 1 && GameObject.Find("atGaze").transform.Find("1button").tag == "button")
        {
            if (LoadingBar.fillAmount == 1.0f)
            {
                //팝업창 닫고 2번 열기
                Debug.Log("PopUp 삭제");
                GameObject.Find("atGaze").transform.Find("1PopUp").gameObject.SetActive(false);
                GameObject.Find("atGaze").transform.Find("1button").gameObject.SetActive(false);
                GameObject.Find("atGaze").transform.Find("1texts").gameObject.SetActive(false);

                GameObject.Find("atGaze").transform.Find("2brimstone").gameObject.SetActive(true);
                LoadingBar.fillAmount = 0;
                num = 2;
            }
        }

        else if (num == 2 && GameObject.Find("atGaze").transform.Find("2brimstone").tag == "5Clouds")
        {
            if (LoadingBar.fillAmount == 1.0f)
            {

                Debug.Log("2번 삭제");
                GameObject.Find("atGaze").transform.Find("2PopUp").gameObject.SetActive(true);
                GameObject.Find("atGaze").transform.Find("2button").gameObject.SetActive(true);
                GameObject.Find("atGaze").transform.Find("2texts").gameObject.SetActive(true);

                GameObject.Find("atGaze").transform.Find("2brimstone").gameObject.SetActive(false);
                LoadingBar.fillAmount = 0;
                num = 3;
            }
        }

        else if (num == 3 && GameObject.Find("atGaze").transform.Find("2button").tag == "button")
        {
            if (LoadingBar.fillAmount == 1.0f)
            {
                //팝업창 닫고 2번 열기
                Debug.Log("PopUp 삭제");
                GameObject.Find("atGaze").transform.Find("2PopUp").gameObject.SetActive(false);
                GameObject.Find("atGaze").transform.Find("2button").gameObject.SetActive(false);
                GameObject.Find("atGaze").transform.Find("2texts").gameObject.SetActive(false);

                LoadingBar.fillAmount = 0;
                num = 4;
            }
        }

        else if (num == 4 && GameObject.Find("MediumPoly").tag == "2Animals")
        {
            if (LoadingBar.fillAmount == 1.0f)
            {

                SceneManager.LoadScene("Sample3");
            }
        }

   
    }

    public void SetGazedAt(bool gazedAt)
    {
        IsOn = gazedAt;
        barTime = 0.0f;

        if (gazedAt)
            Debug.Log("In");
        else
        {
            Debug.Log("Out");
            LoadingBar.fillAmount = 0;
        }


    }
}
