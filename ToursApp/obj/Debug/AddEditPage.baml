   M S B A M L   `   `   `  ????C  ?ToursApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:ToursAppToursApp  5          ToursApp.AddEditPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      (localclr-namespace:ToursApp     5        N? Title$  AddEditPage??5	      .??5      ?  ? ColumnDefinitions 5   
   ?? 5      $	??200 ?6   ?? 5      $??* ?6    ? RowDefinitions 5   
   ?? 5      $??* ?6   ?? 5      $??* ?6   ?? 5      $??* ?6   ?? 5      $??* ?6   .+?5   
   ?? $??Название??6   6&   ?? 5   
   $%??Количество звезд??6   $??1??6,   6;   ?? 5   
   $??Страна??6   $??2??6"   61   ?? 5   
    ?? 	MaxLength$	 100??6(   $??1??68   ??6   ?? *Name+6J   ?? 5   
   $??1??60   $??1??6@   $	??175??6M   $
??Left=?6Y   ??6   ?? *CountOfStars+6v   ?? 5   
   -   5         ??Name$ ComboCountries??5   P   $??2??63   $??1??6@    ?? DisplayMemberPath$
 Name??6h    ?? SelectedItem 6   ?? *County+6?   ?? 5   
   -   5        $??BtnSave??5   F   $??Сохранить??6   $??2??6%   $??3??69   6n   5      5      