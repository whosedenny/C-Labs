using System;

namespace LW8_2;
class Program
{
    static void Main(string[] args)
    {
        SmartPhone smart = new SmartPhone();
        smart.Call();
        smart.AcceptCall();
        smart.SendSms();
        smart.AcceptSms();
        smart.SendMms();
        smart.AcceptMms();
        smart.MakeAPhoto();
        smart.MakeAVideo();
    }
}