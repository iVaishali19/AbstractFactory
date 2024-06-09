using System;
using AbstractFactory.Contracts;

namespace AbstractFactory.Implementations
{
	public class Application
	{
		private GUIInterface factory;
        private IButtonInterface button;

        public Application(GUIInterface gUIInterface)
		{
			this.factory = gUIInterface;
		}

		public void CreateUI()
		{
			this.button = factory.CreateButton();
		}

		public void Paint()
		{
			button.Paint();
		}
	}
}

