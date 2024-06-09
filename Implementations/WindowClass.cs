using System;
using AbstractFactory.Contracts;

namespace AbstractFactory.Implementations
{
	public class WindowClass : GUIInterface
	{
        public IButtonInterface CreateButton()
        {
            return new WindowsButton();
        }

        public ICheckBoxInterface CreateCheckbox()
        {
            return new WindowsCheckBox();
        }
    }
}

