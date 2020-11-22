using UnityEngine;
using UnityEngine.UI;

public class GameOverPresenter : MonoBehaviour
{
    [SerializeReference] private SphereStates m_sphereStates = null;
    [SerializeReference] private Text m_gameOverText = null;

    private void Start()
    {
        m_gameOverText.text = string.Empty;
    }

    private void Update()
    {
        if(m_sphereStates.GameOver)
        {
            Time.timeScale = 0f;
            m_gameOverText.text = "ガメオベラ";
        }
    }

}
