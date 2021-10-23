using UnityEngine;
using System.Collections;

public class PauseScript : MonoBehaviour
{

	[SerializeField]
	private GameObject pauseUI;

	void Update()
	{
		if (Input.GetKeyDown("q"))
		{
			if (!pauseUI.activeSelf)
			{
				pause();//ボタンにも対応するために関数を使用
			}
			else
			{
				restart();//ボタンにも対応するために関数を使用
			}
		}
	}

    public void pause()
    {
		pauseUI.SetActive(!pauseUI.activeSelf);
		Time.timeScale = 0f;
		AudioListener.volume = 0f;
	}

	public void restart()
    {
		pauseUI.SetActive(!pauseUI.activeSelf);
		Time.timeScale = 1f;
		AudioListener.volume = 1f;
	}
}