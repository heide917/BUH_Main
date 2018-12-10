using BUH.DAL;
using BUH.Domain.Enums;
using BUH.Domain.Models;
using BUH.Domain.Providers.Abstraction;
using BUH.Domain.Repositories;
using BUH.Domain.Services.Abstraction;
using BUH.ViewModels;
using System;
using System.Linq;
using System.Windows;

namespace BUH
{
    public partial class Handbook : Window
    {
        public Handbook(
            IKekRepository kekRepository,
            IFirstRunService firstRunService)
        {
            InitializeComponent();
            DataContext = new HandbookViewModel(kekRepository, firstRunService);
        }

        private void Menu_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
