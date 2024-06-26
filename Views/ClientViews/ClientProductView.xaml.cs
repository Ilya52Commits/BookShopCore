﻿using BookShopCore.Model;
using BookShopCore.ViewModels.ClientViewModels;
using System.Windows.Controls;

namespace BookShopCore.Views.ClientViews;

/// <summary>
/// Логика взаимодействия для ClientProductView.xaml
/// </summary>
public partial class ClientProductView : Page
{
  public ClientProductView(User user)
  {
    InitializeComponent();

    /* Привязка объекта ViewModel к контексту данных */
    DataContext = new ClientProductViewModel(user);
  }
}