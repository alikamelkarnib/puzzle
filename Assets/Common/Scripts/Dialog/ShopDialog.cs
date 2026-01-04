 using UnityEngine.UI;

public class ShopDialog : Dialog
{
    public Text[] valueTexts, priceTexts;
    public Text watchAdValueText;

    protected override void Start()
    {
        base.Start();
 

        watchAdValueText.text = ConfigController.Config.rewardedVideoAmount + " Free";
    }

    public void OnBuyProduct(int index)
	{
		Sound.instance.PlayButton();
     }

    
}
