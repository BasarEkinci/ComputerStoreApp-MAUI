
namespace ComputerStoreApp.Objects;

public class ShopManager
{
    #region Singleton
    private static ShopManager ?_instance;
    private static readonly object lockObject = new object();


    public static ShopManager Instance
    {
        get
        {
            if (_instance == null)
            {
                lock (lockObject)
                {
                    if (_instance == null)
                    {
                        _instance = new ShopManager();
                    }
                }
            }
            return _instance;
        }
    }

    private ShopManager() { }
    #endregion

    #region Public Properties
    public double TotalPrice => _totalPrice;
    public double StoragePrice => _storagePrice;
    public double MonitorPrice => _monitorPrice;
    public double CpuPrice => _cpuPrice;
    public double MemoryPrice => _memoryPrice;

    #endregion

    #region Private Fields

    private double _totalPrice;
    private double _storagePrice;
    private double _monitorPrice;
    private double _cpuPrice;
    private double _memoryPrice = 150;

    #endregion

    //Storage
    public void SetStoragePrice(double value)
    {
        _storagePrice = value;
    }

    public double ChangeStoragePrice(double value)
    {
        var result = _storagePrice + value;
        _storagePrice = result;
        return _storagePrice;
    }

    //Monitor
    public void SetMonitorPrice(double value)
    {
        _monitorPrice = value;
    }   
    public double ChangeMonitorPrice(double value)
    {
        var result = _monitorPrice + value;
        _monitorPrice = result;
        return _monitorPrice;
    }

    //Cpu
    public void SetCpuPrice(double value)
    {
        _cpuPrice = value;
    }

    //Memory
    public void SetMemoryPrice(double value)
    {
        _memoryPrice = value;
    }
    public double IncreaseMemoryPrice()
    {
        var result = _memoryPrice * 2;
        _memoryPrice = result;
        return _memoryPrice;
    }

    public double DecreaseMemoryPrice()
    {
        var result = _memoryPrice / 2;
        _memoryPrice = result;
        return _memoryPrice;
    }

    public double CalculateTotalPrice()
    {
        _totalPrice = _storagePrice + _monitorPrice + _cpuPrice + _memoryPrice;
        return _totalPrice;
    }
}
