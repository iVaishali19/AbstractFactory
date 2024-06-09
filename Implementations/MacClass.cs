using System;
using AbstractFactory.Contracts;

namespace AbstractFactory.Implementations
{
    public class MacClass : GUIInterface
    {
        public IButtonInterface CreateButton()
        {
            return new MacButton();
        }

        public ICheckBoxInterface CreateCheckbox()
        {
            return new MacCheckBox();
        }
    }
}

