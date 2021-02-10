/******************************************************************************/
//
//                             DO NOT MODIFY
//          This file has been generated by the UIElementsGenerator tool
//              See StyleGroupStructsCsGenerator class for details
//
/******************************************************************************/
using System;

namespace UnityEngine.UIElements
{
    internal struct InheritedData : IEquatable<InheritedData>
    {
        public Color color;
        public Length fontSize;
        public Font unityFont;
        public FontStyle unityFontStyleAndWeight;
        public TextAnchor unityTextAlign;
        public Visibility visibility;
        public WhiteSpace whiteSpace;

        public static bool operator==(InheritedData lhs, InheritedData rhs)
        {
            return lhs.color == rhs.color &&
                lhs.fontSize == rhs.fontSize &&
                lhs.unityFont == rhs.unityFont &&
                lhs.unityFontStyleAndWeight == rhs.unityFontStyleAndWeight &&
                lhs.unityTextAlign == rhs.unityTextAlign &&
                lhs.visibility == rhs.visibility &&
                lhs.whiteSpace == rhs.whiteSpace;
        }

        public static bool operator!=(InheritedData lhs, InheritedData rhs)
        {
            return !(lhs == rhs);
        }

        public bool Equals(InheritedData other)
        {
            return other == this;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj))
                return false;
            return obj is InheritedData &&
                Equals((InheritedData)obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = color.GetHashCode();
                hashCode = (hashCode * 397) ^ fontSize.GetHashCode();
                hashCode = (hashCode * 397) ^ (unityFont == null ? 0 : unityFont.GetHashCode());
                hashCode = (hashCode * 397) ^ (int)unityFontStyleAndWeight;
                hashCode = (hashCode * 397) ^ (int)unityTextAlign;
                hashCode = (hashCode * 397) ^ (int)visibility;
                hashCode = (hashCode * 397) ^ (int)whiteSpace;
                return hashCode;
            }
        }
    }

    internal struct NonInheritedData : IEquatable<NonInheritedData>
    {
        public Align alignContent;
        public Align alignItems;
        public Align alignSelf;
        public Color backgroundColor;
        public Background backgroundImage;
        public Color borderBottomColor;
        public Length borderBottomLeftRadius;
        public Length borderBottomRightRadius;
        public float borderBottomWidth;
        public Color borderLeftColor;
        public float borderLeftWidth;
        public Color borderRightColor;
        public float borderRightWidth;
        public Color borderTopColor;
        public Length borderTopLeftRadius;
        public Length borderTopRightRadius;
        public float borderTopWidth;
        public Length bottom;
        public Cursor cursor;
        public DisplayStyle display;
        public Length flexBasis;
        public FlexDirection flexDirection;
        public float flexGrow;
        public float flexShrink;
        public Wrap flexWrap;
        public Length height;
        public Justify justifyContent;
        public Length left;
        public Length marginBottom;
        public Length marginLeft;
        public Length marginRight;
        public Length marginTop;
        public Length maxHeight;
        public Length maxWidth;
        public Length minHeight;
        public Length minWidth;
        public float opacity;
        public OverflowInternal overflow;
        public Length paddingBottom;
        public Length paddingLeft;
        public Length paddingRight;
        public Length paddingTop;
        public Position position;
        public Length right;
        public TextOverflow textOverflow;
        public Length top;
        public Color unityBackgroundImageTintColor;
        public ScaleMode unityBackgroundScaleMode;
        public OverflowClipBox unityOverflowClipBox;
        public int unitySliceBottom;
        public int unitySliceLeft;
        public int unitySliceRight;
        public int unitySliceTop;
        public TextOverflowPosition unityTextOverflowPosition;
        public Length width;

        public static bool operator==(NonInheritedData lhs, NonInheritedData rhs)
        {
            return lhs.alignContent == rhs.alignContent &&
                lhs.alignItems == rhs.alignItems &&
                lhs.alignSelf == rhs.alignSelf &&
                lhs.backgroundColor == rhs.backgroundColor &&
                lhs.backgroundImage == rhs.backgroundImage &&
                lhs.borderBottomColor == rhs.borderBottomColor &&
                lhs.borderBottomLeftRadius == rhs.borderBottomLeftRadius &&
                lhs.borderBottomRightRadius == rhs.borderBottomRightRadius &&
                lhs.borderBottomWidth == rhs.borderBottomWidth &&
                lhs.borderLeftColor == rhs.borderLeftColor &&
                lhs.borderLeftWidth == rhs.borderLeftWidth &&
                lhs.borderRightColor == rhs.borderRightColor &&
                lhs.borderRightWidth == rhs.borderRightWidth &&
                lhs.borderTopColor == rhs.borderTopColor &&
                lhs.borderTopLeftRadius == rhs.borderTopLeftRadius &&
                lhs.borderTopRightRadius == rhs.borderTopRightRadius &&
                lhs.borderTopWidth == rhs.borderTopWidth &&
                lhs.bottom == rhs.bottom &&
                lhs.cursor == rhs.cursor &&
                lhs.display == rhs.display &&
                lhs.flexBasis == rhs.flexBasis &&
                lhs.flexDirection == rhs.flexDirection &&
                lhs.flexGrow == rhs.flexGrow &&
                lhs.flexShrink == rhs.flexShrink &&
                lhs.flexWrap == rhs.flexWrap &&
                lhs.height == rhs.height &&
                lhs.justifyContent == rhs.justifyContent &&
                lhs.left == rhs.left &&
                lhs.marginBottom == rhs.marginBottom &&
                lhs.marginLeft == rhs.marginLeft &&
                lhs.marginRight == rhs.marginRight &&
                lhs.marginTop == rhs.marginTop &&
                lhs.maxHeight == rhs.maxHeight &&
                lhs.maxWidth == rhs.maxWidth &&
                lhs.minHeight == rhs.minHeight &&
                lhs.minWidth == rhs.minWidth &&
                lhs.opacity == rhs.opacity &&
                lhs.overflow == rhs.overflow &&
                lhs.paddingBottom == rhs.paddingBottom &&
                lhs.paddingLeft == rhs.paddingLeft &&
                lhs.paddingRight == rhs.paddingRight &&
                lhs.paddingTop == rhs.paddingTop &&
                lhs.position == rhs.position &&
                lhs.right == rhs.right &&
                lhs.textOverflow == rhs.textOverflow &&
                lhs.top == rhs.top &&
                lhs.unityBackgroundImageTintColor == rhs.unityBackgroundImageTintColor &&
                lhs.unityBackgroundScaleMode == rhs.unityBackgroundScaleMode &&
                lhs.unityOverflowClipBox == rhs.unityOverflowClipBox &&
                lhs.unitySliceBottom == rhs.unitySliceBottom &&
                lhs.unitySliceLeft == rhs.unitySliceLeft &&
                lhs.unitySliceRight == rhs.unitySliceRight &&
                lhs.unitySliceTop == rhs.unitySliceTop &&
                lhs.unityTextOverflowPosition == rhs.unityTextOverflowPosition &&
                lhs.width == rhs.width;
        }

        public static bool operator!=(NonInheritedData lhs, NonInheritedData rhs)
        {
            return !(lhs == rhs);
        }

        public bool Equals(NonInheritedData other)
        {
            return other == this;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj))
                return false;
            return obj is NonInheritedData &&
                Equals((NonInheritedData)obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = (int)alignContent;
                hashCode = (hashCode * 397) ^ (int)alignItems;
                hashCode = (hashCode * 397) ^ (int)alignSelf;
                hashCode = (hashCode * 397) ^ backgroundColor.GetHashCode();
                hashCode = (hashCode * 397) ^ backgroundImage.GetHashCode();
                hashCode = (hashCode * 397) ^ borderBottomColor.GetHashCode();
                hashCode = (hashCode * 397) ^ borderBottomLeftRadius.GetHashCode();
                hashCode = (hashCode * 397) ^ borderBottomRightRadius.GetHashCode();
                hashCode = (hashCode * 397) ^ borderBottomWidth.GetHashCode();
                hashCode = (hashCode * 397) ^ borderLeftColor.GetHashCode();
                hashCode = (hashCode * 397) ^ borderLeftWidth.GetHashCode();
                hashCode = (hashCode * 397) ^ borderRightColor.GetHashCode();
                hashCode = (hashCode * 397) ^ borderRightWidth.GetHashCode();
                hashCode = (hashCode * 397) ^ borderTopColor.GetHashCode();
                hashCode = (hashCode * 397) ^ borderTopLeftRadius.GetHashCode();
                hashCode = (hashCode * 397) ^ borderTopRightRadius.GetHashCode();
                hashCode = (hashCode * 397) ^ borderTopWidth.GetHashCode();
                hashCode = (hashCode * 397) ^ bottom.GetHashCode();
                hashCode = (hashCode * 397) ^ cursor.GetHashCode();
                hashCode = (hashCode * 397) ^ (int)display;
                hashCode = (hashCode * 397) ^ flexBasis.GetHashCode();
                hashCode = (hashCode * 397) ^ (int)flexDirection;
                hashCode = (hashCode * 397) ^ flexGrow.GetHashCode();
                hashCode = (hashCode * 397) ^ flexShrink.GetHashCode();
                hashCode = (hashCode * 397) ^ (int)flexWrap;
                hashCode = (hashCode * 397) ^ height.GetHashCode();
                hashCode = (hashCode * 397) ^ (int)justifyContent;
                hashCode = (hashCode * 397) ^ left.GetHashCode();
                hashCode = (hashCode * 397) ^ marginBottom.GetHashCode();
                hashCode = (hashCode * 397) ^ marginLeft.GetHashCode();
                hashCode = (hashCode * 397) ^ marginRight.GetHashCode();
                hashCode = (hashCode * 397) ^ marginTop.GetHashCode();
                hashCode = (hashCode * 397) ^ maxHeight.GetHashCode();
                hashCode = (hashCode * 397) ^ maxWidth.GetHashCode();
                hashCode = (hashCode * 397) ^ minHeight.GetHashCode();
                hashCode = (hashCode * 397) ^ minWidth.GetHashCode();
                hashCode = (hashCode * 397) ^ opacity.GetHashCode();
                hashCode = (hashCode * 397) ^ (int)overflow;
                hashCode = (hashCode * 397) ^ paddingBottom.GetHashCode();
                hashCode = (hashCode * 397) ^ paddingLeft.GetHashCode();
                hashCode = (hashCode * 397) ^ paddingRight.GetHashCode();
                hashCode = (hashCode * 397) ^ paddingTop.GetHashCode();
                hashCode = (hashCode * 397) ^ (int)position;
                hashCode = (hashCode * 397) ^ right.GetHashCode();
                hashCode = (hashCode * 397) ^ (int)textOverflow;
                hashCode = (hashCode * 397) ^ top.GetHashCode();
                hashCode = (hashCode * 397) ^ unityBackgroundImageTintColor.GetHashCode();
                hashCode = (hashCode * 397) ^ (int)unityBackgroundScaleMode;
                hashCode = (hashCode * 397) ^ (int)unityOverflowClipBox;
                hashCode = (hashCode * 397) ^ unitySliceBottom;
                hashCode = (hashCode * 397) ^ unitySliceLeft;
                hashCode = (hashCode * 397) ^ unitySliceRight;
                hashCode = (hashCode * 397) ^ unitySliceTop;
                hashCode = (hashCode * 397) ^ (int)unityTextOverflowPosition;
                hashCode = (hashCode * 397) ^ width.GetHashCode();
                return hashCode;
            }
        }
    }
}
