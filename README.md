# How to create custom annotation in WPF Chart (SfChart)?

This article explains how to display custom content in WPF SfChart Annotation by following the steps.

**Step 1:** Write a custom class inheriting from [RectangleAnnotation](https://help.syncfusion.com/cr/wpf/Syncfusion.UI.Xaml.Charts.RectangleAnnotation.html) and add the Content property in this class.

**[C#]**
```
public class CustomTextAnnotation : RectangleAnnotation
{
    public object Content
    {
        get { return GetValue(ContentProperty); }
        set { SetValue(ContentProperty, value); }
    }

    // Using DependencyProperty as the backing store for TextString.  This enables animation, styling, binding, etc...
    public static readonly DependencyProperty ContentProperty = DependencyProperty.Register("Content", typeof(object), typeof(CustomTextAnnotation), new PropertyMetadata(null));

    protected override void SetBindings()
    {
        base.SetBindings();  //You need to invoke this method to make all the default bindings
        if (TextElement != null)
        {
            Binding textBinding = new Binding { Path = new PropertyPath("Content"), Source = this };
            //TextElement is content control define internally to display text.
            TextElement.SetBinding(ContentControl.ContentProperty, textBinding);
        }
    }
}
```

**Step 2:** Add the necessary content in the Content property of Annotation.

**[XAML]**
```
<chart:SfChart  x:Name="chart" Margin="10" >
    <chart:SfChart.PrimaryAxis>
        <chart:CategoryAxis/>
    </chart:SfChart.PrimaryAxis>

    <chart:SfChart.SecondaryAxis>
        <chart:NumericalAxis/>
    </chart:SfChart.SecondaryAxis>

    <chart:SfChart.Annotations>
        <local:CustomTextAnnotation X1="1.6" X2="2.4" Y1="17.8" Y2="20.3" HorizontalTextAlignment="Center" 
                                    VerticalTextAlignment="Center" CanDrag="True" CanResize="True" x:Name="annotation">
            <local:CustomTextAnnotation.Content>
                <StackPanel Orientation="Horizontal">
                    <Path Data="M16.710899,36.727C20.7409,39.759457 25.747499,41.558827 31.1693,41.558827 36.588501,
                          41.558827 41.596401,39.759457 45.627602,36.727 55.046902,37.911882 62.335999,
                          45.946764 62.335999,55.688923L62.335999,64 0,64 0,55.688923C0,45.946764,7.2904,37.911882,
                          16.710899,36.727z M31.169201,0C40.807137,0 48.622002,7.8164558 48.622002,
                          17.455803 48.622002,27.095258 40.807137,34.909003 31.169201,34.909003 21.528767,
                          34.909003 13.715,27.095258 13.715,17.455803 13.715,7.8164558 21.528767,0 31.169201,0z" 
                          Stretch="Uniform" Fill="#606060" Height="49" Width="49"/>
                    <TextBox Text="Employee:Jack Profit:16%" x:Name="textBox" Height="49" BorderBrush="Transparent"
                             TextWrapping="Wrap" FontSize="15" HorizontalContentAlignment="Center" 
                             VerticalContentAlignment="Center" Foreground="Black" Background="Transparent" Width="105" />
                </StackPanel>
            </local:CustomTextAnnotation.Content>
        </local:CustomTextAnnotation>
    </chart:SfChart.Annotations>

    <chart:ColumnSeries ItemsSource="{Binding Collection}" XBindingPath="XValue" YBindingPath="YValue"/>
</chart:SfChart>
```

## Output:

![Customized Rectangle Annotation with button](https://user-images.githubusercontent.com/102642528/212282757-e057007f-7bc2-46b7-832f-712dc69bbf20.png)
