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
using SaveEyesShakirov.DB;

namespace SaveEyesShakirov.Pages
{
    /// <summary>
    /// Логика взаимодействия для AgentsTablePage.xaml
    /// </summary>
    public partial class AgentsTablePage : Page
    {
        List<Agent> Agents { get; set; }
        List<int> prodSaleY;
        public AgentsTablePage()
        {
            InitializeComponent();
            Agents = DataAccess.GetAgents();
            lvAgentsTable.ItemsSource = Agents;

            
        }
    }
}
