using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEngine.UI;

public class PickUpCountPresenter : MonoBehaviour
{
    [SerializeField]private Text pickUpCountText = null;
    private static int pickUpCounter = 0;
    
    public int GetPickUpCount
    {
        get { return pickUpCounter; }
            }
    public void Update()
    {
        pickUpCountText.text = $"{pickUpCounter}";
    }

        ///<summary>
        ///引数をpickUpCountrに加算
        ///＜/summary＞
        ///<param name="dissapperCount"></param>
        
        public static void CountDisplay(int dissapperCount)
        {
            pickUpCounter += dissapperCount;
        }
   
    }
    

