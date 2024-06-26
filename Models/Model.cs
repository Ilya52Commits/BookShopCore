﻿namespace BookShopCore.Model;

#region Модели таблиц
/* Модель таблицы пользователя */
public class User
{
  public int Id { get; init; }                                // Идентификатор пользователя
  public string? Login { get; init; }                         // Логин пользователя
  public string? Email { get; init; }                         // Почта пользователя
  public string? Password { get; init; }                      // Пароль ползователя
  public string? Role { get; init; }                          // Тип пользователя
  public ICollection<Book> SelectedBooks { get; init; } = []; // Коллекция выбранных книг
}

/* Модель таблицы книг */ 
public class Book
{
  public int Id { get; init; }        // Идентификатор книги
  public string? Name { get; set; }   // Название книги
  public string? Author { get; set; } // Автор продукта
  public string? Genre { get; set; }  // Жанр книги
  public int Price { get; set; }      // Цена книги
}
#endregion