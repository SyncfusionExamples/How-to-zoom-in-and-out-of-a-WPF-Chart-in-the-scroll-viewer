# How to zoom in and out of a WPF Chart in the scroll viewer
The article describes how to perform chart zooming within the scroll viewer using the mouse wheel. To enable zooming through the mouse wheel, set the [EnableMouseWheelZooming](https://help.syncfusion.com/cr/wpf/Syncfusion.UI.Xaml.Charts.ChartZoomPanBehavior.html#Syncfusion_UI_Xaml_Charts_ChartZoomPanBehavior_EnableMouseWheelZooming) property of [ChartZoomPanBehavior](https://help.syncfusion.com/cr/wpf/Syncfusion.UI.Xaml.Charts.ChartZoomPanBehavior.html) to true. 

The default behavior is that when the chart is placed inside the scroll viewer, it scrolls up or down instead of zooming in or out. By limiting the scrolling action to the scroll viewer, we can zoom in or out of the chart without any unintended interactions.
![DefaultScollViewerDisplay](https://user-images.githubusercontent.com/105496706/228227912-cb158545-f566-45fe-85ad-ae84cb03fbdf.gif)
The scrolling action inside the scroll viewer has been restricted according to the following code samples:

**[C#]**
```
public class ScrollViewerExt: ScrollViewer
    {
        protected override void OnMouseWheel(MouseWheelEventArgs e)
        {
            // To restrict scroll action on chart
            if (e.Source is SfChart)
                return;
            
            base.OnMouseWheel(e);
        }
    }
```
**[XAML]**
```
<local:ScrollViewerExt VerticalScrollBarVisibility="Visible" HorizontalScrollBarVisibility="Hidden" >
        <StackPanel>
            <chart:SfChart  x:Name="chart">
                . . .
                <chart:SfChart.Behaviors >
                    <chart:ChartZoomPanBehavior EnableMouseWheelZooming="True" />
                </chart:SfChart.Behaviors>
                . . .
            </chart:SfChart>
            <chart:SfChart  x:Name="chart1">
                . . .
                <chart:SfChart.Behaviors >
                    <chart:ChartZoomPanBehavior EnableMouseWheelZooming="True" />
                </chart:SfChart.Behaviors>
                . . .
            </chart:SfChart>

            <chart:SfChart  x:Name="chart2">
                . . .
                <chart:SfChart.Behaviors >
                    <chart:ChartZoomPanBehavior EnableMouseWheelZooming="True" />
                </chart:SfChart.Behaviors>
                . . .
            </chart:SfChart>
        </StackPanel>
    </local:ScrollViewerExt>
```
![RestrictedScrollDisplay](https://user-images.githubusercontent.com/105496706/228233809-eae9a7bc-c5b4-408a-8ce2-27991f1e5110.gif)
