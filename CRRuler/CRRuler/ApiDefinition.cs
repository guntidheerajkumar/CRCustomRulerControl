using System;
using CoreAnimation;
using CoreGraphics;
using Foundation;
using ObjCRuntime;
using UIKit;

namespace CRRuler
{
	// @interface CRMark : NSObject
	[BaseType(typeof(NSObject))]
	interface CRMark
	{
		// @property (nonatomic) CGFloat frequency;
		[Export("frequency")]
		nfloat Frequency { get; set; }

		// @property (nonatomic) CGSize size;
		[Export("size", ArgumentSemantic.Assign)]
		CGSize Size { get; set; }

		// @property (nonatomic) UIColor * color;
		[Export("color", ArgumentSemantic.Assign)]
		UIColor Color { get; set; }

		// @property (nonatomic) UIFont * font;
		[Export("font", ArgumentSemantic.Assign)]
		UIFont Font { get; set; }

		// @property (nonatomic) UIColor * textColor;
		[Export("textColor", ArgumentSemantic.Assign)]
		UIColor TextColor { get; set; }

		// @property (nonatomic) CRRulerMarkAlignment alignment;
		[Export("alignment", ArgumentSemantic.Assign)]
		CRRulerMarkAlignment Alignment { get; set; }

		// @property (nonatomic) CRRulerMarkAlignment textAlignment;
		[Export("textAlignment", ArgumentSemantic.Assign)]
		CRRulerMarkAlignment TextAlignment { get; set; }

		// @property (nonatomic) CGPoint textOffset;
		[Export("textOffset", ArgumentSemantic.Assign)]
		CGPoint TextOffset { get; set; }

		// @property (nonatomic) CGPoint offset;
		[Export("offset", ArgumentSemantic.Assign)]
		CGPoint Offset { get; set; }
	}

	// @interface CRRulerLayer : CALayer
	[BaseType(typeof(CALayer))]
	interface CRRulerLayer
	{
		// @property (nonatomic) CRRange rulerRange;
		[Export("rulerRange", ArgumentSemantic.Assign)]
		CRRange RulerRange { get; set; }

		// @property (nonatomic) CRMark * minorMark;
		[Export("minorMark", ArgumentSemantic.Assign)]
		CRMark MinorMark { get; set; }

		// @property (nonatomic) CRMark * middleMark;
		[Export("middleMark", ArgumentSemantic.Assign)]
		CRMark MiddleMark { get; set; }

		// @property (nonatomic) CRMark * majorMark;
		[Export("majorMark", ArgumentSemantic.Assign)]
		CRMark MajorMark { get; set; }
	}

	// @interface CRRulerControl : UIControl
	[BaseType(typeof(UIControl))]
	interface CRRulerControl
	{
		// @property (readonly, nonatomic) UIScrollView * scrollView;
		[Export("scrollView")]
		UIScrollView ScrollView { get; }

		// @property (readonly, nonatomic) UIImageView * pointerImageView;
		[Export("pointerImageView")]
		UIImageView PointerImageView { get; }

		// @property (nonatomic) CGFloat spacingBetweenMarks;
		[Export("spacingBetweenMarks")]
		nfloat SpacingBetweenMarks { get; set; }

		// @property (nonatomic) CGFloat rulerWidth;
		[Export("rulerWidth")]
		nfloat RulerWidth { get; set; }

		// @property (nonatomic) CGFloat rangeFrom;
		[Export("rangeFrom")]
		nfloat RangeFrom { get; set; }

		// @property (nonatomic) CGFloat rangeLength;
		[Export("rangeLength")]
		nfloat RangeLength { get; set; }

		// @property (nonatomic) CGFloat value;
		[Export("value")]
		nfloat Value { get; set; }

		// -(void)setValue:(CGFloat)value animated:(BOOL)animated;
		[Export("setValue:animated:")]
		void SetValue(nfloat value, bool animated);

		// -(CGRect)frameForPointerImageView;
		[Export("frameForPointerImageView")]
		CGRect FrameForPointerImageView { get; }

		// -(CGPoint)contentOffsetForValue:(CGFloat)value;
		[Export("contentOffsetForValue:")]
		CGPoint ContentOffsetForValue(nfloat value);

