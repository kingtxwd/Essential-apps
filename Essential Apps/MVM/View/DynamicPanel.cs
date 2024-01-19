using System;
using System.Windows;
using System.Windows.Controls;

namespace Essential_Apps.MVM.View
{
    public class DynamicPanel : Panel
    {
        protected override Size MeasureOverride(Size availableSize)
        {
            double minWidth = double.MaxValue;
            double maxWidth = double.MinValue;
            foreach (UIElement child in InternalChildren)
            {
                double childMinWidth = (double)child.GetValue(MinWidthProperty);
                double childMaxWidth = (double)child.GetValue(MaxWidthProperty);
                minWidth = Math.Min(minWidth, childMinWidth);
                maxWidth = Math.Max(maxWidth, childMaxWidth);
            }
            if (minWidth == double.MaxValue) { return new Size(0, 0); }
            return new Size(minWidth, maxWidth);
        }

        protected override Size ArrangeOverride(Size finalSize)
        {
            double totalWidth = 0;
            double minWidth = double.MaxValue;
            double maxWidth = double.MinValue;
            double margins = 5;
            int itemCount = InternalChildren.Count;
            double height = 0;
            foreach (UIElement child in InternalChildren)
            {
                double childMinWidth = (double)child.GetValue(MinWidthProperty);
                double childMaxWidth = (double)child.GetValue(MaxWidthProperty);
                minWidth = Math.Min(minWidth, childMinWidth);
                maxWidth = Math.Max(maxWidth, childMaxWidth);
                height = (double) child.GetValue(HeightProperty); 
                child.Arrange(new Rect(new Point(0,0), new Size(0, 0)));
            }
            double availableWidth = finalSize.Width;
            availableWidth -= margins;
            int maxRectangle = (int)Math.Floor((availableWidth / (minWidth + margins)));
            if (maxRectangle >= 2)
            {
                maxRectangle = Math.Min(itemCount, maxRectangle);
                totalWidth += margins;
                double widthPerRectangle = (availableWidth / maxRectangle) - margins;
                for (int i = 0; i < maxRectangle; i++)
                {
                    InternalChildren[i].Arrange(new Rect(new Point(totalWidth, 48), new Size(widthPerRectangle, height + 10)));
                    totalWidth += widthPerRectangle + margins;
                }
            }        
            return finalSize;
        }
    }
}
