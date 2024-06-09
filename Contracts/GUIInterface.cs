using System;
namespace AbstractFactory.Contracts
{
	public interface GUIInterface
	{
		public IButtonInterface CreateButton();

		public ICheckBoxInterface CreateCheckbox();
	}
}