		// -(void)setSize:(CGSize)size forMarkType:(CRRulerMarkType)markType;
		[Export("setSize:forMarkType:")]
		void SetSize(CGSize size, CRRulerMarkType markType);

		// -(void)setColor:(UIColor *)color forMarkType:(CRRulerMarkType)markType;
		[Export("setColor:forMarkType:")]
		void SetColor(UIColor color, CRRulerMarkType markType);

		// -(void)setTextColor:(UIColor *)textColor forMarkType:(CRRulerMarkType)markType;
		[Export("setTextColor:forMarkType:")]
		void SetTextColor(UIColor textColor, CRRulerMarkType markType);

		// -(void)setFont:(UIFont *)font forMarkType:(CRRulerMarkType)markType;
		[Export("setFont:forMarkType:")]
		void SetFont(UIFont font, CRRulerMarkType markType);

		// -(void)setFrequency:(CGFloat)frequency forMarkType:(CRRulerMarkType)markType;
		[Export("setFrequency:forMarkType:")]
		void SetFrequency(nfloat frequency, CRRulerMarkType markType);

		// -(void)setTextAlignment:(CRRulerMarkAlignment)alignment forMarkType:(CRRulerMarkType)markType;
		[Export("setTextAlignment:forMarkType:")]
		void SetTextAlignment(CRRulerMarkAlignment alignment, CRRulerMarkType markType);

		// -(void)setAlignment:(CRRulerMarkAlignment)alignment forMarkType:(CRRulerMarkType)markType;
		[Export("setAlignment:forMarkType:")]
		void SetAlignment(CRRulerMarkAlignment alignment, CRRulerMarkType markType);

		// -(void)setTextOffset:(CGPoint)textOffset forMarkType:(CRRulerMarkType)markType;
		[Export("setTextOffset:forMarkType:")]
		void SetTextOffset(CGPoint textOffset, CRRulerMarkType markType);

		// -(void)setOffset:(CGPoint)offset forMarkType:(CRRulerMarkType)markType;
		[Export("setOffset:forMarkType:")]
		void SetOffset(CGPoint offset, CRRulerMarkType markType);

		// -(CGSize)sizeForMarkType:(CRRulerMarkType)markType;
		[Export("sizeForMarkType:")]
		CGSize SizeForMarkType(CRRulerMarkType markType);

		// -(UIColor *)colorForMarkType:(CRRulerMarkType)markType;
		[Export("colorForMarkType:")]
		UIColor ColorForMarkType(CRRulerMarkType markType);

		// -(UIColor *)textColorForMarkType:(CRRulerMarkType)markType;
		[Export("textColorForMarkType:")]
		UIColor TextColorForMarkType(CRRulerMarkType markType);

		// -(UIFont *)fontForMarkType:(CRRulerMarkType)markType;
		[Export("fontForMarkType:")]
		UIFont FontForMarkType(CRRulerMarkType markType);

		// -(CGFloat)frequencyForMarkType:(CRRulerMarkType)markType;
		[Export("frequencyForMarkType:")]
		nfloat FrequencyForMarkType(CRRulerMarkType markType);

		// -(CRRulerMarkAlignment)textAlignmentForMarkType:(CRRulerMarkType)markType;
		[Export("textAlignmentForMarkType:")]
		CRRulerMarkAlignment TextAlignmentForMarkType(CRRulerMarkType markType);

		// -(CRRulerMarkAlignment)alignmentForMarkType:(CRRulerMarkType)markType;
		[Export("alignmentForMarkType:")]
		CRRulerMarkAlignment AlignmentForMarkType(CRRulerMarkType markType);

		// -(CGPoint)textOffsetForMarkType:(CRRulerMarkType)markType;
		[Export("textOffsetForMarkType:")]
		CGPoint TextOffsetForMarkType(CRRulerMarkType markType);

		// -(CGPoint)offsetForMarkType:(CRRulerMarkType)markType;
		[Export("offsetForMarkType:")]
		CGPoint OffsetForMarkType(CRRulerMarkType markType);
	}
}
