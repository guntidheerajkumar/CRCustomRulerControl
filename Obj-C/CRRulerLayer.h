 
#import <QuartzCore/QuartzCore.h>
#import "CRMark.h"

@interface CRRulerLayer : CALayer

typedef struct CRRange {
    CGFloat location;
    CGFloat length;
} CRRange;

@property (nonatomic) CRRange rulerRange;

@property (nonatomic) CRMark *minorMark;
@property (nonatomic) CRMark *middleMark;
@property (nonatomic) CRMark *majorMark;

@end
