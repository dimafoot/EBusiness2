   M S B A M L   `   `   `  ����J  FPrismSampleMVVM, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:PrismSampleMVVM.ViewsPrismSampleMVVM.Views  5   	   &     PrismSampleMVVM.Views.BaseWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   5views#clr-namespace:PrismSampleMVVM.Views     5   	   P LPrism.Wpf, Version=6.1.0.0, Culture=neutral, PublicKeyToken=91a96d2a154366d8$prismhttp://prismlibrary.com/  5   	   !  Prism.Mvvm.ViewModelLocator    AutoWireViewModel  .  � Title$ 
BaseWindow��5
   	   
����d�.��5      �  � RowDefinitions 5   
   �� 5      $
��Auto �6   6,   �� 5      $
��Auto �6   6,   �� 5      $��* �6   6)    � ColumnDefinitions 5   
   �� 5      $��1* �6   6,   �� 5      $��1* �6   6,   .+�5   
   �� $��2��6    �� Orientation$ 
Horizontal=�6)   .+�5      �� $��View A��6   $��ViewA��6J   $��5q�6c   ��6&   �� *NavigateCommand+6q   �� 5      $��View B��6   $��ViewB��6J   $��5q�6c   ��6&   �� *NavigateCommand+6q   �� 5      $��View B��6   $��ViewB��6K   $��5q�6d   ��6&   �� *NavigateCommand2+6r   5      �� 5   
   $��2��6   $��0��6&   !  Prism.Regions.RegionManager   
RegionName$ ContentRegion��66   $��5q�6e   �� 5   
   $��2��6   $��1��6&   $ ContentRegion2��66   $��5q�6f   5!      5"      