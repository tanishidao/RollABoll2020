using UnityEngine;
using UnityEngine.UI;

public class ClearPresenter : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private Text clearText = null;

    [SerializeField] private PickUpCountPresenter pickUpCountPresenter = null;

   private void Start()
            {
        //最初文字は決しておk
        clearText.text = string.Empty;
    }

    // Update is called once per frame
    void Update()
    {
        if (pickUpCountPresenter.GetPickUpCount.Equals(12))
        {
            clearText.text = "クリアー";
    }
    }

}
