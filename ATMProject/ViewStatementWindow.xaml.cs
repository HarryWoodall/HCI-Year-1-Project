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
using System.Windows.Shapes;

namespace ATMProject {
    /// <summary>
    /// Interaction logic for ViewStatementWindow.xaml
    /// </summary>
    public partial class ViewStatementWindow : Window {

        private Window caller;
        private Customer customer;

        public ViewStatementWindow(Window caller, Customer customer) {
            InitializeComponent();
            this.caller = caller;
            this.customer = customer;

            foreach (string[] statement in customer.getStatements()) {
                statementList.Items.Add(formatStatement(statement));
            }
        }

        private void Window_ContentRendered(object sender, EventArgs e) {
            caller.Hide();
        }

        private Grid formatStatement(string[] statement) {
            Grid grid = new Grid();
            grid.HorizontalAlignment = HorizontalAlignment.Stretch;
            grid.Width = statementList.Width;
            grid.Margin = new Thickness(0);

            ColumnDefinition c1 = new ColumnDefinition();
            c1.Width = new GridLength(1, GridUnitType.Star);
            ColumnDefinition c2 = new ColumnDefinition();
            c1.Width = new GridLength(1, GridUnitType.Star);
            ColumnDefinition c3 = new ColumnDefinition();
            c1.Width = new GridLength(1, GridUnitType.Star);

            grid.ColumnDefinitions.Add(c1);
            grid.ColumnDefinitions.Add(c2);
            grid.ColumnDefinitions.Add(c3);

            int fontSize = 48;

            Label dateLabel = new Label();
            dateLabel.FontSize = fontSize;
            dateLabel.HorizontalAlignment = HorizontalAlignment.Stretch;
            dateLabel.Height = 100;
            dateLabel.HorizontalContentAlignment = HorizontalAlignment.Center;
            dateLabel.VerticalContentAlignment = VerticalAlignment.Center;
            dateLabel.Content = statement[0];
            grid.Children.Add(dateLabel);

            Label descriptionLabel = new Label();
            descriptionLabel.FontSize = fontSize;
            descriptionLabel.HorizontalAlignment = HorizontalAlignment.Stretch;
            descriptionLabel.Height = 100;
            descriptionLabel.HorizontalContentAlignment = HorizontalAlignment.Left;
            descriptionLabel.VerticalContentAlignment = VerticalAlignment.Center;
            descriptionLabel.Content = statement[1];
            grid.Children.Add(descriptionLabel);
            Grid.SetColumn(descriptionLabel, 1);

            Label ammountLabel = new Label();
            ammountLabel.FontSize = fontSize;
            ammountLabel.HorizontalAlignment = HorizontalAlignment.Stretch;
            ammountLabel.Height = 100;
            ammountLabel.HorizontalContentAlignment = HorizontalAlignment.Left;
            ammountLabel.VerticalContentAlignment = VerticalAlignment.Center;
            ammountLabel.Content = statement[2];
            grid.Children.Add(ammountLabel);
            Grid.SetColumn(ammountLabel, 2);

            return grid;
        }
    }
}
