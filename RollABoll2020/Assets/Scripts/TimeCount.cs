using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeCount : MonoBehaviour
{
    // Start is called before the first frame update


    /// <summary>
    /// 時間を計測するカウント
    /// </summary>
    public float TimeUpdateCounts { get; private set; } = 0f;

    // Update is called once per frame
    public virtual void Update()
    {
        TimeUpdateCounts += Time.deltaTime;
    }

    ///<summary>
    ///秒数と任意の小数点以下の桁数を返す
    /// </summary>
    /// <param name="timeCounts">TimeUpdateCounts</param>
    /// <param name="decimalPlace">指定の桁</param>
    public string GetTimeDecimal(float timeCounts,int decimalPlace)
    {
        var secondsTxt = timeCounts.ToString($"F{decimalPlace}");
        return secondsTxt;
    }
    }