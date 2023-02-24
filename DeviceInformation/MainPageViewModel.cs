using CommunityToolkit.Mvvm.ComponentModel;

namespace ManufacturerFinder;

public partial class MainPageViewModel : ObservableObject
{
    public MainPageViewModel()
    {
        Device_Model = DeviceInfo.Model;
        Device_Manufacturer = DeviceInfo.Manufacturer;
        Device_Name = DeviceInfo.Name;
        Device_Version = DeviceInfo.VersionString;
        Device_Platform = DeviceInfo.Platform.ToString();
        Device_Idiom = DeviceInfo.Idiom.ToString();
        Device_DeviceType = DeviceInfo.DeviceType.ToString();
    }

    [ObservableProperty]
    string device_Model;

    [ObservableProperty]
    string device_Manufacturer;

    [ObservableProperty]
    string device_Name;

    [ObservableProperty]
    string device_Version;

    [ObservableProperty]
    string device_Platform;

    [ObservableProperty]
    string device_Idiom;

    [ObservableProperty]
    string device_DeviceType;
}

