using ComputerStoreApp.Objects;

namespace ComputerStoreApp.Pages;

public partial class StorePage : ContentPage
{
	public StorePage()
	{
		InitializeComponent();
	}

	public void CPUButton_CheckedChanged(object sender, CheckedChangedEventArgs e)
	{
        if(sender == I3Button && I3Button.IsChecked)
		{
			ShopManager.Instance.SetCpuPrice(1500);
        }
        else if(sender == I5Button && I5Button.IsChecked)
		{
			ShopManager.Instance.SetCpuPrice(1700);
        }
		else if(sender == I7Button && I7Button.IsChecked)
		{
			ShopManager.Instance.SetCpuPrice(2000);
		}
		else if(sender == I9Button && I9Button.IsChecked)
		{
			ShopManager.Instance.SetCpuPrice(2500);
		}
    }	

	private void MonitorButton_CheckedChanged(object sender, CheckedChangedEventArgs e)
	{
		if(sender == PhilipsButton && PhilipsButton.IsChecked)
		{
			ShopManager.Instance.SetMonitorPrice(1500);
		}
		else if(sender == HPButton && HPButton.IsChecked)
		{
			ShopManager.Instance.SetMonitorPrice(2000);
		}
		else if(sender == NECButton && NECButton.IsChecked)
		{
			ShopManager.Instance.SetMonitorPrice(1300);
		}
    }

	private void StorageButton_CheckedChanged(object sender, CheckedChangedEventArgs e)
	{
        if(sender == SSDButton && SSDButton.IsChecked)
		{
			ShopManager.Instance.SetStoragePrice(500);
        }
        else if(sender == HDDButton && HDDButton.IsChecked)
		{
			ShopManager.Instance.SetStoragePrice(300);
        }
    }	
}