   M S B A M L   `   `   `  ����K  GPrismMVVMProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:PrismMVVMProject.ViewsPrismMVVMProject.Views  5   	   $    PrismMVVMProject.Views.WinBase   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   6views$clr-namespace:PrismMVVMProject.Views     5   	   P LPrism.Wpf, Version=6.1.0.0, Culture=neutral, PublicKeyToken=91a96d2a154366d8$prismhttp://prismlibrary.com/  5   	   !  Prism.Mvvm.ViewModelLocator    AutoWireViewModel  .  � Title$ WinBase��5
   	   $	��300��6   $	��300��6&   .��5      �  � RowDefinitions 5   
   �� 5      $
��Auto �6   6,   �� 5      $
��Auto �6   6,   �� 5      $��* �6   6)    � ColumnDefinitions 5   
   �� 5      $��1* �6   6,   �� 5      $��1* �6   6,   .+�5   
   �� ��6   �� *Name+�� 5   
   $��1��60   ��6   �� *
LastUpdate+6@   �� 5   
   $��Update��6   $��1��6D   $��Right=�6Q   ��6"   �� *UpdateCommand+6Q   �� 5   
   $��View A��6   $��ViewA��6F   $��1��6_   $��0,5,71,5q�6o   $��75��6�   ��6"   �� *NavigateCommand+6�   �� 5   
   $��View B��6   $��ViewB��6F   $��1��6_   $��	75,5,-4,5q�6o   $��75��6�   ��6"   �� *NavigateCommand+6�   �� 5"   
   $��2��6   $��0��6&   !  Prism.Regions.RegionManager   
RegionName$ ContentRegion��66   �� 5$   
   $��2��6   $��1��6&   .��5%      "   PrismMVVMProject.Views.ViewB  6   5&      5(      5)      