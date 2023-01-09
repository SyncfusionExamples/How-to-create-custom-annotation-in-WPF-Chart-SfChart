using Syncfusion.UI.Xaml.Charts;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;

namespace Custom_Annotation
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // Can perform any action required
        }
    }

    public class CustomTextAnnotation : RectangleAnnotation
    {
        public object Content
        {
            get { return GetValue(ContentProperty); }
            set { SetValue(ContentProperty, value); }
        }

        // Using DependencyProperty as the backing store for TextString.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ContentProperty =
            DependencyProperty.Register("Content", typeof(object), typeof(CustomTextAnnotation), new PropertyMetadata(null));

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
}
