   M S B A M L   `   `   `  ����T  PMahApps.Metro, Version=1.1.2.0, Culture=neutral, PublicKeyToken=f4fb5a3c4d1e5b4fV;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.MetroMahApps.Metro.Controls  5      L HEmployeeWPFClient, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:EmployeeWPFClient.ViewModelEmployeeWPFClient.ViewModel 5      A%clr-namespace:EmployeeWPFClient.ViewsEmployeeWPFClient.Views 5	      "   EmployeeWPFClient.MainWindow   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      PControls;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      8vm)clr-namespace:EmployeeWPFClient.ViewModel     5      8custom%clr-namespace:EmployeeWPFClient.Views     5	      -   5          � Title$  
MainWindow��5      $��502.735��6,   $��852.127��6=   .��5      �  � RowDefinitions 5   
   �� 5      $
��Auto �6   6,   �� 5      $
��Auto �6   6,   �� 5      $
��Auto �6   6,   �� 5      $
��Auto �6   6,   �� 5      $
��Auto �6   6,   �� 5      $
��Auto �6   6,   �� 5      $
��Auto �6   6,   �� 5      $
��Auto �6   6,   �� 5      $
��Auto �6   6,   �� 5      $
��Auto �6   6,   �� 5      $��1* �6   6*   �� 5      $��2* �6   6*    � ColumnDefinitions 5#   
   �� 5$      $��2* �6   6,   �� 5%      $��1* �6   6,   .+�5)   
   ]� $��0��6   .+�5*      o� $	��Top=�6   .@�5+      m� $��Fichier��6   .@�5,      m� $
��_New��6   m� 5-      $��_Open��6   m� 5.      $��_Save��6   �� 5/      m� 50      $��_Exit��6   51      52      53      �� 55   
   $��1��6&   $
��Left=�63   $��23��6N   $��	11,10,0,0q�6Z    �� TextWrapping$
 Wrap=�6m   $	��Top=�6�   $��65��6�   ��6   �� *Id+6�   �� 56   
   $��9��64   $��Get Employee��6A   $
��Left=�6X   $��26��6s   $��10,5,0,0q�6   $	��Top=�6�   $	��259��6�   ��6   �� *GetEmployeeCmd+6�   �� 58   
   $
��Id :��6   $��2��6   $
��Left=�6,   $��10,5,0,0q�6G   $	��Top=�6Y   $��68��6q    J� RenderTransformOrigin$ 0.5,0.5&�6|   6�   �� 59   
   $��2��6/   $
��Left=�6<   $��23��6W   $��98,5,0,0q�6c   $
 Wrap=�6u   $	��Top=�6�   $	��172��6�   ��6   �� *Employee.Id+6�   �� 5;   
   $��Name :��6   $��3��6!   $
��Left=�6.   $��10,5,0,0q�6I   $	��Top=�6[   $��65��6s   �� 5<   
   $��3��61   $
��Left=�6>   $��23��6Y   $��98,5,0,0q�6e   $
 Wrap=�6w   $	��Top=�6�   $	��172��6�   ��6   �� *Employee.Name+6�   �� 5>   
   $��Gender :��6   $��4��6#   $
��Left=�60   $��10,5,0,0q�6K   $	��Top=�6]   $��65��6u   �� 5?   
   $��4��63   $
��Left=�6@   $��23��6[   $��98,5,0,0q�6g   $
 Wrap=�6y   $	��Top=�6�   $	��172��6�   ��6   �� *Employee.Gender+6�   �� 5A   
   $��Date of birth :��6   $��5��6*   $
��Left=�67   $��11,5,0,0q�6R   $	��Top=�6d   $��82��6|   �� 5B   
   $��5��64   $
��Left=�6A   $��23��6\   $��98,5,0,0q�6h   $
 Wrap=�6z   $	��Top=�6�   $	��171��6�   ��6   �� *Employee.Dateofb+6�   �� 5D   
   $��Type :��6   $��6��6!   $
��Left=�6.   $��11,5,0,0q�6I   $	��Top=�6[   $��65��6s   �� 5E   
   $��6��61   $
��Left=�6>   $��23��6Y   $��	303,5,0,0q�6e   $
 Wrap=�6x   $	��Top=�6�   $	��137��6�   ��6   �� *Employee.Type+6�   �� 5F   
   $��6��6:   $
��Left=�6G   $��98,5,0,0q�6b   $	��Top=�6t   $	��171��6�    �� SelectedIndex 6   �� *SelectedType+.@�5G      �� $��Select Employee Type��6   �� 5H      $��Full Time Employee��6   �� 5I      $��Part Time Employee��6   5J      �� 5L   
   $��9��65   $��Save Employee��6B   $
��Left=�6Z   $��	303,5,0,0q�6u   $	��Top=�6�   $	��245��6�   $��26��6�   ��6   �� *SaveEmployeeCmd+6�   �� 5M   
   $��2��68    �� DisplayMemberPath$
 Name��6E   $
��Left=�6�   $��	303,5,0,0q�6�   $	��Top=�6�   $	��204��6�   ��6   �� *EmployeeList+ �� SelectedItem 6^   �� *SelectedEmployee+6�   �� 5O   
   $��Annual Salary :��6   $��7��6*   $
��Left=�6Z   $��11,5,0,0q�6u   $	��Top=�6�   $��82��6�   y�67   �� *FeIsEnabled+6�   �� 5P   
   $��7��69   $
��Left=�6j   $��23��6�   $��98,5,0,0q�6�   $
 Wrap=�6�   $	��Top=�6�   $	��172��6�   ��6   �� *Employee.AnnualSalary+y�6F   �� *FeIsEnabled+6�   �� 5Q   
   $��Hourly Pay :��6   $��7��6'   $
��Left=�6W   $��10,5,0,0q�6r   $	��Top=�6�   $��82��6�   y�64   �� *PeIsEnabled+6�   �� 5R   
   $��7��66   $
��Left=�6f   $��23��6�   $��98,5,0,0q�6�   $
 Wrap=�6�   $	��Top=�6�   $	��172��6�   ��6   �� *Employee.HourlyPay+y�6C   �� *PeIsEnabled+6�   �� 5S   
   $��Hours Worked :��6   $��8��6)   $
��Left=�6Y   $��10,5,0,0q�6t   $	��Top=�6�   $��86��6�   y�66   �� *PeIsEnabled+6�   �� 5T   
   $��8��68   $
��Left=�6h   $��23��6�   $��97,5,0,0q�6�   $
 Wrap=�6�   $	��Top=�6�   $	��172��6�   ��6   �� *Employee.HoursWorked+y�6E   �� *PeIsEnabled+6�   �� 5U   
   $��10��66   $��WrapWithOverflow=�6D   $
��Left=�6d   $��10,5,0,0q�6   $	��Top=�6�   $��59��6�   $	��824��6�   ��6   �� *UserNotification+6�   %  EmployeeWPFClient.Views.Details  5W   
   -   5          Name$ Details��5W      $��1��6*   $��1��67   $��10��6G   	 � DataContext	 6Y   �� *	DetailsVm+5Y      5Z      