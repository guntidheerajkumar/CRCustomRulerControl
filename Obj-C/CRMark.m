 
#import "CRMark.h"

@implementation CRMark

- (instancetype)init {
    self = [super init];
    if (self) {
        self.frequency = 1.0;                                   // default frequency for minor mark
        self.size = CGSizeMake(1.0, 5.0);                       // default size for minor lines mark
        self.color = [UIColor blackColor];                      // default color set in RullerControl (is Tint Color)
        self.font = [UIFont systemFontOfSize:12 weight:UIFontWeightMedium]; // default font for all text mark
        self.textColor = [UIColor blackColor];                  // default color set in RullerControl (is Tint Color)
        self.alignment = CRRulerMarkAlignmentCenter;
        self.textAlignment = CRRulerMarkAlignmentBottom;
        self.offset = CGPointZero;
        self.textOffset = CGPointZero;
    }
    return self;
}

@end
