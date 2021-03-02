
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MyPlathsRecordingSoftware.Views
{
    /// <summary>
    /// Interaction logic for DependencyTest.xaml
    /// </summary>
    public partial class DependencyTest : UserControl
    {
        public DependencyTest()
        {
            InitializeComponent();
            DataContext = this;
            Secret = "Test";
        }

        /// <summary>
        /// We use dependency properties for example to show a property(control) with a default value based on on the input value
        /// to add a custom dependency property
        /// </summary>
        /// 
        ///
        /// <summary>
        ///
        /// Dependency property is used where
        /// You know the property is going to be the binding target i.e you are creating a user control/custom control and want property that should be binding driven.
        /// You want automatic property change notifications (coerse and validation also).
        /// We want value inheritance in styles,themes, parent or default value.
        /// There is not need to create the properties on Model or ViewModel layer as dependency properties most of the time as that is not going to help much on memory saving front as most of the properties we define in model/VM will have values per instance as they will be constantly changing.Resolving Dependency property value is a burden in itself so making property dependency unnecessarily is not advisable.
        ///
        /// </summary>


        public string Secret
        {
            get { return (string)GetValue(SecretProperty); }
            set { SetValue(SecretProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Secret.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty SecretProperty =
            DependencyProperty.Register("Secret", typeof(string), typeof(DependencyTest), new PropertyMetadata("default"));


    }
}
