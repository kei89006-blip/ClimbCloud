using UnityEngine;
using UnityEngine.SceneManagement; // これがシーン切り替えに必要！

public class TitleManager : MonoBehaviour
{
    // ボタンが押された時に実行する命令
    public void OnStartButton()
    {
        SceneManager.LoadScene("GameScene");
    }
}