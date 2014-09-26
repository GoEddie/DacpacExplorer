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
using FirstFloor.ModernUI.Windows.Controls;


namespace DacpacExplorer
{
    

    public partial class MainWindow : ModernWindow 
    {
        public MainWindow()
        {
            
        }

        
    }


    public class DacpacMainWindow : MainWindow
    {
        public event RenderTree RenderTree;

        public void InvokeRenderTree()
        {
            if (RenderTree != null)
                RenderTree.Invoke();
        }
    }

    public delegate void RenderTree();
}
