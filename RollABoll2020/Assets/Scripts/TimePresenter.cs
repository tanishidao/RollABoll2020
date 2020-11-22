using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimePresenter : TimeCount
{
    /// <summary>
    ///　時間を表示するTextComprnent
    ///　</summary>
    [SerializeField] private Text m_timeText = null;

    /// <summary>
    /// 秒数の下の桁数
    /// </summary>
    public enum TimeDecimalPlace
    {
        None = 0,
        DecimalOne,
        DecimalTwo,
    }
    
    public TimeDecimalPlace timeDecimal = TimePresenter.TimeDecimalPlace.None;
    // Update is called once per frame
   public override void Update()
    {
        base.Update();
        m_timeText.text = GetTimeDecimal(TimeUpdateCounts, (int)timeDecimal);
    }
}
