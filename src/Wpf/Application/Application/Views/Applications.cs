using System;
using System.Collections.Generic;
using System.Windows.Controls;
using Simprod.Application.Controls;
using Simprod.Application.UI;
using Simprod.Application.ViewModels;

namespace Simprod.Application.Views
{
    public partial class Applications : View
    {
        private readonly IApplicationsViewModel _applicationsViewModel;
        private readonly IList<ApplicationShortcutControl> _applicationShortcutControls;

        public Applications(IApplicationsViewModel applicationsViewModel)
        {
            _applicationsViewModel = applicationsViewModel ??
                throw new ArgumentNullException(nameof(applicationsViewModel));

            _applicationShortcutControls = new List<ApplicationShortcutControl>();

            Init();

            InitViewModel();
            /*
             * <Grid>
            <Grid.RowDefinitions>
                <RowDefinition Height="120" />
            </Grid.RowDefinitions>
            <Grid.ColumnDefinitions>
                <ColumnDefinition Width="120" />
                <ColumnDefinition Width="120" />
                <ColumnDefinition Width="120" />
                <ColumnDefinition Width="120" />
                <ColumnDefinition Width="120" />
            </Grid.ColumnDefinitions>

            <controls:ApplicationShortcutControl />
            <controls:ApplicationShortcutControl Grid.Column="1" />
            <controls:ApplicationShortcutControl Grid.Column="2" />
            <controls:ApplicationShortcutControl Grid.Column="3" />
            <controls:ApplicationShortcutControl Grid.Column="4" />
        </Grid>
             */
        }

        private void InitViewModel()
        {
            _applicationsViewModel.ItemsAdd += _applicationsViewModel_ItemsAdd;
            _applicationsViewModel.ItemsRemove += _applicationsViewModel_ItemsRemove;
        }

        private void _applicationsViewModel_ItemsRemove(object sender, Mvvm.CollectionModifyEventArgs<Models.Application> e)
        {
            foreach (var item in e.Items)
                grid.Children.Remove(_applicationsViewModel[item]);
        }

        private void _applicationsViewModel_ItemsAdd(object sender, Mvvm.CollectionModifyEventArgs<Models.Application> e)
        {
            foreach (var item in e.Items)
                grid.Children.Remove(_applicationsViewModel[item]);
        }
    }
}