using UnityEngine;
using UnityEngine.UI;

public class QTEPresenter : MonoBehaviour
{
    [SerializeField] private Text m_QTEText = null;

    [SerializeField] private Text m_QTETimeLimitText = null;

    [SerializeField] private InputField m_QTEInputField = null;

    [SerializeField] private float m_timeLimit = 5f;

    [SerializeField] private string m_theme = "SUSHI";

    public SphereDamage SphereDamage = null;

    public enum QTEStates
    {
        OFF = 0,
        ON,
        Input,
        Result,
    }

    public QTEStates QTEPresenterStates = QTEStates.OFF;


    private void Start()
    {
        SetQTEObject(false);
    }

    private void Update()
    {
        switch (QTEPresenterStates)
        {
            case QTEStates.OFF:
                return;///帰る

            case QTEStates.ON:
                //時間を止める
                Time.timeScale = 0f;
                m_timeLimit = 5f;

                SetQTEObject(true);

                //QTEの命令をユーザに伝える
                m_QTEText.text = $"{m_theme}と入力しろ!";
                m_QTEInputField.text = string.Empty;

                QTEPresenterStates = QTEStates.Input;
                break;

            case QTEStates.Input:

                //入力にはタイムリミットを設ける
                m_timeLimit -= Time.unscaledDeltaTime;

                m_QTETimeLimitText.text = $"{m_timeLimit}";
                
                //タイムリミットが来たらResultに移行
                if (m_timeLimit < 0)
                {
                    QTEPresenterStates = QTEStates.Result;
                }
                break;

            case QTEStates.Result:

                if(m_QTEInputField.text.Equals(m_theme))
                {
                    //正解していたら体力を5回復
                    SphereDamage.AddSphereDamage(-5);
                }
                else
                {
                    //不正解ならダメージ
                    SphereDamage.AddSphereDamage(2);
                }
                SetQTEObject(false);
                //時間を戻す
                Time.timeScale = 1f;
                QTEPresenterStates = QTEStates.OFF;
                break;
        }
    }
    ///<summary>
    ///m_QTEText等のGameObjectのアクティブ状態を管理する
    ///</summary>
    ///<param name="active"></param>
    private void SetQTEObject(bool active)
    {
        m_QTEText.gameObject.SetActive(active);
        m_QTETimeLimitText.gameObject.SetActive(active);
        m_QTEInputField.gameObject.SetActive(active);
    }
}
