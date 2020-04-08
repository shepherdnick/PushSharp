﻿namespace PushSharpStandard.Core
{
    public interface INotification
    {
        bool IsDeviceRegistrationIdValid();
        object Tag { get; set; }
    }
}
