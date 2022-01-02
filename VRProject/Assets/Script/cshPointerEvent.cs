using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(Collider))]
public class cshPointerEvent : MonoBehaviour
{
	public Image LoadingBar;
	private bool IsOn;
	private float barTime = 0.0f;
	private int num = -1;

	void Start()
	{
		num = -1;
		IsOn = false;
		LoadingBar.fillAmount = 0;
	}

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

       

        if (num == -1 && GameObject.Find("atGaze").transform.Find("button").tag == "button")
        {
			if (LoadingBar.fillAmount == 1.0f)
			{
				//팝업창 닫고 3번 열기
				Debug.Log("PopUp 삭제");
				GameObject.Find("atGaze").transform.Find("PopUp_").gameObject.SetActive(false);
				GameObject.Find("atGaze").transform.Find("button_").gameObject.SetActive(false);
				GameObject.Find("atGaze").transform.Find("texts_").gameObject.SetActive(false);

				LoadingBar.fillAmount = 0;
				num = 0;
			}
		}

		//2번 열려있음
		if (num == 0 && GameObject.Find("atGaze").transform.Find("2Animals").tag == "2Animals")
		{
			if (LoadingBar.fillAmount == 1.0f)
			{
				//동물 쳐다보기 2번 닫고 팝업창 열기
				Debug.Log("1번 삭제");
				GameObject.Find("atGaze").transform.Find("PopUp").gameObject.SetActive(true);
				GameObject.Find("atGaze").transform.Find("button").gameObject.SetActive(true);
				GameObject.Find("atGaze").transform.Find("texts").gameObject.SetActive(true);

				GameObject.Find("atGaze").transform.Find("2Animals").gameObject.SetActive(false);
				LoadingBar.fillAmount = 0;
				num = 1;
			}
		}

		else if (num == 1 && GameObject.Find("atGaze").transform.Find("button").tag == "button")
		{
			if (LoadingBar.fillAmount == 1.0f)
			{
				//팝업창 닫고 3번 열기
				Debug.Log("PopUp 삭제");
				GameObject.Find("atGaze").transform.Find("PopUp").gameObject.SetActive(false);
				GameObject.Find("atGaze").transform.Find("button").gameObject.SetActive(false);
				GameObject.Find("atGaze").transform.Find("texts").gameObject.SetActive(false);

				GameObject.Find("atGaze").transform.Find("3lightPrefab").gameObject.SetActive(true);
				LoadingBar.fillAmount = 0;
				num = 2;
			}
		}
		else if (num == 2 && GameObject.Find("atGaze").transform.Find("3lightPrefab").tag == "3lightPrefab")
		{
			if (LoadingBar.fillAmount == 1.0f)
			{
				//3번 닫고 팝업창 열기
				Debug.Log("2번삭제");
				GameObject.Find("atGaze").transform.Find("PopUp2").gameObject.SetActive(true);
				GameObject.Find("atGaze").transform.Find("button2").gameObject.SetActive(true);
				GameObject.Find("atGaze").transform.Find("texts2").gameObject.SetActive(true);
				GameObject.Find("atGaze").transform.Find("3lightPrefab").gameObject.SetActive(false);
				num = 3;
				LoadingBar.fillAmount = 0;
			}
		}

		else if (num == 3 && GameObject.Find("atGaze").transform.Find("button").tag == "button")
		{
			if (LoadingBar.fillAmount == 1.0f)
			{
				//팝업창 닫고 4번 열기
				Debug.Log("PopUp 삭제");
				GameObject.Find("atGaze").transform.Find("PopUp2").gameObject.SetActive(false);
				GameObject.Find("atGaze").transform.Find("button2").gameObject.SetActive(false);
				GameObject.Find("atGaze").transform.Find("texts2").gameObject.SetActive(false);

				GameObject.Find("atGaze").transform.Find("4water").gameObject.SetActive(true);
				LoadingBar.fillAmount = 0;
				num = 4;
			}
		}

		else if (num == 4 && GameObject.Find("atGaze").transform.Find("4water").tag == "4water")
		{
			if (LoadingBar.fillAmount == 1.0f)
			{
				//4번 닫고 팝업창 열기
				Debug.Log("3번 삭제");
				GameObject.Find("atGaze").transform.Find("PopUp3").gameObject.SetActive(true);
				GameObject.Find("atGaze").transform.Find("button3").gameObject.SetActive(true);
				GameObject.Find("atGaze").transform.Find("texts3").gameObject.SetActive(true);
				GameObject.Find("atGaze").transform.Find("4water").gameObject.SetActive(false);
				num = 5;
				LoadingBar.fillAmount = 0;
			}
		}
		else if (num == 5 && GameObject.Find("atGaze").transform.Find("button").tag == "button")
		{
			if (LoadingBar.fillAmount == 1.0f)
			{
				//팝업창 닫고 5번 열기
				Debug.Log("PopUp 삭제");
				GameObject.Find("atGaze").transform.Find("PopUp3").gameObject.SetActive(false);
				GameObject.Find("atGaze").transform.Find("button3").gameObject.SetActive(false);
				GameObject.Find("atGaze").transform.Find("texts3").gameObject.SetActive(false);

				GameObject.Find("atGaze").transform.Find("5Clouds").gameObject.SetActive(true);
				LoadingBar.fillAmount = 0;
				num = 6;
			}
		}
		else if (num == 6 && GameObject.Find("atGaze").transform.Find("5Clouds").tag == "5Clouds")

		{
			if (LoadingBar.fillAmount == 1.0f)
			{
				// 5번 닫고 팝업창 열기
			Debug.Log("4번 삭제");
			GameObject.Find("atGaze").transform.Find("PopUp4").gameObject.SetActive(true);
			GameObject.Find("atGaze").transform.Find("button4").gameObject.SetActive(true);
			GameObject.Find("atGaze").transform.Find("texts4").gameObject.SetActive(true);
			GameObject.Find("atGaze").transform.Find("5Clouds").gameObject.SetActive(false);
			num = 7;
			LoadingBar.fillAmount = 0;
			}
		}

		else if (num == 7 && GameObject.Find("atGaze").transform.Find("button").tag == "button")
		{
			if (LoadingBar.fillAmount == 1.0f)
			{
				SceneManager.LoadScene("Sample2");
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
