using System;
using System.Collections.Generic;
using CocosSharp;

namespace ARM64BugLook
{
	public class GameLayer : CCLayerColor
	{
		private CCLabel DummyLabel;
		private int Counter;
		public GameLayer () : base (CCColor4B.AliceBlue)
		{
			Position = new CCPoint (100, 100);
		}

		protected override void AddedToScene ()
		{
			base.AddedToScene ();
			Counter = 0;
			DummyLabel = new CCLabel (Counter + "", "Avenir", 100);

			AddChild (DummyLabel);
			DummyLabel.Position = new CCPoint (50, 50);
			Schedule (UpdateView, 1f/30f);
		}

		private void UpdateView (float dt){
			DummyLabel.Text = ++Counter + "";
		}
	}
}
