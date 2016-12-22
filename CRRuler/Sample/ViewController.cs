using System;
using CRRuler;
using UIKit;
using CoreGraphics;

namespace Sample
{
	public partial class ViewController : UIViewController
	{
		protected ViewController(IntPtr handle) : base(handle)
		{
			// Note: this .ctor should not contain any initialization logic.
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			var rulerView = new CRRulerControl();
			rulerView.Frame = new CGRect(20, 70, this.View.Frame.Width - 40, 50);
			rulerView.RulerWidth = this.View.Frame.Width - 40;
			rulerView.RangeLength = 1000f;
			rulerView.RangeFrom = 10f;
			rulerView.SetFrequency(10, CRRulerMarkType.Minor);
			rulerView.Value = 10f;
			rulerView.SpacingBetweenMarks = 10f;
			rulerView.ValueChanged += (sender, e) =>
			{
				this.LblSelectedValue.Text = Math.Round(Convert.ToDouble(((CRRulerControl)sender).Value)).ToString();
			};
			this.View.AddSubview(rulerView);
		}
	}
}
