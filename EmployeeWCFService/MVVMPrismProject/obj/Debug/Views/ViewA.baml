   M S B A M L   `   `   `  ����  MVVMPrismProject"    MVVMPrismProject.Views.ViewA   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      P LPrism.Wpf, Version=6.1.0.0, Culture=neutral, PublicKeyToken=91a96d2a154366d8$prismhttp://prismlibrary.com/  5      !  Prism.Mvvm.ViewModelLocator    AutoWireViewModel  . 
�������.��5
      � .+�5   
   �� -   5         ��Name$ label��5      $��
First Name��6   $
��Left=�64   $��	28,57,0,0q�6O   $	��Top=�6b   $��26��6z   $��73��6�   �� 5   
   -   5        $ label1��5      $��	Last Name��6    $
��Left=�64   $��
28,112,0,0q�6O   $	��Top=�6c   �� 5   
   -   5        $ label2��5      $��Last Updated��6    $
��Left=�67   $��
28,172,0,0q�6R   $	��Top=�6f   �� 5   
   -   5         ��Name$ textBox��5      $
��Left=�6#   $��23��6>   $��
122,60,0,0q�6J    �� TextWrapping$
 Wrap=�6^   $	��Top=�6�   $	��120��6�   ��6r   �� *	FirstName+ �� UpdateSourceTrigger$ PropertyChanged=�6�   �� 5   
   -   5        $ textBox1��5      $
��Left=�6$   $��23��6?   $��122,114,0,0q�6K   $
 Wrap=�6`   $	��Top=�6�   $	��120��6�   ��6t   �� *
LastName+$ PropertyChanged=�6�   �� 5   
   -   5         ��Name$ 	textBlock��5      $
��Left=�6'   $��122,172,0,0q�6B   $
��Wrap=�6W   $	��Top=�6�   $��16��6�   $	��120��6�   ��6k   �� *LastUpdated+$ PropertyChanged=�6�   �� 5   
   -   5         ��Name$ button��5      $��Update��6D   $
��Left=�6U   $��122,220,0,0q�6p   $	��Top=�6�   $	��120��6�   ��6!   �� *UpdatedCommand+6�   5      5      