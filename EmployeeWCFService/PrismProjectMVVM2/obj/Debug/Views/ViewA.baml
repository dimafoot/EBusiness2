   M S B A M L   `   `   `  ����L  HPrismProjectMVVM2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:PrismProjectMVVM2.ViewsPrismProjectMVVM2.Views  5      #    PrismProjectMVVM2.Views.ViewA   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      7local%clr-namespace:PrismProjectMVVM2.Views     5      P LPrism.Wpf, Version=6.1.0.0, Culture=neutral, PublicKeyToken=91a96d2a154366d8$prismhttp://prismlibrary.com/  5      !  Prism.Mvvm.ViewModelLocator    AutoWireViewModel  . 
���W�.�.��5      �  � RowDefinitions 5   
   �� 5      $
��Auto �6   6,   �� 5      $
��Auto �6   6,   �� 5      $
��Auto �6   6,    � ColumnDefinitions 5   
   �� 5      $��1* �6   6,   �� 5      $��1* �6   6,   .+�5   
   �� $��Name :��6   $��0��6!   $��Arial)�6.   $��15(�6A   
�������$	��5,5q�6b   �� 5   
   $��Last Updated :��6   $��1��6)   $��Arial)�66   $��15(�6I   
�������$	��5,5q�6j   �� 5   
   $��0��6Q   $��1��6^   $��Arial)�6n   $��15(�6�    �� TextAlignment$ Center=�6�   $	��5,5q�6�   ��6   �� *	FirstName+ �� UpdateSourceTrigger$ PropertyChanged=�6�   �� 5   
   $��1��61   $��1��6>   $��Arial)�6N   $��15(�6a   
�������$��Center=�6�   $��Center=�6�   ��6   �� *LastUpdated+6�   �� 5   
   $��Update��6   $��2��6E   $��1��6R   $	��5,5q�6b   $��25��6o   ��6"   �� *UpdatedCommand+6o   5      5       