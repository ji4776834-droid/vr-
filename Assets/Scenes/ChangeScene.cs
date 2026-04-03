using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    // 이동하고 싶은 다음 씬의 이름을 유니티 인스펙터에서 적어줄 겁니다.
    public string nextSceneName;

    // 무언가(플레이어)와 부딪혔을 때 실행됩니다.
    private void OnTriggerEnter(Collider other)
    {
        // 설정한 이름의 씬으로 넘어갑니다.
        SceneManager.LoadScene(nextSceneName);
    }
}