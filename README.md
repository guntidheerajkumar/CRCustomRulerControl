# CRCustomRulerControl
Custom Ruler Control which can be easily used to transform any view.

This is a binding project based on https://github.com/Cleveroad/CRRulerControl


###Usage

```
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
```

###Output
![](https://github.com/guntidheerajkumar/CRCustomRulerControl/blob/master/Output.gif)
