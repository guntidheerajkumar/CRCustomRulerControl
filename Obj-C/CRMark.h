 
#import <Foundation/Foundation.h>
#import <CoreGraphics/CoreGraphics.h>
#import <UIKit/UIKit.h>

@interface CRMark : NSObject

typedef NS_ENUM(NSUInteger, CRRulerMarkAlignment) {
    CRRulerMarkAlignmentBottom = 0,
    CRRulerMarkAlignmentCenter,
    CRRulerMarkAlignmentTop,
};

@property (nonatomic) CGFloat frequency;
@property (nonatomic) CGSize size;
@property (nonatomic) UIColor *color;
@property (nonatomic) UIFont *font;
@property (nonatomic) UIColor *textColor;
@property (nonatomic) CRRulerMarkAlignment alignment;
@property (nonatomic) CRRulerMarkAlignment textAlignment;
@property (nonatomic) CGPoint textOffset;
@property (nonatomic) CGPoint offset;

@end
