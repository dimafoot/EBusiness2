   M S B A M L   `   `   `  ����  ProjectPismMVVMRelease(    "ProjectPismMVVMRelease.Views.ViewB   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      P LPrism.Wpf, Version=6.1.0.0, Culture=neutral, PublicKeyToken=91a96d2a154366d8$prismhttp://prismlibrary.com/  5      !  Prism.Mvvm.ViewModelLocator    AutoWireViewModel  . 
�������.��5      � .+�5   
   �� -   5         ��Name$ LabelB��5      $��20(�6=   $
��Left=�6K   $��
10,132,0,0q�6f   $	��Top=�6z   $��38��6�   $	��147��6�   ��6    �� *
MessageB+6�   �� 5   
   $
��Left=�6.   $��34��6I   $��	10,23,0,0q�6U   $	��Top=�6h   $	��147��6�   ��6   �� *	Client.Id+6�   �� 5   
   $
��Left=�60   $��	10,62,0,0q�6K   $	��Top=�6^   $��33��6v   $	��147��6�   ��6   �� *Client.Name+6�   �� 5   
   $
��Left=�68   $��
10,100,0,0q�6S   $	��Top=�6g   $	��147��6   $��32��6�   ��6   �� *Client.CreationDate+6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ dataGrid��5      $
��Left=�6u   $��162,10,-98,0q�6�   $	��Top=�6�   $	��280��6�   $	��236��6�   ��6%   �� *	Clients+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=�   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Id��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ SizeToCells 61      MinWidth$ 50Q�6E   1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 6S   �� *Id+  5      $
 Name��6%   $ SizeToCells 63   $ 50Q�6G   	 6U   �� *Name+  5      $ CreationDate��6%   $ SizeToCells 6;   $ 50Q�6O   	 6]   �� *CreationDate+5      �� 5   
   -   5        
 ��Name$
 textBox��5      $
��Left=�6#   $��23��6>   $��
10,230,0,0q�6J    �� TextWrapping$
 Wrap=�6^   $	��Top=�6�   $	��120��6�   ��6r   �� *
IdToRemove+6�   �� 5   
   -   5         ��Name$ button��5      $��Remove Client��6!   $
��Left=�6[   $��
10,258,0,0q�6v   $	��Top=�6�   $	��120��6�   ��69   �� *RemoveCommand+6�   5      5      