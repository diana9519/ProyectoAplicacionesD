using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Essentials;

namespace Movil
{
    public static class Config
    {
        public static string Url = DeviceInfo.Platform == DevicePlatform.Android ? "http://servidor4distri.somee.com/servicios/Services.svc" : "http://servidor4distri.somee.com/servicios/Services.svc";
        public static string UrlSignalr = DeviceInfo.Platform == DevicePlatform.Android ? "http://servidor4distri.somee.com/signalr/chat" : "http://servidor4distri.somee.com/signalr/chat ";

    }
}
