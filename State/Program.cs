using System;

namespace State
{
    class Program
    {
        static void Main(string[] args)
        {
            PhoneContext phone = new PhoneContext();
            phone.ChangeState(new OffState(phone));
            phone.PressKeyboardButtons();
            phone.PressVolumeButtons();

            phone.PressPowerButton();

            phone.PressVolumeButtons();
            phone.PressKeyboardButtons();

            phone.PressVolumeButtons();
            phone.PressKeyboardButtons();

            phone.PressPowerButton();
            phone.PressKeyboardButtons();

            phone.PressPowerButton();
            phone.PressVolumeButtons();

            phone.PressPowerButton();
            phone.PressKeyboardButtons();

        }
    }
}
