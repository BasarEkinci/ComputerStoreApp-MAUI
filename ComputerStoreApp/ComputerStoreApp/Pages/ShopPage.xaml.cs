using ComputerStoreApp.Objects;

namespace ComputerStoreApp.Pages;

public partial class ShopPage : ContentPage
{
	private int _memory = 4;
	private int _monitorSize = 0;
	public ShopPage()
	{
		InitializeComponent();
		MemoryLabel.Text = "4";
	}

	private void MemoryButton_Clicked(object sender, EventArgs e)
	{
        if(sender == IncreaseMemory)
		{
			if(ShopManager.Instance.MemoryPrice <= 64)
			{
				_memory *= 2;
				ShopManager.Instance.IncreaseMemoryPrice();
            }
		}
		else if(sender == DecreaseMemory)
		{
			if(ShopManager.Instance.MemoryPrice >= 4)
			{
                ShopManager.Instance.DecreaseMemoryPrice();
            }
		}
		MemoryLabel.Text = _memory.ToString();
    }

	private void StorageButton_Clicked(object sender, EventArgs e)
	{

    }

    private void MonitorSizeButton_Clicked(object sender, EventArgs e)
    {

    }
}